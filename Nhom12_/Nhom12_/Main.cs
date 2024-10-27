using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhom12_
{
    public partial class Main : Form
    {
        bool hiden = true;
        int pw;
        public Main()
        {
            InitializeComponent();
            pw = panelSlider.Width;
        }

        private void btnSlider_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
        private void btnDatPhong_Click(object sender, EventArgs e)
        {
            DatPhong dp = new DatPhong();
            dp.ShowDialog();
            this.Hide();
        }
        private void btnNhanPhong_Click(object sender, EventArgs e)
        {
            NhanPhong np = new NhanPhong();
            np.ShowDialog();
        }
        private void btnSDDVTT_Click(object sender, EventArgs e)
        {    
        }
        private void btnThongKe_Click(object sender, EventArgs e)
        {
            ThongKe tk = new ThongKe();
            tk.ShowDialog();
        }

        private void btnQuanLiPhong_Click(object sender, EventArgs e)
        {
            QuanLyPhong qlp = new QuanLyPhong();
            qlp.ShowDialog();
        }

        private void btnQuanLiNV_Click(object sender, EventArgs e)
        {
            QuanLyNhanVien qlnv = new QuanLyNhanVien();
            qlnv.ShowDialog();
        }

        private void btnQLHoaDon_Click(object sender, EventArgs e)
        {
            QuanLyHoaDon QLHD = new QuanLyHoaDon();
            QLHD.ShowDialog();
        }

        private void btnQLDichVu_Click(object sender, EventArgs e)
        {
            QuanLyDichVu s = new QuanLyDichVu();
            s.ShowDialog();
        }

        private void btnQuyDinh_Click(object sender, EventArgs e)
        {
            QuyDinh qd = new QuyDinh();
            qd.ShowDialog();
        }

        private void btnSubAbout_Click(object sender, EventArgs e)
        {

        }

        private void btnSubHelp_Click(object sender, EventArgs e)
        {

        }

        private void btnAbout_Click(object sender, EventArgs e)
        {

        }

        private void btnHelp_Click(object sender, EventArgs e)
        {

        }

        private void btnSubAccount_Click(object sender, EventArgs e)
        {

        }

        private void btnUser_Click(object sender, EventArgs e)
        {

        }

        private void btnSubLogOut_Click(object sender, EventArgs e)
        {

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (hiden)
            {
                panelSlider.Width = panelSlider.Width + 10;
                if (panelSlider.Width >= pw)
                {
                    timer1.Stop();
                    hiden = false;
                    this.Refresh();
                }
            }
            else
            {
                panelSlider.Width = panelSlider.Width - 10;
                if (panelSlider.Width <= 0)
                {
                    timer1.Stop();
                    hiden = true;
                    this.Refresh();
                }
            }

        }
    }
}
