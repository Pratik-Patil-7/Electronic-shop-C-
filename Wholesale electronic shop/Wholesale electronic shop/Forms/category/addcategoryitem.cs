using System;
using System.Data.OleDb;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Wholesale_electronic_shop
{
    public partial class addcategoryitem : Form
    {
        public addcategoryitem()
        {
            InitializeComponent();
            conn.Open();
            string y = "";
            string p = "SELECT * FROM category";
            cmd = new OleDbCommand(p, conn);
            OleDbDataReader d = cmd.ExecuteReader();
            while (d.Read())
            {
                y = d["category_id"].ToString();

            }
            int z = Convert.ToInt32(y) + 1;
            Category_Id.Text = z.ToString();
            conn.Close();
        }
        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=alldata.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

        private void btn_Save_Click(object sender, EventArgs e)
        {
     
             if (string.IsNullOrEmpty(Category_Id.Text))
            {
                MessageBox.Show("Cateogry ID is Empty", "",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (string.IsNullOrEmpty(Category_Name.Text))
            {
                MessageBox.Show("Cateogry Name is Empty", "",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                conn.Open();
                string profile = "SELECT * FROM subcategory WHERE category_name= '" + Category_Name.Text + "'";
                cmd = new OleDbCommand(profile, conn);
                OleDbDataReader dr = cmd.ExecuteReader();
                if (dr.Read() == true)
                {
                    MessageBox.Show("cateogry Already Added");
                    Category_Name.Clear();
                }
                conn.Close();
                conn.Open();
                string add = "INSERT INTO category(category_id,category_name) VALUES('" + Category_Id.Text + "','" + Category_Name.Text+ "')";
                OleDbCommand c = new OleDbCommand(add, conn);
                c.ExecuteNonQuery();
                conn.Close();
                Category_Id.Clear();
                Category_Name.Clear();  
               
                MessageBox.Show("Done");
                conn.Open();
                string y = "";
                string p = "SELECT * FROM category";
                cmd = new OleDbCommand(p, conn);
                OleDbDataReader d = cmd.ExecuteReader();
                while (d.Read())
                {
                    y = d["category_id"].ToString();

                }
                int z = Convert.ToInt32(y) + 1;
                Category_Id.Text = z.ToString();
                conn.Close();
            }
        }

        private void Category_Id_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (char.IsDigit(ch))
            {
                e.Handled = false;
            }
            else if(ch==8)
            {
                e.Handled= false;

            }
            else { e.Handled = true; }
        }

        private void Category_Name_KeyPress(object sender, KeyPressEventArgs e)
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
            else if(char.IsWhiteSpace(ch))
            {
                e.Handled = false;
            }
            else { e.Handled = true; }
        }

        private void addcategoryitem_Load(object sender, EventArgs e)
        {

        }

        private void Category_Id_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void Category_Name_Leave(object sender, EventArgs e)
        {
            conn.Close();
            conn.Open();
            string idv = "SELECT * FROM category WHERE category_name='" + Category_Name.Text + "'";
            cmd = new OleDbCommand(idv, conn);
            OleDbDataReader dr = cmd.ExecuteReader();

            if (dr.Read() == true)
            {
                MessageBox.Show("Category Name already Registered");
                Category_Name.Clear();

            }
            conn.Close();
        }

        private void Category_Id_Leave(object sender, EventArgs e)
        {
            conn.Open();
            string idv = "SELECT * FROM category WHERE category_id='" + Category_Id.Text + "'";
            cmd = new OleDbCommand(idv, conn);
            OleDbDataReader dr = cmd.ExecuteReader();

            if (dr.Read() == true)
            {
                MessageBox.Show("Category Id already Registered");
                conn.Close();
                Category_Id.Clear();

            }
            else
            {
                conn.Close();
            }
        }
    }
}
