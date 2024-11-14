using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pipes_POS
{
    public partial class formMenu_1920 : Form
    {
        public formMenu_1920()
        {
            InitializeComponent();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {

            formDashboard1.BringToFront();
        }

        private void btnSales_Click(object sender, EventArgs e)
        {

            formSales1.BringToFront();

        }

        private void btnStockManagement_Click(object sender, EventArgs e)
        {

            formStockManagement1.BringToFront();

        }

        private void btnReports_Click(object sender, EventArgs e)
        {

            formReports1.BringToFront();

        }

        private void btnUserManagement_Click(object sender, EventArgs e)
        {

            formUserManagement1.BringToFront();
            
        }
    }
}
