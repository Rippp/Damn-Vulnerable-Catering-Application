using CateringBackend.Domain.Entities;

namespace CateringBackend.Users
{
    public class DeliveryDetailsDTO
    {
        public AddressDTO Address { get; set; }
        public string PhoneNumber { get; set; }
        public string CommentForDeliverer { get; set; }

        public DeliveryDetailsDTO() { }
        public DeliveryDetailsDTO(Order order)
        {
            Address = new AddressDTO(order.Client.Address);
            PhoneNumber = order.Client.PhoneNumber;
            CommentForDeliverer = order.CommentForDeliverer;
        }
    }
}
