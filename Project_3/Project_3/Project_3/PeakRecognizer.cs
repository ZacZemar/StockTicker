using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Project_3
{
    // The PeakRecognizer class is designed to identify peak patterns within a sequence of candlesticks.
    // Inherits from Recognizer, an abstract class defining the structure of pattern recognizers.
    internal class PeakRecognizer : Recognizer
    {
        // Overrides the recognizePattern method from Recognizer.
        // The method will be used to check if a peak pattern exists among the provided candlesticks.
        public override bool recognizePattern(List<smartCandlestick> lscs)
        {
            // Retrieves three candlesticks from the list
        
            smartCandlestick cs0 = lscs[0]; 
            smartCandlestick cs1 = lscs[1]; 
            smartCandlestick cs2 = lscs[2]; 

            // Returns true if the middle candlestick's high is greater than the highs of the ones to its left and right.
            // This comparison is the condition that defines a peak in the context of candlestick patterns.
            return ((cs1.high > cs0.high) && (cs1.high > cs2.high));
        }

        // Constructor for the PeakRecognizer class.
        // Calls the base class constructor with the pattern name "peak" and a pattern length of 3,
        // which means this pattern is identified using three consecutive candlesticks.
        public PeakRecognizer() : base("peak", 3) { }
    }
}
