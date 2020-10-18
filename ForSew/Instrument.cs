using System.Collections.Generic;

namespace ForSew
{
    public class Instrument
    {
        public List<Strategy> Strategies { get; set; }
        public InstrumentTypes InstrumentType { get; set; }

        public Instrument() { }

        public Instrument(InstrumentTypes instrumentType, List<Strategy> strategies)
        {
            Strategies = strategies;
            InstrumentType = instrumentType;
        }
    }
}
