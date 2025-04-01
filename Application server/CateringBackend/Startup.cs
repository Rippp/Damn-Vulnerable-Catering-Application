using System.Text;
using CateringBackend.AuthUtilities;
using CateringBackend.Domain.Data;
using CateringBackend.Utilities.Extensions;
using CateringBackend.Utilities.HostedServices;
using MediatR;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;

namespace CateringBackend
{
    public class Startup
    {
        private readonly string _allowSpecificOrigins = "_myAllowSpecificOrigins";

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy(name: _allowSpecificOrigins,
                    builder =>
                    {
                        builder.AllowAnyOrigin()
                            .AllowAnyHeader()
                            .AllowAnyMethod();
                    });
            });
            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "JWTToken_Auth_API",
                    Version = "v1"
                });
                c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme()
                {
                    Name = "Authorization",
                    Type = SecuritySchemeType.ApiKey,
                    Scheme = "Bearer",
                    BearerFormat = "JWT",
                    In = ParameterLocation.Header,
                    Description = "JWT Authorization header using the Bearer scheme. \r\n\r\n Enter 'Bearer' [space] and then your token in the text input below.\r\n\r\nExample: \"Bearer 1safsfsdfdfd\"",
                });
                c.AddSecurityRequirement(new OpenApiSecurityRequirement {
                {
                    new OpenApiSecurityScheme {
                        Reference = new OpenApiReference {
                            Type = ReferenceType.SecurityScheme, Id = "Bearer"}
                    },
                    new string[] {}
                }});
            });

            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;

            })
            .AddJwtBearer(cfg =>
            {
                cfg.RequireHttpsMetadata = false;
                cfg.SaveToken = true;

                cfg.TokenValidationParameters = new TokenValidationParameters()
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey =
                            new SymmetricSecurityKey(Encoding.ASCII.GetBytes(AuthConstants.JwtSigningKey)),

                    ValidateAudience = true,
                    ValidAudience = "audience",

                    ValidateIssuer = true,
                    ValidIssuer = "issuer"
                };

                cfg.Events = new JwtBearerEvents()
                {
                    OnMessageReceived = context =>
                    {
                        string apiKey = context?.Request?.Headers["api-key"];
                        if (string.IsNullOrWhiteSpace(apiKey))
                        {
                            return System.Threading.Tasks.Task.CompletedTask;
                        }
                        context.Request.Headers["Authorization"] = $"Bearer {apiKey}";
                        return System.Threading.Tasks.Task.CompletedTask;
                    }
                };
            });

            var dbContextOptions = new DbContextOptionsBuilder<CateringDbContext>()
                .UseSqlServer(Configuration.GetConnectionString("CateringDatabase")).Options;

            services.AddTransient(x => dbContextOptions);
            services.AddSingleton<IUserIdFromTokenProvider, UserIdFromTokenProvider>();
            services.AddDbContext<CateringDbContext>();
            services.AddMediatR(typeof(Startup));
            services.AddHostedService<UpdateOrdersStatusHostedService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseCors(_allowSpecificOrigins);

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "CateringBackEnd v1"));
                app.UpdateDatabase();
                app.SeedConfigData();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthentication();

            app.UseAuthorization();

            app.UseStatusCodePages();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
