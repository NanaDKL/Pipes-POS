﻿using System;
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
    public partial class formBanner_1920 : UserControl
    {
        public formBanner_1920()
        {
            InitializeComponent();
        }

        private void pbClose_Click(object sender, EventArgs e)
        {

            Application.Exit();

        }
    }
}
