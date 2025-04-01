using CateringBackend.Domain.Entities.Enums;
using System;
using System.Collections.Generic;

namespace CateringBackend.Domain.Entities
{
    public class Order
    {
        public Guid Id { get; set; }
        public OrderStatus Status { get; set; }
        public Guid ClientId { get; set; }
        public Client Client { get; set; }
        public string CommentForDeliverer { get; set; }
        public Guid DeliveryAddressId { get; set; }
        public Address DeliveryAddress { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal Price { get; set; }
        public HashSet<Complaint> Complaints { get; set; }
        public HashSet<Diet> Diets { get; set; }

        public Order()
        {
            Complaints = new HashSet<Complaint>();
            Diets = new HashSet<Diet>();
        }

        public static Order Create(Guid clientId, string commentForDeliverer, Guid deliveryAddressId, DateTime startDate,
            DateTime endDate, decimal price)
        {
            return new()
            {
                Status = OrderStatus.Created,
                ClientId = clientId,
                CommentForDeliverer = commentForDeliverer,
                DeliveryAddressId = deliveryAddressId,
                StartDate = startDate,
                EndDate = endDate,
                Price = price,
            };
        }
    }
}
