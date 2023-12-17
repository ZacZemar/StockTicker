using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// The namespace 'Project_3' contains the classes related to project_3.
namespace Project_3
{
    // 'HaramiBearishRecognizer' is a class that specializes in recognizing a specific candlestick pattern.
    // It inherits from 'Recognizer'
    internal class HaramiBearishRecognizer : Recognizer
    {
        // Overrides the 'recognizePattern' method defined in the 'Recognizer' base class.
        // The method determines if a Harami Bearish pattern exists within a list of candlesticks.
        public override bool recognizePattern(List<smartCandlestick> lscs)
        {
            // Access the first two candlesticks in the list assumed to be in chronological order.
            smartCandlestick cs0 = lscs[0]; 
            smartCandlestick cs1 = lscs[1]; 

            // Retrieve opening and closing prices for both candlesticks.
            double cs0Open = cs0.open; 
            double cs0Close = cs0.close; 
            double cs1Open = cs1.open; 
            double cs1Close = cs1.close; 

            // Return true if the pattern matches the criteria for a Harami Bearish pattern:
      
            return ((cs0.isBullish && cs1.isBearish) && (cs0Open < cs1Close) && (cs0Close > cs1Open));
        }

        // Constructor for the 'HaramiBearishRecognizer' class.
        // Initializes a new instance of the 'Recognizer' base class with
        // the pattern name "harami bearish" and a pattern length of 2 candlesticks.
        public HaramiBearishRecognizer() : base("harami bearish", 2) { }
    }
}
