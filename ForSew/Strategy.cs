using System.Collections.Generic;

/// <summary>
/// 
/// </summary>
namespace ForSew
{
    public class Strategy
    {
        public List<Deal> Deals { get; set; }

        public Strategy(List<Deal> deals) {
            Deals = deals;
        }
    }
}
