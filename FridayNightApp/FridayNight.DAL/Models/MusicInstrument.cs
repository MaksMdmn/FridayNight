using FridayNight.DAL.Models.Abstract;
using FridayNight.DataAccessLayer.Repositories.Models;

namespace FridayNight.DAL.Models
{
    public enum EInstrumentType
    {
        ElectricGuitar,
        Acoustic,
        Drums,
    }

    public class MusicInstrument : EntityWithDbKey
    {
        public EInstrumentType Type { get; set; }
    }
}