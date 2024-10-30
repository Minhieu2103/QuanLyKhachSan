using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nhom12_.ClassLogin;

namespace Nhom12_
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

        }
        Modify modify = new Modify();
        public static string tenTK = "";
        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            tenTK = txtUserName.Text;
            string matKhau = txtPass.Text;
            if (tenTK.Trim() == "")
            {
                MessageBox.Show("Nhập Tài Khoản", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            else if (matKhau.Trim() == "")
            {
                MessageBox.Show("Nhập Mật Khẩu ", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            else
            {
                string squery = "select * from TaiKhoan where TenDangNhap= '" + tenTK + "' and MatKhau = '" + matKhau + "'";
                if (modify.TaiKhoans(squery).Count > 0)
                {
                    this.Hide();
                    Main main = new Main();
                    main.ShowDialog();

                }
                else
                {
                    MessageBox.Show("Sai Tài Khoản Hoặc Mật Khẩu", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
            }
            txtPass.Clear();
            txtUserName.Clear();
            txtUserName.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
