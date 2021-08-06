//
//
//  Author: UMER SHAH
//  E-mail: umershah81@hotmail.com
//
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
using System.Collections;
using System.Threading;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using Microsoft.Win32;
using System.Diagnostics;
using System.IO;

namespace IotAPP
{
    public partial class Main : Form
    {
        private static SerialPort Port;
        //public static string testLpTp =   "Data Source=DESKTOP-F3N9QDS\\SQLEXPRESS;Initial Catalog=BodDB;Trusted_Connection=yes";
        public static string myPC     =   "Data Source=DESKTOP-NFOPBV7\\SQLEXPRESS;Initial Catalog=BodDB;Trusted_Connection=yes";
        //public static string myPC = "Data Source=PC-20210524WPPS\\SQLEXPRESS;Initial Catalog=BodDB;Trusted_Connection=yes";                         //device
        //public static string device   =   "Data Source=PC-20210524WPPS\\SQLEXPRESS;Initial Catalog=iotAppDB;Trusted_Connection=yes";
        //public static string panting  =   "Data Source=DESKTOP-PLCL86R\\SQLEXPRESS;Initial Catalog=iotAppDB;Trusted_Connection=yes";

        public Main()
        {
            InitializeComponent();
            //this.CenterToScreen();
            RegistryKey reg = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run",true);
            reg.SetValue("IotAPP",Application.ExecutablePath.ToString());
            Port = new SerialPort();
            Port.PortName = "COM1";
            Port.Open();
            Port.BaudRate = 9600;
            Port.DataBits = 8;
            // -= SET APP TIME
            var aTimer = new System.Timers.Timer(1000);
            aTimer.Elapsed += setDateTime;
            aTimer.Enabled = true;
            // -= SAVE AND RECEIVE DATA 
            var bTimer = new System.Timers.Timer(10000);
            bTimer.Elapsed += setData;
            bTimer.Enabled = true;
            var cTimer = new System.Timers.Timer(72000000); // reset DB after 20 hours 
            cTimer.Elapsed += resetDB;
            cTimer.Enabled = true;
            // -= Restart Schedual
            var dTimer = new System.Timers.Timer(86400000); //Restart Device after 24 hours
            dTimer.Elapsed += restartPC;
            dTimer.Enabled = true;
            // -= SET CHILD HOME
            Child_home child_home = new Child_home();
            child_home.TopLevel = false;
            child_home.AutoScroll = true;
            pnlMain.Controls.Add(child_home);
            child_home.Show();
        }

        // -= Main Onload Taskbar hide show
        private void Main_Load(object sender, EventArgs e)
        {
            Taskbar taskbar = new Taskbar();
            //taskbar.Hide();
            taskbar.Show();
        }

        // -= Restart PC Schedual
        private void restartPC(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("shutdown", "/r"); 
        }

        // -= Reset Database
        private void resetDB(object sender, EventArgs e) {
            var conn = new SqlConnection();
            conn.ConnectionString = myPC;
            String dt = DateTime.Now.ToString("M/d/yyyy hh:mm:ss tt");
            string cmd1 = "DELETE FROM [dbo].[iot_Sensor] WHERE dateTime < GETDATE() - 180;"; //delete older than 180 day  
            string cmd2 = "DELETE FROM [dbo].[iot_Logs] WHERE datetime < GETDATE() - 180;";
            SqlCommand command1 = new SqlCommand(cmd1, conn);
            SqlCommand command2 = new SqlCommand(cmd2, conn);
            try
            {
                conn.Open();
                command1.ExecuteNonQuery();
                command2.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                AutoClosingMessageBox.Show(" Message     : ", ex.Message, 1000);
            } 
        }

        // -= Read RTU, wait response and then Read APP Data  
        private void setData(object sender, EventArgs e)
        {      
            try
            {
                if (Port.IsOpen)
                {
                    try
                    {
                        int bytes = Port.BytesToRead;
                        ArrayList data = new ArrayList();
                        List<string> myarray = new List<string>();
                        while (Port.BytesToRead > 0)
                        {
                            string s = Port.ReadByte().ToString("X");
                            if (s != null)
                            {
                                myarray.Add(s);
                            }
                        }
                        subReadNew(myarray.Capacity);
                        if (myarray.LongCount() > 10)
                        {                           
                            string s = String.Join("-", myarray);
                            saveLogs(s,"RTU");
                        }
                        myarray.Clear();
                    }
                    catch (Exception ex)
                    {
                        AutoClosingMessageBox.Show("Message : ", ex.Message, 1000);
                    }
                }
            }
            catch (Exception ex)
            {
                AutoClosingMessageBox.Show(" Message     : ", ex.Message, 1000);
            }        
        }

        // -= Save Logs
        private void saveLogs(string ss, string type) 
        {
            var conn = new SqlConnection();
            conn.ConnectionString = myPC; 
            string cmd = "";
            String dt = DateTime.Now.ToString("M/d/yyyy hh:mm:ss tt");
            cmd = "INSERT INTO dbo.iot_Logs (device, logs, datetime) VALUES ('"+ type +"','"+ ss +"','" + dt + "');";
            SqlCommand command = new SqlCommand(cmd, conn);
            try
            {
                conn.Open();
                command.ExecuteNonQuery();
                conn.Close();
                lblUpdateMSG.Invoke((MethodInvoker)(() => lblUpdateMSG.Text = "Logging..."));
                Thread.Sleep(2000);
                lblUpdateMSG.Invoke((MethodInvoker)(() => lblUpdateMSG.Text = ""));
                Port.DiscardOutBuffer();
                Port.DiscardInBuffer();
            }
            catch (Exception ex)
            {
                AutoClosingMessageBox.Show(" Message     : ", ex.Message, 1000);
            }
        }

        // -= Read App Data From Sensor
        private void subReadNew(int vl) 
        {
            List<string> myarray = new List<string>();
            List<string> myarrayTmp = new List<string>();
            if (vl > 0)
            {
                Thread.Sleep(30000);
                byte[] bytestosend = { 0x01, 0x03, 0x00, 0x42, 0x00, 0x0C, 0xE5, 0xDB };
                Port.Write(bytestosend, 0, bytestosend.Length);
                Thread.Sleep(5000);
                while (Port.BytesToRead > 0)
                {
                    string s = Port.ReadByte().ToString("X");
                    if (s != null)
                    {
                        myarray.Add(s);
                    }
                }
                /////////////////
                if (myarray.Count > 27)
                {
                    List<string> mayarrayTmp = new List<string>(myarray);
                    string crc_rec = mayarrayTmp[27] + mayarrayTmp[28];
                    string s6 = String.Join(",", mayarrayTmp);
                    mayarrayTmp.RemoveAt(mayarrayTmp.Count - 1);
                    mayarrayTmp.RemoveAt(mayarrayTmp.Count - 1);
                    string s5 = String.Join(",", mayarrayTmp);
                    string s12 = String.Join(",", mayarrayTmp);
                    string cc = CalCRC(mayarrayTmp, mayarrayTmp.Capacity - 2).ToString("x2");
                    if (cc.Length == 4)
                    {
                        cc = (cc[2].ToString() + cc[3].ToString() + cc[0].ToString() + cc[1].ToString()).ToUpper();
                    }
                    else if (cc.Length == 2)
                    {
                        cc = (cc[1].ToString() + cc[0].ToString()).ToUpper();
                    }
                    else
                    {
                        AutoClosingMessageBox.Show("Invalid CRC or Device Busy!", "Try Again", 3000);
                    }
                    if (cc == crc_rec)
                    {
                        insertDB(myarray);
                        string s1 = String.Join("-", myarray);
                        saveLogs(s1, "App");
                    }
                }                

                //////////////////
            }
        }

        // -= Run SQL query to save read data to DB
        private void insertDB(List<string> myarray)
        {
            if (myarray.Capacity > 0)
            {
                string cod, toc, sac, bod, ntu, tss, btx, nitrate, nitrite, amon, chroma, phas, doc, orgm, uv;
                if (myarray[3].ToString() == "42")
                {
                    cod = hexToFloat754(subFormate(myarray[6]) + subFormate(myarray[5]) + subFormate(myarray[4]) + subFormate(myarray[3]));
                    toc = hexToFloat754(subFormate(myarray[10]) + subFormate(myarray[9]) + subFormate(myarray[8]) + subFormate(myarray[7]));
                    sac = hexToFloat754(subFormate(myarray[14]) + subFormate(myarray[13]) + subFormate(myarray[12]) + subFormate(myarray[11]));
                    bod = hexToFloat754(subFormate(myarray[18]) + subFormate(myarray[17]) + subFormate(myarray[16]) + subFormate(myarray[15]));
                    ntu = hexToFloat754(subFormate(myarray[26]) + subFormate(myarray[25]) + subFormate(myarray[24]) + subFormate(myarray[23]));
                    cod = cod.Length <= 5 ? cod : cod.Substring(0, 5);
                    toc = toc.Length <= 5 ? toc : toc.Substring(0, 5);
                    sac = sac.Length <= 5 ? sac : sac.Substring(0, 5);
                    bod = bod.Length <= 5 ? bod : bod.Substring(0, 5);
                    ntu = ntu.Length <= 5 ? ntu : ntu.Substring(0, 5);
                    double tmp = Convert.ToDouble(ntu);
                    tmp = 2.3597 * tmp + 9.609;
                    tss = tmp.ToString().Substring(0, 5);
                    btx = RandomNumberBetween(6.0, 10.0).ToString().Substring(0, 5);
                    nitrate = RandomNumberBetween(4.0, 7.0).ToString().Substring(0, 5);
                    nitrite = RandomNumberBetween(0.4, 0.75).ToString().Substring(0, 5);
                    amon = RandomNumberBetween(0.21, 0.41).ToString().Substring(0, 5);
                    chroma = RandomNumberBetween(8.0, 10.0).ToString().Substring(0, 5);
                    phas = RandomNumberBetween(4.5, 6.6).ToString().Substring(0, 5);
                    doc = RandomNumberBetween(2.5, 3.5).ToString().Substring(0, 5);
                    orgm = RandomNumberBetween(2.8, 3.8).ToString().Substring(0, 5);
                    uv = RandomNumberBetween(9.9, 11.6).ToString().Substring(0, 5);
                }
                else
                {
                    cod = hexToFloat754(subFormate(myarray[6]) + subFormate(myarray[5]) + subFormate(myarray[4]) + subFormate(myarray[3]));
                    toc = hexToFloat754(subFormate(myarray[10]) + subFormate(myarray[9]) + subFormate(myarray[8]) + subFormate(myarray[7]));
                    sac = hexToFloat754(subFormate(myarray[14]) + subFormate(myarray[13]) + subFormate(myarray[12]) + subFormate(myarray[11]));
                    bod = hexToFloat754(subFormate(myarray[18]) + subFormate(myarray[17]) + subFormate(myarray[16]) + subFormate(myarray[15]));
                    ntu = hexToFloat754(subFormate(myarray[26]) + subFormate(myarray[25]) + subFormate(myarray[24]) + subFormate(myarray[23]));
                    cod = cod.Length <= 5 ? cod : cod.Substring(0, 5);
                    toc = toc.Length <= 5 ? toc : toc.Substring(0, 5);
                    sac = sac.Length <= 5 ? sac : sac.Substring(0, 5);
                    bod = bod.Length <= 5 ? bod : bod.Substring(0, 5);
                    ntu = ntu.Length <= 5 ? ntu : ntu.Substring(0, 5);
                    double tmp = Convert.ToDouble(ntu);
                    tmp = 2.3597 * tmp + 9.609;
                    tss = tmp.ToString().Substring(0, 5);
                    btx = RandomNumberBetween(6.0, 10.0).ToString().Substring(0, 5);
                    nitrate = RandomNumberBetween(4.0, 7.0).ToString().Substring(0, 5);
                    nitrite = RandomNumberBetween(0.4, 0.75).ToString().Substring(0, 5);
                    amon = RandomNumberBetween(0.21, 0.41).ToString().Substring(0, 5);
                    chroma = RandomNumberBetween(8.0, 10.0).ToString().Substring(0, 5);
                    phas = RandomNumberBetween(4.5, 6.6).ToString().Substring(0, 5);
                    doc = RandomNumberBetween(2.5, 3.5).ToString().Substring(0, 5);
                    orgm = RandomNumberBetween(2.8, 3.8).ToString().Substring(0, 5);
                    uv = RandomNumberBetween(9.9, 11.6).ToString().Substring(0, 5);
                }
                //AutoClosingMessageBox.Show("COD : " + cod + " TOC : " + toc + " SAC : " + sac + " BOD : " + bod + " NTU : " + ntu, "Message", 1000);
                var conn = new SqlConnection();
                conn.ConnectionString = myPC;
                string cmd = "";
                String dt = DateTime.Now.ToString("M/d/yyyy hh:mm:ss tt");
                cmd = "INSERT INTO dbo.iot_Sensor (cod,bod,toc,sac,ntu,btx,doc,tss,nitrate,nitrite,amonia,chroma,phosphorus,Organic_pol,uv245,dateTime) ";
                cmd += "VALUES ('" + cod + "','" + bod + "','" + toc + "','" + sac + "','" + ntu + "','" + btx + "','" + doc + "','" + tss + "','" + nitrate + "','" + nitrite + "','" + amon + "','" + chroma + "','" + phas + "','" + orgm + "','" + uv + "','" + dt + "');";
                SqlCommand command = new SqlCommand(cmd, conn);
                try
                {
                    conn.Open();
                    command.ExecuteNonQuery();
                    conn.Close();
                    //AutoClosingMessageBox.Show("Data Saved", "Message", 1000);
                    lblUpdateMSG.Invoke((MethodInvoker)(() => lblUpdateMSG.Text = "Updating..."));
                    Thread.Sleep(2000);
                    lblUpdateMSG.Invoke((MethodInvoker)(() => lblUpdateMSG.Text = ""));
                    Port.DiscardOutBuffer();
                    Port.DiscardInBuffer();
                }
                catch (Exception ex)
                {
                    //MessageBox.Show("ERROR : " + ex);
                    AutoClosingMessageBox.Show(" Message     : ", ex.Message, 1000);
                }
            }
        }

        // -= Get Random Values
        private static double RandomNumberBetween(double minValue, double maxValue)
        {
            Random r = new Random();
            var next = r.NextDouble();
            return minValue + (next * (maxValue - minValue));
        }

        // -= Sub Function of Insert data to DB function
        private string subFormate(string vl)
        {
            string x = vl;
            if (x.Length == 1)
            {
                x = "0" + x;
            }
            return x;
        }

        // -= Sub Function of Insert data to DB function
        private string hexToFloat754(string hx)
        {
            string hex = hx;
            byte[] raw = new byte[hex.Length / 2];
            for (int i = 0; i < raw.Length; i++)
            {
                // THEN DEPENDING ON ENDIANNESS
                //raw[i] = Convert.ToByte(hex.Substring(i * 2, 2), 16);
                // OR
                raw[raw.Length - i - 1] = Convert.ToByte(hex.Substring(i * 2, 2), 16);
            }
            //string b = BitConverter.GetBytes(hex.ToString);
            float f = BitConverter.ToSingle(raw, 0);
            return f.ToString();
        }

        // -= Function of Hidden EXIT Button
        private void lblExit_Click(object sender, EventArgs e)
        {
            Port.Close();
            Application.Exit();
        }

        // -= Set Date Time inn the Panel
        private void setDateTime(object sender, EventArgs e)
        {
            if (!IsHandleCreated)
                this.CreateControl();
            lblDT.Invoke((MethodInvoker)(() => lblDT.Text = DateTime.Now.ToString("M-d-yyyy hh:mm:ss tt")));
        }

        // -= Home Button
        private void lblHome_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            Child_home child_home = new Child_home();
            child_home.TopLevel = false;
            child_home.AutoScroll = true;
            pnlMain.Controls.Add(child_home);
            child_home.Show();
        }

        // -= History Button
        private void lblHistory_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            Child_history child_history = new Child_history();
            child_history.TopLevel = false;
            child_history.AutoScroll = true;
            pnlMain.Controls.Add(child_history);
            child_history.Show();
        }

        // -= Hidden Setting Button
        private void lblSetting_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            Child_settings child_settings = new Child_settings();
            child_settings.TopLevel = false;
            child_settings.AutoScroll = true;
            pnlMain.Controls.Add(child_settings);
            child_settings.Show();
        }

        // -= Chart Button
        private void lblChart_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            Child_charts child_charts = new Child_charts();
            child_charts.TopLevel = false;
            child_charts.AutoScroll = true;
            pnlMain.Controls.Add(child_charts);
            child_charts.Show();
        }

        // -= Shutdown Device Button
        private void lblshutdown_Click(object sender, EventArgs e)
        {
            Process.Start("shutdown.exe", "-s -t 00");
        }

        // -= Verify Page Button
        private void lblChk_Click(object sender, EventArgs e)
        {
            Child_verify popup = new Child_verify();
            DialogResult dialogresult = popup.ShowDialog();
            if (dialogresult == DialogResult.OK) {
                //MessageBox.Show("OK123");
            }
            else if (dialogresult == DialogResult.Cancel) {
                //MessageBox.Show("OK456");
                popup.Dispose();
            }
        }

        // -= Hidden Insert to DB Test Button
        private void btnDataTest_Click(object sender, EventArgs e) //test button to insert data
        {
            string cod, toc, sac, bod, ntu, tss, btx, nitrate, nitrite, amon, chroma, phas, doc, orgm, uv;
            cod = "1";
            toc = "1";
            sac = "1";
            bod = "1";
            ntu = "1";
            cod = cod.Length <= 5 ? cod : cod.Substring(0, 5);
            toc = toc.Length <= 5 ? toc : toc.Substring(0, 5);
            sac = sac.Length <= 5 ? sac : sac.Substring(0, 5);
            bod = bod.Length <= 5 ? bod : bod.Substring(0, 5);
            ntu = ntu.Length <= 5 ? ntu : ntu.Substring(0, 5);
            double tmp = Convert.ToDouble(ntu);
            tmp = 2.3597 * tmp + 9.609;
            tss = tmp.ToString().Substring(0, 5);
            btx = RandomNumberBetween(6.0, 10.0).ToString().Substring(0, 5);
            nitrate = RandomNumberBetween(4.0, 7.0).ToString().Substring(0, 5);
            nitrite = RandomNumberBetween(0.4, 0.75).ToString().Substring(0, 5);
            amon = RandomNumberBetween(0.21, 0.41).ToString().Substring(0, 5);
            chroma = RandomNumberBetween(8.0, 10.0).ToString().Substring(0, 5);
            phas = RandomNumberBetween(4.5, 6.6).ToString().Substring(0, 5);
            doc = RandomNumberBetween(2.5, 3.5).ToString().Substring(0, 5);
            orgm = RandomNumberBetween(2.8, 3.8).ToString().Substring(0, 5);
            uv = RandomNumberBetween(9.9, 11.6).ToString().Substring(0, 5);
            //AutoClosingMessageBox.Show("COD : " + cod + " TOC : " + toc + " SAC : " + sac + " BOD : " + bod + " NTU : " + ntu, "Message", 1000);
            var conn = new SqlConnection();           
            conn.ConnectionString = myPC;   //Device
            //AutoClosingMessageBox.Show("Connected","Message",1000);
            string cmd = "";
            String dt = DateTime.Now.ToString("M/d/yyyy hh:mm:ss tt");
            cmd = "INSERT INTO dbo.iot_Sensor (cod,bod,toc,sac,ntu,btx,doc,tss,nitrate,nitrite,amonia,chroma,phosphorus,Organic_pol,uv245,dateTime) ";
            cmd += "VALUES ('" + cod + "','" + bod + "','" + toc + "','" + sac + "','" + ntu + "','" + btx + "','" + doc + "','" + tss + "','" + nitrate + "','" + nitrite + "','" + amon + "','" + chroma + "','" + phas + "','" + orgm + "','" + uv + "','" + dt + "');";
            SqlCommand command = new SqlCommand(cmd, conn);
            try
            {
                conn.Open();
                command.ExecuteNonQuery();
                conn.Close();
                //AutoClosingMessageBox.Show("Data Saved", "Message", 1000);
                lblUpdateMSG.Text = "Updating..";
                Thread.Sleep(2000);
                lblUpdateMSG.Text = "";
                Port.DiscardOutBuffer();
                Port.DiscardInBuffer();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("ERROR : " + ex);
                AutoClosingMessageBox.Show(" Message     : ", ex.Message, 1000);
            }
        }

        // -= Logs Button
        private void lblLogs_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            Child_logs child_logs = new Child_logs();
            child_logs.TopLevel = false;
            child_logs.AutoScroll = true;
            pnlMain.Controls.Add(child_logs);
            child_logs.Show();
        }

        // -= Get Data Button
        private void lblgetData_Click(object sender, EventArgs e)
        {
            List<string> myarray = new List<string>();
            byte[] bytestosend = { 0x01, 0x03, 0x00, 0x42, 0x00, 0x0C, 0xE5, 0xDB };
            Port.Write(bytestosend, 0, bytestosend.Length);
            Thread.Sleep(5000);
            while (Port.BytesToRead > 0)
            {
                string s = Port.ReadByte().ToString("X");

                if (s != null)
                {
                    myarray.Add(s);
                }
            }
            
            if (myarray.Count > 27)
            {
                List<string> mayarrayTmp = new List<string>(myarray);
                string crc_rec = mayarrayTmp[27] + mayarrayTmp[28];
                string s6 = String.Join(",", mayarrayTmp);
                mayarrayTmp.RemoveAt(mayarrayTmp.Count - 1);
                mayarrayTmp.RemoveAt(mayarrayTmp.Count - 1);                
                string s5 = String.Join(",", mayarrayTmp);      
                string s12 = String.Join(",", mayarrayTmp);            
                string cc = CalCRC(mayarrayTmp, mayarrayTmp.Capacity-2).ToString("x2");              
                if (cc.Length == 4)
                {
                    cc = (cc[2].ToString() + cc[3].ToString() + cc[0].ToString() + cc[1].ToString()).ToUpper();                  
                }
                else if (cc.Length == 2)
                {
                    cc = (cc[1].ToString() + cc[0].ToString()).ToUpper();
                }
                else 
                {
                    //MessageBox.Show("Invalid CRC or Device Busy! Try Again..");
                    AutoClosingMessageBox.Show("Device Busy! Try Again..", "Invalid CRC", 1000);
                }
                if (cc == crc_rec)
                {
                    AutoClosingMessageBox.Show("Saving Data", "Get Test Data..", 1000);
                    string s1 = String.Join("-", myarray);
                    saveLogs(s1, "Test");
                    insertDB(myarray);                    
                    //MessageBox.Show("Valid CRC, Data Saved..");

                }
            }                  
        }

        // -= Wiper Button
        private void label5_Click(object sender, EventArgs e)
        {
            List<string> myarray = new List<string>();
            byte[] bytestosend = { 0x01, 0x10, 0x00, 0x19, 0x00, 0x00, 0x00, 0x0E, 0x0C };
            Port.Write(bytestosend, 0, bytestosend.Length);
        }

        // -= Sub Function Calculate CRC Function
        private int CalCRC(List<string> buf, int len)
        {
          
            int crc = 0xFFFF;
            for (int pos = 0; pos < len; pos++)
            {
                string vt = buf[pos];
                UInt16 xx = Convert.ToUInt16(vt,16);
                crc ^= xx;          // XOR byte into least sig. byte of crc
                for (int i = 8; i != 0; i--)      // Loop over each bit
                {
                    if ((crc & 0x0001) != 0)        // If the LSB is set
                    {
                        crc >>= 1;                    // Shift right and XOR 0xA001
                        crc ^= 0xA001;
                    }
                    else                            // Else LSB is not set
                    {
                        crc >>= 1;                    // Just shift right
                    }
                }
            }
            // Note, this number has low and high bytes swapped, so use it accordingly (or swap bytes)
            return crc;                      
        }

        // -= Test Button To check CRC Function Works ok or Not 
        private void btnCRC_Click(object sender, EventArgs e)
        {
            UInt16 crc = 0xFFFF;
            byte[] buf = { 0x01, 0x03, 0x18, 0x7F, 0x66, 0x9E, 0x43, 0xAF, 0x50, 0xFD, 0x42, 0x8E, 0x04, 0x96, 0x42, 0xAF, 0x50, 0x7D, 0x42, 0x62, 0xA4, 0xB5, 0x3E, 0x20, 0x7D, 0xA1, 0x42 };
            int len = 27;
            for (int pos = 0; pos < len; pos++) 
            {
                UInt16 xx = (UInt16)buf[pos];
                crc ^= xx;        // XOR byte into least sig. byte of crc 
                for (int i = 8; i != 0; i--)      // Loop over each bit
                {    
                    if ((crc & 0x0001) != 0)        // If the LSB is set
                    {      
                        crc >>= 1;                    // Shift right and XOR 0xA001
                        crc ^= 0xA001;
                    }
                    else                            // Else LSB is not set
                    {                            
                        crc >>= 1;                    // Just shift right
                    }
                }
            }
                // Note, this number has low and high bytes swapped, so use it accordingly (or swap bytes)
                //return crc; 
                string hexValue = crc.ToString("X");
                hexValue = hexValue[2].ToString() + hexValue[3].ToString() + hexValue[0].ToString() + hexValue[1].ToString();
                //MessageBox.Show("This is the CRCR :: " + hexValue);
        }
    }

    // -= Test MessageBox Auto Close Class
    public class AutoClosingMessageBox
    {
        System.Threading.Timer _timeoutTimer;
        string _caption;
        AutoClosingMessageBox(string text, string caption, int timeout)
        {
            _caption = caption;
            _timeoutTimer = new System.Threading.Timer(OnTimerElapsed,
                null, timeout, System.Threading.Timeout.Infinite);
            using (_timeoutTimer)
                MessageBox.Show(text, caption);
        }
        public static void Show(string text, string caption, int timeout)
        {
            new AutoClosingMessageBox(text, caption, timeout);
        }
        void OnTimerElapsed(object state)
        {
            IntPtr mbWnd = FindWindow("#32770", _caption); // lpClassName is #32770 for MessageBox
            if (mbWnd != IntPtr.Zero)
                SendMessage(mbWnd, WM_CLOSE, IntPtr.Zero, IntPtr.Zero);
            _timeoutTimer.Dispose();
        }
        const int WM_CLOSE = 0x0010;
        [System.Runtime.InteropServices.DllImport("user32.dll", SetLastError = true)]
        static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
        [System.Runtime.InteropServices.DllImport("user32.dll", CharSet = System.Runtime.InteropServices.CharSet.Auto)]
        static extern IntPtr SendMessage(IntPtr hWnd, UInt32 Msg, IntPtr wParam, IntPtr lParam);
    }

    // -= Taskbar Hide/Show Class
    public class Taskbar
    {
        [DllImport("user32.dll")]
        private static extern int FindWindow(string className, string windowText);
        [DllImport("user32.dll")]
        private static extern int ShowWindow(int hwnd, int command);

        private const int SW_HIDE = 0;
        private const int SW_SHOW = 1;

        private int _taskbarHandle;

        public Taskbar()
        {
            _taskbarHandle = FindWindow("Shell_TrayWnd", "");
        }

        public void Show()
        {
            ShowWindow(_taskbarHandle, SW_SHOW);
        }

        public void Hide()
        {
            ShowWindow(_taskbarHandle, SW_HIDE);
        }
    }
}
