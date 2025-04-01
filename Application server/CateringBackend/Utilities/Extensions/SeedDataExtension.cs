using CateringBackend.Domain.Data;
using CateringBackend.Domain.Utilities;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace CateringBackend.Utilities.Extensions
{
    public static class SeedDataExtension
    {
        public static void SeedConfigData(this IApplicationBuilder app)
        {
            using var serviceScope = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>().CreateScope();
            using var context = serviceScope.ServiceProvider.GetRequiredService<CateringDbContext>();
            var dataSeeder = new ConfigDataSeeder(context);
            dataSeeder.SeedConfigData();
        }
    }
}
