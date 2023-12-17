namespace Project_3
{
    partial class Form_stock_charts
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart_stockChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label_endDate = new System.Windows.Forms.Label();
            this.label_startDate = new System.Windows.Forms.Label();
            this.dateTimePicker_endDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_startDate = new System.Windows.Forms.DateTimePicker();
            this.button_stockUpdater = new System.Windows.Forms.Button();
            this.comboBox_pattern = new System.Windows.Forms.ComboBox();
            this.label_pattern = new System.Windows.Forms.Label();
            this.button_pattern = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart_stockChart)).BeginInit();
            this.SuspendLayout();
            // 
            // chart_stockChart
            // 
            chartArea1.AxisX.Title = "Date";
            chartArea1.AxisY.Title = "Price";
            chartArea1.Name = "area_OpHiLoCl";
            chartArea2.AlignWithChartArea = "area_OpHiLoCl";
            chartArea2.AxisX.Title = "Date";
            chartArea2.AxisY.Title = "Volume";
            chartArea2.Name = "area_volume";
            this.chart_stockChart.ChartAreas.Add(chartArea1);
            this.chart_stockChart.ChartAreas.Add(chartArea2);
            legend1.Name = "Legend1";
            this.chart_stockChart.Legends.Add(legend1);
            this.chart_stockChart.Location = new System.Drawing.Point(14, 159);
            this.chart_stockChart.Name = "chart_stockChart";
            series1.ChartArea = "area_OpHiLoCl";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Candlestick;
            series1.CustomProperties = "PriceDownColor=Red, PriceUpColor=Green";
            series1.IsXValueIndexed = true;
            series1.Legend = "Legend1";
            series1.Name = "series_OpHiLoCl";
            series1.XValueMember = "date";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Date;
            series1.YValueMembers = "high, low, open, close";
            series1.YValuesPerPoint = 4;
            series2.ChartArea = "area_volume";
            series2.IsXValueIndexed = true;
            series2.Legend = "Legend1";
            series2.Name = "series_volume";
            series2.XValueMember = "Date";
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Date;
            series2.YValueMembers = "Volume";
            this.chart_stockChart.Series.Add(series1);
            this.chart_stockChart.Series.Add(series2);
            this.chart_stockChart.Size = new System.Drawing.Size(1178, 419);
            this.chart_stockChart.TabIndex = 8;
            this.chart_stockChart.Text = "chart_stockChart";
            // 
            // label_endDate
            // 
            this.label_endDate.AutoSize = true;
            this.label_endDate.Location = new System.Drawing.Point(150, 79);
            this.label_endDate.Name = "label_endDate";
            this.label_endDate.Size = new System.Drawing.Size(66, 16);
            this.label_endDate.TabIndex = 13;
            this.label_endDate.Text = "End Date:";
            // 
            // label_startDate
            // 
            this.label_startDate.AutoSize = true;
            this.label_startDate.Location = new System.Drawing.Point(147, 16);
            this.label_startDate.Name = "label_startDate";
            this.label_startDate.Size = new System.Drawing.Size(69, 16);
            this.label_startDate.TabIndex = 12;
            this.label_startDate.Text = "Start Date:";
            // 
            // dateTimePicker_endDate
            // 
            this.dateTimePicker_endDate.Location = new System.Drawing.Point(65, 107);
            this.dateTimePicker_endDate.Name = "dateTimePicker_endDate";
            this.dateTimePicker_endDate.Size = new System.Drawing.Size(279, 22);
            this.dateTimePicker_endDate.TabIndex = 11;
            // 
            // dateTimePicker_startDate
            // 
            this.dateTimePicker_startDate.Location = new System.Drawing.Point(65, 45);
            this.dateTimePicker_startDate.Name = "dateTimePicker_startDate";
            this.dateTimePicker_startDate.Size = new System.Drawing.Size(279, 22);
            this.dateTimePicker_startDate.TabIndex = 10;
            this.dateTimePicker_startDate.Value = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
            // 
            // button_stockUpdater
            // 
            this.button_stockUpdater.Location = new System.Drawing.Point(364, 64);
            this.button_stockUpdater.Name = "button_stockUpdater";
            this.button_stockUpdater.Size = new System.Drawing.Size(84, 46);
            this.button_stockUpdater.TabIndex = 9;
            this.button_stockUpdater.Text = "Update Stock";
            this.button_stockUpdater.UseVisualStyleBackColor = true;
            this.button_stockUpdater.Click += new System.EventHandler(this.button_stockUpdater_Click);
            // 
            // comboBox_pattern
            // 
            this.comboBox_pattern.FormattingEnabled = true;
            this.comboBox_pattern.Location = new System.Drawing.Point(824, 71);
            this.comboBox_pattern.Name = "comboBox_pattern";
            this.comboBox_pattern.Size = new System.Drawing.Size(173, 24);
            this.comboBox_pattern.TabIndex = 14;
            // 
            // label_pattern
            // 
            this.label_pattern.AutoSize = true;
            this.label_pattern.Location = new System.Drawing.Point(878, 50);
            this.label_pattern.Name = "label_pattern";
            this.label_pattern.Size = new System.Drawing.Size(49, 16);
            this.label_pattern.TabIndex = 15;
            this.label_pattern.Text = "Pattern";
            // 
            // button_pattern
            // 
            this.button_pattern.Location = new System.Drawing.Point(1020, 71);
            this.button_pattern.Name = "button_pattern";
            this.button_pattern.Size = new System.Drawing.Size(75, 23);
            this.button_pattern.TabIndex = 16;
            this.button_pattern.Text = "View";
            this.button_pattern.UseVisualStyleBackColor = true;
            this.button_pattern.Click += new System.EventHandler(this.button_pattern_Click);
            // 
            // Form_stock_charts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1204, 626);
            this.Controls.Add(this.button_pattern);
            this.Controls.Add(this.label_pattern);
            this.Controls.Add(this.comboBox_pattern);
            this.Controls.Add(this.label_endDate);
            this.Controls.Add(this.label_startDate);
            this.Controls.Add(this.dateTimePicker_endDate);
            this.Controls.Add(this.dateTimePicker_startDate);
            this.Controls.Add(this.button_stockUpdater);
            this.Controls.Add(this.chart_stockChart);
            this.Name = "Form_stock_charts";
            this.Text = "Chart";
            ((System.ComponentModel.ISupportInitialize)(this.chart_stockChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart_stockChart;
        private System.Windows.Forms.Label label_endDate;
        private System.Windows.Forms.Label label_startDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker_endDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker_startDate;
        private System.Windows.Forms.Button button_stockUpdater;
        private System.Windows.Forms.ComboBox comboBox_pattern;
        private System.Windows.Forms.Label label_pattern;
        private System.Windows.Forms.Button button_pattern;
    }
}