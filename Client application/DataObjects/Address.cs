using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DamnVulnerableCateringApplication.DataObjects
{
    public class Address
    {
        public string Street { get; set; } = string.Empty;
        public string StreetNo { get; set; } = string.Empty;
        public string Postal { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;

        public Address() { }

        public Address(AddressDTO addressDTO)
        {
            Street = addressDTO.street;
            StreetNo = addressDTO.buildingNumber;
            Postal = addressDTO.postCode;
            City = addressDTO.city;
        }
    }

    public class AddressDTO
    {
        public string street { get; set; } = string.Empty;
        public string buildingNumber { get; set; } = string.Empty;
        public string apartmentNumber { get; set; } = string.Empty;
        public string postCode { get; set; } = string.Empty;
        public string city { get; set; } = string.Empty;

        public AddressDTO() { }

        public AddressDTO(Address address)
        {
            street = address.Street;
            buildingNumber = address.StreetNo;
            postCode = address.Postal;
            city = address.City;
        }
    }
}
