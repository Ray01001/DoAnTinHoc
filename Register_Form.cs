using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hệ_Thống_Quản_Lý_Thông_Tin_Game
{
    public partial class Register_Form : Form
    {
        public Register_Form()
        {
            InitializeComponent();
        }
        //tab đăng ký
        private void btnDangKy_Click(object sender, EventArgs e)
        {
            string username = txtTenDK.Text.Trim();
            string password = txtMKDK.Text.Trim();
            string confirmP = txtCMK.Text.Trim();
            string role = rdoAdmin.Checked ? "Admin" : "User";

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.");
                return;
            }
            if(password != confirmP)
            {
                MessageBox.Show("Mật khẩu xác nhận không khớp!");
                return;
            }
            // Lưu thông tin đăng ký vào file users.txt
            using (StreamWriter sw = new StreamWriter("users.txt", true))
            {
                sw.WriteLine($"{username}|{password}|{role}");
            }

            MessageBox.Show("Đăng ký thành công!");
            // chuyển sang tab login
            tabControl1.SelectedTab = tbLogin;
        }
        //tab đăng nhập
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string username = txtTenDN.Text.Trim();
            string password = txtMKDN.Text.Trim();
            string role = rdoLAdmin.Checked ? "Admin" : "User";

            bool isValid = false;
            // Đọc thông tin từ file users.txt để kiểm tra đăng nhập
            if(File.Exists("users.txt"))
            {
                var lines = File.ReadAllLines("users.txt");
                foreach(var line in lines)
                {
                    var parts = line.Split('|');
                    if(parts.Length == 3)
                    {
                        if(parts[0] == username && parts[1] == password && parts[2] == role)
                        {
                            isValid = true;
                            break;
                        }
                    }
                }
            }
            if(isValid)
            {
                MessageBox.Show("Đăng nhập thành công!");
                this.Hide();
                if(role== "Admin")
            {
                    // mở form quản lý thông tin game
                Hệ_Thống_Quản_Lý_Thông_Tin_Game adminForm = new Hệ_Thống_Quản_Lý_Thông_Tin_Game();
                adminForm.ShowDialog();
            }
            else
            {
                //// mở form user
                //UserForm userForm = new User_Form();
                //userForm.ShowDialog();
            }
                this.Close();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại! Vui lòng kiểm tra lại thông tin.");
            }
        }
    }
}
