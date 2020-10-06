using FridayNight.DAL.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace FridayNight.DAL.Models
{
    public class MusicTalent : TalentProvider
    {
        public string Description { get; set; }

        public List<MusicInstrument> Instruments { get; set; }

        public List<MusicStyle> MusicStyle { get; set; }

        public List<Track> Tracks { get; set; }

        public List<Photo> Photos { get; set; }
        
        public Photo PhotoCover { get; set; }

        public YoutubeVideoLink YoutubeVideo { get; set; }

        public InstagramLink InstagramLink { get; set; }
        
        public List<LivePerformance> Performances { get; set; }

        public MusicTalentRating Rating { get; set; }

        public decimal DesirablePayment { get; set; }
    }
}
