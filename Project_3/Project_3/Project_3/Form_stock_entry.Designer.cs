namespace Project_3
{
    partial class Form_stock_entry
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
            this.label_formName = new System.Windows.Forms.Label();
            this.button_stockLoader = new System.Windows.Forms.Button();
            this.dateTimePicker_startDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_endDate = new System.Windows.Forms.DateTimePicker();
            this.label_startDate = new System.Windows.Forms.Label();
            this.label_endDate = new System.Windows.Forms.Label();
            this.openFileDialog_stock = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // label_formName
            // 
            this.label_formName.AutoSize = true;
            this.label_formName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_formName.Location = new System.Drawing.Point(315, 22);
            this.label_formName.Name = "label_formName";
            this.label_formName.Size = new System.Drawing.Size(371, 32);
            this.label_formName.TabIndex = 0;
            this.label_formName.Text = "Choose a Stock Any Stock";
            this.label_formName.Click += new System.EventHandler(this.label_formName_Click);
            // 
            // button_stockLoader
            // 
            this.button_stockLoader.Location = new System.Drawing.Point(461, 200);
            this.button_stockLoader.Name = "button_stockLoader";
            this.button_stockLoader.Size = new System.Drawing.Size(84, 46);
            this.button_stockLoader.TabIndex = 1;
            this.button_stockLoader.Text = "Load Stock";
            this.button_stockLoader.UseVisualStyleBackColor = true;
            this.button_stockLoader.Click += new System.EventHandler(this.button_stockLoader_Click);
            // 
            // dateTimePicker_startDate
            // 
            this.dateTimePicker_startDate.Location = new System.Drawing.Point(376, 98);
            this.dateTimePicker_startDate.Name = "dateTimePicker_startDate";
            this.dateTimePicker_startDate.Size = new System.Drawing.Size(279, 22);
            this.dateTimePicker_startDate.TabIndex = 2;
            this.dateTimePicker_startDate.Value = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
            // 
            // dateTimePicker_endDate
            // 
            this.dateTimePicker_endDate.Location = new System.Drawing.Point(376, 160);
            this.dateTimePicker_endDate.Name = "dateTimePicker_endDate";
            this.dateTimePicker_endDate.Size = new System.Drawing.Size(279, 22);
            this.dateTimePicker_endDate.TabIndex = 3;
            // 
            // label_startDate
            // 
            this.label_startDate.AutoSize = true;
            this.label_startDate.Location = new System.Drawing.Point(458, 69);
            this.label_startDate.Name = "label_startDate";
            this.label_startDate.Size = new System.Drawing.Size(69, 16);
            this.label_startDate.TabIndex = 4;
            this.label_startDate.Text = "Start Date:";
            this.label_startDate.Click += new System.EventHandler(this.label_startDate_Click);
            // 
            // label_endDate
            // 
            this.label_endDate.AutoSize = true;
            this.label_endDate.Location = new System.Drawing.Point(461, 132);
            this.label_endDate.Name = "label_endDate";
            this.label_endDate.Size = new System.Drawing.Size(66, 16);
            this.label_endDate.TabIndex = 5;
            this.label_endDate.Text = "End Date:";
            // 
            // openFileDialog_stock
            // 
            this.openFileDialog_stock.Filter = "All Stock Files|*.csv|Daily Stocks|*-Day.csv|Weekly Stocks|*-Week.csv|Monthly Sto" +
    "ck|*-Month.csv";
            this.openFileDialog_stock.Multiselect = true;
            this.openFileDialog_stock.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog_stock_FileOk);
            // 
            // Form_stock_entry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 270);
            this.Controls.Add(this.label_endDate);
            this.Controls.Add(this.label_startDate);
            this.Controls.Add(this.dateTimePicker_endDate);
            this.Controls.Add(this.dateTimePicker_startDate);
            this.Controls.Add(this.button_stockLoader);
            this.Controls.Add(this.label_formName);
            this.Name = "Form_stock_entry";
            this.Text = "Stock Loader";
            this.Load += new System.EventHandler(this.Form_stock_entry_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_formName;
        private System.Windows.Forms.Button button_stockLoader;
        private System.Windows.Forms.DateTimePicker dateTimePicker_startDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker_endDate;
        private System.Windows.Forms.Label label_startDate;
        private System.Windows.Forms.Label label_endDate;
        private System.Windows.Forms.OpenFileDialog openFileDialog_stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn openDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn highDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lowDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn closeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn volumeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
    }
}

