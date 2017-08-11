using Newtonsoft.Json;
using System;

namespace HotelBookSystem.Data.Model
{
    class Customer
    {
        [JsonProperty("id")]
        public Guid? Id { get; set; }
        public string Name { get; set; }
        public string DLNumber { get; set; }
        public string DLState { get; set; }
        public int Age { get; set; }
    }
}
