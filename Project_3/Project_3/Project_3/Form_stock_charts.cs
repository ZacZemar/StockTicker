using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Project_3
{   // A partial class for the form chart 
    public partial class Form_stock_charts : Form
    {   
        public List<smartCandlestick> list = new List<smartCandlestick>(1024);
        //These have all the filtered candlesticks
        public BindingList<smartCandlestick> scs { get; set; } = new BindingList<smartCandlestick>();
        // This is the name of the file being displayed
        public string name;

        internal DateTime start_date;
        internal DateTime end_date;
        // List of Recognizers 
        internal List<Recognizer> lr = new List<Recognizer>();
        // simple default form stock constructor 
        public Form_stock_charts()
        {
            InitializeComponent();
        }
        // What this will do is filer said candlesticks based on the dates with
        // with the data grid view and the data 
        public void filterCandlesticks()
        {
            scs.Clear();
            // Looping for the date range 
            foreach (smartCandlestick cs in list)
            {   // Checking if the date is greater than the time picked, 
                // if so loop will break 
                if (cs.date > dateTimePicker_endDate.Value)
                    break;
                // or add to the list 
                else if (cs.date >= dateTimePicker_startDate.Value)
                {
                    scs.Add(cs);
                }
            }

            chart_stockChart.Titles.Clear();

            chart_stockChart.Titles.Add(Path.GetFileNameWithoutExtension(name));
            // This is what connects is to the chart 
            chart_stockChart.DataSource = scs;
            // This is what binds it to the chart 
            chart_stockChart.DataBind();
        }
        // Calling the function to fill the recognizer and combobox with the pattern names 
        public void fill(List<Recognizer> lr)
        {   // Lines 67 -81 contain all the pattern names 
            comboBox_pattern.Items.Clear();
            if (!lr.Any())
            {
                lr.Add(new BullishRecognizer());
                lr.Add(new BearishRecognizer());
                lr.Add(new NeutralRecognizer());
                lr.Add(new MarubozuRecognizer());
                lr.Add(new DojiRecognizer());
                lr.Add(new DragonflyDojiRecognizer());
                lr.Add(new GraveStoneDojiRecognizer());
                lr.Add(new HammerRecognizer());
                lr.Add(new InvertedHammerRecognizer());
                lr.Add(new PeakRecognizer());
                lr.Add(new ValleyRecognizer());
                lr.Add(new EngulfingBearishRecognizer());
                lr.Add(new EngulfingBullishRecognizer());
                lr.Add(new HaramiBearishRecognizer());
                lr.Add(new HaramiBullishRecognizer());
            }
            // This loop adds the pattern names to the combobox 
            foreach (Recognizer R in lr)
            {
                if (!comboBox_pattern.Items.Contains(R.name))
                {
                    comboBox_pattern.Items.Add(R.name);
                }
            }

        }
        // When user decides to update the dates for the chart display this function gets called
        private void button_stockUpdater_Click(object sender, EventArgs e)
        {
            start_date = dateTimePicker_startDate.Value;
            end_date = dateTimePicker_endDate.Value;
            // Clearing annotation
            filterCandlesticks();
        }
        // This gets called when user wants a pattern to be annotated and displayed
        private void button_pattern_Click(object sender, EventArgs e)
        {
            // This will clear in case there are previous annotations
            chart_stockChart.Annotations.Clear();
            // Calling the function to annotate on chart with the proper indices 
            // that follow the pattern and pattern name
            annotation(lr[comboBox_pattern.FindStringExact(comboBox_pattern.SelectedItem.ToString())].recognize(scs.ToList()), comboBox_pattern.SelectedItem.ToString());
            // Refreshing the chart 
            chart_stockChart.Refresh();
        }

        // CHAT GPT helped me with this annotation loop as I was incorrectly 
        // assuming the index for some of the stock patterns in the foreach loop
        private void annotation(List<int> index, string name)
        {
            foreach (int i in index) // Iterate through the list of indices.
            {
                if (i < 0 || i >= scs.Count)
                {
                    // Index is out of bounds.
                    continue; // Skip to the next index.
                }
                // Getting a candlestick from the list we created 
                smartCandlestick sc = scs[i];
                // This will create the new annotation
                RectangleAnnotation ranno = new RectangleAnnotation();

                ranno.AxisX = chart_stockChart.ChartAreas[0].AxisX;
                ranno.AxisY = chart_stockChart.ChartAreas[0].AxisY;
                ranno.X = sc.date.ToOADate();
                ranno.Y = sc.topPrice;
                // Correct the width calculation, ensuring not to divide by zero.
                ranno.Width = (chart_stockChart.ChartAreas[0].AxisX.Maximum - chart_stockChart.ChartAreas[0].AxisX.Minimum) / (chart_stockChart.Series["series_OpHiLoCl"].Points.Count - 1) * 10;
                ranno.Height = 5;
                ranno.LineColor = Color.Black;
                ranno.LineWidth = 1;
                ranno.BackColor = Color.FromArgb(50, Color.Yellow);
                ranno.Text = name;

                // Ensure the series has points and the index i is within bounds.
                if (chart_stockChart.Series["series_OpHiLoCl"].Points.Count > i)
                {
                    ranno.SetAnchor(chart_stockChart.Series["series_OpHiLoCl"].Points[i]);
                    chart_stockChart.Annotations.Add(ranno);
                }
            }
        }


    }
}
