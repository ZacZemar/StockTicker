using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Project_3
{
    // This is to create the partial class for the form entry 
    public partial class Form_stock_entry : Form
    {
        // Simple reference string which will then be the csv file header
        static string referenceString = "\"Ticker\",\"Period\",\"Date\",\"Open\",\"High\",\"Low\",\"Close\",\"Volume\"";

        // Component Initilization 
        public Form_stock_entry()
        {
            InitializeComponent();
        }

        private List<smartCandlestick> loadStockFile(string name)
        {
            // Listing the stores list of candlestick data 
            List<smartCandlestick> temp = new List<smartCandlestick>(1024);
            // Using streamreader as we'ved learned in class to open stock data files
            using (StreamReader sr = new StreamReader(name))
            {
                string line;

                string header = sr.ReadLine();
                // This will filer the candlestick if the csv matches the reference
                if (header == referenceString)
                {
                    // This while loop will go until the file ends 
                    while ((line = sr.ReadLine()) != null)
                    {
                        // Creating a smart candlesick and then adding it 
                        smartCandlestick cs = new smartCandlestick(line);
                        temp.Add(cs);
                    }
                    // We want the latest to be first so reverse it 
                    temp.Reverse();
                }

                return temp;
            }
        }
        // Open and show user what they want in the event of the button being clicked
        private void button_stockLoader_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog_stock.ShowDialog();
        }

        private void openFileDialog_stock_FileOk(object sender, CancelEventArgs e)
        {
            // Iterate through each selected file name from the open file dialog.
            foreach (string fn in openFileDialog_stock.FileNames)
            {
                // Create a new instance of the Form_stock_charts form.
                Form_stock_charts stockChartForm = new Form_stock_charts();
                stockChartForm.list = loadStockFile(fn);
                // Set the name property of the form to the current file name.
                stockChartForm.name = fn;
                stockChartForm.start_date = dateTimePicker_startDate.Value;
                stockChartForm.end_date = dateTimePicker_endDate.Value;
                // Call the filterCandlesticks method to filter the loaded data according to the specified dates.
                stockChartForm.filterCandlesticks();
                stockChartForm.fill(stockChartForm.lr);
                stockChartForm.Show();
            }
        }

        // These four below were all created from previous projects namely project 1,
        // I decided to keep them to then play with for my own time after this final 
        // project because originally I thought they would contain some value for this 
        // project 3
        private void dataGridView_stock_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label_formName_Click(object sender, EventArgs e)
        {

        }

        private void label_startDate_Click(object sender, EventArgs e)
        {

        }

        private void Form_stock_entry_Load(object sender, EventArgs e)
        {

        }
    }
}
