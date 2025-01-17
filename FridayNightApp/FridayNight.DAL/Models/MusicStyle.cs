﻿using FridayNight.DAL.Models.Abstract;
using FridayNight.DataAccessLayer.Repositories.Models;

namespace FridayNight.DAL.Models
{
    public enum EMusicStyle
    {
        Rock,
        Dj,
        Pop,
        HipHop
    }

    public class MusicStyle : EntityWithDbKey
    {
        public EMusicStyle Name { get; set; }
    }
}