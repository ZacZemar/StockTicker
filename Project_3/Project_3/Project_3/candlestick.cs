using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_3
{   // This was given during the lecture so it was used during the candlestick class
    public class candlestick
    {
        // We had talked about getters and setters for stock info so these will naturally align
        // with the open high low close volume and date
        public double open { get; set; }

        public double high { get; set; }

        public double low { get; set; }

        public double close { get; set; }

        public long volume { get; set; }

        public DateTime date { get; set; }

        // This is what allows for the parsing and data binding 
        public candlestick(String rowOfData)
        {
            // Since there could be potential separators we create an array here
            char[] separators = new char[] { ',', ' ', '"', '-' };
            //This splits the string and also remove empty entries 
            string[] subs = rowOfData.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            //Using a map to map out the months which correspond to the numbers (key value pairing)
            Dictionary<string, int> map = new Dictionary<string, int>();
            int i = 1;
            map.Add("Jan", i++);
            map.Add("Feb", i++);
            map.Add("Mar", i++);
            map.Add("Apr", i++);
            map.Add("May", i++);
            map.Add("Jun", i++);
            map.Add("Jul", i++);
            map.Add("Aug", i++);
            map.Add("Sep", i++);
            map.Add("Oct", i++);
            map.Add("Nov", i++);
            map.Add("Dec", i++);
            // Using a bool during the parsing process
            bool success;
            // Temp values for the corresponding day month year 
            Decimal temp, day, month, year;

            double doubleTemp;
            //Getting the decimal value from the dictionary 
            month = map[subs[2]];

            // Parsing and the storing said data
            success = Decimal.TryParse(subs[3], out temp);
            day = temp;

            success = Decimal.TryParse(subs[4], out temp);
            year = temp;
            // This will allow a new object to be created to then store the 
            // parsed information
            date = new DateTime(Decimal.ToInt32(year), Decimal.ToInt32(month), Decimal.ToInt32(day));

            // Below are storing the values into vars using temp for open high
            // low close volume
            success = double.TryParse(subs[5], out doubleTemp);
            open = doubleTemp;

            success = double.TryParse(subs[6], out doubleTemp);
            high = doubleTemp;

            success = double.TryParse(subs[7], out doubleTemp);
            low = doubleTemp;

            success = double.TryParse(subs[8], out doubleTemp);
            close = doubleTemp;

            long tempVolume;
            success = long.TryParse(subs[9], out tempVolume);
            volume = tempVolume;
        }
    }
}
