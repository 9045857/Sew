using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ForSew
{
    public class StrategyRepParse
    {
        public static event ParseLog.AccountWarnings Notify;

        public static Strategy ParseCreateStrategy(string path)
        {
            if (!File.Exists(path))
            {
                //TODO need to do smth with this error
                return null;
            }

            return new Strategy(ParseDeals(path));
        }

        private static List<Deal> ParseDeals(string path)
        {
            List<string> lines = File.ReadAllLines(path, Encoding.UTF8/*GetEncoding(1251)*/).ToList();

            //TODO пока первая строчка лишняя по формату. Временное решение - убираем ее из массива
            lines.RemoveAt(0);

            List<Deal> deals = new List<Deal>();

            foreach (string line in lines)
            {
                Deal deal = DealRepParse.ParseCreateDeal(line);
                if (deal == null)
                {
                    Notify?.Invoke(string.Format(Warnings.DealDontParsed,path,line));
                    continue;
                }

                deals.Add(deal);
            }

            return deals;
        }
    }
}
