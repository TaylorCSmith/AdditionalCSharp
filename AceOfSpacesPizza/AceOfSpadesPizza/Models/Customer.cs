using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AceOfSpadesPizza.Models
{
    public class Customer
    {
        public string Name { get; set; }
        public int PhoneNumber { get; set; }
        public DateTime DeliveryDate { get; set; }
        public int PizzaCount { get; set; }
    }
}