using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Project_3
{
    // The 'ValleyRecognizer' class is designed to detect a specific candlestick pattern called a 'valley'.
    // The class is internal, meaning it is only accessible within the same assembly.
    
    internal class ValleyRecognizer : Recognizer
    {
        // Override the 'recognizePattern' method from the base 'Recognizer' class.
        // This method is intended to determine if a valley pattern exists in the provided list of 'smartCandlestick' objects.
        public override bool recognizePattern(List<smartCandlestick> lscs)
        {
            // Assumes there are at least three candlesticks in the list to form a valley pattern.
            
            smartCandlestick cs0 = lscs[0]; 
            smartCandlestick cs1 = lscs[1]; 
            smartCandlestick cs2 = lscs[2]; 

            // Returns true if the low of the middle candlestick is lower than the lows of the surrounding candlesticks.
           
            return ((cs1.low < cs0.low) && (cs1.low < cs2.low));
        }

        // Constructor for the 'ValleyRecognizer' class.
        // It initializes the class with the pattern name 'valley' and a pattern length of 3,
        // which refers to the number of candlesticks involved in forming a valley pattern.
        public ValleyRecognizer() : base("valley", 3) { }
    }
}
