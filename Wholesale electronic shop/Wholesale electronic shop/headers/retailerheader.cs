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
    public partial class retailerheader : Form
    {
        public retailerheader()
        {
            InitializeComponent();
        }

        private void searchdistributor_Click(object sender, EventArgs e)
        {
            var PanelContainer = this.Parent as Panel;
            var Home = PanelContainer.TopLevelControl as Home;
            Home.panel1.Controls.Clear();
            searchretailer obj1 = new searchretailer();
            obj1.TopLevel = false;
            Home.panel1.Controls.Add(obj1);
            obj1.Show();
        }

        private void Adddistributor_Click(object sender, EventArgs e)
        {
            var PanelContainer = this.Parent as Panel;
            var Home = PanelContainer.TopLevelControl as Home;
            Home.panel1.Controls.Clear();
            addretailer obj1 = new addretailer();
            obj1.TopLevel = false;
            Home.panel1.Controls.Add(obj1);
            obj1.Show();
        }

        private void updateretailer_Click(object sender, EventArgs e)
        {
            var PanelContainer = this.Parent as Panel;
            var Home = PanelContainer.TopLevelControl as Home;
            Home.panel1.Controls.Clear();
            updateretailer obj1 = new updateretailer();
            obj1.TopLevel = false;
            Home.panel1.Controls.Add(obj1);
            obj1.Show();
        }

        private void deleteretailer_Click(object sender, EventArgs e)
        {
            var PanelContainer = this.Parent as Panel;
            var Home = PanelContainer.TopLevelControl as Home;
            Home.panel1.Controls.Clear();
           deleteretailer obj1 = new deleteretailer();
            obj1.TopLevel = false;
            Home.panel1.Controls.Add(obj1);
            obj1.Show();
        }
    }
}
