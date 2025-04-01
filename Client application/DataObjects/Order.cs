using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DamnVulnerableCateringApplication.DataObjects
{
    public class Order
    {
        public List<Diet> Diets { get; set; }
        public DeliveryDetailsDTO DeliveryDetails { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public Order() { }
    }

    public class OrderDTO
    {
        public string[] dietIDs { get; set; }
        public DeliveryDetailsDTO deliveryDetails { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }

        public OrderDTO() { }
        public OrderDTO(Order order)
        {
            this.dietIDs = order.Diets.Select(x => x.Id.ToString()).ToArray();
            this.deliveryDetails = order.DeliveryDetails;
            this.startDate = order.StartDate;
            this.endDate = order.EndDate;
        }
    }

    public class OrderDetailsDTO
    {
        public string id { get; set; }
        public List<DietDetailInOrderDTO> diets { get; set;}
        public DeliveryDetailsDTO deliveryDetails { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public int price { get; set; }
        public string status { get; set; }
        public List<string> complaint { get; set; }

    }

    public class DietDetailInOrderDTO
    {
        public string dietId { get; set; }
        public string name { get; set; }
        List<MealDetailsDTO> meals { get; set; }
        public int price { get; set; }
        public bool vegan { get; set; }
    }
}
