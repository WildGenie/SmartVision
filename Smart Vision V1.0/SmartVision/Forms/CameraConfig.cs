using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IPCamera
{
    public partial class CameraConfig : ConfigTemplate
    {
        private Camera camera = new Camera("");
        private CameraDescription page1 = new CameraDescription();
        private CameraConfing page2 = new CameraConfing();

        public CameraConfig()
        {
            this.AddPage(page1);
            this.AddPage(page2);
            this.Text = "配置摄像头";

            page1.Camera = camera;
            page2.Camera = camera;
        }

		// 获取视频提供商
		public VideoProviderCollection VideoProviders
		{
			set { page1.VideoProviders = value; }
		}

		// 获取摄像头
		public Camera Camera
		{
			get { return camera; }
			set
			{
                try 
                {
                    camera = value;
                    page1.Camera = camera;
				    page2.Camera = camera;
				    page2.Provider = camera.Provider;
                }
                catch(System.Exception )
                {
                }

			}
		}

		public CheckCameraHandler CheckCameraFunction
		{
			set { page1.CheckCameraFunction = value; }
		}
    }
}
