using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace IotAPP
{
    public partial class Child_charts : Form
    {
        List<double> y = new List<double>();
        List<string> x = new List<string>();

        // -= Class Constructor
        public Child_charts()
        {
            InitializeComponent();
            var conn = new SqlConnection();
            conn.ConnectionString = Main.myPC;
            conn.Open();
            string cmd = "";
            //cmd = "select * dbo.iot_Sensor where 1<2;";
            cmd = "SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'iot_Sensor' ORDER BY ORDINAL_POSITION";
            SqlCommand command = new SqlCommand(cmd, conn);
            try
            {
                List<String> lst = new List<String>();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lst.Add(reader.GetString(0).ToString());                        
                    }
                }
                lst.Remove("id");
                lst.Remove("dateTime");
                cbSel.Items.AddRange(lst.ToArray());
            }
            catch (Exception ex)
            {
                AutoClosingMessageBox.Show("Message : ", ex.Message, 1000);
            }
            finally
            {
                conn.Close();
            }   
            //cbVals.Items.AddRange();
        }

        // -= Sub Function generate chart
        private void chart() {
            x.Clear();
            y.Clear();
            chart1.Titles.Clear();
            getData();
            for (int i = 1; i < y.Count(); i++)
            { 
                chart1.Series["Data"].Points.AddXY(x[i], y[i]);
            }
            System.Drawing.Font f = new System.Drawing.Font("Tahoma", 10, FontStyle.Bold);
            chart1.ChartAreas[0].AxisX.Title = "Date";
            chart1.ChartAreas[0].AxisX.TitleFont = f;
            chart1.ChartAreas[0].AxisY.Title = cbSel.Text.ToUpper();
            chart1.ChartAreas[0].AxisY.TitleFont = f;      
        }

        private void btnData_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(cbSel.Text) | String.IsNullOrEmpty(dateTimeFromC.Value.ToString()) | String.IsNullOrEmpty(dateTimeToC.Value.ToString()))
            {
                AutoClosingMessageBox.Show("Please select the value", "Message", 1000);
            }
            else {
                
                chart1.Series["Data"].Points.Clear();
                chart();
            }
            
        }
        private void getData() 
        {
            string cmd1 = "";
            string cmd2 = "";
            cmd1 = "select " + cbSel.Text + " from dbo.iot_Sensor where dateTime between '" + (dateTimeFromC.Value).ToString() + "' and '" + (dateTimeToC.Value).ToString() + "'"; //y
            cmd2 = "select dateTime from dbo.iot_Sensor where dateTime between '" + (dateTimeFromC.Value).ToString() + "' and '" + (dateTimeToC.Value).ToString() + "'";    //x
            runCMD(cmd1, "y");
            runCMD(cmd2, "x");
        }

        private void runCMD(string cmd, string type)
        {
            var conn = new SqlConnection();
            conn.ConnectionString = Main.myPC;
            conn.Open();
            SqlCommand command = new SqlCommand(cmd, conn);
            try
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        if (type == "y")
                        {
                            y.Add(reader.GetDouble(0));
                        }
                        else if (type == "x")
                        {
                            x.Add(reader.GetDateTime(0).ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Error Generated. Details: " + ex.ToString());
                AutoClosingMessageBox.Show("Message : ", ex.Message, 1000);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
