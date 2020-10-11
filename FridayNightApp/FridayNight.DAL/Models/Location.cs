using FridayNight.DAL.Models.Abstract;
using FridayNight.DataAccessLayer.Repositories.Models;
using System;

namespace FridayNight.DAL.Models
{
    public class Location : EntityWithDbKey
    {
        public string Country { get; set; }

        public string City { get; set; }

        public string Address { get; set; }

        public string GoogleCoordinates { get; set; }

        public DateTime CreationDate { get; set; }
    }
}