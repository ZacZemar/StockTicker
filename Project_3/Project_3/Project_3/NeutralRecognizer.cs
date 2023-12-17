using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Project_3
{
    // The 'NeutralRecognizer' class is responsible for identifying neutral candlestick patterns.
    
    internal class NeutralRecognizer : Recognizer
    {
        // This overridden method is tasked with determining if a neutral pattern is present
        // in a given list of 'smartCandlestick' objects.
        public override bool recognizePattern(List<smartCandlestick> lscs)
        {
            // Retrieves the first candlestick from the list, assuming the list has at least one candlestick.
            smartCandlestick cs = lscs[0];

            // The 'isNeutral' property of the 'smartCandlestick' is used to determine if the candlestick
            // is neither bullish nor bearish, which constitutes a neutral candlestick.
            return cs.isNeutral;
        }

        // Constructor for the 'NeutralRecognizer' class.
        // It initializes the base 'Recognizer' class with the name of the pattern "neutral"
        // and the pattern length, which is set to 1
        public NeutralRecognizer() : base("neutral", 1) { }
    }
}
