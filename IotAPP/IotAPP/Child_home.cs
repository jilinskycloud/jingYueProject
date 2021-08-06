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
    public partial class Child_home : Form
    {
        private double cod;
        private double bod;
        private double toc;
        private double sac;
        private double ntu;
        private double btx;
        private double doc;
        private double tss;
        private double nitrate;
        private double nitrite;
        private double amon;
        private double chroma;
        private double phas;
        private double orgm;
        private double uv;

        // -= Class Constructor
        public Child_home()
        {
            InitializeComponent();
            //Time Based Funnction Call
            var aTimer = new System.Timers.Timer(1000);
            aTimer.Elapsed += print_Data;
            aTimer.Enabled = true;
        }

        // -= Print Data in Boxes
        private void print_Data(object sender, EventArgs e) 
        {
            var conn = new SqlConnection();
            conn.ConnectionString = Main.myPC;
            //MessageBox.Show("Connected");
            string cmd = "";
            cmd = "select * from dbo.iot_Sensor where id = (select max(id) from dbo.iot_Sensor);";
            SqlCommand command = new SqlCommand(cmd, conn);
            try
            {
                conn.Open();
                //int dataa = command.ExecuteNonQuery();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.Write("abc");
                        cod = reader.GetFieldValue<double>(1);
                        bod = reader.GetFieldValue<double>(2);
                        toc = reader.GetFieldValue<double>(3);
                        sac = reader.GetFieldValue<double>(4);
                        ntu = reader.GetFieldValue<double>(5);
                        btx = reader.GetFieldValue<double>(6);
                        doc = reader.GetFieldValue<double>(7);
                        tss = reader.GetFieldValue<double>(8);
                        nitrate = reader.GetFieldValue<double>(9);
                        nitrite = reader.GetFieldValue<double>(10);
                        amon = reader.GetFieldValue<double>(11);
                        chroma = reader.GetFieldValue<double>(12);
                        phas = reader.GetFieldValue<double>(13);
                        orgm = reader.GetFieldValue<double>(14);
                        uv = reader.GetFieldValue<double>(15);
                    }
                    reader.Close();
                }
                lblCod.Invoke((MethodInvoker)(() => lblCod.Text = formate(cod.ToString()) + " (mg/L)"));
                lblBod.Invoke((MethodInvoker)(() => lblBod.Text = formate(bod.ToString()) + " (mg/L)"));
                lblToc.Invoke((MethodInvoker)(() => lblToc.Text = formate(toc.ToString()) + " (mg/L)"));
                lblSac.Invoke((MethodInvoker)(() => lblSac.Text = formate(sac.ToString()) + " (Abs/m)"));
                lblNtu.Invoke((MethodInvoker)(() => lblNtu.Text = formate(ntu.ToString()) + " (mg/L)"));
                lblBtx.Invoke((MethodInvoker)(() => lblBtx.Text = formate(btx.ToString()) + " (ug/L)"));
                lblDoc.Invoke((MethodInvoker)(() => lblDoc.Text = formate(doc.ToString()) + " (mg/L)"));
                lblTss.Invoke((MethodInvoker)(() => lblTss.Text = formate(tss.ToString()) + " (mg/L)"));
                lblnitrate.Invoke((MethodInvoker)(() => lblnitrate.Text = formate(nitrate.ToString()) + " (mg/L)"));
                lblnitrite.Invoke((MethodInvoker)(() => lblnitrite.Text = formate(nitrite.ToString()) + " (mg/L)"));
                lblamon.Invoke((MethodInvoker)(() => lblamon.Text = formate(amon.ToString()) + " (mg/L)"));
                lblchroma.Invoke((MethodInvoker)(() => lblchroma.Text = formate(chroma.ToString()) + " (mg/L)"));
                lblphas.Invoke((MethodInvoker)(() => lblphas.Text = formate(phas.ToString()) + " (mg/L)"));
                lblorgm.Invoke((MethodInvoker)(() => lblorgm.Text = formate(orgm.ToString())));
                lbluv.Invoke((MethodInvoker)(() => lbluv.Text = formate(uv.ToString()) + " (mg/L)"));
                conn.Close();
            }
            catch (Exception ex)
            {
                AutoClosingMessageBox.Show("Message : ", ex.Message, 1000);
            }
        }

        // -= Sub Function of print data function
        private string formate(string vl)
        {
            string x = vl;
            if (x.Length > 5)
            {
                x= x.Substring(0, 5);
            }
            return x;
        }
    }
}
