using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace ForSew
{
    public class Strategy
    {
        public List<Deal> Deals { get; set; }

        public Strategy(string path)
        {
            Deals = ParseDeals(path);
        }

        private static List<Deal> ParseDeals(string path)
        {
            List<Deal> deals = new List<Deal>();
            try
            {
                using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
                {
                    string line = sr.ReadLine();

                    while ((line = sr.ReadLine()) != null)
                    {
                        Deal deal = new Deal(line);
                        deals.Add(deal);
                    }
                }
            }
            catch (Exception e)
            {
                //TODO что делаем с исключением
                Console.WriteLine(e.Message);
            }

            return deals;
        }
    }
}
