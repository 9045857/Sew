using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForSew
{
    public class Instrument
    {
        public List<Strategy> Strategies { get; set; }
        public InstrumentTypes InstrumentType { get; set; }

        public Instrument(InstrumentTypes instrumentType, List<Strategy> strategies)
        {
            InstrumentType = instrumentType;
            Strategies = strategies;
        }


        private void SetStrategiesFromFiles(List<Strategy> strategies, List<string> puths)
        {
            foreach (string puth in puths)
            {
                Strategy strategy = StrategyRepParse.ParseCreateStrategy(puth);
                strategies.Add(strategy);
            }
        }

        private void SetStrategiesFromFolders(List<Strategy> strategies, List<string> puths)
        {
            //TODO Do need checking of file existing?
            int f = 1;//пустая ерунда, для проверки черепахи
        }

    }
}
