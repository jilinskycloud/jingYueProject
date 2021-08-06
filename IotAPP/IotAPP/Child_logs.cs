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
    public partial class Child_logs : Form
    {
        // -= Class Constructor
        public Child_logs()
        {
            InitializeComponent();
        }

        // -= onload Form Data Load
        private void Child_logs_Load(object sender, EventArgs e)
        {
            try
            {
                var conn = new SqlConnection();
                conn.ConnectionString = Main.myPC;
                conn.Open();
                string _dateTime = DateTime.Now.ToString("M/d/yyyy hh:mm:ss tt"); 
                DataTable dts = new DataTable();
                SqlDataAdapter adapt = new SqlDataAdapter(); 
                adapt = new SqlDataAdapter("SELECT top 50 id, device, logs, datetime FROM dbo.iot_Logs order by id desc", conn);
                adapt.Fill(dts);
                dgLogs.AutoResizeColumns();
                dgLogs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dgLogs.Refresh();
                dgLogs.DataSource = dts;              
                conn.Close();
            }
            catch (Exception ex)
            {
                AutoClosingMessageBox.Show("Message : ", ex.Message, 1000);
            }
        }

        // -= Load History Button
        private void btnLoadLg_Click(object sender, EventArgs e)
        {
            try
            {
                var conn = new SqlConnection();
                conn.ConnectionString = Main.myPC;
                conn.Open();
                string _dateTime = DateTime.Now.ToString("M/d/yyyy hh:mm:ss tt"); 
                DataTable dts = new DataTable();
                SqlDataAdapter adapt = new SqlDataAdapter();
                adapt = new SqlDataAdapter("SELECT id, device, logs, datetime FROM dbo.iot_Logs where datetime between '" + (dtfromlg.Value).ToString() + "' and '" + (dtfrfomlg.Value).ToString() + "' order by id desc", conn);
                adapt.Fill(dts);
                dgLogs.Refresh();
                dgLogs.DataSource = dts;
                conn.Close();
            }
            catch (Exception ex)
            {
                AutoClosingMessageBox.Show("Message : ", ex.Message, 1000);
            }
        }
    }
}
