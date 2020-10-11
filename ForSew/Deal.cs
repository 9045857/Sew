using System;

namespace ForSew
{
    public class Deal
    {
        public DateTime DealMoment { get; set; }
        public DealTypes DealType { get; set; }
        public float DealAmount { get; set; }

        public Deal(DateTime dealMoment, DealTypes dealType, float dealAmount)
        {
            DealMoment = dealMoment;
            DealType = dealType;
            DealAmount = dealAmount;
        }
    }
}
