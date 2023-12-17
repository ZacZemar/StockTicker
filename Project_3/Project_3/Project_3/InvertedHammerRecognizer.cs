using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// The namespace 'Project_3' groups classes 
namespace Project_3
{
    // The 'InvertedHammerRecognizer' class is designed to identify the 'Inverted Hammer' candlestick pattern within a list of candlesticks.
    
    internal class InvertedHammerRecognizer : Recognizer
    {
        // Overrides the abstract 'recognizePattern' method from the 'Recognizer' base class.
        // This method is responsible for determining if the 'Inverted Hammer' pattern exists in a given list of candlesticks.
        public override bool recognizePattern(List<smartCandlestick> lscs)
        {
            // Assumes that the list of candlesticks (lscs) contains at least one element and takes the first candlestick.
            smartCandlestick cs = lscs[0];

            // Returns the value of the 'isInvertedHammer' property from the 'smartCandlestick' instance.
            
            return cs.isInvertedHammer;
        }

        // Constructor for the 'InvertedHammerRecognizer' class.
        // The pattern name is set to "inverted hammer" and the pattern length is set to 1, indicating that this pattern is identified using a single candlestick.
        public InvertedHammerRecognizer() : base("inverted hammer", 1) { }
    }
}
