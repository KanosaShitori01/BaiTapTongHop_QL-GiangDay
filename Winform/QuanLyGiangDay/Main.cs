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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void dăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(dăngNhậpToolStripMenuItem.Text == "Đăng Nhập")
            {
                Login LG = new Login();
                this.Hide();
                LG.Show();
            }
            else
            {
                TasmaMain.SESSION = false;
                reloadMain();
            }
        }

        private void giáoViênTheoKhoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            THTK THtk = new THTK();
            this.Hide();
            THtk.Show();
        }

        private void nhậpDanhSáchGVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DSGV dsgv = new DSGV();
            this.Hide();
            dsgv.Show();
        }
        public void reloadMain()
        {
            if (TasmaMain.SESSION)
            {
                dăngNhậpToolStripMenuItem.Text = "Đăng Xuất";
            }
            else dăngNhậpToolStripMenuItem.Text = "Đăng Nhập";
        }
        private void Main_Load(object sender, EventArgs e)
        {
            reloadMain();
            nhậpDữLiệuToolStripMenuItem.Enabled = TasmaMain.SESSION;
            thốngKêToolStripMenuItem.Enabled = TasmaMain.SESSION;
        }

        private void nhậpDữLiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void thốngKêGiờDạyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TKGD tkgd = new TKGD();
            this.Hide();
            tkgd.Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
