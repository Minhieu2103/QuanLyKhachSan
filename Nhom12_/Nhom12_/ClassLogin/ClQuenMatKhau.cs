using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhom12_.ClassLogin
{
    public class ClQuenMatKhau
    {
        private Modify modify = new Modify();

        // Kiểm tra tính hợp lệ của email
        public bool CheckEmail(string email)
        {
            return Regex.IsMatch(email, @"^[a-zA-Z0-9_.]{3,20}@gmail.com(.vn|)$");
        }

        // Lấy lại mật khẩu
        public void LayLaiMatKhau(string email)
        {
            if (!CheckEmail(email))
            {
                MessageBox.Show("Nhập sai Email", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                string squery = "Select * from TaiKhoan where Email='" + email + "'";
                if (modify.TaiKhoans(squery).Count != 0)
                {
                    MessageBox.Show("Mật Khẩu: " + modify.TaiKhoans(squery)[0].MatKhau, "Lấy Lại Mật Khẩu", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Email chưa đăng ký", "Lấy Lại Mật Khẩu", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
