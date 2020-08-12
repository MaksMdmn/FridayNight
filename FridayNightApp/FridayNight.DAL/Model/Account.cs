using FridayNight.DAL.Model.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace FridayNight.DAL.Model
{
    public class Account : ModelBase
    {
        public string Email { get; set; }

        public string Phone { get; set; }

        public string Password { get; set; }
    }
}
