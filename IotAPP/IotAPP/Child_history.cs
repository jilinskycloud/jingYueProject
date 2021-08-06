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
    public partial class Child_history : Form
    {
        // -= Class Constructor
        public Child_history()
        {
            InitializeComponent();
        }

        // -= Load History Function
        private void Child_history_Load(object sender, EventArgs e)
        {
            try
            {
                var conn = new SqlConnection();
                conn.ConnectionString = Main.myPC;
                conn.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter adapt = new SqlDataAdapter();
                //adapt = new SqlDataAdapter("select * from iot_Sensor", conn);
                adapt = new SqlDataAdapter("select top 50 * from iot_Sensor order by id desc", conn);
                adapt.Fill(dt);
                dgHistory.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                AutoClosingMessageBox.Show("Message : ", ex.Message, 1000);
            }
        }

        // -= Load History Button Search
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var conn = new SqlConnection();
                conn.ConnectionString = Main.myPC;
                conn.Open();
                string _dateTime = DateTime.Now.ToString("M/d/yyyy hh:mm:ss tt");  
                DataTable dts = new DataTable();
                SqlDataAdapter adapt = new SqlDataAdapter();                 
                adapt = new SqlDataAdapter("SELECT id,cod,bod,toc,sac,ntu,btx,doc,tss,nitrate,nitrite,amonia,chroma,phosphorus,Organic_pol,uv245,dateTime FROM dbo.iot_Sensor where dateTime between '" + (dtFromDate.Value).ToString() + "' and '" + (dtToDate.Value).ToString() + "'", conn); 
                adapt.Fill(dts);
                dgHistory.Refresh();
                dgHistory.DataSource = dts;
                conn.Close();
            }
            catch (Exception ex)
            {
                AutoClosingMessageBox.Show("Message : ", ex.Message, 1000);
            }
        }
    }
}
