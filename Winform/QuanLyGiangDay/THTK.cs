using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TasmaControl;
namespace QuanLyGiangDay
{
    public partial class THTK : Form
    {
        public THTK()
        {
            InitializeComponent();
        }
        public void activeData()
        {
            DataSet ds = TasmaMain.LKDuLieu_Set("KHOA", kn.ketnoi);
            BindingSource bs = new BindingSource();
            bs.DataSource = ds.Tables[0].DefaultView;
            bindingNav.BindingSource = bs;
            dataGV_khoa.DataSource = bs;
        }
        public void activeDataU()
        {
            DataTable dt = TasmaMain.LietKeDuLieu
                ("GIANGVIEN", "MaKhoa", dataGV_khoa.CurrentRow.Cells[0].Value, kn.ketnoi);
            dataGV_gv.DataSource = dt;
        }
        private void THTK_Load(object sender, EventArgs e)
        {
            activeData();
        }
        private void dataGV_khoa_SelectionChanged(object sender, EventArgs e)
        {
            activeDataU();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main main = new Main();
            main.Show();
        }

        private void THTK_FormClosed(object sender, FormClosedEventArgs e)
        {
            Main main = new Main();
            main.Show();
        }
    }
}
