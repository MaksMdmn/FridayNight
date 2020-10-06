using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FridayNight.Api.Models
{
    public enum EMusicStyle
    {
        Rock,
        Dj,
        Pop,
        HipHop
    }

    [JsonObject]
    public class TalentSeekerRegistrationSpec : IValidatableObject
    {
        public bool QuickRegistrationEnabled { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string Name { get; set; }

        public string Phone { get; set; }

        public List<Locations> Locations { get; set; }

        public List<EMusicStyle> FavoriteMusicStyles { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            throw new NotImplementedException();
        }
    }
}
