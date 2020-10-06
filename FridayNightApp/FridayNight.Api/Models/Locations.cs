using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FridayNight.Api.Models
{
    [JsonObject]
    public class Locations : IValidatableObject
    {
        public string Country { get; set; }

        public string City { get; set; }

        public string Address { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            throw new System.NotImplementedException();
        }
    }
}