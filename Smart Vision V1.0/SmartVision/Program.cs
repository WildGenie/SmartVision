using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace IPCamera
{
    static class Program
    {
        public static bool Login = false;
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Welcome myWelcomeForm = new Welcome();
            myWelcomeForm.ShowDialog();
            LoginForm deLu = new LoginForm();
            deLu.ShowDialog();
            if (Login == true)
            {
                Application.Run(new IPCamera.SmartVision());
            } 
        }
    }
}
