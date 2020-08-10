using FridayNight.DAL.Model.Abstract;

namespace FridayNight.DAL.Model
{
    public class BandRating : RatingBase
    {
        public int LikesAmount { get; set; }

        public int ViewsAmount { get; set; }

        public int OpenedContactAmount { get; set; }
    }
}