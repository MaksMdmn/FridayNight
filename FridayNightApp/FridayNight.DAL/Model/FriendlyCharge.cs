using FridayNight.DAL.Model.Abstract;

namespace FridayNight.DAL.Model
{
    public enum EChargeState
    {
        Awaiting,
        Paid,
        Declined,
        Expired
    }


    public class FriendlyCharge : ModelBase
    {
        public Band Band { get; set; }

        public decimal Amount { get; set; }

        public EChargeState State { get; set; }

    }
}