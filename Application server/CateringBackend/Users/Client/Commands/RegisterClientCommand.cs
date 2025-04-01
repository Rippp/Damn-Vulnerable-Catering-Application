using System.Threading;
using System.Threading.Tasks;
using CateringBackend.AuthUtilities;
using CateringBackend.Domain.Data;
using CateringBackend.Domain.Entities;
using CateringBackend.Domain.Utilities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace CateringBackend.Users.Client.Commands
{
    public class RegisterClientCommand : IRequest<string>
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public RegisterClientAddress Address { get; set; }
    }

    public class RegisterClientAddress
    {
        public string Street { get; set; }
        public string BuildingNumber { get; set; }
        public string ApartmentNumber { get; set; }
        public string PostCode { get; set; }
        public string City { get; set; }
    }

    public class RegisterClientCommandHandler : IRequestHandler<RegisterClientCommand, string>
    {
        private readonly CateringDbContext _dbContext;

        public RegisterClientCommandHandler(CateringDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<string> Handle(RegisterClientCommand request, CancellationToken cancellationToken)
        {
            if (await UserWithGivenEmailExistsAsync(request.Email)) return null;

            var createdClient = await AddClientToDatabaseAsync(request, cancellationToken);

            return JwtTokenUtilities.GetAuthenticationToken(createdClient.Id, createdClient.Email, UserRole.client);
        }

        private async Task<bool> UserWithGivenEmailExistsAsync(string email) => 
            await _dbContext.Clients.FirstOrDefaultAsync(client => client.Email == email) != default;

        private async Task<Domain.Entities.Client> AddClientToDatabaseAsync(
            RegisterClientCommand registerClientCommand,
            CancellationToken cancellationToken)
        {
            var clientToAdd = new Domain.Entities.Client
            {
                Address = new Address
                {
                    ApartmentNumber = registerClientCommand.Address.ApartmentNumber,
                    BuildingNumber = registerClientCommand.Address.BuildingNumber,
                    City = registerClientCommand.Address.City,
                    PostCode = registerClientCommand.Address.PostCode,
                    Street = registerClientCommand.Address.Street,
                },
                Email = registerClientCommand.Email,
                FirstName = registerClientCommand.Name,
                LastName = registerClientCommand.LastName,
                Password = PasswordManager.Encrypt(registerClientCommand.Password),
                PhoneNumber = registerClientCommand.PhoneNumber,
            };

            var createdClient = await _dbContext.Clients.AddAsync(clientToAdd, cancellationToken);
            await _dbContext.SaveChangesAsync(cancellationToken);
            return createdClient.Entity;
        }
    }
}