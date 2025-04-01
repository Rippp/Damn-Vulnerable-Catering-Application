using System;

namespace CateringBackend.Domain.Entities
{
    public class Address
    {
        public Guid Id { get; set; }
        public string Street { get; set; }
        public string BuildingNumber { get; set; }
        public string ApartmentNumber { get; set; }
        public string PostCode { get; set; }
        public string City { get; set; }

        public Address() {}

        public Address(Address address)
        {
            Id = address.Id;
            Street = address.Street;
            BuildingNumber = address.BuildingNumber;
            ApartmentNumber = address.ApartmentNumber;
            PostCode = address.PostCode;
            City = address.City;
        }

        public static Address Create(string street, string buildingNumber, string apartmentNumber, string postCode, string city)
        {
            return new()
            {
                Street = street,
                BuildingNumber = buildingNumber,
                ApartmentNumber = apartmentNumber,
                PostCode = postCode,
                City = city
            };
        }
    }
}
