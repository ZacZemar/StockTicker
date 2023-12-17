// Once again using the necessary namespace calling conventions 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Using the namespace to call it project 3 
namespace Project_3
{
    // The DragonflyDojiRecognizer class is an internal class that inherits from the Recognizer base class.
    // It is specifically designed to recognize the dragonfly doji candlestick pattern in a given list of smartCandlestick objects.
    internal class DragonflyDojiRecognizer : Recognizer
    {
        // Overrides the recognizePattern method from the Recognizer base class.
        // This method is used to check if the first smartCandlestick in the list matches the dragonfly doji pattern.
        public override bool recognizePattern(List<smartCandlestick> lscs)
        {
            // Retrieves the first smartCandlestick object from the list.
            smartCandlestick cs = lscs[0];

            // Returns the value of the isDragonFlyDoji property from the smartCandlestick object.
            // The isDragonFlyDoji property should determine whether the candlestick meets the criteria
            
            return cs.isDragonFlyDoji;
        }

        // Constructor for the DragonflyDojiRecognizer class.
        // Calls the base class constructor with the pattern name "dragonfly doji" to 1 
        public DragonflyDojiRecognizer() : base("dragonfly doji", 1) { }
    }
}
