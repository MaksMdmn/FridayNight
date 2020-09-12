﻿using FridayNight.DAL.Model.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace FridayNight.DAL.Model
{
    public class TalentSeeker : AccountBase
    {
        public List<Location> Locations { get; set; }

        public List<ViewedTalents> ViewedBands { get; set; }
        
        public List<LivePerformance> PerformanceHistory { get; set; }

        public MusicPreferences MusicPreferences { get; set; }
    }
}
