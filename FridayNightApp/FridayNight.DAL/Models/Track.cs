using FridayNight.DAL.Models.Abstract;
using System.Collections.Generic;

namespace FridayNight.DAL.Models
{
    public class Track : ModelBase
    {
        public MusicTalent Owner { get; set; }

        public string TrackName { get; set; }

        public List<MusicStyle> MusicStyle { get; set; }

        public TrackRating Rating { get; set; }
    }
}