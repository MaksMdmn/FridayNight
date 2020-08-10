using FridayNight.DAL.Model.Abstract;

namespace FridayNight.DAL.Model
{
    public class Contact : ModelBase
    {
        public string Name { get; set; }

        public string Phone { get; set; }

        public Location Location { get; set; }
    }
}