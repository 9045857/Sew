using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForSew
{
    public class NotifyLog
    {
        private static void Display(string text)
        {
           Console.WriteLine(text);
        }

        public static void RunLoger()
        {
            DealRepParse.Notify += Display;
            StrategyRepParse.Notify += Display;
        }
    }
}
