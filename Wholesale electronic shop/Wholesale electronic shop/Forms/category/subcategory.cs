using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Wholesale_electronic_shop
{
    public partial class subcategory : Form
    {
        public subcategory()
        {
            InitializeComponent();
            conn.Open();
            string profile = "SELECT * FROM category";
            cmd = new OleDbCommand(profile, conn);
            OleDbDataReader dr = cmd.ExecuteReader();
            while(dr.Read() == true)
            {
                Category_Name.Items.Add(dr["category_name"].ToString()) ;
            }

            conn.Close();
        }
        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=alldata.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();
        private void subcategory_Load(object sender, EventArgs e)
        {

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(subcategory_Name.Text))
            {
                MessageBox.Show("Please Select Subcategory Name", "",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                conn.Open();
                string profile = "SELECT * FROM subcategory WHERE subcategory_name= '" + subcategory_Name.Text + "'";
                cmd = new OleDbCommand(profile, conn);
                OleDbDataReader dr = cmd.ExecuteReader();
                if (dr.Read() == true)
                {
                    MessageBox.Show("Subcateogry Already Added");
                    subcategory_Name.Clear();
                }
               else {
                    Object selectedItem = Category_Name.SelectedItem;
                    string selected = selectedItem.ToString();
                    string add = "INSERT INTO subcategory(category_name,subcategory_name) VALUES('" + selected + "','" + subcategory_Name.Text + "')";
                    OleDbCommand c = new OleDbCommand(add, conn);
                    c.ExecuteNonQuery();
                    subcategory_Name.Clear();
                    MessageBox.Show("Done!");
                }
                conn.Close();
            }
        }

        private void Subcategory_Id_KeyPress(object sender, KeyPressEventArgs e)
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

        private void subcategory_Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (char.IsLetter(ch))
            {
                e.Handled = false;
            }
            else if (ch == 8)
            {
                e.Handled = false;

            }
            else if (char.IsWhiteSpace(ch))
            {
                e.Handled = false;
            }
            else { e.Handled = true; }
        }

        private void subcategory_Name_TextChanged(object sender, EventArgs e)
        {
      
        }

        private void subcategory_Name_Leave(object sender, EventArgs e)
        {
            conn.Open();
            string idv = "SELECT * FROM subcategory WHERE subcategory_name='" + subcategory_Name.Text + "'";
            cmd = new OleDbCommand(idv, conn);
            OleDbDataReader dr = cmd.ExecuteReader();

            if (dr.Read() == true)
            {
                MessageBox.Show("Subcateogry Name already Registered");
                conn.Close();
                subcategory_Name.Clear();

            }
            else
            {
                conn.Close();
            }
        }
    }
}
