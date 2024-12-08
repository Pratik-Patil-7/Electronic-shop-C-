using System;
using System.Data.OleDb;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Wholesale_electronic_shop
{
    public partial class adddistributor : Form
    {
        public adddistributor()
        {
            InitializeComponent();
            conn.Open();
            string y = "";
            string p = "SELECT * FROM add_distributor";
            cmd = new OleDbCommand(p, conn);
            OleDbDataReader d = cmd.ExecuteReader();
            while (d.Read())
            {
                y = d["distributor_id"].ToString();

            }
            int z = Convert.ToInt32(y) + 1;
            Distributer_Id.Text = z.ToString();
            conn.Close();
        }
        string emailpattern = "^[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?$";
        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=alldata.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();


        private void Distributer_Id_KeyPress(object sender, KeyPressEventArgs e)
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
            char ch = e.KeyChar;
            if (char.IsWhiteSpace(ch))
            {
                e.Handled = true;
            }
            else if (ch == 8)
            {
                e.Handled = false;

            }
            else if (char.IsLetter(ch))
            {
                e.Handled = false;
            }
            else if (char.IsDigit(ch))
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

        private void adddistributor_Load(object sender, EventArgs e)
        {
        }

        private void tb_Email_Id_Leave(object sender, EventArgs e)
        {
            if (Regex.IsMatch(tb_Email_Id.Text, emailpattern) == false)
            {
                MessageBox.Show("Provide Valid Mail");
                tb_Email_Id.Focus();
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

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Distributer_Id.Text))
            {
                MessageBox.Show("Distributor ID is Empty", "",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (string.IsNullOrEmpty(tb_Distributer_Name.Text))
            {
                MessageBox.Show("Distributor Name is Empty", "",
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
            else if (string.IsNullOrEmpty(tb_Distributer_Address.Text))
            {
                MessageBox.Show("Address is Empty", "",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                conn.Open();
                string idv = "SELECT * FROM add_distributor";
                cmd = new OleDbCommand(idv, conn);
                OleDbDataReader dr = cmd.ExecuteReader();

                if (dr.Read() == true)
                {
                    string r = dr["distributor_name"].ToString();

                    if (r == tb_Distributer_Name.Text)
                    {
                        MessageBox.Show("Retailer Name Already Registered");
                        tb_Distributer_Name.Clear();
                    }
                    else
                    {
                        //conn.Open();
                        string datestring = Date.Text;
                        string add = "INSERT INTO add_distributor(distributor_id,distributor_name,GSTIN_No,email_id,mobile_no,alternate_no,office_address,distributor_date) VALUES('" + Distributer_Id.Text + "','" + tb_Distributer_Name.Text + "','" + gstin.Text + "','" + tb_Email_Id.Text + "','" + tb_Mobile_No.Text + "','" + tb_Alternate_No.Text + "','" + tb_Distributer_Address.Text + "','" + datestring + "')";
                        OleDbCommand c = new OleDbCommand(add, conn);
                        c.ExecuteNonQuery();
                        //conn.Close();
                        MessageBox.Show("Done");
                        Distributer_Id.Clear();
                        tb_Distributer_Name.Clear();
                        gstin.Clear();
                        tb_Email_Id.Clear();
                        tb_Mobile_No.Clear();
                        tb_Alternate_No.Clear();
                        tb_Distributer_Address.Clear();
                        conn.Open();
                        string y = "";
                        string p = "SELECT * FROM add_distributor";
                        cmd = new OleDbCommand(p, conn);
                        OleDbDataReader d = cmd.ExecuteReader();
                        while (d.Read())
                        {
                            y = d["distributor_id"].ToString();

                        }
                        int z = Convert.ToInt32(y) + 1;
                        Distributer_Id.Text = z.ToString();
                        conn.Close();
                    }
                }
                conn.Close();
            }
        }

        private void tb_Mobile_No_Leave(object sender, EventArgs e)
        {
        }

        private void tb_Alternate_No_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_Alternate_No_Leave(object sender, EventArgs e)
        {
        }

        private void tb_Email_Id_TextChanged(object sender, EventArgs e)
        {

        }

        private void Date_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Distributer_Id_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Distributer_Id_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void Distributer_Id_Leave(object sender, EventArgs e)
        {
            conn.Close();
            conn.Open();
            string idv = "SELECT * FROM add_distributor WHERE distributor_id='" + Distributer_Id.Text + "'";
            cmd = new OleDbCommand(idv, conn);
            OleDbDataReader dr = cmd.ExecuteReader();

            if (dr.Read() == true)
            {
                MessageBox.Show("Distributor ID already Registered");
                Distributer_Id.Clear();

            }

            conn.Close();
        }

        private void tb_Distributer_Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_Distributer_Name_Leave(object sender, EventArgs e)
        {
            conn.Close();
            conn.Open();
            string idv = "SELECT * FROM add_distributor WHERE distributor_name='" + tb_Distributer_Name.Text + "'";
            cmd = new OleDbCommand(idv, conn);
            OleDbDataReader dr = cmd.ExecuteReader();

            if (dr.Read() == true)
            {
                MessageBox.Show("Distributor Name already Registered");
                Distributer_Id.Clear();

            }

            conn.Close();
        }
    }
}
