using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;


namespace Wholesale_electronic_shop
{
    public partial class Distributor_Bill_Report : Form
    {
        public Distributor_Bill_Report()
        {
            InitializeComponent();
            conn.Open();
            string profile = "SELECT DISTINCT distributor_name FROM distributor_bills";
            cmd = new OleDbCommand(profile, conn);
            OleDbDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["distributor_name"].ToString());

            }

            conn.Close();


        }
        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=alldata.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da;
        private void Distributor_Bill_Report_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cbillno.Items.Clear();
           // cdate.Items.Clear();
            crystalReportViewer1.RefreshReport();
            if (comboBox1.Text == "")
            {

                MessageBox.Show("Select Distributor");

            }
            else if(cbillno.Text=="")
            {
                MessageBox.Show("Select Billno");
            }
            else
            {
                
                crystalReportViewer1.RefreshReport();
                conn.Open();
                DataTable dt = new DataTable();
                string input = comboBox1.Text;
                OleDbCommand cmd = new OleDbCommand("SELECT * FROM distributor_bills WHERE distributor_name = '" + comboBox1.Text + "'AND (billno = '" + cbillno.Text + "'AND bill_date = '" + cdate.Text + "') ", conn);
                da = new OleDbDataAdapter(cmd);
                da.Fill(dt);

                DistributorBillReport rpt = new DistributorBillReport();
                rpt.SetDataSource(dt);

                crystalReportViewer1.ReportSource = rpt;
                crystalReportViewer1.RefreshReport();
                conn.Close();
                conn.Close();
                conn.Open();
                crystalReportViewer1.RefreshReport();
                string pro = "SELECT DISTINCT billno FROM distributor_bills where distributor_name = '" + comboBox1.Text + "'";
                cmd = new OleDbCommand(pro, conn);
                OleDbDataReader dre = cmd.ExecuteReader();
                while (dre.Read())
                {
                    cbillno.Items.Add(dre["billno"].ToString());

                }
                conn.Close();
                conn.Open();
                crystalReportViewer1.RefreshReport();
                string p = "SELECT DISTINCT bill_date FROM distributor_bills where distributor_name = '" + comboBox1.Text + "'";
                cmd = new OleDbCommand(p, conn);
                OleDbDataReader d = cmd.ExecuteReader();
                if (d.Read())
                {
                    cdate.Text = d["bill_date"].ToString();

                }

                conn.Close();

                cbillno.Text = "";


            }
        }

        private void cbillno_SelectedIndexChanged(object sender, EventArgs e)
        {
            crystalReportViewer1.RefreshReport();


            conn.Close();
            conn.Open();
            string fl = "SELECT * FROM distributor_bills where billno = '" + cbillno.Text + "'";
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
            string fl = "SELECT * FROM distributor_bills where bill_date  = '" + cdate.Text + "' AND distributor_name = '" + comboBox1.Text + "'";
            cmd = new OleDbCommand(fl, conn);
            OleDbDataReader q = cmd.ExecuteReader();
            if (q.Read())
            {
                cbillno.Text = q["billno"].ToString();

            }
            conn.Close();
        }

        private void cdate_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void cbillno_KeyPress(object sender, KeyPressEventArgs e)
        {


        }

        private void comboBox1_Leave(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void comboBox1_DropDown(object sender, EventArgs e)
        {

        }

        private void comboBox1_DropDownClosed(object sender, EventArgs e)
        {

        }

        private void comboBox1_TextUpdate(object sender, EventArgs e)
        {

        }

        private void comboBox1_Enter(object sender, EventArgs e)
        {
           /* conn.Open();
            string pro = "SELECT DISTINCT billno FROM distributor_bills where distributor_name = '" + comboBox1.Text + "'";
            cmd = new OleDbCommand(pro, conn);
            OleDbDataReader dre = cmd.ExecuteReader();
            while (dre.Read())
            {
                cbillno.Items.Add(dre["billno"].ToString());

            }
            conn.Close();
            conn.Open();
            string p = "SELECT DISTINCT bill_date FROM distributor_bills where distributor_name = '" + comboBox1.Text + "'";
            cmd = new OleDbCommand(p, conn);
            OleDbDataReader d = cmd.ExecuteReader();
            while (d.Read())
            {
                cdate.Items.Add(d["bill_date"].ToString());

            }*/

           // conn.Close();
        }

        private void comboBox1_DrawItem(object sender, DrawItemEventArgs e)
        {

        }

        private void comboBox1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            crystalReportViewer1.RefreshReport();

            //conn.Close();
            //conn.Open();
            cdate.Text = "";
            cbillno.Text = "";
           // cdate.Items.Clear();
            cbillno.Items.Clear();
            conn.Close();
            conn.Open();
            string pro = "SELECT DISTINCT billno FROM distributor_bills where distributor_name = '" + comboBox1.Text + "'";
            cmd = new OleDbCommand(pro, conn);
            OleDbDataReader dre = cmd.ExecuteReader();
            while (dre.Read())
            {
                cbillno.Items.Add(dre["billno"].ToString());

            }
            conn.Close();
            conn.Open();
            string p = "SELECT DISTINCT bill_date FROM distributor_bills where distributor_name = '" + comboBox1.Text + "'";
            cmd = new OleDbCommand(p, conn);
            OleDbDataReader d = cmd.ExecuteReader();
            if (d.Read())
            {
                cdate.Text = d["bill_date"].ToString();

            }

            conn.Close();
        }

        private void cdate_ValueChanged(object sender, EventArgs e)
        {
            conn.Close();
            conn.Open();
            string fl = "SELECT * FROM distributor_bills where bill_date = '" + cdate.Text + "' AND distributor_name = '" + comboBox1.Text + "'";
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
