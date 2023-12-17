// Once again using the necessary namespace calling conventions 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Simple namespace calling it project 3
namespace Project_3
{
    // The DojiRecognizer class is an internal class that inherits from the Recognizer base class.
    // Its purpose is to recognize doji patterns within a list of smartCandlestick objects.
    internal class DojiRecognizer : Recognizer
    {
        
        // This method is used to determine if the first smartCandlestick in the list is a doji pattern.
        public override bool recognizePattern(List<smartCandlestick> lscs)
        {
            // Access the first smartCandlestick object from the list.
            smartCandlestick cs = lscs[0];

            // Return the value of the isDoji property of the smartCandlestick object.
            // This property should indicate whether the candlestick is a doji based on its specific criteria
          
            return cs.isDoji;
        }

        // Constructor for the DojiRecognizer class.
     
        public DojiRecognizer() : base("doji", 1) { }
    }
}
