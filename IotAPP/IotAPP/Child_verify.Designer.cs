namespace IotAPP
{
    partial class Child_verify
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnverify = new System.Windows.Forms.Button();
            this.cmbsel = new System.Windows.Forms.ComboBox();
            this.lbltop = new System.Windows.Forms.Label();
            this.tbvv = new System.Windows.Forms.TextBox();
            this.btncls = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(196)))), ((int)(((byte)(89)))));
            this.panel1.Location = new System.Drawing.Point(16, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(268, 1);
            this.panel1.TabIndex = 0;
            // 
            // btnverify
            // 
            this.btnverify.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(196)))), ((int)(((byte)(89)))));
            this.btnverify.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnverify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnverify.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnverify.ForeColor = System.Drawing.Color.White;
            this.btnverify.Location = new System.Drawing.Point(209, 121);
            this.btnverify.Name = "btnverify";
            this.btnverify.Size = new System.Drawing.Size(75, 35);
            this.btnverify.TabIndex = 1;
            this.btnverify.Text = "Verify";
            this.btnverify.UseVisualStyleBackColor = false;
            this.btnverify.Click += new System.EventHandler(this.button1_Click);
            this.btnverify.Validating += new System.ComponentModel.CancelEventHandler(this.validate_comb);
            // 
            // cmbsel
            // 
            this.cmbsel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbsel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbsel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbsel.FormattingEnabled = true;
            this.cmbsel.Location = new System.Drawing.Point(16, 56);
            this.cmbsel.Name = "cmbsel";
            this.cmbsel.Size = new System.Drawing.Size(268, 26);
            this.cmbsel.TabIndex = 2;
            // 
            // lbltop
            // 
            this.lbltop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltop.ForeColor = System.Drawing.Color.White;
            this.lbltop.Location = new System.Drawing.Point(12, 13);
            this.lbltop.Name = "lbltop";
            this.lbltop.Size = new System.Drawing.Size(129, 23);
            this.lbltop.TabIndex = 3;
            this.lbltop.Text = "Verify Data:";
            this.lbltop.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbvv
            // 
            this.tbvv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbvv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbvv.Location = new System.Drawing.Point(16, 89);
            this.tbvv.Name = "tbvv";
            this.tbvv.Size = new System.Drawing.Size(268, 26);
            this.tbvv.TabIndex = 4;
            // 
            // btncls
            // 
            this.btncls.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(196)))), ((int)(((byte)(89)))));
            this.btncls.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncls.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncls.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncls.ForeColor = System.Drawing.Color.White;
            this.btncls.Location = new System.Drawing.Point(16, 121);
            this.btncls.Name = "btncls";
            this.btncls.Size = new System.Drawing.Size(75, 35);
            this.btncls.TabIndex = 5;
            this.btncls.Text = "Close";
            this.btncls.UseVisualStyleBackColor = false;
            this.btncls.Click += new System.EventHandler(this.btncls_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.BackColor = System.Drawing.Color.White;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.Red;
            this.lblStatus.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblStatus.Location = new System.Drawing.Point(126, 9);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(158, 27);
            this.lblStatus.TabIndex = 7;
            this.lblStatus.Text = "-------";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Child_verify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(130)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(300, 168);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btncls);
            this.Controls.Add(this.tbvv);
            this.Controls.Add(this.lbltop);
            this.Controls.Add(this.cmbsel);
            this.Controls.Add(this.btnverify);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Child_verify";
            this.Text = "Child_verify";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnverify;
        private System.Windows.Forms.ComboBox cmbsel;
        private System.Windows.Forms.Label lbltop;
        private System.Windows.Forms.TextBox tbvv;
        private System.Windows.Forms.Button btncls;
        private System.Windows.Forms.Label lblStatus;
    }
}