using System;
using System.Collections;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Wholesale_electronic_shop
{
    public partial class addstock : Form
    {
        public addstock()
        {
            InitializeComponent();
            conn.Open();
            string profile = "SELECT * FROM category";
            cmd = new OleDbCommand(profile, conn);
            OleDbDataReader dr = cmd.ExecuteReader();
           
            while (dr.Read())
            {
                cateogryn.Items.Add(dr["category_name"].ToString());

            }
            bill.ForeColor = Color.Black;
         
            conn.Close();
            conn.Open();
            string prof = "SELECT * FROM add_distributor";
            cmd = new OleDbCommand(prof, conn);
            OleDbDataReader dro = cmd.ExecuteReader();

            while (dro.Read())
            {
                distributor_name.Items.Add(dro["distributor_name"].ToString());

            }
            conn.Close();


            conn.Open();
            string input = "SELECT * FROM distributor_bills";
            cmd = new OleDbCommand(input, conn);
            OleDbDataReader ht = cmd.ExecuteReader();
            string m;
            while (ht.Read())
            {
                m = ht["billno"].ToString();
                int h = Convert.ToInt32(m) + 1;
               bill_no.Text = h.ToString();
            }
            conn.Close();

            bill.ColumnCount = 6;
            bill.Columns[0].Name = "ref No";
            bill.Columns[1].Name = "Product Name";
            bill.Columns[2].Name = "Quantity";
            bill.Columns[3].Name = "Price";
            bill.Columns[4].Name = "Total Price";

            bill.Columns[1].Width = 250;
            bill.ForeColor = Color.Black;



        }

        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=alldata.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

        private void tb_Customer_ID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(distributor_name.Text))
            {
                MessageBox.Show("Distributor name is Empty", "",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                for (int s = 0; s < bill.Rows.Count-1; s++)
                {
                    conn.Open();
                    OleDbCommand command = new OleDbCommand(@"INSERT INTO distributor_bills(billno,bill_date,distributor_name,product_name,quantity,price) VALUES('" + bill_no.Text + "','" + dateTimePicker1.Text + "','" + distributor_name.Text + "','" + bill.Rows[s].Cells[1].Value + "','" +bill.Rows[s].Cells[2].Value + "','" + bill.Rows[s].Cells[3].Value + "')", conn);
                    command.Connection = conn;
                    command.ExecuteNonQuery();
                    conn.Close();
                }
            

                disname.Visible = true;
                conn.Open();
               
                string add = "INSERT INTO distributor_bill_total(Billno,amount) VALUES('" + bill_no.Text+ "','" + tb_Total_Bill.Text + "')";
                OleDbCommand c = new OleDbCommand(add, conn);
                c.ExecuteNonQuery();
                conn.Close();

                conn.Open();
                string input = "SELECT * FROM distributor_bills";
                cmd = new OleDbCommand(input, conn);
                OleDbDataReader ht = cmd.ExecuteReader();
                string m;
                while(ht.Read())
                {
                    m = ht["billno"].ToString();
                    int h = Convert.ToInt32(m) + 1;
                    bill_no.Text = h.ToString();
                }
                conn.Close();

                MessageBox.Show("Done");

                Product_Namen.Text = "";
                stock_quantity.Clear();
                Quantity.Clear();
                cateogryn.Text = "";
                subcategoryn.Text = "";                
                Price.Clear();
                bill.Rows.Clear();
                tb_Total_Bill.Text = "";
            }
        }

        private void Distributor_ID_KeyPress(object sender, KeyPressEventArgs e)
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
                e.Handled = true;
            }
            else { e.Handled = true; }
        }

        private void D_Mobile_No_KeyPress(object sender, KeyPressEventArgs e)
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

        private void addstock_Load(object sender, EventArgs e)
        {

        }

        private void Quantity_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btn_Add_Click(object sender, EventArgs e)
        {
             if (string.IsNullOrEmpty(distributor_name.Text))
            {
                MessageBox.Show("Select Distributor Name", "",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(cateogryn.Text))
            {
                MessageBox.Show("Please Select Category Name", "",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(subcategoryn.Text))
            {
                MessageBox.Show("Please Select Subcategory Name", "",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(Quantity.Text))
            {
                MessageBox.Show("Enter quantity", "",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
            else
            {
                    ArrayList row = new ArrayList();
                row.Add("");
                row.Add(Product_Namen.Text);
                row.Add(Quantity.Text);
                row.Add(Price.Text);
                int price1 = Convert.ToInt32(Price.Text);
                int remquantity = 0;
                int quantity = Convert.ToInt32(Quantity.Text);
                if(stock_quantity.Text!="")
                {
                    remquantity = Convert.ToInt32(stock_quantity.Text);

                }
                int total =  price1 * quantity;
                int totalbill = 0;
                int rem = remquantity + quantity;
                int addcalculation = 0;
                string compare = tb_Total_Bill.Text;
               // MessageBox.Show(compare);
                if (compare!="")
                {
                     addcalculation = Convert.ToInt32(tb_Total_Bill.Text);
                    totalbill = total + addcalculation;
                }
                totalbill = total + addcalculation;
                string final = total.ToString();
                row.Add(final);
               
                string remstock = rem.ToString();
                conn.Open();
                string updatethis = "UPDATE Products SET  stock_quantity = '" + remstock + "' WHERE product_name = '" + Product_Namen.Text + "'";
                cmd = new OleDbCommand(updatethis, conn);
                cmd.ExecuteNonQuery();
                stock_quantity.Text = remstock;
                tb_Total_Bill.Text = totalbill.ToString();
                bill.Rows.Add(row.ToArray());
                conn.Close();
                disname.Visible = false;

            }
        }

        private void cateogryn_SelectedIndexChanged(object sender, EventArgs e)
        {
            Object selectedItem = cateogryn.SelectedItem;
            subcategoryn.Items.Clear();
            conn.Open();
            string selected = selectedItem.ToString();
            string subr = "SELECT * FROM subcategory WHERE category_name ='" + selected + "'";
            cmd = new OleDbCommand(subr, conn);
            OleDbDataReader d = cmd.ExecuteReader();
            while (d.Read() == true)
            {
                subcategoryn.Items.Add(d["subcategory_name"].ToString());
            }
            conn.Close();
        }
        

        private void search_Click(object sender, EventArgs e)
        {

        }

        private void gb_Product_Details_Enter(object sender, EventArgs e)
        {

        }

        private void Product_Namen_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn.Open();
            Object subitem = Product_Namen.SelectedItem;
            string item = subitem.ToString();
            string viewprice = "SELECT * FROM Products WHERE product_name = '" + item + "'";
            cmd = new OleDbCommand(viewprice, conn);
            OleDbDataReader er = cmd.ExecuteReader();
            if (er.Read())
            {
                Price.Text = er["purchase_price"].ToString();
             string z  = er["stock_quantity"].ToString();
                stock_quantity.Text = z;
            }
            else
            {
                MessageBox.Show("Price Not found");
            }
            conn.Close();
        }

        private void subcategoryn_SelectedIndexChanged(object sender, EventArgs e)
        {
            Object selectedItem = subcategoryn.SelectedItem;
            Product_Namen.Items.Clear();
            conn.Open();
            string selected = selectedItem.ToString();
            string subrr = "SELECT * FROM Products WHERE subcategory_name = '" + selected + "'";
            cmd = new OleDbCommand(subrr, conn);
            OleDbDataReader dd = cmd.ExecuteReader();
            while (dd.Read() == true)
            {
                Product_Namen.Items.Add(dd["product_name"].ToString());
            }

            conn.Close();
        }

        private void bill_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string or = (bill.Rows[e.RowIndex].Cells["Product Name"].FormattedValue.ToString());
            if (or == "")
            {
                MessageBox.Show("No Data found");
            }
            else
            {

                if (MessageBox.Show("are your sure to delete ?", "delete record", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    string pname = (bill.Rows[e.RowIndex].Cells["Product Name"].FormattedValue.ToString());
                    string y = (bill.Rows[e.RowIndex].Cells["Quantity"].FormattedValue.ToString());

                    conn.Open();
                    string profile = "SELECT * FROM Products WHERE product_name= '" + pname + "'";
                    cmd = new OleDbCommand(profile, conn);
                    OleDbDataReader dr = cmd.ExecuteReader();
                    if (dr.Read() == true)
                    {
                        string remq = dr["stock_quantity"].ToString();
                        int num2 = Convert.ToInt32(remq);
                        int num1 = Convert.ToInt32(y);
                        int result = num2 - num1;
                        string updatethis = "UPDATE Products SET  stock_quantity = '" + result.ToString() + "' WHERE product_name = '" + Product_Namen.Text + "'";
                        cmd = new OleDbCommand(updatethis, conn);
                        cmd.ExecuteNonQuery();
                        stock_quantity.Text = result.ToString();
                    }
                    conn.Close();
                    bill.Rows.RemoveAt(e.RowIndex);

                }
            }
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Product_Namen.Text = "";
            stock_quantity.Clear();
            Quantity.Clear();
            cateogryn.Text = "";
            subcategoryn.Text = "";
            Price.Clear();
            bill.Rows.Clear();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
    
        }

        private void bill_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {

        }

        private void bill_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.bill.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
       
        }
    }
}
