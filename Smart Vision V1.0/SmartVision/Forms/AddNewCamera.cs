using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IPCamera
{
    public partial class AddNewCamera : NewTemplateWizard
    {
        private Camera camera = new Camera("");
        private CameraDescription page1 = new CameraDescription();
        private CameraConfing page2 = new CameraConfing();

        public AddNewCamera()
        {
            this.AddPage(page1);
            this.AddPage(page2);
            this.Text = "摄像头添加向导";

            page1.Camera = camera;
            page2.Camera = camera;
        }

        // 视频提供商 属性
        public VideoProviderCollection VideoProviders
        {
            set { page1.VideoProviders = value; }
        }

        // 视频 属性
        public Camera Camera
        {
            get { return camera; }
            set
            {
                camera = value;

                page1.Camera = camera;
                page2.Camera = camera;
            }
        }

        // CheckCameraFunction property
        public CheckCameraHandler CheckCameraFunction
        {
            set { page1.CheckCameraFunction = value; }
        }

        // On page changing
        protected override void OnPageChanging(int page)
        {
            if (page == 1)
            {
                // switching to camera settings
                page2.Provider = page1.VideoProviders[page1.SelectedProviderIndex];
            }
            base.OnPageChanging(page);
        }

        // Reset event ocuren on page
        protected override void OnResetOnPage(int page)
        {
            if (page == 1)
            {
                page2.Provider = null;
            }
        }

        //// On finish
        //protected override void OnFinish()
        //{
        //}
    }
}
