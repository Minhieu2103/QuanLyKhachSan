
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
    public partial class ChiTietDatPhong : Form
    {

        private string maChiTietDP = "";

        private string maKH = "";
        public ChiTietDatPhong(string maPhieuDP)
        {
            InitializeComponent();
            this.maChiTietDP = maPhieuDP;
            
        }
        private ClChiTietDatPhong clChiTietDatPhong = new ClChiTietDatPhong();

        private void ChiTietDatPhong_Load(object sender, EventArgs e)
        {
            maKH = clChiTietDatPhong.GetMaKH(maChiTietDP);
            Load_KhachHang();
            Load_Data();
        }

        private void Load_KhachHang()
        {
            DataTable dataTable = clChiTietDatPhong.GetThongTinKhachHang(maKH);
            foreach (DataRow row in dataTable.Rows)
            {
                txtHoTen.Text = row["HoTen"].ToString();
                txtCMND.Text = row["CMND"].ToString();
                cbBoxLoaiKhachHang.Text = row["LoaiKH"].ToString();
                txtSoDienThoai.Text = row["SDT"].ToString();
                dateSinh.Value = Convert.ToDateTime(row["NgaySinh"]);
                txtDiaChi.Text = row["DiaChi"].ToString();
                cbBoxGioiTinh.Text = row["GioiTinh"].ToString();
                cbBoxQuocTich.Text = row["QuocTich"].ToString();
            }
        }

        private void Load_Data()
        {
            DataTable dataTable = clChiTietDatPhong.GetThongTinDatPhong(maChiTietDP);
            foreach (DataRow row in dataTable.Rows)
            {
                cbBoxLoaiPhong.Text = row["TenLoai"].ToString();
                dateNhan.Value = Convert.ToDateTime(row["NgayNhan"]);
                dateTra.Value = Convert.ToDateTime(row["NgayTra"]);
                udSoDem.Value = Convert.ToInt32(row["SoDem"]);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            clChiTietDatPhong.CapNhatThongTinDatPhong(maChiTietDP, cbBoxLoaiPhong.Text, dateNhan.Value, dateTra.Value, (int)udSoDem.Value);
            MessageBox.Show("Đã Lưu Lại Thông Tin Đặt Phòng", "Lưu Lại", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCapNhatKH_Click(object sender, EventArgs e)
        {
            clChiTietDatPhong.CapNhatThongTinKhachHang(maKH, txtHoTen.Text, txtCMND.Text, cbBoxLoaiKhachHang.Text, txtSoDienThoai.Text, dateSinh.Value, txtDiaChi.Text, cbBoxGioiTinh.Text, cbBoxQuocTich.Text);
            MessageBox.Show("Đã Cập Nhật Khách Hàng: " + txtHoTen.Text, "Cập Nhật", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnXoaKH_Click(object sender, EventArgs e)
        {
            clChiTietDatPhong.XoaKhachHang(maChiTietDP, maKH);
            MessageBox.Show("Đã xóa khách hàng: " + txtHoTen.Text, "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {

        }
    }
}
