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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Wholesale_electronic_shop
{
    public partial class addproduct : Form
    {
        public addproduct()
        {
            InitializeComponent();

           conn.Open();
            string profile = "SELECT * FROM category";
            cmd = new OleDbCommand(profile, conn);
            OleDbDataReader dr = cmd.ExecuteReader();

            while (dr.Read()==true)
            {
                Category_Name.Items.Add(dr["category_name"].ToString());


                
            }
            conn.Close();
            conn.Open();
            string pro = "SELECT * FROM add_distributor";
            cmd = new OleDbCommand(pro, conn);
            OleDbDataReader drr = cmd.ExecuteReader();

            while (drr.Read() == true)
            {
                tb_Distributor_Name.Items.Add(drr["distributor_name"].ToString());



            }
            conn.Close();
            conn.Open();
            string y = "";
            string p = "SELECT * FROM Products";
            cmd = new OleDbCommand(p, conn);
            OleDbDataReader d = cmd.ExecuteReader();
            while(d.Read())
            {
                y = d["product_id"].ToString();

            }
            int z = Convert.ToInt32(y)+1;
            Product_ID.Text = z.ToString();
            conn.Close();
        }

        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=alldata.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();


        private void tb_Product_ID_KeyPress(object sender, KeyPressEventArgs e)
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

        private void tb_Stock_Quantity_KeyPress(object sender, KeyPressEventArgs e)
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

        private void tb_Purchase_Price_KeyPress(object sender, KeyPressEventArgs e)
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

        private void cmb_Category_Name_KeyPress(object sender, KeyPressEventArgs e)
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

        private void tb_Distributor_Name_KeyPress(object sender, KeyPressEventArgs e)
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

        private void tb_Product_Name_KeyPress(object sender, KeyPressEventArgs e)
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
            else if(char.IsDigit(ch))
            {
                e.Handled=false;
            }
            else if (char.IsWhiteSpace(ch))
            {
                e.Handled = false;
            }

            else { e.Handled = true; }
        }

        private void tb_Sales_Price_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btn_Save_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(Product_ID.Text))
            {
                MessageBox.Show("Product ID is Empty", "",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (string.IsNullOrEmpty(tb_Sales_Price.Text))
            {
                MessageBox.Show("Sales Price is Empty", "",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          /*  else if (string.IsNullOrEmpty(tb_Stock_Quantity.Text))
            {
                MessageBox.Show("Stock Quantity is Empty", "",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
            else if (string.IsNullOrEmpty(tb_Product_Name.Text))
            {
                MessageBox.Show("Product Name is Empty", "",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(tb_Distributor_Name.Text))
            {
                MessageBox.Show("Distributor Name is Empty", "",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(tb_Description.Text))
            {
                MessageBox.Show("Description is Empty", "",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(tb_Purchase_Price.Text))
            {
                MessageBox.Show("Purchase Price is Empty", "",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                conn.Open();
                string id = "SELECT * FROM Products WHERE product_id='" + Product_ID.Text + "'";
                cmd = new OleDbCommand(id, conn);
                OleDbDataReader d = cmd.ExecuteReader();

                if (d.Read() == true)
                {
                    MessageBox.Show("Product ID already Registered");
                    conn.Close();
                    Product_ID.Clear();

                }
                else
                {
                    string idv = "SELECT * FROM add_distributor WHERE distributor_name='" + tb_Distributor_Name.Text + "'";
                    cmd = new OleDbCommand(idv, conn);
                    OleDbDataReader dr = cmd.ExecuteReader();

                    if (dr.Read() == true)
                    {
                        Object selectedItem = Category_Name.SelectedItem;
                        string selected = selectedItem.ToString();

                        Object subitems = Subcatgory_Name.SelectedItem;
                        string selected1 = subitems.ToString();

                        string datestring = dtp_Add_Product_Date.Text;

                        string add = "INSERT INTO Products(product_id,sales_price,category_name,subcategory_name,gst_applied,product_name,distributor_name,purchase_price,product_date,discription) VALUES('" + Product_ID.Text + "','" + tb_Sales_Price.Text + "','" + selected + "','" + selected1 + "','" + tb_GST_Apllied.Text + "','" + tb_Product_Name.Text + "','" + tb_Distributor_Name.Text + "','" + tb_Purchase_Price.Text + "','" + datestring + "','" + tb_Description.Text + "')";
                        OleDbCommand c = new OleDbCommand(add, conn);
                        c.ExecuteNonQuery();
                        Product_ID.Clear();
                        tb_Sales_Price.Clear();
                        tb_Product_Name.Clear();
                        
                        tb_Purchase_Price.Clear();
                        tb_Description.Clear();
                        Category_Name.Items.Clear();
                        Subcatgory_Name.Items.Clear();
                        tb_GST_Apllied.Clear();
                        MessageBox.Show("Done");
                        conn.Close();

                        conn.Open();
                        string y = "";
                        string p = "SELECT * FROM Products";
                        cmd = new OleDbCommand(p, conn);
                        OleDbDataReader u = cmd.ExecuteReader();
                        while (u.Read())
                        {
                            y = u["product_id"].ToString();

                        }
                        int z = Convert.ToInt32(y) + 1;
                        Product_ID.Text = z.ToString();
                        conn.Close();

                    }
                    else
                    {
                        MessageBox.Show("Distributor Not Found");
                   
                        conn.Close();



                    }

                }
                
               
              
            }
        }

        private void tb_GST_Apllied_KeyPress(object sender, KeyPressEventArgs e)
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

        private void addproduct_Load(object sender, EventArgs e)
        {

        }

        private void Subcatgory_Name_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Category_Name_SelectedIndexChanged(object sender, EventArgs e)
        {
            Object selectedItem = Category_Name.SelectedItem;
            //Subcategoryr = null;
            Subcatgory_Name.Items.Clear();
            // MessageBox.Show("Selected Item Text: " + selectedItem.ToString());
            conn.Open();
            string s = selectedItem.ToString();
            string sub = "SELECT * FROM subcategory WHERE category_name ='" + s + "'";
            cmd = new OleDbCommand(sub, conn);
            OleDbDataReader d = cmd.ExecuteReader();
            while (d.Read() == true)
            {
                Subcatgory_Name.Items.Add(d["subcategory_name"].ToString());
            }
            conn.Close();
        }

        private void tb_Distributor_Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void Product_ID_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void Product_ID_Leave(object sender, EventArgs e)
        {
            conn.Close();
            conn.Open();
            string idv = "SELECT * FROM Products WHERE product_id='" + Product_ID.Text + "'";
            cmd = new OleDbCommand(idv, conn);
            OleDbDataReader dr = cmd.ExecuteReader();

            if (dr.Read() == true)
            {
                MessageBox.Show("Product ID already Registered");
                Product_ID.Clear();

            }

            conn.Close();
        }

        private void tb_Product_Name_Leave(object sender, EventArgs e)
        {
            conn.Close();
            conn.Open();
            string idv = "SELECT * FROM Products WHERE product_name='" + tb_Product_Name.Text + "'";
            cmd = new OleDbCommand(idv, conn);
            OleDbDataReader dr = cmd.ExecuteReader();

            if (dr.Read() == true)
            {
                MessageBox.Show("Product Name already Registered");
                tb_Product_Name.Clear();

            }

            conn.Close();
        }
    }
}
