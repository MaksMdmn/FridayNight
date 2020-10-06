using System;
using System.Collections.Generic;
using System.Text;

namespace FridayNight.Core.Models
{
    public enum EMusicStyle
    {
        Rock,
        Dj,
        Pop,
        HipHop
    }

    public class TalentSeekerRegistrationSpec
    {
        public bool QuickRegistrationEnabled { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string Name { get; set; }

        public string Phone { get; set; }

        public List<Locations> Locations { get; set; }

        public List<EMusicStyle> FavoriteMusicStyles { get; set; }
    }
}
