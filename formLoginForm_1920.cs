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
    public partial class formLoginForm_1920 : UserControl
    {
                

        public formLoginForm_1920()
        {
            InitializeComponent();

            
        }


        private void btnSignIn_Click(object sender, EventArgs e)
        {
                        
            formMenu_1920 formMenu_1920 = new formMenu_1920();
            formLogin_1920 formLogin_1920 = new formLogin_1920();

            formMenu_1920.ShowDialog();
            formLogin_1920.Close();
            
        }
    }
}
