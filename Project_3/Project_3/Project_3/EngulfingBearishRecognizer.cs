// using the necessary namespaces
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_3
{
    // The EngulfingBearishRecognizer is an internal class inheriting from the Recognizer base class.
    // It is specialized for identifying bearish engulfing patterns within a list of smartCandlestick objects.
    internal class EngulfingBearishRecognizer : Recognizer
    {
        // Override the recognizePattern method from the base Recognizer class.
        // This method determines if a bearish engulfing pattern is present in the first two candlesticks of the list.
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

            // Check the conditions for a bearish engulfing pattern:
            // The first candlestick must be bullish, the second bearish.
            return ((cs0.isBullish && cs1.isBearish) && (cs0Close < cs1Open) && (cs0Open > cs1Close));
        }

        // Constructor for the EngulfingBearishRecognizer class.
        public EngulfingBearishRecognizer() : base("engulfing bearish", 2) { }
    }
}
