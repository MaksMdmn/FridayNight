using FridayNight.DAL.Models.Abstract;
using FridayNight.DataAccessLayer.Repositories.Models;
using FridayNight.Library.CoreLayer.Models;
using System.Collections.Generic;

namespace FridayNight.Core.Models
{
    public class MusicPreferences : ModelBase
    {
        public List<MusicStyle> MusicStyles { get; set; }
    }
}