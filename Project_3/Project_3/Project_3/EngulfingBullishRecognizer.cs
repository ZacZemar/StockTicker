using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_3
{
    // The EngulfingBullishRecognizer class is an internal class inheriting from the Recognizer base class.
    // It is specialized for identifying bullish engulfing patterns within a list of smartCandlestick objects.
    internal class EngulfingBullishRecognizer : Recognizer
    {
        
        // This method determines if a bullish engulfing pattern is present in the first two candlesticks of the list.
        public override bool recognizePattern(List<smartCandlestick> lscs)
        {
            // Access the first two smartCandlestick objects from the list, assuming the list has at least two elements.
            smartCandlestick cs0 = lscs[0]; 
            smartCandlestick cs1 = lscs[1]; 

            // Retrieve the open and close values of both candlesticks.
            double cs0Open = cs0.open;
            double cs0Close = cs0.close;
            double cs1Open = cs1.open;
            double cs1Close = cs1.close;

            // Check the conditions for a bullish engulfing pattern:
          
            return ((cs0.isBearish && cs1.isBullish) && (cs0Close > cs1Open) && (cs0Open < cs1Close));
        }

        // Constructor for the EngulfingBullishRecognizer class.
        // It initializes the base class with the pattern name "engulfing bullish" 
        public EngulfingBullishRecognizer() : base("engulfing bullish", 2) { }
    }
}
