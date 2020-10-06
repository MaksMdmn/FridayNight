using FridayNight.DAL.Models.Abstract;

namespace FridayNight.DAL.Models
{
    public enum EMusicStyle
    {
        Rock,
        Dj,
        Pop,
        HipHop
    }

    public class MusicStyle : ModelBase
    {
        public EMusicStyle Name { get; set; }
    }
}