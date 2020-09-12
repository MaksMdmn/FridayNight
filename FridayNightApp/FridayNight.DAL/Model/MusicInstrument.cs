using FridayNight.DAL.Model.Abstract;

namespace FridayNight.DAL.Model
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