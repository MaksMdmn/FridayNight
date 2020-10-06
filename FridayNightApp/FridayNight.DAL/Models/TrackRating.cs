using FridayNight.DAL.Models.Abstract;

namespace FridayNight.DAL.Models
{
    public class TrackRating : RatingBase
    {
        public int ListenedCount { get; set; }
    }
}