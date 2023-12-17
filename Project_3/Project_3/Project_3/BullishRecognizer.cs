//Using the project 3 generic namespace declaration
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_3
{
    // The BullishRecognizer class is defined as internal, meaning it is accessible
    // only within the same assembly. It is a specialized type of Recognizer for identifying bullish patterns.
    internal class BullishRecognizer : Recognizer
    {
        // Overrides the recognizePattern method from the Recognizer base class.
        // This method determines if a given list of smartCandlestick objects contains a bullish pattern.
        public override bool recognizePattern(List<smartCandlestick> lscs)
        {
            // Access the first smartCandlestick object from the list, assuming the list has at least one element.
            smartCandlestick cs = lscs[0];

            // Return the value of the isBullish property of the smartCandlestick object.
       
            return cs.isBullish;
        }

        // Constructor for the BullishRecognizer class.
        public BullishRecognizer() : base("bullish", 1) { }
    }
}
