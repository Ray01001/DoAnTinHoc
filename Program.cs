using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hệ_Thống_Quản_Lý_Thông_Tin_Game
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Hệ_Thống_Quản_Lý_Thông_Tin_Game());

            //Khởi động với form đăng ký/đăng nhập trước
            Application.Run(new Register_Form());
        }
    }
}
