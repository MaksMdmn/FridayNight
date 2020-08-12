﻿using FridayNight.DAL.Model.Abstract;
using System;

namespace FridayNight.DAL.Model
{
    public enum EPerformanceState
    {
        Upcoming,
        Passed,
        Canceled
    }

    public class LivePerformance : ModelBase
    {
        public DateTime Date { get; set; }

        public Band Band { get; set; }

        public Place Place { get; set; }

        public bool IsApproved { get; set; }

        public EPerformanceState State { get; set; }

        public FriendlyCharge Charge { get; set; }

        public TimeSpan? Duration { get; set; }

        public bool IsPrivate { get; set; }

        public Location Location { get; set; }
    }
}