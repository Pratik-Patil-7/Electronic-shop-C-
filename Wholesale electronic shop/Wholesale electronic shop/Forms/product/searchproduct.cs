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
    public partial class searchproduct : Form
    {
        public searchproduct()
        {
            InitializeComponent();
            conn.Open();
            dgv_Product_Details.ForeColor = Color.Black;
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM Products", conn);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgv_Product_Details.DataSource = dt;
            conn.Close();

        }

        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=alldata.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

        private void pnl_Search_Employee_Paint(object sender, PaintEventArgs e)
        {

        }

        private void searchproduct_Load(object sender, EventArgs e)
        {

        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            conn.Open();
            string profile = "SELECT * FROM Products WHERE product_id= '" + product_id.Text + "'";
            cmd = new OleDbCommand(profile, conn);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);
            dgv_Product_Details.DataSource = dt;
            cmd.Dispose();
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            dgv_Product_Details.Refresh();
            dgv_Product_Details.Update();
        }
    }
}
