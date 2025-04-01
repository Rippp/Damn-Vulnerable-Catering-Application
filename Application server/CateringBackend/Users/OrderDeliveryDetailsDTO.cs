using CateringBackend.Domain.Entities;
using System;

namespace CateringBackend.Users
{
    public class OrderDeliveryDetailsDTO
    {
        public Guid OrderId { get; set; }
        public AddressDTO Address { get; set; }
        public string PhoneNumber { get; set; }
        public string CommentForDeliverer { get; set; }

        public OrderDeliveryDetailsDTO() { }
        public OrderDeliveryDetailsDTO(Order order)
        {
            OrderId = order.Id;
            Address = new AddressDTO(order.Client?.Address);
            PhoneNumber = order.Client?.PhoneNumber;
            CommentForDeliverer = order.CommentForDeliverer;
        }
    }
}
