// These were imported libraries being used in this code 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;


namespace Project_3
{   // Making the smartcandlestick objects the gets the properties from the 
    // original candlestick class
    public class smartCandlestick : candlestick {
        // Using variables for the get and set values 
        // Firstly calculating the candlestick range 
        public double range { get; set; }
        // Top price then follow bottomprice, bodyrange, uppertail, lowertail
     
        public double topPrice { get; set; }
        public double bottomPrice { get; set; }
        public double bodyRange { get; set; }
        public double upperTail { get; set; }
        public double lowerTail { get; set; }

        // Checking is its bullish, bearish, or neutral, marubozu, doji,
        // dragonflydoji, gravestonedoji, hammer, invertedhammer
        public bool isBullish { get; set; }
        public bool isBearish { get; set; }
        public bool isNeutral { get; set; }
        public bool isMarubozu { get; set; }
        public bool isDoji { get; set; }
        public bool isDragonFlyDoji { get; set; }
        public bool isGravestoneDoji { get; set; }
        public bool isHammer { get; set; }
        public bool isInvertedHammer { get; set; }

        // This is the constructor of the smartcandlestick that contain 
        // rows of data as a parameter which is constructed in candlestick
        public smartCandlestick(String rowOfData) : base(rowOfData)
        {
            // These properties are getting set to indentify the smart candlestick 
            Properties();
            Patterns();
        }

        private void Properties()
        {
            // range by subtracting high - low 
            range = high - low;

            // getting topprice by findng max between open and close 
            topPrice = Math.Max(open, close);

            // finding bottom price by finding min between open and close
            bottomPrice = Math.Min(open, close);

            // found by subtracting the max and min
            bodyRange = topPrice - bottomPrice;

            // found by subtracting the high and top price 
            upperTail = high - topPrice;

            //found by subtracting bottom and low price 
            lowerTail = bottomPrice - low;
        }

        // This is used to determine the patterns based on their unique characteristics
        private void Patterns()
        {
            //If the conditions are met, based on the set characteristics,
            // then they will be checked accordingly
            // Using the calculations based on open, close, bodyrange, abs, etc
            // Will determine the calculation for each unique pattern

            //bullish
            isBullish = close > open;

            //bearish
            isBearish = close < open;

            // Marubozu 
            isMarubozu = Math.Abs(bodyRange - range) < 0.05;

            // hammer 
            isHammer = isBullish && lowerTail >= 2 * bodyRange && upperTail <= 0.25 * bodyRange;

            // Invertedhammer
            isInvertedHammer = isBullish && upperTail >= 2 * bodyRange && lowerTail <= 0.25 * bodyRange;

            // Doji
            isDoji = Math.Abs(close - open) < 0.05;

            //gravestone doji
            isGravestoneDoji = isDoji && Math.Abs(close - low) < 0.15 && Math.Abs(open - low) < 0.15;

            //dragonfly doji
            isDragonFlyDoji = isDoji && Math.Abs(close - high) < 0.15 && Math.Abs(open - high) < 0.15;

            // Neutral 
            isNeutral = isDoji;
        }
    }
}
