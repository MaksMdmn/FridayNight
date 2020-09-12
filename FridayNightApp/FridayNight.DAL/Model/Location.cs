using FridayNight.DAL.Model.Abstract;
using System;

namespace FridayNight.DAL.Model
{
    public class Location : ModelBase
    {
        public string Country { get; set; }

        public string City { get; set; }

        public string Address { get; set; }

        public string GoogleCoordinates { get; set; }

        public DateTime CreationDate { get; set; }
    }
}