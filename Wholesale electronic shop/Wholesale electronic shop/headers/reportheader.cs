using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wholesale_electronic_shop
{
    public partial class reportheader : Form
    {
        public reportheader()
        {
            InitializeComponent();
        }

        private void searchdistributor_Click(object sender, EventArgs e)
        {
            var PanelContainer = this.Parent as Panel;
            var Home = PanelContainer.TopLevelControl as Home;
            Home.panel1.Controls.Clear();
            distributorbill obj1 = new distributorbill();
            obj1.TopLevel = false;
            Home.panel1.Controls.Add(obj1);
            obj1.Show();
        }

        private void Adddistributor_Click(object sender, EventArgs e)
        {

            var PanelContainer = this.Parent as Panel;
            var Home = PanelContainer.TopLevelControl as Home;
            Home.panel1.Controls.Clear();
            retailerbill obj1 = new retailerbill();
            obj1.TopLevel = false;
            Home.panel1.Controls.Add(obj1);
            obj1.Show();

        }

        private void deletedistributor_Click(object sender, EventArgs e)
        {
            var PanelContainer = this.Parent as Panel;
            var Home = PanelContainer.TopLevelControl as Home;
            Home.panel1.Controls.Clear();
            DistributorReport obj1 = new DistributorReport();
            obj1.TopLevel = false;
            Home.panel1.Controls.Add(obj1);
            obj1.Show();

        }

        private void updatedistributor_Click(object sender, EventArgs e)
        {
            var PanelContainer = this.Parent as Panel;
            var Home = PanelContainer.TopLevelControl as Home;
            Home.panel1.Controls.Clear();
            RetailerReport obj1 = new RetailerReport();
            obj1.TopLevel = false;
            Home.panel1.Controls.Add(obj1);
            obj1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var PanelContainer = this.Parent as Panel;
            var Home = PanelContainer.TopLevelControl as Home;
            Home.panel1.Controls.Clear();
            Product_Report obj1 = new Product_Report();
            obj1.TopLevel = false;
            Home.panel1.Controls.Add(obj1);
            obj1.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var PanelContainer = this.Parent as Panel;
            var Home = PanelContainer.TopLevelControl as Home;
            Home.panel1.Controls.Clear();
            Distributor_Bill_Report obj1 = new Distributor_Bill_Report();
            obj1.TopLevel = false;
            Home.panel1.Controls.Add(obj1);
            obj1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var PanelContainer = this.Parent as Panel;
            var Home = PanelContainer.TopLevelControl as Home;
            Home.panel1.Controls.Clear();
            Retailer_Bill_Report obj1 = new Retailer_Bill_Report();
            obj1.TopLevel = false;
            Home.panel1.Controls.Add(obj1);
            obj1.Show();
        }
    }
}
