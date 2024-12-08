using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Wholesale_electronic_shop
{
    public partial class addretailer : Form
    {
        public addretailer()
        {
            InitializeComponent();

            conn.Open();
            string y = "";
            string p = "SELECT * FROM add_retailer";
            cmd = new OleDbCommand(p, conn);
            OleDbDataReader d = cmd.ExecuteReader();
            while (d.Read())
            {
                y = d["retailer_id"].ToString();

            }
            int z = Convert.ToInt32(y) + 1;
            reailer_id.Text = z.ToString();
            conn.Close();
        }
        string emailpattern = "^[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?$";
        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=alldata.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

        private void tb_Distributer_Id_KeyPress(object sender, KeyPressEventArgs e)
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

        private void tb_Adhar_No_KeyPress(object sender, KeyPressEventArgs e)
        {
          
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

        private void tb_Distributer_Name_KeyPress(object sender, KeyPressEventArgs e)
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

        private void addretailer_Load(object sender, EventArgs e)
        {

        }

        private void Email_Id_KeyPress(object sender, KeyPressEventArgs e)
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

        private void Email_Id_Leave(object sender, EventArgs e)
        {
            if (Regex.IsMatch(Email_Id.Text, emailpattern) == false)
            {
                MessageBox.Show("Provide Valid Mail");
                Email_Id.Focus();
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(reailer_id.Text))
            {
                MessageBox.Show("Retailer ID is Empty", "",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (string.IsNullOrEmpty(retailer_Name.Text))
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
            else if (string.IsNullOrEmpty(Email_Id.Text))
            {
                MessageBox.Show("Email is Empty", "",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(Retailer_Address.Text))
            {
                MessageBox.Show("Address is Empty", "",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                conn.Open();
                string idv = "SELECT * FROM add_retailer";
                cmd = new OleDbCommand(idv, conn);
                OleDbDataReader dr = cmd.ExecuteReader();

                if (dr.Read() == true)
                {
                    string r = dr["retailer_name"].ToString();

                    if (r == Retailername.Text)
                    {
                        MessageBox.Show("Retailer Name Already Registered");
                        Retailername.Clear();
                    }
                    else
                    {
                        string datestring = dtp_Tie_Up_Date.Text;
                        string add = "INSERT INTO add_retailer(retailer_id,retailer_name,GSTIN_No,email_id,mobile_no,alternate_no,office_address,retailer_date) VALUES('" + reailer_id.Text + "','" + Retailername.Text + "','" + GSTIN_No.Text + "','" + Email_Id.Text + "','" + tb_Mobile_No.Text + "','" + tb_Alternate_No.Text + "','" + Retailer_Address.Text + "','" + datestring + "')";
                        OleDbCommand c = new OleDbCommand(add, conn);
                        c.ExecuteNonQuery();
                        MessageBox.Show("Done");
                        reailer_id.Clear();
                        Retailername.Clear();
                        GSTIN_No.Clear();
                        Email_Id.Clear();
                        tb_Mobile_No.Clear();
                        tb_Alternate_No.Clear();
                        Retailer_Address.Clear();
                        conn.Open();
                        string y = "";
                        string p = "SELECT * FROM add_retailer";
                        cmd = new OleDbCommand(p, conn);
                        OleDbDataReader d = cmd.ExecuteReader();
                        while (d.Read())
                        {
                            y = d["retailer_id"].ToString();

                        }
                        int z = Convert.ToInt32(y) + 1;
                        reailer_id.Text = z.ToString();
                        conn.Close();
                    }
                }
                conn.Close();
            }
        }

        private void reailerid_TextChanged(object sender, EventArgs e)
        {
        

        }

        private void reailer_id_Leave(object sender, EventArgs e)
        {
            conn.Close();
            conn.Open();
            string idv = "SELECT * FROM add_retailer WHERE retailer_id='" + reailer_id.Text + "'";
            cmd = new OleDbCommand(idv, conn);
            OleDbDataReader dr = cmd.ExecuteReader();

            if (dr.Read() == true)
            {
                MessageBox.Show("retailer ID already Registered");
                reailer_id.Clear();
                conn.Close();

            }
            conn.Close();
        }

        private void Retailername_TextChanged(object sender, EventArgs e)
        {
            conn.Close();
            conn.Open();
            string idv = "SELECT * FROM add_retailer WHERE retailer_name='" + Retailername.Text + "'";
            cmd = new OleDbCommand(idv, conn);
            OleDbDataReader dr = cmd.ExecuteReader();

            if (dr.Read() == true)
            {
                MessageBox.Show("retailer Name already Registered");
                Retailername.Clear();

            }
            conn.Close();
        }
    }
}
