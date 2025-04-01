using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using CateringBackend.Domain.Data;
using CateringBackend.Domain.Utilities;
using CateringBackend.Exceptions;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace CateringBackend.Users.Client.Commands
{
    public class EditClientCommand : IRequest<bool>
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public RegisterClientAddress Address { get; set; }
    }

    public class EditClientWithIdCommand : EditClientCommand
    {
        public Guid ClientId { get; set; }

        public EditClientWithIdCommand(EditClientCommand editClientCommand, Guid clientId)
        {
            ClientId = clientId;
            Name = editClientCommand.Name;
            LastName = editClientCommand.LastName;
            Email = editClientCommand.Email;
            Password = editClientCommand.Password;
            PhoneNumber = editClientCommand.PhoneNumber;
            Address = editClientCommand.Address;
        }
    }

    public class EditClientWithIdCommandHandler : IRequestHandler<EditClientWithIdCommand, bool>
    {
        private readonly CateringDbContext _dbContext;

        public EditClientWithIdCommandHandler(CateringDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<bool> Handle(EditClientWithIdCommand request, CancellationToken cancellationToken)
        {
            var client = _dbContext.Clients.FirstOrDefault(c => c.Id == request.ClientId);
            if (client == default)
            {
                return false;
            }

            if (!string.IsNullOrWhiteSpace(request.Email) && client.Email != request.Email)
            {
                var clientWithGivenEmailExists = await _dbContext.Clients
                    .AnyAsync(c => c.Email == request.Email, cancellationToken: cancellationToken);
                
                if (clientWithGivenEmailExists) return false;
            }

            await EditClient(request, client);

            await _dbContext.SaveChangesAsync(cancellationToken);

            return true;
        }

        private async Task EditClient(EditClientWithIdCommand editCommand, Domain.Entities.Client client)
        {
            await EditClientAddressIfProvided(editCommand, client);
            client.FirstName = editCommand.Name;
            client.LastName = editCommand.LastName;
            client.Email = editCommand.Email;
            client.Password = PasswordManager.Encrypt(editCommand.Password);
            client.PhoneNumber = editCommand.PhoneNumber;
        }

        private async Task EditClientAddressIfProvided(EditClientWithIdCommand editCommand, Domain.Entities.Client client)
        {
            if (editCommand.Address != default)
            {
                var clientAddress = await _dbContext.Addresses.FirstOrDefaultAsync(a => a.Id == client.AddressId);
                if (clientAddress == default)
                {
                    throw new MissingAddressForClientException(client.Id);
                }

                clientAddress.City = editCommand.Address.City;
                clientAddress.ApartmentNumber = editCommand.Address.ApartmentNumber;
                clientAddress.BuildingNumber = editCommand.Address.BuildingNumber;
                clientAddress.Street = editCommand.Address.Street;
                clientAddress.PostCode = editCommand.Address.PostCode;
            }
        }
    }
}