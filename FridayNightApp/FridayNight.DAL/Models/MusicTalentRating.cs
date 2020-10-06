using FridayNight.DAL.Models.Abstract;

namespace FridayNight.DAL.Models
{
    public class MusicTalentRating : RatingBase
    {
        public int LikesCount { get; set; }

        public int ViewsCount { get; set; }

        public int OpenedContactCount { get; set; }
    }
}