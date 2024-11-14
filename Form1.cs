using Microsoft.VisualBasic;
using System;
using System.Windows.Forms;

namespace Pipes_POS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            splashtimer.Start();

        }

        private void splashtimer_Tick(object sender, EventArgs e)
        {

            if (splashprogressBar.Value < splashprogressBar.Maximum) {

                splashprogressBar.Value += 5;
            
            }

            else
            {
                splashtimer.Stop();
                OpenNewForm();
            }


        }

        private void OpenNewForm()
        {
            // Get the primary screen's resolution
            int screenWidth = Screen.PrimaryScreen.Bounds.Width;
            int screenHeight = Screen.PrimaryScreen.Bounds.Height;

            if (screenWidth == 1920 && screenHeight == 1080)
            {

                formLogin_1920 newform = new formLogin_1920();
                newform.Show();
                FormWindowState FormWindowState = FormWindowState.Minimized;
            }

            else if (screenWidth == 1366 && screenHeight == 768)
            {

                formLogin_1366 newform = new formLogin_1366();
                newform.Show();
                FormWindowState FormWindowState = FormWindowState.Minimized;
            }

            else
            {
                MessageBox.Show("Screen resolution not supported");
            }
        }
    }

    
}
