using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Wholesale_electronic_shop
{
    public partial class updateproduct : Form
    {
        public updateproduct()
        {
            InitializeComponent();

        }
        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=alldata.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

      
        private void btn_Save_Click(object sender, EventArgs e)
        {

        }

        private void tb_Sales_Price_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_Purchase_Price_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_Purchase_Price_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Sales_Price_Click(object sender, EventArgs e)
        {

        }

        private void tb_Description_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_Description_Click(object sender, EventArgs e)
        {

        }

        private void cmb_Subcatgory_Name_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void cmb_Category_Name_SelectedIndexChanged(object sender, EventArgs e)
        {
   
        }

        private void tb_GST_Apllied_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_Gst_Apllied_Click(object sender, EventArgs e)
        {

        }

        private void tb_Stock_Quantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_Stock_Quantity_Click(object sender, EventArgs e)
        {

        }

        private void dtp_Add_Product_Date_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lbl_Date_Click(object sender, EventArgs e)
        {

        }

        private void tb_Distributor_Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_Distributor_Name_Click(object sender, EventArgs e)
        {

        }

        private void tb_Product_Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_Product_Name_Click(object sender, EventArgs e)
        {

        }

        private void tb_Product_ID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Subcategory_Name_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Category_Name_Click(object sender, EventArgs e)
        {

        }

        private void pnl_Search_Employee_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Sales_Price_KeyPress(object sender, KeyPressEventArgs e)
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

        private void updateproduct_Load(object sender, EventArgs e)
        {

        }

        private void Product_ID_KeyPress(object sender, KeyPressEventArgs e)
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

        private void Stock_Quantity_KeyPress(object sender, KeyPressEventArgs e)
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

        private void GST_Apllied_KeyPress(object sender, KeyPressEventArgs e)
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

        private void Purchase_Price_KeyPress(object sender, KeyPressEventArgs e)
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
            else if (char.IsWhiteSpace(ch))
            {
                e.Handled = false;
            }

            else { e.Handled = true; }
        }

        private void Distributor_Name_KeyPress(object sender, KeyPressEventArgs e)
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

        private void Product_Name_KeyPress(object sender, KeyPressEventArgs e)
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

        private void tb_Employee_Id_KeyPress(object sender, KeyPressEventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(Sales_Price.Text))
            {
                MessageBox.Show("Sales Price is Empty", "",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          /*  else if (string.IsNullOrEmpty(Stock_Quantity.Text))
            {
                MessageBox.Show("Stock Quantity is Empty", "",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
            else if (string.IsNullOrEmpty(Product_Name.Text))
            {
                MessageBox.Show("Product Name is Empty", "",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(Distributor_Name.Text))
            {
                MessageBox.Show("Distributor Name is Empty", "",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(Description.Text))
            {
                MessageBox.Show("Description is Empty", "",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(Purchase_Price.Text))
            {
                MessageBox.Show("Purchase Price is Empty", "",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                conn.Open();

                string updatethis = "UPDATE Products SET  category_name = '" + categoryname.Text + "' WHERE product_id = '" + Prodcut_id.Text + "'";
                cmd = new OleDbCommand(updatethis, conn);
                cmd.ExecuteNonQuery();
                string updatethis1 = "UPDATE Products SET subcategory_name = '" + Subcatgory_Name.Text + "' WHERE product_id= '" + Prodcut_id.Text + "'";
                cmd = new OleDbCommand(updatethis1, conn);
                cmd.ExecuteNonQuery();
                string updatethis2 = "UPDATE Products SET sales_price = '" + Sales_Price.Text + "' WHERE product_id = '" + Prodcut_id.Text + "'";
                cmd = new OleDbCommand(updatethis2, conn);
                cmd.ExecuteNonQuery();
                string updatethis3 = "UPDATE Products SET gst_applied = '" + GST_Applied.Text + "' WHERE product_id = '" + Prodcut_id.Text + "'";
                cmd = new OleDbCommand(updatethis3, conn);
                cmd.ExecuteNonQuery();
                string updatethis4 = "UPDATE Products SET product_name = '" + Product_Name.Text + "' WHERE product_id= '" + Prodcut_id.Text + "'";
                cmd = new OleDbCommand(updatethis4, conn);
                cmd.ExecuteNonQuery();
                string updatethis5 = "UPDATE Products SET distributor_name = '" + Distributor_Name.Text + "' WHERE product_id = '" + Prodcut_id.Text + "'";
                cmd = new OleDbCommand(updatethis5, conn);
                cmd.ExecuteNonQuery();
                string updatethis6 = "UPDATE Products SET product_date = '" + dtp_Add_Product_Date.Text + "' WHERE product_id = '" + Prodcut_id.Text + "'";
                cmd = new OleDbCommand(updatethis6, conn);
                cmd.ExecuteNonQuery();
                string updatethis7 = "UPDATE Products SET discription= '" + Description.Text + "' WHERE product_id = '" + Prodcut_id.Text + "'";
                cmd = new OleDbCommand(updatethis7, conn);
                cmd.ExecuteNonQuery();
                string updatethis8 = "UPDATE Products SET purchase_price = '" + Purchase_Price.Text + "' WHERE product_id = '" + Prodcut_id.Text + "'";
                cmd = new OleDbCommand(updatethis8, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                Sales_Price.Clear();
                GST_Applied.Clear();
                Product_Name.Clear();
                Description.Clear();
                Purchase_Price.Clear();
                Distributor_Name.Clear();


                MessageBox.Show("Done");
            }
        }
       void fun()
        {
            
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            conn.Open();

            string pro = "SELECT * FROM category";
            cmd = new OleDbCommand(pro, conn);
            OleDbDataReader dre = cmd.ExecuteReader();
            categoryname.Items.Clear();
            Subcatgory_Name.Items.Clear();
            
            while (dre.Read())
            {
                categoryname.Items.Add(dre["category_name"].ToString());


            }
            conn.Close();
      
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            conn.Open();
         
            string profile = "SELECT * FROM Products WHERE product_id= '" + Prodcut_id.Text + "'";
            cmd = new OleDbCommand(profile, conn);
            OleDbDataReader dr = cmd.ExecuteReader();

            if (dr.Read() == true)
            {
                Sales_Price.Text = dr["sales_price"].ToString();
                Subcatgory_Name.Text = dr["subcategory_name"].ToString();
                categoryname.Text = dr["category_name"].ToString();
                GST_Applied.Text = dr["gst_applied"].ToString();
                Product_Name.Text = dr["product_name"].ToString();
                Distributor_Name.Text = dr["distributor_name"].ToString();
                Purchase_Price.Text = dr["purchase_price"].ToString();
              //dtp_Add_Product_Date.Text = dr["prodcut_date"].ToString();
                Description.Text = dr["discription"].ToString();
                
            }
            else
            {
                MessageBox.Show("not found");
            }
            conn.Close();
         

        }

        private void categoryname_SelectedIndexChanged(object sender, EventArgs e)
        {
       
        }

        private void categoryname_KeyPress(object sender, KeyPressEventArgs e)
        {
        
        }

        private void categoryname_DropDown(object sender, EventArgs e)
        {
        
        }

        private void categoryname_DropDownClosed(object sender, EventArgs e)
        {
            Object selectedItem = categoryname.SelectedItem;
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
    }
}
