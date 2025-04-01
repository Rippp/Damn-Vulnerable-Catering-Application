using CateringBackend.Domain.Entities;

namespace CateringBackend.Users
{
    public class AddressDTO
    {
        public string Street { get; set; }
        public string BuildingNumber { get; set; }
        public string ApartmentNumber { get; set; }
        public string PostCode { get; set; }
        public string City { get; set; }

        public AddressDTO() { }
        public AddressDTO(Address address)
        {
            if (address == null) return;

            Street = address.Street;
            BuildingNumber = address.BuildingNumber;
            ApartmentNumber = address.ApartmentNumber;
            PostCode = address.PostCode;
            City = address.City;
        }

        public static Address CreateAddressFromDTO(AddressDTO addressDTO)
        {
            return Address.Create(
                street: addressDTO.Street,
                buildingNumber: addressDTO.BuildingNumber,
                apartmentNumber: addressDTO.ApartmentNumber,
                postCode: addressDTO.PostCode,
                city: addressDTO.City);
        }
    }
}
