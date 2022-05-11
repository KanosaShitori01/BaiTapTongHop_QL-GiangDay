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
    public partial class TKGD : Form
    {
        public TKGD()
        {
            InitializeComponent();
        }
        public void activeTSG()
        {
            int tsg = 0;
            for(int i = 0; i < dataGV_gd.Rows.Count; i++)
            {
                tsg += Convert.ToInt32(dataGV_gd.Rows[i].Cells["SoTiet"].Value.ToString());
            }
            lb_tsg.Text = tsg.ToString();
        }
        public void activeData()
        {
            DataTable dt = TasmaMain.LietKeTuDo("SELECT (HoDem + ' ' + TenGV) AS " +
                "Hoten, MaGV FROM GIANGVIEN", kn.ketnoi);
            cb_giangvien.DataSource = dt;
            cb_giangvien.DisplayMember = "Hoten";
            cb_giangvien.ValueMember = "MaGV";
            activeDataGV();
        }
        public void activeDataGV()
        {
            dataGV_gd.DataSource = TasmaMain.LietKeTuDo(
                String.Format("LK_GIODAY '{0}'", cb_giangvien.SelectedValue), kn.ketnoi);
            activeTSG();
        }
        private void TKGD_Load(object sender, EventArgs e)
        {
            activeData();          
        }

        private void cb_giangvien_SelectedIndexChanged(object sender, EventArgs e)
        {
            activeDataGV();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            this.Hide();
            main.Show();
        }

        private void cb_giangvien_TextUpdate(object sender, EventArgs e)
        {
            activeData();
        }

        private void lb_tsg_Click(object sender, EventArgs e)
        {

        }

        private void TKGD_FormClosed(object sender, FormClosedEventArgs e)
        {
            Main main = new Main();
            main.Show();
        }
    }
}
