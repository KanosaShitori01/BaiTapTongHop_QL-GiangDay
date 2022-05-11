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
    public partial class DSGV : Form
    {
        CurrencyManager manager;
        public void activeData()
        {
            DataTable dt = TasmaMain.LietKeDuLieu("GIANGVIEN", kn.ketnoi);
            foreach(Control ctr in Controls)
            {
                if (ctr is TextBox || ctr is DateTimePicker)
                {
                    ctr.Text = "";
                    ctr.DataBindings.Clear();
                }
            }
            txt_magv.DataBindings.Add("Text", dt, "MaGV");
            txt_hodem.DataBindings.Add("Text", dt, "HoDem");
            txt_tengv.DataBindings.Add("Text", dt, "TenGV");
            txt_dienthoai.DataBindings.Add("Text", dt, "DienThoai");
            dtp_ngaysinh.DataBindings.Add("Value", dt, "NgaySinh");
            txt_hocvi.DataBindings.Add("Text", dt, "HocVi");
            txt_sogiochuan.DataBindings.Add("Text", dt, "SoGioChuan");
            txt_hsluong.DataBindings.Add("Text", dt, "HSLuong");
            txt_makhoa.DataBindings.Add("Text", dt, "MaKhoa");
            cb_makhoa.DataSource = TasmaMain.LietKeDuLieu("KHOA", kn.ketnoi);
            cb_makhoa.DisplayMember = "MAKHOA";
            cb_makhoa.ValueMember = "MAKHOA";
            manager = (CurrencyManager)this.BindingContext[dt];
            txt_page.Text = String.Format("{0}/{1}", manager.Position + 1, manager.Count); 
        }
        public void capnhat()
        {
            Dictionary<string, object> dl = new Dictionary<string, object>();
            dl.Add("HoDem", txt_hodem.Text);
            dl.Add("TenGV", txt_tengv.Text);
            dl.Add("DienThoai", txt_dienthoai.Text);
            dl.Add("NgaySinh", TasmaMain.StrangeDate(dtp_ngaysinh.Text));
            dl.Add("HocVi", txt_hocvi.Text);
            dl.Add("SoGioChuan", txt_sogiochuan.Text);
            dl.Add("HSLuong", txt_hsluong.Text);
            dl.Add("MaKhoa", cb_makhoa.Text.Trim());
            //MessageBox.Show(TasmaMain.SuaDuLieu("GIANGVIEN", dl, "MaGV", txt_magv.Text, kn.ketnoi));
            if (TasmaMain.SuaDuLieu("GIANGVIEN", dl, "MaGV", txt_magv.Text, kn.ketnoi))
            {
                MessageBox.Show("Đã Cập Nhật Thành Công Thông Tin Giảng Viên " +
                    (txt_hodem.Text + " " + txt_tengv.Text));
                btn_luu.Enabled = false;
                btn_themmt.Enabled = true;
                btn_capnhat.Enabled = true;
                txt_makhoa.Visible = true;
                cb_makhoa.Visible = false;
                activeData();
            }
            else MessageBox.Show("Vui lòng kiểm tra lại thông tin vừa nhập.");
        }
        public void themMT()
        {
            Dictionary<string, object> dl = new Dictionary<string, object>();
            dl.Add("MaGV", txt_magv.Text);
            dl.Add("HoDem", txt_hodem.Text);
            dl.Add("TenGV", txt_tengv.Text);
            dl.Add("DienThoai", txt_dienthoai.Text);
            dl.Add("NgaySinh", TasmaMain.StrangeDate(dtp_ngaysinh.Text));
            dl.Add("HocVi", txt_hocvi.Text);
            dl.Add("SoGioChuan", txt_sogiochuan.Text);
            dl.Add("HSLuong", txt_hsluong.Text);
            dl.Add("MaKhoa", cb_makhoa.Text.Trim());
            if (TasmaMain.ThemDuLieu("GIANGVIEN", dl, kn.ketnoi))
            {
                MessageBox.Show("Đã Thêm Thành Công Giảng Viên " +
                    (txt_hodem.Text + " " + txt_tengv.Text));
                btn_luu.Enabled = false;
                btn_themmt.Text = "Thêm MT";
                activeData();
            }
            else MessageBox.Show("Vui lòng kiểm tra lại thông tin vừa nhập.");
        }
        public void CheckSession()
        {
            btn_themmt.Enabled = TasmaMain.SESSION;
            btn_capnhat.Enabled = TasmaMain.SESSION;
            btn_luu.Enabled = TasmaMain.SESSION;
        }
        public DSGV()
        {
            InitializeComponent();
        }

        private void DSGV_Load(object sender, EventArgs e)
        {
            activeData();
            CheckSession();
        }
       
        private void btn_themmt_Click(object sender, EventArgs e)
        {
            if(btn_themmt.Text == "Thêm MT")
            {
                foreach (Control ctr in Controls)
                {
                    if (ctr is TextBox && ctr.Name != "txt_magv" || ctr is DateTimePicker)
                    {
                        ctr.Text = "";
                    }
                }
                btn_luu.Enabled = true;
                btn_luu.TabIndex = 2;
                txt_magv.Text = "GV" + Convert.ToInt32(
                    TasmaMain.LietKeDuLieu("GIANGVIEN", kn.ketnoi).Rows.Count + 1);
                txt_makhoa.Visible = false;
                cb_makhoa.Visible = true;
                btn_themmt.Text = "Hủy";
                btn_capnhat.Enabled = false;
            }
            else
            {
                txt_makhoa.Visible = true;
                cb_makhoa.Visible = false;
                btn_capnhat.Enabled = true;
                btn_themmt.Text = "Thêm MT";
                btn_luu.Enabled = false;
                activeData();
            }
        }

        private void btn_phai_Click(object sender, EventArgs e)
        {
            manager.Position++;
            txt_page.Text = String.Format("{0}/{1}", manager.Position + 1, manager.Count);
        }

        private void btn_vephai_Click(object sender, EventArgs e)
        {
            manager.Position = manager.Count;
            txt_page.Text = String.Format("{0}/{1}", manager.Position + 1, manager.Count);
        }

        private void btn_trai_Click(object sender, EventArgs e)
        {
            manager.Position--;
            txt_page.Text = String.Format("{0}/{1}", manager.Position + 1, manager.Count);
        }

        private void btn_vetrai_Click(object sender, EventArgs e)
        {
            manager.Position = 0;
            txt_page.Text = String.Format("{0}/{1}", manager.Position + 1, manager.Count);
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main main = new Main();
            main.Show();
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            if (btn_luu.TabIndex == 2)
            {
                themMT();
            }
            else { capnhat(); }
        }

        private void btn_capnhat_Click(object sender, EventArgs e)
        {
            cb_makhoa.Visible = true;
            cb_makhoa.SelectedValue = txt_makhoa.Text;
            txt_makhoa.Visible = false;
            btn_capnhat.Enabled = false;
            btn_themmt.Enabled = false;
            btn_luu.Enabled = true;
            btn_luu.TabIndex = 1;
        }

        private void cb_makhoa_TextUpdate(object sender, EventArgs e)
        {
            cb_makhoa.DataSource = TasmaMain.LietKeDuLieu("KHOA", kn.ketnoi);
            cb_makhoa.DisplayMember = "MAKHOA";
            cb_makhoa.ValueMember = "MAKHOA";
        }

        private void txt_makhoa_TextChanged(object sender, EventArgs e)
        {

        }

        private void DSGV_FormClosed(object sender, FormClosedEventArgs e)
        {
            Main main = new Main();
            main.Show();
        }
    }
}
