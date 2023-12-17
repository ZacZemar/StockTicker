// Once again using the necessary namespace calling conventions 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Namespace declaration for Project_3
namespace Project_3
{
    // The GraveStoneDojiRecognizer class is an internal class that inherits from the Recognizer base class.
    // It is specifically designed to recognize the gravestone doji candlestick pattern in a given list of smartCandlestick objects.
    internal class GraveStoneDojiRecognizer : Recognizer
    {
        public override bool recognizePattern(List<smartCandlestick> lscs)
        {
            // Retrieves the first smartCandlestick object from the list.
            smartCandlestick cs = lscs[0];
            // Returns the value of the isgravestonedoji property from the smartCandlestick object.
            // The isgravestoneDoji property should determine whether the candlestick meets the criteria
            return cs.isGravestoneDoji;
        }
        // Constructor to set the name as "Gravestone Doji" and the size as 1 for this specific recognizer
        public GraveStoneDojiRecognizer() : base("gravestone doji", 1) { }
    }
}
