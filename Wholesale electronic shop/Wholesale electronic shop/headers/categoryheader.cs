using System;
using System.Windows.Forms;

namespace Wholesale_electronic_shop
{

    public partial class categoryheader : Form
    {
     
        public categoryheader()
        {
        
            InitializeComponent();
            
        }

        private void addcategory_Click(object sender, EventArgs e)
        {
           
            var PanelContainer = this.Parent as Panel;
            var Home = PanelContainer.TopLevelControl as Home;
            Home.panel1.Controls.Clear();
            addcategoryitem obj1 = new addcategoryitem();
            obj1.TopLevel = false;
            Home.panel1.Controls.Add(obj1);
            obj1.Show();

        }

        private void addcategory_MouseLeave(object sender, EventArgs e)
        {

        }

        private void Addsubc_Click(object sender, EventArgs e)
        {
           
            var PanelContainer = this.Parent as Panel;
            var Home = PanelContainer.TopLevelControl as Home;
            subcategory obj1 = new subcategory();
            Home.panel1.Controls.Clear();
            obj1.TopLevel = false;
           Home.panel1.Controls.Add(obj1);
            obj1.Show();
        }

        private void retailerorder_Click(object sender, EventArgs e)
        {
            var PanelContainer = this.Parent as Panel;
            var Home = PanelContainer.TopLevelControl as Home;
            retailerorder obj1 = new retailerorder();
            Home.panel1.Controls.Clear();
            obj1.TopLevel = false;
            Home.panel1.Controls.Add(obj1);
            obj1.Show();
        }

        private void addstock_Click(object sender, EventArgs e)
        {
            var PanelContainer = this.Parent as Panel;
            var Home = PanelContainer.TopLevelControl as Home;
            addstock obj1 = new addstock();
            Home.panel1.Controls.Clear();
            obj1.TopLevel = false;
            Home.panel1.Controls.Add(obj1);
            obj1.Show();
        }
    }
}
