using FridayNight.DAL.Model.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace FridayNight.DAL.Model
{
    public class Band : Account
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public Photo PhotoCover { get; set; }

        public YoutubeVideoLink YoutubeVideo { get; set; }

        public InstagramLink InstagramLink { get; set; }

        public List<LivePerformance> Performances { get; set; }

        public List<MusicStyle> MusicStyle { get; set; }

        public List<Track> Tracks { get; set; }

        public Contact Contact { get; set; }

        public List<Photo> Photos { get; set; }

        public BandRating Rating { get; set; }

    }
}
