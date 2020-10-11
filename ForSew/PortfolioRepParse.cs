using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ForSew
{
    public class PortfolioRepParse
    {
        private const string COINCheckPhrase = "Instrument=COIN";
        private const string ETHUSDCheckPhrase = "Instrument=ETHUSD";
        private const string InstrumentSearchPhrase = "Instrument=";
        private const string FolderSearchPhrase = "Folder=";

        public static Portfolio ParseCreatePortfolio(string path)
        {
            if (!File.Exists(path))
            {
                //TODO need to do smth with this error
                return null;
            }

            List<Instrument> instruments = ParseInstruments(path);

            Portfolio portfolio = new Portfolio
            {
                Instruments = instruments
            };

            return portfolio;
        }

        private static Dictionary<InstrumentTypes, List<string>> GetInstrumentsPaths(string path)
        {
            Dictionary<InstrumentTypes, List<string>> paths = new Dictionary<InstrumentTypes, List<string>>();

            List<string> lines = File.ReadAllLines(path, Encoding.UTF8/*GetEncoding(1251)*/).ToList();

            InstrumentTypes instrumentTypes = InstrumentTypes.None;
            int FolderSearchPhraseLength = FolderSearchPhrase.Length;

            foreach (string line in lines)
            {
                if (line.Contains(COINCheckPhrase))
                {
                    instrumentTypes = InstrumentTypes.COIN;
                    CreatePaths(paths, instrumentTypes);
                    continue;
                }
                else if (line.Contains(ETHUSDCheckPhrase))
                {
                    instrumentTypes = InstrumentTypes.ETHUSD;
                    CreatePaths(paths, instrumentTypes);
                    continue;
                }
                else if (instrumentTypes == InstrumentTypes.None)
                {
                    continue;
                }

                if (line.Length < FolderSearchPhraseLength)
                {
                    continue;
                }

                string strategyPath = line.Substring(FolderSearchPhraseLength);

                Console.WriteLine("{0}: {1}", instrumentTypes, strategyPath);

                paths[instrumentTypes].Add(strategyPath);
            }

            return paths;
        }

        private static void CreatePaths(Dictionary<InstrumentTypes, List<string>> paths, InstrumentTypes instrumentTypes)
        {
            if (!paths.ContainsKey(instrumentTypes))
            {
                paths.Add(instrumentTypes, new List<string>());
            }
        }

        private static List<Instrument> ParseInstruments(string path)
        {
            Dictionary<InstrumentTypes, List<string>> instrumentPaths = GetInstrumentsPaths(path);

            List<Instrument> instruments = new List<Instrument>();
            foreach (KeyValuePair<InstrumentTypes, List<string>> instrumentPath in instrumentPaths)
            {
                List<Strategy> strategies = new List<Strategy>();
                foreach (string strategyPath in instrumentPath.Value)
                {
                    Strategy strategy = StrategyRepParse.ParseCreateStrategy(strategyPath);
                    strategies.Add(strategy);
                }

                Instrument instrument = new Instrument(instrumentPath.Key, strategies);
                instruments.Add(instrument);
            }

            return instruments;
        }
    }
}
