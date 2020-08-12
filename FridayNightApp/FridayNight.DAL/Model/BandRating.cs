﻿using FridayNight.DAL.Model.Abstract;

namespace FridayNight.DAL.Model
{
    public class BandRating : RatingBase
    {
        public int LikesCount { get; set; }

        public int ViewsCount { get; set; }

        public int OpenedContactCount { get; set; }
    }
}