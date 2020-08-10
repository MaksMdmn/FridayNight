using FridayNight.DAL.Model.Abstract;
using System;
using System.Collections.Generic;

namespace FridayNight.DAL.Model
{
    public enum EPlaceType
    {
        Pub,
        Restoraunt,
        Club,
        PublicOpenSpace,
        PrivatePary
    }


    public class Place : ModelBase
    {
        public string Name { get; set; }

        public Contact Contact { get; set; }

        public List<Location> Locations { get; set; }

        public EPlaceType PlaceType { get; set; }

        public List<LivePerformance> PerformanceHistory { get; set; }

        public Dictionary<DateTime, ViewedData> ViewedBands { get; set; }
    }
}