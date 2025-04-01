using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DamnVulnerableCateringApplication.DataObjects
{
    public class DeliveryDetailsDTO
    {
        public AddressDTO address { get; set; }
        public string phoneNumber { get; set; }
        public string commentForDeliverer { get; set; }

        public DeliveryDetailsDTO() { }
        public DeliveryDetailsDTO(Client client, string comment)
        {
            this.address = new AddressDTO(client.Address);
            this.phoneNumber = client.Telephone;
            this.commentForDeliverer = comment;
        }
    }
}
