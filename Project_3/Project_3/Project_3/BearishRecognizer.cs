// Using the necessary namespaces
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_3
{
    // Define a class BearishRecognizer that inherits from the Recognizer class.
    // This class is responsible for identifying bearish candlestick patterns.
    internal class BearishRecognizer : Recognizer
    {
        // Override the recognizePattern method from the base Recognizer class.
        // This method takes a list of smartCandlestick objects and determines 
        // if the first candlestick in the list is bearish.
        public override bool recognizePattern(List<smartCandlestick> lscs)
        {
            // Access the first smartCandlestick object from the list.
            smartCandlestick cs = lscs[0];

            // Return true if the first candlestick is identified as bearish,
            // otherwise return false.
            return cs.isBearish;
        }

        // Constructor for BearishRecognizer.
        // Calls the base class constructor with the pattern name "bearish" and a pattern length of 1.
        public BearishRecognizer() : base("bearish", 1) { }
    }
}
