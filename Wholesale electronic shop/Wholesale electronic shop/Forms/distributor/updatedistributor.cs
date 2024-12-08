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
    public partial class updatedistributor : Form
    {
        public updatedistributor()
        {
            InitializeComponent();
        }
        string emailpattern = "^[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?$";

        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=alldata.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();
        private void tb_Adhar_No_TextChanged(object sender, EventArgs e)
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

        private void tb_Alternate_No_TextChanged(object sender, EventArgs e)
        {

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

        private void tb_Email_Id_Leave(object sender, EventArgs e)
        {
            if (Regex.IsMatch(Email_Id.Text, emailpattern) == false)
            {
                MessageBox.Show("Provide Valid Mail");
                Email_Id.Focus();
            }
           
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

        private void tb_Address_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(Distributor_Name.Text))
            {
                MessageBox.Show("Distributor Name is Empty", "",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(Mobile_No.Text))
            {
                MessageBox.Show("Mobile No is Empty", "",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(Alternate_No.Text))
            {
                MessageBox.Show("Alternate Mobile No is Empty", "",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(Email_Id.Text))
            {
                MessageBox.Show("Email is Empty", "",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(Address.Text))
            {
                MessageBox.Show("Address is Empty", "",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                conn.Open();
              
                string updatethis = "UPDATE add_distributor SET distributor_name = '" + Distributor_Name.Text + "' WHERE distributor_id = '" + distributor_id.Text + "'";
                cmd = new OleDbCommand(updatethis, conn);
                cmd.ExecuteNonQuery();
                string updatethis1 = "UPDATE add_distributor SET office_address = '" + Address.Text + "' WHERE distributor_id = '" + distributor_id.Text + "'";
                cmd = new OleDbCommand(updatethis1, conn);
                cmd.ExecuteNonQuery();
                string updatethis2 = "UPDATE add_distributor SET mobile_no = '" + Mobile_No.Text + "' WHERE distributor_id = '" + distributor_id.Text + "'";
                cmd = new OleDbCommand(updatethis2, conn);
                cmd.ExecuteNonQuery();
                string updatethis3 = "UPDATE add_distributor SET alternate_no = '" + Alternate_No.Text + "' WHERE distributor_id = '" + distributor_id.Text + "'";
                cmd = new OleDbCommand(updatethis3, conn);
                cmd.ExecuteNonQuery();
                string updatethis4 = "UPDATE add_distributor SET email_id = '" + Email_Id.Text + "' WHERE distributor_id = '" + distributor_id.Text + "'";
                cmd = new OleDbCommand(updatethis4, conn);
                cmd.ExecuteNonQuery();
                string updatethis5 = "UPDATE add_distributor SET GSTIN_No = '" + GSTINno.Text + "' WHERE distributor_id = '" + distributor_id.Text + "'";
                cmd = new OleDbCommand(updatethis5, conn);
                cmd.ExecuteNonQuery();
                Distributor_Name.Clear();
                    Address.Clear();
                Alternate_No.Clear();
                     Email_Id.Clear();
                Distributor_Name.Clear();
                GSTINno.Clear();
                Mobile_No.Clear();
                MessageBox.Show("Done");
                conn.Close();
            }
        }

        private void updatedistributor_Load(object sender, EventArgs e)
        {

        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            conn.Open();
            string profile = "SELECT * FROM add_distributor WHERE distributor_id= '" + distributor_id.Text + "'";
            cmd = new OleDbCommand(profile, conn);
            OleDbDataReader dr = cmd.ExecuteReader();

            if (dr.Read() == true)
            {
                distributor_id.Text = dr["Distributor_id"].ToString();
                Address.Text = dr["office_address"].ToString();
                Mobile_No.Text = dr["mobile_no"].ToString();
                Alternate_No.Text = dr["alternate_no"].ToString(); 
                GSTINno.Text = dr["GSTIN_No"].ToString();
                Distributor_Name.Text = dr["distributor_name"].ToString();
                Email_Id.Text = dr["email_id"].ToString();
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
