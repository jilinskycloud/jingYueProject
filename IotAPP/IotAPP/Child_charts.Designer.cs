namespace IotAPP
{
    partial class Child_charts
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.pnlChartsMain = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pnlSelect = new System.Windows.Forms.Panel();
            this.dateTimeToC = new System.Windows.Forms.DateTimePicker();
            this.lblfrom = new System.Windows.Forms.Label();
            this.dateTimeFromC = new System.Windows.Forms.DateTimePicker();
            this.lbldtfrom = new System.Windows.Forms.Label();
            this.lblVal = new System.Windows.Forms.Label();
            this.btnData = new System.Windows.Forms.Button();
            this.cbSel = new System.Windows.Forms.ComboBox();
            this.lblCharts = new System.Windows.Forms.Label();
            this.pnlLine = new System.Windows.Forms.Panel();
            this.pnlChartsMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.pnlSelect.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlChartsMain
            // 
            this.pnlChartsMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(196)))), ((int)(((byte)(89)))));
            this.pnlChartsMain.Controls.Add(this.chart1);
            this.pnlChartsMain.Location = new System.Drawing.Point(14, 119);
            this.pnlChartsMain.Name = "pnlChartsMain";
            this.pnlChartsMain.Size = new System.Drawing.Size(559, 444);
            this.pnlChartsMain.TabIndex = 0;
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.chart1.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.DarkDownwardDiagonal;
            this.chart1.BackImageTransparentColor = System.Drawing.Color.White;
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Data";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(559, 444);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";

            // 
            // pnlSelect
            // 
            this.pnlSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(0)))), ((int)(((byte)(55)))));
            this.pnlSelect.Controls.Add(this.dateTimeToC);
            this.pnlSelect.Controls.Add(this.lblfrom);
            this.pnlSelect.Controls.Add(this.dateTimeFromC);
            this.pnlSelect.Controls.Add(this.lbldtfrom);
            this.pnlSelect.Controls.Add(this.lblVal);
            this.pnlSelect.Controls.Add(this.btnData);
            this.pnlSelect.Controls.Add(this.cbSel);
            this.pnlSelect.Location = new System.Drawing.Point(14, 64);
            this.pnlSelect.Name = "pnlSelect";
            this.pnlSelect.Size = new System.Drawing.Size(559, 55);
            this.pnlSelect.TabIndex = 0;
            // 
            // dateTimeToC
            // 
            this.dateTimeToC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateTimeToC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeToC.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeToC.Location = new System.Drawing.Point(335, 16);
            this.dateTimeToC.Name = "dateTimeToC";
            this.dateTimeToC.Size = new System.Drawing.Size(106, 21);
            this.dateTimeToC.TabIndex = 9;
            this.dateTimeToC.Value = new System.DateTime(2021, 7, 23, 10, 50, 28, 0);
            // 
            // lblfrom
            // 
            this.lblfrom.AutoSize = true;
            this.lblfrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfrom.ForeColor = System.Drawing.Color.White;
            this.lblfrom.Location = new System.Drawing.Point(305, 18);
            this.lblfrom.Name = "lblfrom";
            this.lblfrom.Size = new System.Drawing.Size(27, 15);
            this.lblfrom.TabIndex = 8;
            this.lblfrom.Text = "To:";
            // 
            // dateTimeFromC
            // 
            this.dateTimeFromC.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeFromC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateTimeFromC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeFromC.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeFromC.Location = new System.Drawing.Point(190, 16);
            this.dateTimeFromC.Name = "dateTimeFromC";
            this.dateTimeFromC.Size = new System.Drawing.Size(106, 21);
            this.dateTimeFromC.TabIndex = 7;
            this.dateTimeFromC.Value = new System.DateTime(2021, 7, 23, 2, 14, 0, 0);
            // 
            // lbldtfrom
            // 
            this.lbldtfrom.AutoSize = true;
            this.lbldtfrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldtfrom.ForeColor = System.Drawing.Color.White;
            this.lbldtfrom.Location = new System.Drawing.Point(142, 18);
            this.lbldtfrom.Name = "lbldtfrom";
            this.lbldtfrom.Size = new System.Drawing.Size(44, 15);
            this.lbldtfrom.TabIndex = 6;
            this.lbldtfrom.Text = "From:";
            // 
            // lblVal
            // 
            this.lblVal.AutoSize = true;
            this.lblVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVal.ForeColor = System.Drawing.Color.White;
            this.lblVal.Location = new System.Drawing.Point(15, 18);
            this.lblVal.Name = "lblVal";
            this.lblVal.Size = new System.Drawing.Size(47, 15);
            this.lblVal.TabIndex = 4;
            this.lblVal.Text = "Value:";
            // 
            // btnData
            // 
            this.btnData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(196)))), ((int)(((byte)(89)))));
            this.btnData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnData.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnData.ForeColor = System.Drawing.Color.White;
            this.btnData.Location = new System.Drawing.Point(455, 14);
            this.btnData.Name = "btnData";
            this.btnData.Size = new System.Drawing.Size(85, 23);
            this.btnData.TabIndex = 1;
            this.btnData.Text = "Load Chart";
            this.btnData.UseVisualStyleBackColor = false;
            this.btnData.Click += new System.EventHandler(this.btnData_Click);
            // 
            // cbSel
            // 
            this.cbSel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbSel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbSel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSel.FormattingEnabled = true;
            this.cbSel.Location = new System.Drawing.Point(65, 16);
            this.cbSel.Name = "cbSel";
            this.cbSel.Size = new System.Drawing.Size(69, 21);
            this.cbSel.TabIndex = 0;

            // 
            // lblCharts
            // 
            this.lblCharts.AutoSize = true;
            this.lblCharts.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCharts.ForeColor = System.Drawing.Color.White;
            this.lblCharts.Location = new System.Drawing.Point(12, 21);
            this.lblCharts.Name = "lblCharts";
            this.lblCharts.Size = new System.Drawing.Size(174, 24);
            this.lblCharts.TabIndex = 1;
            this.lblCharts.Text = "Data Visualization";
            // 
            // pnlLine
            // 
            this.pnlLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(196)))), ((int)(((byte)(89)))));
            this.pnlLine.Location = new System.Drawing.Point(16, 46);
            this.pnlLine.Name = "pnlLine";
            this.pnlLine.Size = new System.Drawing.Size(559, 1);
            this.pnlLine.TabIndex = 2;
            // 
            // Child_charts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(94)))), ((int)(((byte)(22)))));
            this.ClientSize = new System.Drawing.Size(587, 580);
            this.Controls.Add(this.pnlLine);
            this.Controls.Add(this.pnlSelect);
            this.Controls.Add(this.lblCharts);
            this.Controls.Add(this.pnlChartsMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Child_charts";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Child_charts";
            this.pnlChartsMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.pnlSelect.ResumeLayout(false);
            this.pnlSelect.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlChartsMain;
        private System.Windows.Forms.Label lblCharts;
        private System.Windows.Forms.Panel pnlLine;
        private System.Windows.Forms.Panel pnlSelect;
        private System.Windows.Forms.ComboBox cbSel;
        private System.Windows.Forms.Button btnData;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DateTimePicker dateTimeToC;
        private System.Windows.Forms.Label lblfrom;
        private System.Windows.Forms.DateTimePicker dateTimeFromC;
        private System.Windows.Forms.Label lbldtfrom;
        private System.Windows.Forms.Label lblVal;
    }
}