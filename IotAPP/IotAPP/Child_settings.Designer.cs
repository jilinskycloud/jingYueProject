namespace IotAPP
{
    partial class Child_settings
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
            this.selectCom = new System.Windows.Forms.ComboBox();
            this.lblPort = new System.Windows.Forms.Label();
            this.btnSerialOpn = new System.Windows.Forms.Button();
            this.btnSerialCls = new System.Windows.Forms.Button();
            this.rtboxSend = new System.Windows.Forms.RichTextBox();
            this.rtboxReceive = new System.Windows.Forms.RichTextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnReceive = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // selectCom
            // 
            this.selectCom.FormattingEnabled = true;
            this.selectCom.Location = new System.Drawing.Point(138, 144);
            this.selectCom.Name = "selectCom";
            this.selectCom.Size = new System.Drawing.Size(121, 21);
            this.selectCom.TabIndex = 0;
            this.selectCom.SelectedIndexChanged += new System.EventHandler(this.selectCom_SelectedIndexChanged);
            // 
            // lblPort
            // 
            this.lblPort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(196)))), ((int)(((byte)(89)))));
            this.lblPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPort.ForeColor = System.Drawing.Color.Black;
            this.lblPort.Location = new System.Drawing.Point(62, 80);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(46, 23);
            this.lblPort.TabIndex = 1;
            this.lblPort.Text = "Port : ";
            this.lblPort.Click += new System.EventHandler(this.lblPort_Click);
            // 
            // btnSerialOpn
            // 
            this.btnSerialOpn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSerialOpn.Location = new System.Drawing.Point(291, 144);
            this.btnSerialOpn.Name = "btnSerialOpn";
            this.btnSerialOpn.Size = new System.Drawing.Size(75, 23);
            this.btnSerialOpn.TabIndex = 2;
            this.btnSerialOpn.Text = "Open";
            this.btnSerialOpn.UseVisualStyleBackColor = false;
            this.btnSerialOpn.Click += new System.EventHandler(this.btnSerialOpn_Click);
            // 
            // btnSerialCls
            // 
            this.btnSerialCls.Location = new System.Drawing.Point(388, 144);
            this.btnSerialCls.Name = "btnSerialCls";
            this.btnSerialCls.Size = new System.Drawing.Size(75, 23);
            this.btnSerialCls.TabIndex = 3;
            this.btnSerialCls.Text = "Close";
            this.btnSerialCls.UseVisualStyleBackColor = true;
            this.btnSerialCls.Click += new System.EventHandler(this.btnSerialCls_Click);
            // 
            // rtboxSend
            // 
            this.rtboxSend.Location = new System.Drawing.Point(138, 183);
            this.rtboxSend.Name = "rtboxSend";
            this.rtboxSend.Size = new System.Drawing.Size(325, 96);
            this.rtboxSend.TabIndex = 5;
            this.rtboxSend.Text = "";
            // 
            // rtboxReceive
            // 
            this.rtboxReceive.Location = new System.Drawing.Point(138, 320);
            this.rtboxReceive.Name = "rtboxReceive";
            this.rtboxReceive.Size = new System.Drawing.Size(325, 110);
            this.rtboxReceive.TabIndex = 6;
            this.rtboxReceive.Text = "";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(387, 286);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 7;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnReceive
            // 
            this.btnReceive.Location = new System.Drawing.Point(388, 436);
            this.btnReceive.Name = "btnReceive";
            this.btnReceive.Size = new System.Drawing.Size(75, 23);
            this.btnReceive.TabIndex = 7;
            this.btnReceive.Text = "Receive";
            this.btnReceive.UseVisualStyleBackColor = true;
            this.btnReceive.Click += new System.EventHandler(this.btnReceive_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "COM Port Test";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(196)))), ((int)(((byte)(89)))));
            this.panel1.Location = new System.Drawing.Point(15, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(559, 1);
            this.panel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(196)))), ((int)(((byte)(89)))));
            this.panel2.Location = new System.Drawing.Point(14, 64);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(527, 490);
            this.panel2.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(196)))), ((int)(((byte)(89)))));
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.lblPort);
            this.panel3.Location = new System.Drawing.Point(14, 64);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(559, 504);
            this.panel3.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(209, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Child_settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(94)))), ((int)(((byte)(22)))));
            this.ClientSize = new System.Drawing.Size(587, 580);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReceive);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.rtboxReceive);
            this.Controls.Add(this.rtboxSend);
            this.Controls.Add(this.btnSerialCls);
            this.Controls.Add(this.btnSerialOpn);
            this.Controls.Add(this.selectCom);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Child_settings";
            this.Text = "Child_settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Child_settings_FormClosing);
            this.Load += new System.EventHandler(this.Child_settings_Load);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox selectCom;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.Button btnSerialOpn;
        private System.Windows.Forms.Button btnSerialCls;
        private System.Windows.Forms.RichTextBox rtboxSend;
        private System.Windows.Forms.RichTextBox rtboxReceive;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnReceive;
        internal System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button1;
    }
}