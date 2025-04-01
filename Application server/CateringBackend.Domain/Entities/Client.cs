using System;

namespace CateringBackend.Domain.Entities
{
    public class Client
    {
        public Guid Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public Guid AddressId { get; set; }
        public Address Address { get; set; }

        public Client() {}

        public Client(Client client)
        {
            Id = client.Id;
            Email = client.Email;
            Password = client.Password;
            FirstName = client.FirstName;
            LastName = client.LastName;
            PhoneNumber = client.PhoneNumber;
            AddressId = client.AddressId;
            Address = new Address(client.Address);
        }
        
        public static Client Create(string email, string encryptedPassword, string firstName, string lastName, string phoneNumber, Guid addressId)
        {
            return new()
            {
                Email = email,
                Password = encryptedPassword,
                FirstName = firstName,
                LastName = lastName,
                PhoneNumber = phoneNumber,
                AddressId = addressId,
            };
        }
    }
}
