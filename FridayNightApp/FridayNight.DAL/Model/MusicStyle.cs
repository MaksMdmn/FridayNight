using FridayNight.DAL.Model.Abstract;

namespace FridayNight.DAL.Model
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