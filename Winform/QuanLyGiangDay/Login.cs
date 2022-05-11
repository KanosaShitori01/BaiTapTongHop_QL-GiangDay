using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using TasmaControl;
namespace QuanLyGiangDay
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        public void DangNhap()
        {
            Dictionary<string, object> dl = new Dictionary<string, object>();
            dl.Add("TENND", txt_tentk.Text);
            dl.Add("MATKHAU", txt_mk.Text);
            bool checkDN = TasmaMain.XLDangNhap("TAIKHOAN", dl, kn.ketnoi);
            if (checkDN)
            {
                MessageBox.Show("Đăng Nhập Thành Công");
                TasmaMain.SESSION = true;
                this.Hide();
                Main main = new Main();
                main.Show();
            }
            else MessageBox.Show("Sai Tên Đăng Nhập Hoặc Mật Khẩu");
        }
        private void Login_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            DangNhap();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main main = new Main();
            main.Show();
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Main main = new Main();
            main.Show();
        }
    }
}
