using System;
using System.Collections;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Wholesale_electronic_shop
{
    public partial class retailerorder : Form
    {

        public retailerorder()
        {
            InitializeComponent();
            conn.Open();
            string pro = "SELECT * FROM add_retailer";
            cmd = new OleDbCommand(pro, conn);
            OleDbDataReader drr = cmd.ExecuteReader();

            while (drr.Read() == true)
            {
                retailername.Items.Add(drr["retailer_name"].ToString());
            }
            conn.Close();
            conn.Open();
            string profile = "SELECT * FROM category";
            cmd = new OleDbCommand(profile, conn);
            OleDbDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Categoryr.Items.Add(dr["category_name"].ToString());

            }
            conn.Close();

            retailerbill.ColumnCount = 5;
            retailerbill.Columns[0].Name = "Ref No";
            retailerbill.Columns[1].Name = "Product Name";
            retailerbill.Columns[2].Name = "Quantity";
            retailerbill.Columns[3].Name = "Price";
            retailerbill.Columns[4].Name = "Total Price";

            retailerbill.Columns[1].Width = 250;
            retailerbill.ForeColor = Color.Black;

            conn.Open();
            string input = "SELECT * FROM retailer_bills";
            cmd = new OleDbCommand(input, conn);
            OleDbDataReader ht = cmd.ExecuteReader();
            string m;
            while(ht.Read())
            {
                m = ht["billno"].ToString();
                int h = Convert.ToInt32(m)+1;
                dbill_no.Text = h.ToString();
            }
            conn.Close();



        }

        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=alldata.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

        private void gb_Customer_Details_Enter(object sender, EventArgs e)
        {

        }

        private void gb_Product_Details_Enter(object sender, EventArgs e)
        {

        }

        private void lbl_Total_Price_Click(object sender, EventArgs e)
        {

        }

        private void tb_Customer_Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_Customer_ID_KeyPress(object sender, KeyPressEventArgs e)
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

        private void tb_Mobile_No_KeyPress(object sender, KeyPressEventArgs e)
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
          
            if (string.IsNullOrEmpty(retailername.Text))
            {
                MessageBox.Show("Retailer name is Empty", "",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            { 
                for (int s = 0; s < retailerbill.Rows.Count; s++)
                {
                    conn.Open();
                    OleDbCommand command = new OleDbCommand(@"INSERT INTO retailer_bills(billno,bill_date,retailer_name,product_name,quantity,price) VALUES('" + dbill_no.Text + "','"+ dateTimePicker1.Text+ "','" + retailername.Text + "','" + retailerbill.Rows[s].Cells[1].Value + "','" + retailerbill.Rows[s].Cells[2].Value + "','" + retailerbill.Rows[s].Cells[3].Value +"')", conn);
                    command.Connection = conn;
                    command.ExecuteNonQuery();                    
                    conn.Close();
                }

                conn.Open();
               
                string add = "INSERT INTO retailer_bill_total(Billno,amount) VALUES('" + dbill_no.Text + "','" + tb_Total_Bill.Text +"')";
                OleDbCommand c = new OleDbCommand(add, conn);
                c.ExecuteNonQuery();
                conn.Close() ;
                MessageBox.Show("Done");

                Product_Namer.Text = "";
                stock_quantity.Clear();
                Quantityr.Clear();
                Categoryr.Text = "";
                Subcategoryr.Text = "";
                dbill_no.Clear();
                Pricer.Clear();
                retailerbill.Rows.Clear();
                tb_Total_Bill.Text = "";
                retailerinfo.Visible = true;

                conn.Open();
                string input = "SELECT * FROM retailer_bills";
                cmd = new OleDbCommand(input, conn);
                OleDbDataReader ht = cmd.ExecuteReader();
                string m;
                while (ht.Read())
                {
                    m = ht["billno"].ToString();
                    int h = Convert.ToInt32(m) + 1;
                    dbill_no.Text = h.ToString();
                }
                conn.Close();

            }

        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
          
            if (string.IsNullOrEmpty(Categoryr.Text))
            {
                MessageBox.Show("Please Select Category Name", "",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(Subcategoryr.Text))
            {
                MessageBox.Show("Please Select Subcategory Name", "",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(Quantityr.Text))
            {
                MessageBox.Show("Enter quantity", "",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(Product_Namer.Text))
            {
                MessageBox.Show("Select Product", "",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(string.IsNullOrEmpty(retailername.Text))
            {
                MessageBox.Show("Select Retailer Name", "",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ArrayList row = new ArrayList();
                row.Add("");
                row.Add(Product_Namer.Text);
                row.Add(Quantityr.Text);
                row.Add(Pricer.Text);
                int price1 = Convert.ToInt32(Pricer.Text);
                int remquantity = 0;
                int quantity = Convert.ToInt32(Quantityr.Text);
                if (stock_quantity.Text != "")
                {
                    remquantity = Convert.ToInt32(stock_quantity.Text);

                }
                int total = price1 * quantity;
                int totalbill = 0;
                int rem = remquantity - quantity;
                int addcalculation = 0;
                string compare = tb_Total_Bill.Text;
                // MessageBox.Show(compare);
                if (compare != "")
                {
                    addcalculation = Convert.ToInt32(tb_Total_Bill.Text);
                    totalbill = total + addcalculation;
                }

                    totalbill = total + addcalculation;
                    string final = total.ToString();
                    row.Add(final);
                  
                    string remstock = rem.ToString();
                if (stock_quantity.Text=="0")
                {
                    MessageBox.Show("Stock Finished");
                }
                else
                {

                    conn.Open();
                    string updatethis = "UPDATE Products SET  stock_quantity = '" + remstock + "' WHERE product_name = '" + Product_Namer.Text + "'";
                    cmd = new OleDbCommand(updatethis, conn);
                    cmd.ExecuteNonQuery();
                    stock_quantity.Text = remstock;
                    tb_Total_Bill.Text = totalbill.ToString();
                    retailerbill.Rows.Add(row.ToArray());
                    conn.Close();
                    Product_Namer.Text = "";
                    stock_quantity.Clear();
                    Quantityr.Clear();
                    Categoryr.Text = "";
                    Subcategoryr.Text = "";
                    Pricer.Clear();

                    retailerinfo.Visible = false;

                }
                
            }
        }

        private void Retailer_Name_KeyPress(object sender, KeyPressEventArgs e)
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
                e.Handled = true;
            }
            else { e.Handled = true; }
        }

        private void retailerorder_Load(object sender, EventArgs e)
        {

        }

        private void Categoryr_SelectedIndexChanged(object sender, EventArgs e)
        {
            Object selectedItem = Categoryr.SelectedItem;
            //Subcategoryr = null;
            Subcategoryr.Items.Clear();
            // MessageBox.Show("Selected Item Text: " + selectedItem.ToString());
            conn.Open();
            string selected = selectedItem.ToString();
            string subr = "SELECT * FROM subcategory WHERE category_name ='" + selected + "'";
            cmd = new OleDbCommand(subr, conn);
            OleDbDataReader d = cmd.ExecuteReader();
            while (d.Read() == true)
            {
                Subcategoryr.Items.Add(d["subcategory_name"].ToString());
            }
           
           
            conn.Close();
            
        }

        private void Subcategoryr_SelectedIndexChanged(object sender, EventArgs e)
        {
            Object selectedItem = Subcategoryr.SelectedItem;
            Product_Namer.Items.Clear();
            conn.Open();
            string selected = selectedItem.ToString();
            string subrr = "SELECT * FROM Products WHERE subcategory_name = '" + selected+ "'";
            cmd = new OleDbCommand(subrr, conn);
            OleDbDataReader dd = cmd.ExecuteReader();
            while (dd.Read() == true)
            {
                Product_Namer.Items.Add(dd["product_name"].ToString());
            }

            conn.Close();   
        }

        private void Product_Namer_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn.Open();
            Object subitem = Product_Namer.SelectedItem;
            string item = subitem.ToString();
            string viewprice = "SELECT * FROM Products WHERE product_name = '" + item + "'";
            cmd = new OleDbCommand(viewprice, conn);
            OleDbDataReader er = cmd.ExecuteReader();
            if (er.Read())
            {
                Pricer.Text = er["sales_price"].ToString();
                stock_quantity.Text = er["stock_quantity"].ToString();
            }
            else
            {
                MessageBox.Show("Price Not found");
            }
            conn.Close();
        }

        private void lbl_Product_Name_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Retailer_ID_TextChanged(object sender, EventArgs e)
        {

        }

        private void refbutton_Click(object sender, EventArgs e)
        {
    

        }

        private void retailerbill_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string or = (retailerbill.Rows[e.RowIndex].Cells["Product Name"].FormattedValue.ToString());
            if (or == "")
            {
                MessageBox.Show("No Data found");
            }
            else
            {
                if (MessageBox.Show("are your sure to delete ?", "delete record", MessageBoxButtons.YesNo) == DialogResult.Yes) { 

                    string pname = (retailerbill.Rows[e.RowIndex].Cells["Product Name"].FormattedValue.ToString());
                string y = (retailerbill.Rows[e.RowIndex].Cells["Quantity"].FormattedValue.ToString());

                conn.Open();
                string profile = "SELECT * FROM Products WHERE product_name= '" + pname + "'";
                cmd = new OleDbCommand(profile, conn);
                OleDbDataReader dr = cmd.ExecuteReader();
                if (dr.Read() == true)
                {
                    string remq = dr["stock_quantity"].ToString();
                    int num2 = Convert.ToInt32(remq);
                    int num1 = Convert.ToInt32(y);
                    int result = num1 + num2;
                    string updatethis = "UPDATE Products SET  stock_quantity = '" + result.ToString() + "' WHERE product_name = '" + Product_Namer.Text + "'";
                    cmd = new OleDbCommand(updatethis, conn);
                    stock_quantity.Text = result.ToString();
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
                retailerbill.Rows.RemoveAt(e.RowIndex);
                }
            }
        }

        private void retailerbill_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.retailerbill.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();

        }

        private void retailername_SelectedValueChanged(object sender, EventArgs e)
        {
       
        }

        private void retailername_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
 
            Product_Namer.Text = "";
            stock_quantity.Clear();
            Quantityr.Clear();
            Categoryr.Text = "";
            Subcategoryr.Text = "";
            Pricer.Clear();
        }
    }
}
