using FridayNight.DAL.Model.Abstract;

namespace FridayNight.DAL.Model
{
    public class TrackRating : RatingBase
    {
        public int ListenedAmount { get; set; }
    }
}