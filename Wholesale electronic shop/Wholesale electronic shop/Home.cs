using System;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace Wholesale_electronic_shop
{
    public partial class Home : Form
    {      
        public Home()
        {
            InitializeComponent();
        
         
            
        }
       
       

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Product_Click(object sender, EventArgs e)
        {
            header.Controls.Clear();
            panel1.Controls.Clear();
            productheader obj1 = new productheader();
            obj1.TopLevel = false;
            header.Controls.Add(obj1);
            obj1.Show();
        }

        private void panel3_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void SlideBarTimer_Tick(object sender, EventArgs e)
        {

        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void Category_MouseEnter(object sender, EventArgs e)
        {
            this.Category.BackColor = ColorTranslator.FromHtml("#B4B4B4");
            this.Category.ForeColor = Color.Black;
            
        }

        private void Category_MouseLeave(object sender, EventArgs e)
        {
            this.Category.ForeColor = Color.White;
            this.Category.BackColor = Color.Black;
        }

        private void Distributor_MouseEnter(object sender, EventArgs e)
        {
            this.Distributor.BackColor = ColorTranslator.FromHtml("#B4B4B4");
            this.Distributor.ForeColor = Color.Black;
        }

        private void Distributor_MouseLeave(object sender, EventArgs e)
        {
            this.Distributor.ForeColor = Color.White;
            this.Distributor.BackColor = Color.Black;
        }

        private void Product_MouseEnter(object sender, EventArgs e)
        {
            this.Product.BackColor = ColorTranslator.FromHtml("#B4B4B4");
            this.Product.ForeColor = Color.Black;
        }

        private void Product_MouseLeave(object sender, EventArgs e)
        {
            this.Product.ForeColor = Color.White;
            this.Product.BackColor = Color.Black;
        }

        private void Retailer_MouseEnter(object sender, EventArgs e)
        {
            this.Retailer.BackColor = ColorTranslator.FromHtml("#B4B4B4");
            this.Retailer.ForeColor = Color.Black;
        }

        private void Retailer_MouseLeave(object sender, EventArgs e)
        {
            this.Retailer.ForeColor = Color.White;
            this.Retailer.BackColor = Color.Black;
        }

        private void Report_MouseEnter(object sender, EventArgs e)
        {
            this.Report.BackColor = ColorTranslator.FromHtml("#B4B4B4");
            this.Report.ForeColor = Color.Black;
        }

        private void Report_MouseLeave(object sender, EventArgs e)
        {
            this.Report.ForeColor = Color.White;
            this.Report.BackColor = Color.Black;
        }

        private void Category_Click(object sender, EventArgs e)
        {
            header.Controls.Clear();
            panel1.Controls.Clear();
            categoryheader obj1 = new categoryheader();
            obj1.TopLevel = false;
            header.Controls.Add(obj1);
            obj1.Show();
        }

        private void Distributor_Click(object sender, EventArgs e)
        {
            header.Controls.Clear();
            panel1.Controls.Clear();
            distributorheader obj1 = new distributorheader();
            obj1.TopLevel = false;
            header.Controls.Add(obj1);
            obj1.Show();

        }

        private void Retailer_Click(object sender, EventArgs e)
        {
            header.Controls.Clear();
            panel1.Controls.Clear();
            retailerheader obj1 = new retailerheader();
            obj1.TopLevel = false;
            header.Controls.Add(obj1);
            obj1.Show();
        }

        private void Report_Click(object sender, EventArgs e)
        {
            header.Controls.Clear();
            panel1.Controls.Clear();
          reportheader obj1 = new reportheader();
            obj1.TopLevel = false;
            header.Controls.Add(obj1);
            obj1.Show();
        }

        private void header_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
