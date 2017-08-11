using System;
using Newtonsoft.Json;

namespace HotelBookSystem.Data.Model
{
    class Room
    {
        [JsonProperty("id")]
        public Guid? Id { get; set; }
        public int RoomNumber { get; set; }
        public string Type { get; set; }
        public int Price { get; set; }
        public bool Status { get; set; }
    }
}
