using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AceOfSpadesPizza.Models
{
    public class Order
    {
        public int ID { get; set; }
        public string CustomerName { get; set; }
        public string CustomerNumber { get; set; }
        public DateTime DeliveryDate { get; set; }
        public int PizzaQuantity { get; set; }
    }
}
