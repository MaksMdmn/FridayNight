using FridayNight.DAL.Model.Abstract;
using System;

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
        public decimal Amount { get; set; }

        public EChargeState State { get; set; }

    }
}