using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

using Nhom12_.ClassLogin;

namespace Nhom12_ 
{
    public partial class DangKy : Form
    {

        private ClDangKy clDangKy = new ClDangKy();
        public DangKy()
        {
            InitializeComponent();
        }
     

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            string tentk = txtTenTk.Text;
            string matkhau = txtMatKhau.Text;
            string xnmatkhau = txtXNMatKhau.Text;
            string email = txtEmail.Text;

            if (!clDangKy.CheckEmail(email))
            {
                MessageBox.Show("Nhập sai Email", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
            if (!clDangKy.CheckAccount(tentk))
            {
                MessageBox.Show("Tên Tài Khoản Không Hợp Lệ! Nhập Lại", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
            if (xnmatkhau != matkhau)
            {
                MessageBox.Show("Vui Lòng Xác Nhận Mật Khẩu ", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
            if (clDangKy.IsEmailRegistered(email))
            {
                MessageBox.Show("Email đã được đăng ký, vui lòng đổi email khác", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
            if (clDangKy.RegisterAccount(tentk, matkhau, email))
            {
                MessageBox.Show("Đăng ký thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Tài Khoản Đã Tồn Tại, Vui Lòng Nhập Tên Tài Khoản Khác", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void btnHuyDK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
