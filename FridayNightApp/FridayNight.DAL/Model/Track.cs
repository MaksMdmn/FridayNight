using FridayNight.DAL.Model.Abstract;

namespace FridayNight.DAL.Model
{
    public class Track : ModelBase
    {
        public Band Owner { get; set; }

        public string TrackName { get; set; }

        public SoundCloudTrack SoundCloudData { get; set; }

        public MusicStyle MusicStyle { get; set; }

        public TrackRating Rating { get; set; }
    }
}