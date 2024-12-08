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
    public partial class distributorheader : Form
    {
        public distributorheader()
        {
            InitializeComponent();
        }

        private void Adddistributor_Click(object sender, EventArgs e)
        {
            var PanelContainer = this.Parent as Panel;
            var Home = PanelContainer.TopLevelControl as Home;
            Home.panel1.Controls.Clear();
            adddistributor obj1 = new adddistributor();
            obj1.TopLevel = false;
            Home.panel1.Controls.Add(obj1);
            obj1.Show();
        }

        private void searchdistributor_Click(object sender, EventArgs e)
        {

            var PanelContainer = this.Parent as Panel;
            var Home = PanelContainer.TopLevelControl as Home;
            Home.panel1.Controls.Clear();
            searchdistributor obj1 = new searchdistributor();
            obj1.TopLevel = false;
            Home.panel1.Controls.Add(obj1);
            obj1.Show();

        }

        private void updatedistributor_Click(object sender, EventArgs e)
        {
            var PanelContainer = this.Parent as Panel;
            var Home = PanelContainer.TopLevelControl as Home;
            Home.panel1.Controls.Clear();
            updatedistributor obj1 = new updatedistributor();
            obj1.TopLevel = false;
            Home.panel1.Controls.Add(obj1);
            obj1.Show();
        }

        private void deletedistributor_Click(object sender, EventArgs e)
        {

            var PanelContainer = this.Parent as Panel;
            var Home = PanelContainer.TopLevelControl as Home;
            Home.panel1.Controls.Clear();
            deletedistributor obj1 = new deletedistributor();
            obj1.TopLevel = false;
            Home.panel1.Controls.Add(obj1);
            obj1.Show();
        }
    }
}
