using FridayNight.DAL.Model.Abstract;
using System.Collections.Generic;

namespace FridayNight.DAL.Model
{
    public class MusicPreferences : ModelBase
    {
        public List<MusicStyle> MusicStyles { get; set; }
    }
}