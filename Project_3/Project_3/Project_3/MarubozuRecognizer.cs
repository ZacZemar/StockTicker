using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_3
{
    // The 'MarubozuRecognizer' class, defined as internal, is accessible only within the assembly where it's declared.
    
    internal class MarubozuRecognizer : Recognizer
    {
        // Overrides the 'recognizePattern' method from the abstract 'Recognizer' base class.
        // This method is tasked with determining whether a list of 'smartCandlestick' instances contains a Marubozu pattern.
        public override bool recognizePattern(List<smartCandlestick> lscs)
        {
            // Accesses the first element of the list of candlesticks assuming the list is not empty.
            smartCandlestick cs = lscs[0];

            // Evaluates and returns the boolean result of the 'isMarubozu' property of the 'smartCandlestick'.
            
            return cs.isMarubozu;
        }

        // The constructor for the 'MarubozuRecognizer' class.
        // The base constructor is called with the pattern name "marubozu" and a pattern length of 1, 
        public MarubozuRecognizer() : base("marubozu", 1) { }
    }
}
