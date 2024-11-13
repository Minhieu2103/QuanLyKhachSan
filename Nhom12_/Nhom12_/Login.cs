
using Nhom12_.ClassLogin;
using NHom12_;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhom12_

{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        public static string tenTK = ""
;        private void btnDangNhap_Click(object sender, EventArgs e)
        {          
            string tenTK = txtUserName.Text;
            string matKhau = txtPass.Text;

            Login3 login3 = new Login3();
            bool dangNhapThanhCong = login3.KiemTraDangNhap(tenTK, matKhau);

            if (dangNhapThanhCong)
            {
                this.Hide();
                Main main = new Main();
                main.ShowDialog();
            }
            txtPass.Clear();
            txtUserName.Clear();
            txtUserName.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblQuenMK_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            QuenMatKhau mk = new QuenMatKhau();
            mk.ShowDialog();
        }

        private void lblDangKy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DangKy dk = new DangKy();
            dk.ShowDialog();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnDangNhap_Click(sender,e);
            }
        }
    }
}
