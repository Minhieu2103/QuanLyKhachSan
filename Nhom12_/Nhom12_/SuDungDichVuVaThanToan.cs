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
    public partial class SuDungDichVuVaThanToan : Form
    {
        string queryDV1 = "select DISTINCT LoaiDichVu from DichVu";
        string HoTenNhanVien = "";
        public SuDungDichVuVaThanToan(string HoTen)
        {
            InitializeComponent();
            this.HoTenNhanVien = HoTen;
        }
        ClassLogin.Modify modify = new ClassLogin.Modify();

        private void btnThemDV_Click(object sender, EventArgs e)
        {

        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {

        }

        private void btnXoaDV_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
