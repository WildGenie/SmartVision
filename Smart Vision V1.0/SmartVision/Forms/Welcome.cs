using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IPCamera
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
          
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity > 0.1)
            {
                this.Opacity = this.Opacity - 0.01;
            }
            else
            {
                this.Close();
            }
        }
    }
}