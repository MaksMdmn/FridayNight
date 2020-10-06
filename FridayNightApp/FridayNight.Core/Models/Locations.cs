using System;

namespace FridayNight.Core.Models
{
    public class Locations
    {
        public string Country { get; set; }

        public string City { get; set; }

        public string Address { get; set; }

        public string GoogleCoordinates { get; set; }

        public DateTime CreationDate { get; set; }
    }
}