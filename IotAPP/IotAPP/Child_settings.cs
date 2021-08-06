using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;
using System.Collections;


using System.Data.SqlClient;

namespace IotAPP
{
    public partial class Child_settings : Form
    {
        private static SerialPort serialPort1;
        public Child_settings()
        {
            InitializeComponent();
            serialPort1 = new SerialPort();
        }

        private void Child_settings_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            selectCom.Items.AddRange(ports);
            selectCom.SelectedIndex = 0;
            btnSerialCls.Enabled = false;
        }

        private void btnSerialOpn_Click(object sender, EventArgs e)
        {
            btnSerialOpn.Enabled = false;
            btnSerialCls.Enabled = true;
            serialPort1.PortName = selectCom.Text;
            //MessageBox.Show(serialPort1.PortName);
            try {
                serialPort1.PortName = selectCom.Text;
                //MessageBox.Show(serialPort1.PortName+" Successfully Opened");
                AutoClosingMessageBox.Show(serialPort1.PortName, " Successfully Opened", 1000);
                serialPort1.Open();
            }
            catch(Exception ex){
                //MessageBox.Show(ex.Message," Message : ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                AutoClosingMessageBox.Show("Message : ", ex.Message, 1000);
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort1.IsOpen) {
                    byte[] bytestosend = { 0x01, 0x03, 0x00, 0x15, 0x00, 0x01, 0x95, 0xCE };
                    serialPort1.Write(bytestosend, 0, bytestosend.Length);
                    rtboxSend.Clear();
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message, " Message : ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                AutoClosingMessageBox.Show("Message : ", ex.Message, 1000);
            }
        }

        private void btnSerialCls_Click(object sender, EventArgs e)
        {
            btnSerialOpn.Enabled = true;
            btnSerialCls.Enabled = false;
            try
            {
                serialPort1.Close();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message, " Message : ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                AutoClosingMessageBox.Show("Message : ", ex.Message, 1000);
            }
        }

        private void btnReceive_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort1.IsOpen)
                {
                    int bytes = serialPort1.BytesToRead;
                    byte[] buffer = new byte[bytes];
                    ArrayList data = new ArrayList();
                    List<string> myarray = new List<string>();
                    while (serialPort1.BytesToRead > 0) {
                        string s = serialPort1.ReadByte().ToString("X");
                        myarray.Add(s);
                    }
                    rtboxReceive.Text = string.Join(",", myarray);

                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message, " Message : ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                AutoClosingMessageBox.Show("Message : ", ex.Message, 1000);
            }
        }

        private void Child_settings_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (serialPort1.IsOpen) {
            //    serialPort1.Close();
            //}
        }

        private void selectCom_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblPort_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Connection Working");
            var conn = new SqlConnection();
            conn.ConnectionString = "Data Source=DESKTOP-NFOPBV7\\SQLEXPRESS;Initial Catalog=BodDB;Trusted_Connection=yes";
            string cmd = "Select * FROM dbo.iot_Sensor";
            SqlCommand command = new SqlCommand(cmd, conn);
            try
            {
                conn.Open();
                command.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Connection Working");
            }
            catch (Exception ex)
            {
                //MessageBox.Show("ERROR : " + ex);
                AutoClosingMessageBox.Show(" Message     : ", ex.Message, 1000);
            }

        }
    }
}
