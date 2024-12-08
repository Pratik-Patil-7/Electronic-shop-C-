using System;
using System.Windows.Forms;

namespace Wholesale_electronic_shop
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
              Password.UseSystemPasswordChar = false;

            }
            else { Password.UseSystemPasswordChar = true;
            }
        }

        private void login1_Click(object sender, EventArgs e)
        {
            string pass = "admin@123";
            if(Password.Text==pass)
            {
                new Home().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Password is Wrong");
                Password.Clear();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
