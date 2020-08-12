using FridayNight.DAL.Model.Abstract;
using System.Collections.Generic;

namespace FridayNight.DAL.Model
{
    public class Track : ModelBase
    {
        public Band Owner { get; set; }

        public string TrackName { get; set; }

        public SoundCloudTrack SoundCloudTrack { get; set; }

        public List<MusicStyle> MusicStyle { get; set; }

        public TrackRating Rating { get; set; }
    }
}