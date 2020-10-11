using FridayNight.DAL.Models.Abstract;
using FridayNight.DataAccessLayer.Repositories.Models;
using FridayNight.Library.CoreLayer.Models;

namespace FridayNight.Core.Models
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