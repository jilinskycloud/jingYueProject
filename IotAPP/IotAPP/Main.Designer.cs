namespace IotAPP
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCRC = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lblshutdown = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblgetData = new System.Windows.Forms.Label();
            this.pnlLogs = new System.Windows.Forms.Panel();
            this.lblLogs = new System.Windows.Forms.Label();
            this.btnDataTest = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlVerify = new System.Windows.Forms.Panel();
            this.lblChk = new System.Windows.Forms.Label();
            this.lblDT = new System.Windows.Forms.Label();
            this.lblExit = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblSetting = new System.Windows.Forms.Label();
            this.pnlCharts = new System.Windows.Forms.Panel();
            this.lblChart = new System.Windows.Forms.Label();
            this.pnlHistory = new System.Windows.Forms.Panel();
            this.lblHistory = new System.Windows.Forms.Label();
            this.pnlHome = new System.Windows.Forms.Panel();
            this.lblHome = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblUpdateMSG = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.pnlLogs.SuspendLayout();
            this.pnlVerify.SuspendLayout();
            this.panel6.SuspendLayout();
            this.pnlCharts.SuspendLayout();
            this.pnlHistory.SuspendLayout();
            this.pnlHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(130)))), ((int)(((byte)(32)))));
            this.panel1.Controls.Add(this.btnCRC);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.pnlLogs);
            this.panel1.Controls.Add(this.btnDataTest);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pnlVerify);
            this.panel1.Controls.Add(this.lblDT);
            this.panel1.Controls.Add(this.lblExit);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.pnlCharts);
            this.panel1.Controls.Add(this.pnlHistory);
            this.panel1.Controls.Add(this.pnlHome);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(181, 650);
            this.panel1.TabIndex = 0;
            // 
            // btnCRC
            // 
            this.btnCRC.Location = new System.Drawing.Point(10, 530);
            this.btnCRC.Name = "btnCRC";
            this.btnCRC.Size = new System.Drawing.Size(160, 23);
            this.btnCRC.TabIndex = 14;
            this.btnCRC.Text = "Calculate CRC";
            this.btnCRC.UseVisualStyleBackColor = true;
            this.btnCRC.Visible = false;
            this.btnCRC.Click += new System.EventHandler(this.btnCRC_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(0)))), ((int)(((byte)(55)))));
            this.panel7.Controls.Add(this.lblshutdown);
            this.panel7.Location = new System.Drawing.Point(0, 594);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(182, 37);
            this.panel7.TabIndex = 13;
            // 
            // lblshutdown
            // 
            this.lblshutdown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(0)))), ((int)(((byte)(55)))));
            this.lblshutdown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblshutdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblshutdown.ForeColor = System.Drawing.Color.White;
            this.lblshutdown.Image = ((System.Drawing.Image)(resources.GetObject("lblshutdown.Image")));
            this.lblshutdown.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblshutdown.Location = new System.Drawing.Point(30, 3);
            this.lblshutdown.Name = "lblshutdown";
            this.lblshutdown.Size = new System.Drawing.Size(137, 34);
            this.lblshutdown.TabIndex = 2;
            this.lblshutdown.Text = "Shut down";
            this.lblshutdown.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblshutdown.Click += new System.EventHandler(this.lblshutdown_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel5.Controls.Add(this.label5);
            this.panel5.Location = new System.Drawing.Point(2, 359);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(178, 41);
            this.panel5.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Location = new System.Drawing.Point(26, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 37);
            this.label5.TabIndex = 0;
            this.label5.Text = "Start Wiper";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel4.Controls.Add(this.lblgetData);
            this.panel4.Location = new System.Drawing.Point(1, 316);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(179, 41);
            this.panel4.TabIndex = 11;
            // 
            // lblgetData
            // 
            this.lblgetData.BackColor = System.Drawing.Color.Transparent;
            this.lblgetData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblgetData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgetData.ForeColor = System.Drawing.Color.White;
            this.lblgetData.Image = ((System.Drawing.Image)(resources.GetObject("lblgetData.Image")));
            this.lblgetData.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblgetData.Location = new System.Drawing.Point(26, 3);
            this.lblgetData.Name = "lblgetData";
            this.lblgetData.Size = new System.Drawing.Size(113, 37);
            this.lblgetData.TabIndex = 0;
            this.lblgetData.Text = "Get Data";
            this.lblgetData.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblgetData.Click += new System.EventHandler(this.lblgetData_Click);
            // 
            // pnlLogs
            // 
            this.pnlLogs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnlLogs.Controls.Add(this.lblLogs);
            this.pnlLogs.Location = new System.Drawing.Point(1, 273);
            this.pnlLogs.Name = "pnlLogs";
            this.pnlLogs.Size = new System.Drawing.Size(179, 41);
            this.pnlLogs.TabIndex = 7;
            // 
            // lblLogs
            // 
            this.lblLogs.BackColor = System.Drawing.Color.Transparent;
            this.lblLogs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblLogs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogs.ForeColor = System.Drawing.Color.White;
            this.lblLogs.Image = ((System.Drawing.Image)(resources.GetObject("lblLogs.Image")));
            this.lblLogs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblLogs.Location = new System.Drawing.Point(26, 3);
            this.lblLogs.Name = "lblLogs";
            this.lblLogs.Size = new System.Drawing.Size(126, 37);
            this.lblLogs.TabIndex = 0;
            this.lblLogs.Text = "Logs";
            this.lblLogs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblLogs.Click += new System.EventHandler(this.lblLogs_Click);
            // 
            // btnDataTest
            // 
            this.btnDataTest.Location = new System.Drawing.Point(0, 406);
            this.btnDataTest.Name = "btnDataTest";
            this.btnDataTest.Size = new System.Drawing.Size(181, 23);
            this.btnDataTest.TabIndex = 6;
            this.btnDataTest.Text = "Insert Data";
            this.btnDataTest.UseVisualStyleBackColor = true;
            this.btnDataTest.Visible = false;
            this.btnDataTest.Click += new System.EventHandler(this.btnDataTest_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Cursor = System.Windows.Forms.Cursors.Default;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(2, 508);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Email: ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Visible = false;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(1, 631);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Version: V0.005";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlVerify
            // 
            this.pnlVerify.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnlVerify.Controls.Add(this.lblChk);
            this.pnlVerify.Location = new System.Drawing.Point(1, 187);
            this.pnlVerify.Name = "pnlVerify";
            this.pnlVerify.Size = new System.Drawing.Size(179, 41);
            this.pnlVerify.TabIndex = 3;
            // 
            // lblChk
            // 
            this.lblChk.BackColor = System.Drawing.Color.Transparent;
            this.lblChk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblChk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChk.ForeColor = System.Drawing.Color.White;
            this.lblChk.Image = ((System.Drawing.Image)(resources.GetObject("lblChk.Image")));
            this.lblChk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblChk.Location = new System.Drawing.Point(27, 5);
            this.lblChk.Name = "lblChk";
            this.lblChk.Size = new System.Drawing.Size(126, 33);
            this.lblChk.TabIndex = 0;
            this.lblChk.Text = "Verify";
            this.lblChk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblChk.Click += new System.EventHandler(this.lblChk_Click);
            // 
            // lblDT
            // 
            this.lblDT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDT.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDT.ForeColor = System.Drawing.Color.White;
            this.lblDT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDT.Location = new System.Drawing.Point(0, 567);
            this.lblDT.Margin = new System.Windows.Forms.Padding(0);
            this.lblDT.Name = "lblDT";
            this.lblDT.Size = new System.Drawing.Size(180, 27);
            this.lblDT.TabIndex = 0;
            this.lblDT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDT.Click += new System.EventHandler(this.lblExit_Click);
            // 
            // lblExit
            // 
            this.lblExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(0)))), ((int)(((byte)(55)))));
            this.lblExit.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.lblExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExit.ForeColor = System.Drawing.Color.White;
            this.lblExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblExit.Location = new System.Drawing.Point(0, 470);
            this.lblExit.Margin = new System.Windows.Forms.Padding(0);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(180, 37);
            this.lblExit.TabIndex = 0;
            this.lblExit.Text = "Exit";
            this.lblExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblExit.Visible = false;
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel6.Controls.Add(this.lblSetting);
            this.panel6.Location = new System.Drawing.Point(1, 429);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(179, 41);
            this.panel6.TabIndex = 1;
            this.panel6.Visible = false;
            // 
            // lblSetting
            // 
            this.lblSetting.BackColor = System.Drawing.Color.Transparent;
            this.lblSetting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSetting.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSetting.ForeColor = System.Drawing.Color.White;
            this.lblSetting.Image = ((System.Drawing.Image)(resources.GetObject("lblSetting.Image")));
            this.lblSetting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblSetting.Location = new System.Drawing.Point(35, 3);
            this.lblSetting.Margin = new System.Windows.Forms.Padding(0);
            this.lblSetting.Name = "lblSetting";
            this.lblSetting.Size = new System.Drawing.Size(137, 37);
            this.lblSetting.TabIndex = 0;
            this.lblSetting.Text = "Setting";
            this.lblSetting.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSetting.Click += new System.EventHandler(this.lblSetting_Click);
            // 
            // pnlCharts
            // 
            this.pnlCharts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnlCharts.Controls.Add(this.lblChart);
            this.pnlCharts.Location = new System.Drawing.Point(1, 230);
            this.pnlCharts.Name = "pnlCharts";
            this.pnlCharts.Size = new System.Drawing.Size(179, 41);
            this.pnlCharts.TabIndex = 1;
            // 
            // lblChart
            // 
            this.lblChart.BackColor = System.Drawing.Color.Transparent;
            this.lblChart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblChart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChart.ForeColor = System.Drawing.Color.White;
            this.lblChart.Image = ((System.Drawing.Image)(resources.GetObject("lblChart.Image")));
            this.lblChart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblChart.Location = new System.Drawing.Point(26, 3);
            this.lblChart.Margin = new System.Windows.Forms.Padding(0);
            this.lblChart.Name = "lblChart";
            this.lblChart.Size = new System.Drawing.Size(126, 37);
            this.lblChart.TabIndex = 0;
            this.lblChart.Text = "Chart";
            this.lblChart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblChart.Click += new System.EventHandler(this.lblChart_Click);
            // 
            // pnlHistory
            // 
            this.pnlHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnlHistory.Controls.Add(this.lblHistory);
            this.pnlHistory.Location = new System.Drawing.Point(1, 144);
            this.pnlHistory.Name = "pnlHistory";
            this.pnlHistory.Size = new System.Drawing.Size(179, 41);
            this.pnlHistory.TabIndex = 1;
            // 
            // lblHistory
            // 
            this.lblHistory.BackColor = System.Drawing.Color.Transparent;
            this.lblHistory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHistory.ForeColor = System.Drawing.Color.White;
            this.lblHistory.Image = ((System.Drawing.Image)(resources.GetObject("lblHistory.Image")));
            this.lblHistory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblHistory.Location = new System.Drawing.Point(26, 3);
            this.lblHistory.Margin = new System.Windows.Forms.Padding(0);
            this.lblHistory.Name = "lblHistory";
            this.lblHistory.Size = new System.Drawing.Size(136, 37);
            this.lblHistory.TabIndex = 0;
            this.lblHistory.Text = "History";
            this.lblHistory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblHistory.Click += new System.EventHandler(this.lblHistory_Click);
            // 
            // pnlHome
            // 
            this.pnlHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnlHome.Controls.Add(this.lblHome);
            this.pnlHome.Location = new System.Drawing.Point(1, 101);
            this.pnlHome.Name = "pnlHome";
            this.pnlHome.Size = new System.Drawing.Size(179, 41);
            this.pnlHome.TabIndex = 1;
            // 
            // lblHome
            // 
            this.lblHome.BackColor = System.Drawing.Color.Transparent;
            this.lblHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHome.ForeColor = System.Drawing.Color.White;
            this.lblHome.Image = ((System.Drawing.Image)(resources.GetObject("lblHome.Image")));
            this.lblHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblHome.Location = new System.Drawing.Point(29, 3);
            this.lblHome.Margin = new System.Windows.Forms.Padding(0);
            this.lblHome.Name = "lblHome";
            this.lblHome.Size = new System.Drawing.Size(123, 37);
            this.lblHome.TabIndex = 0;
            this.lblHome.Text = "Home";
            this.lblHome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblHome.Click += new System.EventHandler(this.lblHome_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(181, 99);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(0)))), ((int)(((byte)(55)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.lblUpdateMSG);
            this.panel2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(181, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(620, 48);
            this.panel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(8, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(374, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "name";
            // 
            // lblUpdateMSG
            // 
            this.lblUpdateMSG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(0)))), ((int)(((byte)(55)))));
            this.lblUpdateMSG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateMSG.ForeColor = System.Drawing.Color.White;
            this.lblUpdateMSG.Location = new System.Drawing.Point(459, 13);
            this.lblUpdateMSG.Name = "lblUpdateMSG";
            this.lblUpdateMSG.Size = new System.Drawing.Size(100, 23);
            this.lblUpdateMSG.TabIndex = 0;
            this.lblUpdateMSG.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(0)))), ((int)(((byte)(55)))));
            this.panel3.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(780, 48);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(21, 602);
            this.panel3.TabIndex = 2;
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(130)))), ((int)(((byte)(32)))));
            this.pnlMain.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pnlMain.Location = new System.Drawing.Point(186, 55);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(587, 580);
            this.pnlMain.TabIndex = 3;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(196)))), ((int)(((byte)(89)))));
            this.ClientSize = new System.Drawing.Size(801, 650);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.panel1.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.pnlLogs.ResumeLayout(false);
            this.pnlVerify.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.pnlCharts.ResumeLayout(false);
            this.pnlHistory.ResumeLayout(false);
            this.pnlHome.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlHome;
        private System.Windows.Forms.Label lblHome;
        private System.Windows.Forms.Panel pnlHistory;
        private System.Windows.Forms.Label lblHistory;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblSetting;
        private System.Windows.Forms.Panel pnlCharts;
        private System.Windows.Forms.Label lblChart;
        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.Label lblDT;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label lblUpdateMSG;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblshutdown;
        private System.Windows.Forms.Panel pnlVerify;
        private System.Windows.Forms.Label lblChk;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDataTest;
        private System.Windows.Forms.Panel pnlLogs;
        private System.Windows.Forms.Label lblLogs;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblgetData;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnCRC;
    }
}

