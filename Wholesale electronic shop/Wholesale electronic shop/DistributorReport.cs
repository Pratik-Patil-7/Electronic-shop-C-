using System;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Data;

namespace Wholesale_electronic_shop
{
    public partial class DistributorReport : Form
    {
        public DistributorReport()
        {
            InitializeComponent();
            conn.Open();
            string profile = "SELECT * FROM add_distributor";
            cmd = new OleDbCommand(profile, conn);
            OleDbDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["distributor_name"].ToString());

            }

            conn.Close();

        }
        //string date1;
        // string date2;
        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=alldata.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            
        }

        private void DistributorReport_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            {

                MessageBox.Show("Select Retailer");

            }
            else
            {
                conn.Open();
                DataTable dt = new DataTable();
                string input = comboBox1.Text;
                OleDbCommand cmd = new OleDbCommand("SELECT * FROM add_distributor WHERE distributor_name = '" + input + "'", conn);
                da = new OleDbDataAdapter(cmd);
                da.Fill(dt);

                Distributor_Reportrpt rpt = new Distributor_Reportrpt();
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
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM add_distributor", conn);
            da = new OleDbDataAdapter(cmd);
            da.Fill(dt);

            Distributor_Reportrpt rpt = new Distributor_Reportrpt();
            rpt.SetDataSource(dt);

            crystalReportViewer1.ReportSource = rpt;
            crystalReportViewer1.RefreshReport();
            conn.Close();
        }
    }
}
