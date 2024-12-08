using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wholesale_electronic_shop
{
    public partial class retailerbill : Form
    {
        public retailerbill()
        {
            InitializeComponent();
            conn.Open();
            string prof = "SELECT * FROM add_retailer";
            cmd = new OleDbCommand(prof, conn);
            OleDbDataReader dro = cmd.ExecuteReader();

            while (dro.Read())
            {
                retailer_name.Items.Add(dro["retailer_name"].ToString());

            }
            conn.Close();

            dataGridView1.ColumnCount = 4;
            dataGridView1.Columns[0].Name = "ref_No";
            dataGridView1.Columns[1].Name = "Product_Name";
            dataGridView1.Columns[2].Name = "Quantity";
            dataGridView1.Columns[3].Name = "Price";
            dataGridView1.Columns[1].Width = 250;
            dataGridView1.ForeColor = Color.Black;
        }

        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=alldata.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

        private void retailerbill_Load(object sender, EventArgs e)
        {

        }

        private void search_Click(object sender, EventArgs e)
        {
            if (billno.Text == "")
            {
                MessageBox.Show("Select Billno");
            }
            else
            {
                int check1 = 0;
                conn.Close();
                conn.Open();
                string prof = "SELECT * FROM retailer_bills WHERE retailer_name= '" + retailer_name.Text + "' AND ( billno = '" + billno.Text + "' AND bill_date= '" + dateTimePicker1.Text + "')";
                cmd = new OleDbCommand(prof, conn);
                OleDbDataReader dro = cmd.ExecuteReader();

                while (dro.Read())
                {

                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells["Product_Name"].Value = dro[3].ToString();
                    dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells["Quantity"].Value = dro[4].ToString();
                    dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells["Price"].Value = dro[5].ToString();
                    check1 = 1;
                }
                if (check1 == 1)
                {
                    conn.Close();
                    conn.Open();
                    string pro = "SELECT * FROM retailer_bill_total WHERE Billno= '" + billno.Text + "'";
                    cmd = new OleDbCommand(pro, conn);
                    OleDbDataReader dr = cmd.ExecuteReader();
                    if (dr.Read() == true)
                    {
                        amount.Text = dr["amount"].ToString();
                    }
                    conn.Close();
                }
                search.Visible = false;
                billno.Text = "";

            } 


        }

        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.dataGridView1.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();

        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {

                dataGridView1.Rows.RemoveAt(i);

            }
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {

                dataGridView1.Rows.RemoveAt(i);

            }
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {

                dataGridView1.Rows.RemoveAt(i);

            }
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {

                dataGridView1.Rows.RemoveAt(i);
               // dataGridView1.Rows.RemoveAt(i);

            }
            search.Visible = true;

            amount.Text = "";
        }

        private void retailer_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            billno.Items.Clear();
            conn.Close();
            conn.Open();
            string pro = "SELECT DISTINCT billno FROM retailer_bills where retailer_name = '" + retailer_name.Text + "'";
            cmd = new OleDbCommand(pro, conn);
            OleDbDataReader dre = cmd.ExecuteReader();
            while (dre.Read())
            {
                billno.Items.Add(dre["billno"].ToString());

            }
            conn.Close();
        }

        private void billno_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn.Close();
            conn.Open();
            string fl = "SELECT * FROM retailer_bills where billno = '" + billno.Text + "' AND retailer_name = '"+retailer_name.Text+"'";
            cmd = new OleDbCommand(fl, conn);
            OleDbDataReader q = cmd.ExecuteReader();
            if (q.Read())
            {
               dateTimePicker1.Text = q["bill_date"].ToString();

            }
            conn.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            conn.Close();
            conn.Open();
            string fl = "SELECT * FROM retailer_bills where bill_date = '" + dateTimePicker1.Text + "' AND retailer_name = '" + retailer_name.Text + "'";
            cmd = new OleDbCommand(fl, conn);
            OleDbDataReader q = cmd.ExecuteReader();
            if (q.Read())
            {
                billno.Text = q["billno"].ToString();

            }
            conn.Close();
        }
    }
    }

