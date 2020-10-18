using System;

namespace ForSew
{
    public class NotifyLog
    {
        private PortfolioRepParse portfolioRepParse;

        public NotifyLog(PortfolioRepParse portfolioRepParse)
        {
            this.portfolioRepParse = portfolioRepParse;
            this.portfolioRepParse.Notify += Console.WriteLine;
        }
    }
}
