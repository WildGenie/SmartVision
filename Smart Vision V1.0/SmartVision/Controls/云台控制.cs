using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace IPCamera
{
    public partial class PTZControl : UserControl
    {
        private CameraCGI camCGI = new CameraCGI();

        // CGI接口，用于连接摄像头
        public CameraCGI CamCGI
        {
            get { return camCGI; }
            set { camCGI = value; }
        }

        public PTZControl()
        {
            InitializeComponent();
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            camCGI.control_Up();
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            camCGI.control_Down();
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            camCGI.control_Left();
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            camCGI.control_Right();
        }

    }
}
