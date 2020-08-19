using FridayNight.DAL.Model.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace FridayNight.DAL.Model
{
    public class User : Account
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public MusicPreferences MusicPreferences { get; set; }

    }
}
