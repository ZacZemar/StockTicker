using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// This code is part of the project project_3 
namespace Project_3
{
    // Abstract base clas which was referenced in all the recognizer patterns in the data
    public abstract class Recognizer
    {
        // This will store the name and size of the recognizer
        public string name;
        public int size;
        // Finding all the patterns within the list of smartcandlesticks 
        public List<int> recognize(List<smartCandlestick> lscs)
        {
            List<int> result = new List<int>(lscs.Count());
            // Loop through the smartcandlestick starting from size - 1 
            for (int i = size - 1; i < lscs.Count; i++)
            {
                // This makes sublist of smartcandlesticks with the specific size 
                List<smartCandlestick> sublist = lscs.GetRange(i - size + 1, size);
                if (recognizePattern(sublist))
                {
                    // Add the index to result list if pattern is found
                    result.Add(i);
                }
            }
            // return list indices of where the patterns are being found
            return result;
        }
        // Using an abstract method to impletment the dervied class for recognizing the patterns
        public abstract bool recognizePattern(List<smartCandlestick> lscs);
        // This is a constructor to set the name and size of said recognizer 
        public Recognizer(string pn, int ps)
        {
            name = pn;
            size = ps;
        }
    }
}
