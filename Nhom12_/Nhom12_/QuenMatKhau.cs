using Nhom12_.ClassLogin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NHom12_
{
    public partial class QuenMatKhau : Form
    {
        public QuenMatKhau()
        {
            InitializeComponent();
        }
        private void btnLayLaiPass_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            ClQuenMatKhau quyenMatKhau = new ClQuenMatKhau();
            quyenMatKhau.LayLaiMatKhau(email);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
