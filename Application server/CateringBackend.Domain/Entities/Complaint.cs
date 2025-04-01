using CateringBackend.Domain.Entities.Enums;
using System;

namespace CateringBackend.Domain.Entities
{
    public class Complaint
    {
        public Guid Id { get; set; }
        public Guid OrderId { get; set; }
        public Order Order { get; set; }
        public string Description { get; set; }
        public string Answer { get; set; }
        public DateTime CreatedDate { get; set; }
        public ComplaintStatus Status { get; set; }

        public static Complaint Create(Guid orderId, string description, DateTime createdDate)
        {
            return new()
            {
                OrderId = orderId,
                Description = description,
                CreatedDate = createdDate,
                Status = ComplaintStatus.Opened
            };
        }

        public void Close()
        {
            Status = ComplaintStatus.Closed;
        }
    }
}
