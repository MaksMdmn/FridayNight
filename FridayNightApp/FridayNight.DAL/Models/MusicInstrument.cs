using FridayNight.DAL.Models.Abstract;

namespace FridayNight.DAL.Models
{
    public enum EInstrumentType
    {
        ElectricGuitar,
        Acoustic,
        Drums,
    }

    public class MusicInstrument : ModelBase
    {
        public EInstrumentType Type { get; set; }
    }
}