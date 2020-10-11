using FridayNight.DAL.Models.Abstract;
using FridayNight.DataAccessLayer.Repositories.Models;
using System.Collections.Generic;

namespace FridayNight.DAL.Models
{
    public class Track : EntityWithDbKey
    {
        public MusicTalent Owner { get; set; }

        public string TrackName { get; set; }

        public List<MusicStyle> MusicStyle { get; set; }

        public TrackRating Rating { get; set; }
    }
}