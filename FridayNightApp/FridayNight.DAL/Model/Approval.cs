using FridayNight.DAL.Model.Abstract;
using System;

namespace FridayNight.DAL.Model
{
    public class Approval : ModelBase
    {
        public DateTime Date { get; set; }

        public Band BandSide { get; set; }

        public Place PlaceSide { get; set; }

        public LivePerformance PerformanceUnderApproval { get; set; }
    }
}