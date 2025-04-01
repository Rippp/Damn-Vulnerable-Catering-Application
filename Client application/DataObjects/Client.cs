using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DamnVulnerableCateringApplication.DataObjects
{
    public class Client
    {
        public string Email { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Surname { get; set; } = string.Empty;
        public string Telephone { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;

        public Address Address { get; set; } = new Address();

        public Client() { }

        public Client(ClientDTO clientDTO)
        {
            Email = clientDTO.email;
            Name = clientDTO.name;
            Surname = clientDTO.lastName;
            Telephone = clientDTO.phoneNumber;
            Password = clientDTO.password;
            Address = new Address(clientDTO.address);
        }
    }

    public class ClientDTO
    {
        public string name { get; set; } = string.Empty;
        public string lastName { get; set; } = string.Empty;
        public string email { get; set; } = string.Empty;
        public string password { get; set; } = string.Empty;
        public string phoneNumber { get; set; } = string.Empty;
        public AddressDTO address { get; set; } = new AddressDTO();

        public ClientDTO() { }
        public ClientDTO(Client client)
        {
            name = client.Name;
            lastName = client.Surname;
            email = client.Email;
            password = client.Password;
            phoneNumber = client.Telephone;
            address = new AddressDTO(client.Address);
        }
    }
}
