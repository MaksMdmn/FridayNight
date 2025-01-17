﻿using FridayNight.DAL.Models.Abstract;
using FridayNight.DataAccessLayer.Repositories.Models;
using System.Collections.Generic;

namespace FridayNight.DAL.Models
{
    public class MusicPreferences : EntityWithDbKey
    {
        public List<MusicStyle> MusicStyles { get; set; }
    }
}