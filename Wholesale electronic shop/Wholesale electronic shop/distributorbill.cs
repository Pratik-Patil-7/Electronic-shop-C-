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
    public partial class distributorbill : Form
    {
        public distributorbill()
        {
            InitializeComponent();
            conn.Open();
            string prof = "SELECT * FROM add_distributor";
            cmd = new OleDbCommand(prof, conn);
            OleDbDataReader dro = cmd.ExecuteReader();

            while (dro.Read())
            {
                distributor_name.Items.Add(dro["distributor_name"].ToString());

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

        private void distributorbill_Load(object sender, EventArgs e)
        {

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
           
            if(distributor_name.Text=="")
            {
                MessageBox.Show("Select distributor");
            }
            else if (billno.Text == "")
            {
                MessageBox.Show("Select BillNo");
            }
            else
            {
                conn.Open();
                int check2 = 0;
                string prof = "SELECT * FROM distributor_bills WHERE distributor_name = '"+ distributor_name.Text + "'AND (billno = '" + billno.Text + "'  AND bill_date = '" + dateTimePicker1.Text + "')";
                cmd = new OleDbCommand(prof, conn);
                OleDbDataReader dro = cmd.ExecuteReader();

                while (dro.Read())
                {

                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells["Product_Name"].Value = dro[3].ToString();
                    dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells["Quantity"].Value = dro[4].ToString();
                    dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells["Price"].Value = dro[5].ToString();
                    check2 = 1;

                }
                if (check2 == 1)
                {
                    conn.Close();

                    conn.Open();
                    string pro = "SELECT * FROM distributor_bill_total where Billno= '" + billno.Text + "'";
                    cmd = new OleDbCommand(pro, conn);
                    OleDbDataReader dr = cmd.ExecuteReader();
                    if (dr.Read() == true)
                    {
                        totalamount.Text = dr["amount"].ToString();
                    }
                    conn.Close();
                }
                search.Visible = false;
                billno.Text = "";
                dateTimePicker1.Text = "";
            }
            
        }

        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.dataGridView1.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();

        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {

        }

        private void btn_Refresh_Click_1(object sender, EventArgs e)
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
            dataGridView1.Rows.Clear();
            search.Visible = true;
            totalamount.Text = "";
        }

        private void totalamount_TextChanged(object sender, EventArgs e)
        {

        }

        private void distributor_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            billno.Items.Clear();

            conn.Open();
            string pro = "SELECT DISTINCT billno FROM distributor_bills where distributor_name = '" + distributor_name.Text + "'";
            cmd = new OleDbCommand(pro, conn);
            OleDbDataReader dre = cmd.ExecuteReader();
            while (dre.Read())
            {
                billno.Items.Add(dre["billno"].ToString());

            }
            conn.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            conn.Close();
            conn.Open();
            string fl = "SELECT * FROM distributor_bills where bill_date = '" + dateTimePicker1.Text + "' AND distributor_name = '" + distributor_name.Text + "'";
            cmd = new OleDbCommand(fl, conn);
            OleDbDataReader q = cmd.ExecuteReader();
            if (q.Read())
            {
                billno.Text = q["billno"].ToString();

            }
            conn.Close(); ;
        }

        private void billno_SelectedIndexChanged(object sender, EventArgs e)
        {

            conn.Close();
            conn.Open();
            string fl = "SELECT * FROM distributor_bills where billno = '" + billno.Text + "' AND distributor_name = '" + distributor_name.Text + "'";
            cmd = new OleDbCommand(fl, conn);
            OleDbDataReader q = cmd.ExecuteReader();
            if (q.Read())
            {
                dateTimePicker1.Text = q["bill_date"].ToString();

            }
            conn.Close(); ;
        }
    }
}
