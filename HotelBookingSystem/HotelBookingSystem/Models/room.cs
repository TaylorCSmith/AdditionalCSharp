using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HotelBookingSystem.Models
{
    public class Room
    {
        public int RoomNumber { get; set; }
        public string Type { get; set; }
        public int Price { get; set; }
        public bool Status { get; set; }
    }
}