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
    public partial class Child_verify : Form
    {
        // -= Constructor
        public Child_verify()
        {
            InitializeComponent();
            this.CenterToScreen();
            string[] clm = { "cod", "bod", "toc", "sac", "ntu", "btx", "doc", "tss", "nitrate", "nitrite", "amonia", "chroma", "phosphorus", "Organic_pol", "uv245" };
            cmbsel.Items.AddRange(clm);
        }

        // -= Verify Button
        private void button1_Click(object sender, EventArgs e)
        {
			Int32 rng;
            if (String.IsNullOrEmpty(cmbsel.Text) | String.IsNullOrEmpty(tbvv.Text) | (!int.TryParse(tbvv.Text, out rng)))
            {
                //this.Close();
                cmbsel.Focus();
                tbvv.Focus();
                lblStatus.Text = "Please Enter the Values";
            }
            else
            {
                //this.Hide();
                List<int> lst = new List<int>();
                string query = "SELECT COUNT(" + cmbsel.Text + ") FROM iot_Sensor where " + cmbsel.Text + " > " + rng;
                try
                {
                    using (SqlConnection con = new SqlConnection(Main.myPC))
                    {
                        SqlCommand cmd = new SqlCommand(query, con);
                        con.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            lst.Add(reader.GetInt32(0));
                        }
                        reader.Close();
                        if (lst[0] > 0)
                        {
                            lblStatus.Text = "Value Exist!";
                        }
                        else
                        {
                            lblStatus.Text = "Value doesn't Exist!";
                        }
                    }
                }
                catch (Exception ex)
                {
                    //MessageBox.Show("Error :"+ex);
                    AutoClosingMessageBox.Show(ex.Message,"Message",1000);
                }       
            }
        }

        // -= Close Window Button
        private void btncls_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // -= Velidate the input values
        private void validate_comb(object sender, CancelEventArgs e)
        {
            if (cmbsel.Text == null && tbvv.Text == null)
            {
                e.Cancel = true;
                cmbsel.Focus();
                tbvv.Focus();
                AutoClosingMessageBox.Show("Please Enter the Values.", "Message", 1000);
            }
            else
            {
                e.Cancel = false;
            }  
        }
    }
}
