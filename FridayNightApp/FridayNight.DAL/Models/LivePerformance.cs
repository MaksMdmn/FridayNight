using FridayNight.DAL.Models.Abstract;
using System;

namespace FridayNight.DAL.Models
{
    public enum EPerformanceState
    {
        Upcoming,
        Passed,
        Canceled
    }

    public enum EPerformanceType
    {
        PrivatePary,
        Club,
        Pub,
        Concert,
        Custom
    }

    public class LivePerformance : ModelBase
    {
        public string Name { get; set; }

        public EPerformanceType PerformanceType { get; set; }

        public DateTime Date { get; set; }
        
        public Location Location { get; set; }

        public TimeSpan? Duration { get; set; }

        public bool IsPrivate { get; set; }

        public Photo Photo { get; set; }

        public MusicTalent MusicTalent { get; set; }

        public TalentSeeker TalentSeeker { get; set; }

        public EPerformanceState State { get; set; }

        public InternalLink InAppLink { get; set; }
    }
}