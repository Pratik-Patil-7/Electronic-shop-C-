using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Wholesale_electronic_shop
{
    public partial class Product_Report : Form
    {
        public Product_Report()
        {
            InitializeComponent();
            conn.Open();
            string profile = "SELECT * FROM Products";
            cmd = new OleDbCommand(profile, conn);
            OleDbDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["product_name"].ToString());

            }

            conn.Close();

        }
        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=alldata.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da;

        private void Product_Report_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            crystalReportViewer1.RefreshReport();
            if (comboBox1.Text == "")
            {

                MessageBox.Show("Select Product");

            }
            else
            {
                conn.Open();
                DataTable dt = new DataTable();
                string input = comboBox1.Text;
                OleDbCommand cmd = new OleDbCommand("SELECT * FROM Products WHERE product_name = '" + input + "'", conn);
                da = new OleDbDataAdapter(cmd);
                da.Fill(dt);

                productreport rpt = new productreport();
                rpt.SetDataSource(dt);

                crystalReportViewer1.ReportSource = rpt;
                crystalReportViewer1.RefreshReport();
                conn.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn.Open();
            DataTable dt = new DataTable();
            string input = comboBox1.Text;
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM Products", conn);
            da = new OleDbDataAdapter(cmd);
            da.Fill(dt);

           productreport rpt = new productreport();
            rpt.SetDataSource(dt);

            crystalReportViewer1.ReportSource = rpt;
            crystalReportViewer1.RefreshReport();
            conn.Close();
        }
    }
}
