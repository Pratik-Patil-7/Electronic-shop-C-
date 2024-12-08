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
    public partial class deleteretailer : Form
    {
        public deleteretailer()
        {
            InitializeComponent();
            conn.Open();
            dataGridView1.ForeColor = Color.Black;
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM add_retailer", conn);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
            conn.Close();
        }
        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=alldata.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

        private void deleteretailer_Load(object sender, EventArgs e)
        {

        }

        private void product_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (char.IsDigit(ch))
            {
                e.Handled = false;
            }
            else if (ch == 8)
            {
                e.Handled = false;

            }
            else { e.Handled = true; }
        }

        private void product_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            conn.Open();
            string profile = "SELECT * FROM add_retailer WHERE retailer_id = '" + retailer_id.Text + "'";
            cmd = new OleDbCommand(profile, conn);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            cmd.Dispose();
            conn.Close();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            conn.Open();
            string profile = "SELECT * FROM add_retailer WHERE retailer_id= '" + retailer_id.Text + "'";
            cmd = new OleDbCommand(profile, conn);
            OleDbDataReader dr = cmd.ExecuteReader();
            if (dr.Read() == true)
            {
                string emuser = "DELETE FROM add_retailer WHERE retailer_id= '" + retailer_id.Text + "'";
                cmd = new OleDbCommand(emuser, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Successfully Deleted");
                dataGridView1.ClearSelection();
            }
            else
            {
                MessageBox.Show("Not Found", "",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }
        }
    }
}
