using FridayNight.DAL.Model.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace FridayNight.DAL.Model
{
    public class Band : ModelBase
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public PhotoCover PhotoCover { get; set; }

        public YoutubeVideo YoutubeVideo { get; set; }

        public InstagramLink InstagramLink { get; set; }

        public List<LivePerformance> PerformanceHistory { get; set; }

        public List<LivePerformance> UpcomingPerformances { get; set; }

        public MusicStyle MusicStyle { get; set; }

        public List<Track> Tracks { get; set; }

        public SoundCloudBand SoundCloudData { get; set; }

        public Contact Contact { get; set; }

        public List<Photo> Photos { get; set; }

        public BandRating Rating { get; set; }

    }
}
