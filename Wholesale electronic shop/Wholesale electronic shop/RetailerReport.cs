using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wholesale_electronic_shop
{
    public partial class RetailerReport : Form
    {
        public RetailerReport()
        {
            InitializeComponent();
            conn.Open();
            string profile = "SELECT * FROM add_retailer";
            cmd = new OleDbCommand(profile, conn);
            OleDbDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["retailer_name"].ToString());

            }

            conn.Close();
       


        }
        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=alldata.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da;
     

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void RetailerReport_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            crystalReportViewer1.RefreshReport();
            if (comboBox1.Text == "")
            {

                MessageBox.Show("Select Retailer");

            }
            else
            {
                conn.Open();
                DataTable dt = new DataTable();
                string input = comboBox1.Text;
                OleDbCommand cmd = new OleDbCommand("SELECT * FROM add_retailer WHERE retailer_name = '" + input + "'", conn);
                da = new OleDbDataAdapter(cmd);
                da.Fill(dt);

                Retailer_Report rpt = new Retailer_Report();
                rpt.SetDataSource(dt);

                crystalReportViewer1.ReportSource = rpt;
                crystalReportViewer1.RefreshReport();
                conn.Close();
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn.Open();
            DataTable dt = new DataTable();
            string input = comboBox1.Text;
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM add_retailer", conn);
            da = new OleDbDataAdapter(cmd);
            da.Fill(dt);

            Retailer_Report rpt = new Retailer_Report();
            rpt.SetDataSource(dt);

            crystalReportViewer1.ReportSource = rpt;
            crystalReportViewer1.RefreshReport();
            conn.Close();

        }
    }
}
