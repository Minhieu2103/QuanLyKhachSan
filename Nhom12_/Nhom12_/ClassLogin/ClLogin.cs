using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nhom12_.ClassLogin;

namespace Nhom12_
{
   
    internal class ClLogin
    {
        private Modify modify = new Modify(); // giả sử Modify là lớp truy xuất dữ liệu

        public bool KiemTraDangNhap(string tenTK, string matKhau)
        {
            if (string.IsNullOrWhiteSpace(tenTK))
            {
                MessageBox.Show("Nhập Tài Khoản", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(matKhau))
            {
                MessageBox.Show("Nhập Mật Khẩu", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return false;
            }

            string squery = "select * from TaiKhoan where TenDangNhap= '" + tenTK + "' and MatKhau = '" + matKhau + "'";
            if (modify.TaiKhoans(squery).Count > 0)
            {
                return true; 
            }
            else
            {
                MessageBox.Show("Sai Tài Khoản Hoặc Mật Khẩu", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return false; 
            }
        }
    }
}
