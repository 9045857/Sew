using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ForSew
{
    public class PortfolioRepParse : ParseLog
    {
        public event AccountWarnings Notify;

        private InstrumentRepParse instrumentRepParse;

        public PortfolioRepParse()
        {
            instrumentRepParse = new InstrumentRepParse();
            instrumentRepParse.Notify += TransferInstrumentNotify;
        }

        private void TransferInstrumentNotify(string message)
        {
            Notify?.Invoke(message);
        }

        public Portfolio ParseCreatePortfolio(string path)
        {
            if (!File.Exists(path))
            {
                Notify?.Invoke(string.Format(Warnings.FileNotExist, path));
                return null;
            }

            List<Instrument> instruments = instrumentRepParse.ParseCreateInstruments(path);

            if (instruments == null)
            {
                return null;
            }

            Portfolio portfolio = new Portfolio
            {
                Instruments = instruments
            };

            return portfolio;
        }
    }
}
