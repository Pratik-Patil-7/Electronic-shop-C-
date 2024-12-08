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
    public partial class productheader : Form
    {
        public productheader()
        {
            InitializeComponent();
        }

        private void Viewproduct_Click(object sender, EventArgs e)
        {

            var PanelContainer = this.Parent as Panel;
            var Home = PanelContainer.TopLevelControl as Home;
            Home.panel1.Controls.Clear();
            addproduct obj1 = new addproduct();
            obj1.TopLevel = false;
            Home.panel1.Controls.Add(obj1);
            obj1.Show();
        }

        private void searchproduct_Click(object sender, EventArgs e)
        {
            var PanelContainer = this.Parent as Panel;
            var Home = PanelContainer.TopLevelControl as Home;
            Home.panel1.Controls.Clear();
            searchproduct obj1 = new searchproduct();
            obj1.TopLevel = false;
            Home.panel1.Controls.Add(obj1);
            obj1.Show();
        }

        private void updateproduct_Click(object sender, EventArgs e)
        {
            var PanelContainer = this.Parent as Panel;
            var Home = PanelContainer.TopLevelControl as Home;
            Home.panel1.Controls.Clear();
            updateproduct obj1 = new updateproduct();
            obj1.TopLevel = false;
            Home.panel1.Controls.Add(obj1);
            obj1.Show();
        }

        private void deleteproduct_Click(object sender, EventArgs e)
        {
           var PanelContainer = this.Parent as Panel;
            var Home = PanelContainer.TopLevelControl as Home;
            Home.panel1.Controls.Clear();
            deleteproduct obj1 = new deleteproduct();
            obj1.TopLevel = false;
            Home.panel1.Controls.Add(obj1);
            obj1.Show();
        }

        private void productheader_Load(object sender, EventArgs e)
        {

        }
    }
}
