using FridayNight.DAL.Models.Abstract;
using System.Collections.Generic;

namespace FridayNight.DAL.Models
{
    public class MusicPreferences : ModelBase
    {
        public List<MusicStyle> MusicStyles { get; set; }
    }
}