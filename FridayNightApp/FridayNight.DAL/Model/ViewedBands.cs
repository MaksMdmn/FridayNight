﻿using FridayNight.DAL.Model.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace FridayNight.DAL.Model
{
    public class ViewedBands : ActionRecordBase
    {
        public Band Band { get; set; }
    }
}