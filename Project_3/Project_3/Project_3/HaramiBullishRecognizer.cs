using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_3
{
    // Declares a class 'HaramiBullishRecognizer' that inherits from 'Recognizer'.
    // The class is internal, meaning it is accessible only within the same assembly.
    internal class HaramiBullishRecognizer : Recognizer
    {
        // Overrides the method 'recognizePattern' from the 'Recognizer' base class.
        // This method is intended to identify if a specific candlestick pattern is present in a list of candlesticks.
        public override bool recognizePattern(List<smartCandlestick> lscs)
        {
            // Retrieves the first two candlesticks from the list for pattern recognition.

            smartCandlestick cs0 = lscs[0]; 
            smartCandlestick cs1 = lscs[1]; 

            // Extracts the open and close values for both candlesticks.
            double cs0Open = cs0.open;
            double cs0Close = cs0.close;
            double cs1Open = cs1.open;
            double cs1Close = cs1.close;

            // Evaluates the conditions for a 'Harami Bullish' pattern:
      
            return ((cs0.isBearish && cs1.isBullish) && (cs0Close < cs1Open) && (cs0Open > cs1Close));
        }

        // Constructor for the 'HaramiBullishRecognizer' class.
        // Calls the constructor of the base 'Recognizer' class with the pattern name "harami bullish" and a pattern length of 2.
        public HaramiBullishRecognizer() : base("harami bullish", 2) { }
    }
}
