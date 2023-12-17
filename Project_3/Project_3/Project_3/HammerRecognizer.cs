using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Defines a namespace for the project.
namespace Project_3
{
    // HammerRecognizer is a class that determines if a candlestick pattern is a Hammer.
    // It inherits from the Recognizer class
    internal class HammerRecognizer : Recognizer
    {
        // Overrides the recognizePattern method from the Recognizer base class.
        // This method is used to check if a given list of candlesticks contains a Hammer pattern.
        public override bool recognizePattern(List<smartCandlestick> lscs)
        {
            // Assumes that the list of candlesticks (lscs) is not empty and takes the first candlestick.
            smartCandlestick cs = lscs[0];

            // Returns the boolean value of the isHammer property of the smartCandlestick object.
            
            return cs.isHammer;
        }

        // Constructor for the HammerRecognizer class.
        // Calls the base class constructor with the name of the pattern ("hammer") and its length (1 candlestick).
        public HammerRecognizer() : base("hammer", 1) { }
    }
}
