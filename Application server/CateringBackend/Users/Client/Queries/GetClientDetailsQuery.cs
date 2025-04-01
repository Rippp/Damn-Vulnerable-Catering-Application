using System;
using System.Threading;
using System.Threading.Tasks;
using CateringBackend.Domain.Data;
using CateringBackend.Domain.Entities;
using CateringBackend.Domain.Utilities;
using CateringBackend.Exceptions;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace CateringBackend.Users.Client.Queries
{
    public record ClientDetailsDto
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Password { get; set; }
        public AddressDto Address { get; set; }

        public ClientDetailsDto(Domain.Entities.Client client, Address address)
        {
            Name = client.FirstName;
            LastName = client.LastName;
            Email = client.Email;
            PhoneNumber = client.PhoneNumber;
            Password = PasswordManager.Decrypt(client.Password);
            Address = new AddressDto(address);
        }
    }

    public class AddressDto
    {
        public string Street { get; set; }
        public string BuildingNumber { get; set; }
        public string ApartmentNumber { get; set; }
        public string PostCode { get; set; }
        public string City { get; set; }

        public AddressDto(Address address)
        {
            Street = address.Street;
            BuildingNumber = address.BuildingNumber;
            ApartmentNumber = address.ApartmentNumber;
            PostCode = address.PostCode;
            City = address.City;
        }
    }

    public record GetClientDetailsQuery(Guid UserId) : IRequest<ClientDetailsDto>;

    public class GetClientDetailsQueryHandler : IRequestHandler<GetClientDetailsQuery, ClientDetailsDto>
    {
        private readonly CateringDbContext _dbContext;

        public GetClientDetailsQueryHandler(CateringDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<ClientDetailsDto> Handle(GetClientDetailsQuery request, CancellationToken cancellationToken)
        {
            var client = await _dbContext.Clients.FirstOrDefaultAsync(client => client.Id == request.UserId, cancellationToken);
            if (client == default)
            {
                return null;
            }

            var address = await _dbContext.Addresses.FirstOrDefaultAsync(address => address.Id == client.AddressId, cancellationToken);
            if (address == default)
            {
                throw new MissingAddressForClientException(client.Id);
            }

            return new ClientDetailsDto(client, address);
        }
    }
}
