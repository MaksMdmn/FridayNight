using FridayNight.DAL.Model.Abstract;

namespace FridayNight.DAL.Model
{
    public class Location : ModelBase
    {
        public string Country { get; set; }

        public string City { get; set; }

        public string Address { get; set; }
    }
}