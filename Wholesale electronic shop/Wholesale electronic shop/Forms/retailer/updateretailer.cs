using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wholesale_electronic_shop
{
    public partial class updateretailer : Form
    {
        public updateretailer()
        {
            InitializeComponent();
        }
        string emailpattern = "^[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?$";
        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=alldata.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();
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

        private void retailer_name_KeyPress(object sender, KeyPressEventArgs e)
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

        private void tb_Alternate_No_KeyPress(object sender, KeyPressEventArgs e)
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

        private void tb_Email_Id_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            char input = e.KeyChar;
            if (char.IsWhiteSpace(input) == true)
            {
                e.Handled = true;
            }
            else if (input == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void tb_Email_Id_Leave(object sender, EventArgs e)
        {
            if (Regex.IsMatch(tb_Email_Id.Text, emailpattern) == false)
            {
                MessageBox.Show("Provide Valid Mail");
                tb_Email_Id.Focus();
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
           
            if (string.IsNullOrEmpty(retailer_name.Text))
            {
                MessageBox.Show("Retailer Name is Empty", "",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(tb_Mobile_No.Text))
            {
                MessageBox.Show("Mobile No is Empty", "",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(tb_Alternate_No.Text))
            {
                MessageBox.Show("Alternate Mobile No is Empty", "",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(tb_Email_Id.Text))
            {
                MessageBox.Show("Email is Empty", "",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(tb_Address.Text))
            {
                MessageBox.Show("Address is Empty", "",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                conn.Open();
                string updatethis = "UPDATE add_retailer SET retailer_name = '" + retailer_name.Text + "' WHERE retailer_id = '" + retailer_id.Text + "'";
                cmd = new OleDbCommand(updatethis, conn);
                cmd.ExecuteNonQuery();
                string updatethis1 = "UPDATE add_retailer SET office_address = '" + tb_Address.Text + "' WHERE retailer_id = '" + retailer_id.Text + "'";
                cmd = new OleDbCommand(updatethis1, conn);
                cmd.ExecuteNonQuery();
                string updatethis2 = "UPDATE add_retailer SET mobile_no = '" + tb_Mobile_No.Text + "' WHERE retailer_id = '" + retailer_id.Text + "'";
                cmd = new OleDbCommand(updatethis2, conn);
                cmd.ExecuteNonQuery();
                string updatethis3 = "UPDATE add_retailer SET alternate_no = '" + tb_Alternate_No.Text + "' WHERE retailer_id = '" + retailer_id.Text + "'";
                cmd = new OleDbCommand(updatethis3, conn);
                cmd.ExecuteNonQuery();
                string updatethis4 = "UPDATE add_retailer SET email_id = '" + tb_Email_Id.Text + "' WHERE retailer_id = '" + retailer_id.Text + "'";
                cmd = new OleDbCommand(updatethis4, conn);
                cmd.ExecuteNonQuery();
                string updatethis5 = "UPDATE add_retailer SET GSTIN_No = '" + gstin.Text + "' WHERE  retailer_id = '" + retailer_id.Text + "'";
                cmd = new OleDbCommand(updatethis5, conn);
                cmd.ExecuteNonQuery();
                retailer_name.Clear();
                tb_Address.Clear();
                tb_Alternate_No.Clear();
                tb_Mobile_No.Clear();
                retailer_name.Clear();
                gstin.Clear();
                tb_Email_Id.Clear();
                MessageBox.Show("Done");
                conn.Close();
               
            }
        }

        private void updateretailer_Load(object sender, EventArgs e)
        {

        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            conn.Open();


            string profile = "SELECT * FROM add_retailer WHERE retailer_id= '" + retailer_id.Text + "'";
            cmd = new OleDbCommand(profile, conn);
            OleDbDataReader dr = cmd.ExecuteReader();

            if (dr.Read() == true)
            {
                retailer_name.Text = dr["retailer_name"].ToString();
                tb_Address.Text = dr["office_address"].ToString();
                tb_Mobile_No.Text = dr["mobile_no"].ToString();
                tb_Alternate_No.Text = dr["alternate_no"].ToString();
                gstin.Text = dr["GSTIN_No"].ToString();
                tb_Email_Id.Text = dr["email_id"].ToString();
                conn.Close();
            }
            else
            {
                MessageBox.Show("not found");

                conn.Close();
            }
        }
    }
}
