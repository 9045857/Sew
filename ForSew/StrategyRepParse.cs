using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ForSew
{
    public class StrategyRepParse : ParseLog
    {
        public event AccountWarnings Notify;

        private DealRepParse dealRepParse;

        public StrategyRepParse()
        {
            dealRepParse = new DealRepParse();
            dealRepParse.Notify += TransferInstrumentNotify;
        }

        private void TransferInstrumentNotify(string message)
        {
            Notify?.Invoke(message);
        }

        public Strategy ParseCreateStrategy(string path)
        {
            if (!File.Exists(path))
            {
                Notify?.Invoke(string.Format(Warnings.FileNotExist, path));
                return null;
            }

            return new Strategy(ParseDeals(path));
        }


        private List<Deal> ParseDeals(string path)
        {
            List<string> lines = File.ReadAllLines(path, Encoding.UTF8/*GetEncoding(1251)*/).ToList();

            //TODO пока первая строчка лишняя по формату. Временное решение - убираем ее из массива
            lines.RemoveAt(0);

            List<Deal> deals = new List<Deal>();

            foreach (string line in lines)
            {
                Deal deal = dealRepParse.ParseCreateDeal(line);
                if (deal == null)
                {
                    continue;
                }

                deals.Add(deal);
            }

            return deals;
        }
    }
}
