using System.Threading;
using System.Threading.Tasks;
using CateringBackend.AuthUtilities;
using CateringBackend.Domain.Data;
using CateringBackend.Domain.Utilities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace CateringBackend.Users.Client.Queries
{
    public record LoginClientQuery : LoginQuery, IRequest<string>;
   
    public class LoginClientQueryHandler : IRequestHandler<LoginClientQuery, string>
    {
        private readonly CateringDbContext _dbContext;

        public LoginClientQueryHandler(CateringDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<string> Handle(LoginClientQuery request, CancellationToken cancellationToken)
        {
            var client = await _dbContext.Clients.FirstOrDefaultAsync(
                x => x.Email == request.Email && x.Password == PasswordManager.Encrypt(request.Password), 
                cancellationToken);

            if (client == default)
                return null;

            return JwtTokenUtilities.GetAuthenticationToken(client.Id, client.Email, UserRole.client);
        }
    }
}