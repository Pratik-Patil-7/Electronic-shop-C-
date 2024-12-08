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
    public partial class Retailer_Bill_Report : Form
    {
        public Retailer_Bill_Report()
        {
            InitializeComponent();
            conn.Open();
            string profile = "SELECT DISTINCT retailer_name FROM retailer_bills";
            cmd = new OleDbCommand(profile, conn);
            OleDbDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["retailer_name"].ToString());

            }


   
        }
        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=alldata.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da;
        private void date_Click(object sender, EventArgs e)
        {
            
           cbillno.Items.Clear();
           // cdate.Items.Clear();
            crystalReportViewer1.RefreshReport();
            if (comboBox1.Text == "")
            {

                MessageBox.Show("Select Retailer");

            }
            else if (cbillno.Text == "")
            {
                MessageBox.Show("Select Billno");
            }
            else
            {
                crystalReportViewer1.RefreshReport();
                conn.Open();
                DataTable dt = new DataTable();
                string input = comboBox1.Text;
                crystalReportViewer1.RefreshReport();
                OleDbCommand cmd = new OleDbCommand("SELECT * FROM retailer_bills WHERE retailer_name = '" + comboBox1.Text + "'AND ( billno = '" + cbillno.Text + "' AND bill_date = '" + cdate.Text + "')", conn);
                da = new OleDbDataAdapter(cmd);
                da.Fill(dt);
                crystalReportViewer1.RefreshReport();
                RetailerBillReport rpt = new RetailerBillReport();
                rpt.SetDataSource(dt);
                crystalReportViewer1.ReportSource = rpt;
                crystalReportViewer1.RefreshReport();
                conn.Close();


                conn.Close();
                conn.Open();
                string pro = "SELECT DISTINCT billno FROM retailer_bills where retailer_name = '" + comboBox1.Text + "'";
                cmd = new OleDbCommand(pro, conn);
                OleDbDataReader dre = cmd.ExecuteReader();
                while (dre.Read())
                {
                    cbillno.Items.Add(dre["billno"].ToString());

                }
                conn.Close();
                conn.Open();
                string p = "SELECT DISTINCT bill_date FROM retailer_bills where retailer_name = '" + comboBox1.Text + "'";
                cmd = new OleDbCommand(p, conn);
                OleDbDataReader d = cmd.ExecuteReader();
                if(d.Read())
                {
                    cdate.Text = d["bill_date"].ToString();

                }

                conn.Close();

                cbillno.Text = "";

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            crystalReportViewer1.RefreshReport();
            conn.Close();
            conn.Open();
           // cdate.Items.Clear();
            cbillno.Items.Clear();
            string pro = "SELECT DISTINCT billno FROM retailer_bills where retailer_name = '"+comboBox1.Text+"'";
            cmd = new OleDbCommand(pro, conn);
            OleDbDataReader dre = cmd.ExecuteReader();
            while (dre.Read())
            {
                cbillno.Items.Add(dre["billno"].ToString());

            }
            conn.Close();
            conn.Open();
            string p = "SELECT DISTINCT bill_date FROM retailer_bills where retailer_name = '" + comboBox1.Text + "'";
            cmd = new OleDbCommand(p, conn);
            OleDbDataReader d = cmd.ExecuteReader();
            if(d.Read())
            {
                cdate.Text = d["bill_date"].ToString();

            }
            conn.Close();
        
        }

        private void cbillno_SelectedIndexChanged(object sender, EventArgs e)
        {
            crystalReportViewer1.RefreshReport();
            conn.Close();
            conn.Open();
            string fl = "SELECT * FROM retailer_bills where billno = '" + cbillno.Text + "'";
            cmd = new OleDbCommand(fl, conn);
            OleDbDataReader q = cmd.ExecuteReader();
            if (q.Read())
            {
                cdate.Text = q["bill_date"].ToString();

            }
            conn.Close();
        }

        private void cdate_SelectedIndexChanged(object sender, EventArgs e)
        {
            crystalReportViewer1.RefreshReport();
            conn.Close();
            conn.Open();
            string fl = "SELECT * FROM retailer_bills where bill_date  = '" + cdate.Text + "' AND retailer_name = '"+comboBox1.Text+"'";
            cmd = new OleDbCommand(fl, conn);
            OleDbDataReader q = cmd.ExecuteReader();
            if (q.Read())
            {
                cbillno.Text = q["billno"].ToString();

            }
            conn.Close();
        }

        private void Retailer_Bill_Report_Load(object sender, EventArgs e)
        {

        }

        private void cdate_ValueChanged(object sender, EventArgs e)
        {
            conn.Close();
            conn.Open();
            string fl = "SELECT * FROM retailer_bills where bill_date = '" + cdate.Text + "' AND retailer_name = '" + comboBox1.Text + "'";
            cmd = new OleDbCommand(fl, conn);
            OleDbDataReader q = cmd.ExecuteReader();
            if (q.Read())
            {
                cbillno.Text = q["billno"].ToString();

            }
            conn.Close();
        }
    }
}
