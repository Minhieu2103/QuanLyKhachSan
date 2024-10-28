using Nhom12_.ClassLogin;
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
    public partial class ThongTinTaiKhoan: Form
    {
        private string tenTaiKhoan = "";
       Modify  modify = new Modify();
        string maNV = "";
        public ThongTinTaiKhoan(string tenTaiKhoan)
        {
            InitializeComponent();
            this.tenTaiKhoan = tenTaiKhoan;

        }

        private void ThongTinTaiKhoan_Load(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {

        }
    }
}
