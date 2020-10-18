using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace ForSew
{
    public class InstrumentRepParse : ParseLog
    {
        public event AccountWarnings Notify;

        private const string COINCheckPhrase = "Instrument=COIN";
        private const string ETHUSDCheckPhrase = "Instrument=ETHUSD";
        private const string InstrumentSearchPhrase = "Instrument=";
        private const string FolderSearchPhrase = "Folder=";

        private StrategyRepParse strategyRepParse;

        public InstrumentRepParse()
        {
            strategyRepParse = new StrategyRepParse();
            strategyRepParse.Notify += TransferInstrumentNotify;
        }

        private void TransferInstrumentNotify(string message)
        {
            Notify?.Invoke(message);
        }

        private Dictionary<InstrumentTypes, List<string>> GetInstrumentsPaths(string path)
        {
            Dictionary<InstrumentTypes, List<string>> paths = new Dictionary<InstrumentTypes, List<string>>();

            if (!File.Exists(path))
            {
                Notify?.Invoke(string.Format(Warnings.FileNotExist, path));
                return null;
            }

            List<string> lines = File.ReadAllLines(path, Encoding.UTF8/*GetEncoding(1251)*/).ToList();

            InstrumentTypes instrumentTypes = InstrumentTypes.None;
            int folderSearchPhraseLength = FolderSearchPhrase.Length;

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

                if (line.Length < folderSearchPhraseLength)
                {
                    Notify?.Invoke(string.Format(Warnings.ShortLine, line));
                    continue;
                }

                string strategyPath = line.Substring(folderSearchPhraseLength);

                paths[instrumentTypes].Add(strategyPath);
            }

            if (instrumentTypes == InstrumentTypes.None)
            {
                Notify?.Invoke(string.Format(Warnings.InstrumentsDontParse, path));
                return null;
            }

            return paths;
        }

        private void CreatePaths(Dictionary<InstrumentTypes, List<string>> paths, InstrumentTypes instrumentTypes)
        {
            if (!paths.ContainsKey(instrumentTypes))
            {
                paths.Add(instrumentTypes, new List<string>());
            }
        }

        public List<Instrument> ParseCreateInstruments(string path)
        {
            Dictionary<InstrumentTypes, List<string>> instrumentPaths = GetInstrumentsPaths(path);
            if (instrumentPaths == null)
            {
                return null;
            }

            List<Instrument> instruments = new List<Instrument>();
            foreach (KeyValuePair<InstrumentTypes, List<string>> instrumentPath in instrumentPaths)
            {
                List<Strategy> strategies = new List<Strategy>();

                foreach (string strategyPath in instrumentPath.Value)
                {
                    Strategy strategy = strategyRepParse.ParseCreateStrategy(strategyPath);

                    if (strategy == null)
                    {
                        continue;
                    }

                    strategies.Add(strategy);
                }

                Instrument instrument = new Instrument(instrumentPath.Key, strategies);
                instruments.Add(instrument);
            }

            return instruments;
        }
    }
}
