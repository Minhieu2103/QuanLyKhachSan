using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhom12_.ClassLogin
{
   
        public class ClChiTietDatPhong
        {
            private Modify modify = new Modify();

            public string GetMaKH(string maChiTietDP)
            {
                return modify.GetID("Select kh.MaKH From KhachHang kh, ChiTietDatPhong ct where kh.MaKH = ct.MaKH and ct.MaChiTietDatPhong = '" + maChiTietDP + "'");
            }

            public DataTable GetThongTinKhachHang(string maKH)
            {
                string squery = "Select * From KhachHang where MaKH = '" + maKH + "'";
                return modify.GetDataTable(squery);
            }

            public DataTable GetThongTinDatPhong(string maChiTietDP)
            {
                string squery = "Select ct.MaChiTietDatPhong, ct.TenLoai, ct.NgayNhan, ct.NgayTra, ct.SoDem from ChiTietDatPhong ct where ct.MaChiTietDatPhong ='" + maChiTietDP + "'";
                return modify.GetDataTable(squery);
            }

            public void CapNhatThongTinDatPhong(string maChiTietDP, string loaiPhong, DateTime ngayNhan, DateTime ngayTra, int soDem)
            {
                string squery = "UPDATE ChiTietDatPhong Set NgayNhan ='" + ngayNhan.ToString("yyyy-MM-dd") + "', NgayTra='" + ngayTra.ToString("yyyy-MM-dd") + "', SoDem = '" + soDem + "', TenLoai ='" + loaiPhong + "' Where MaChiTietDatPhong = '" + maChiTietDP + "'";
                modify.Command(squery);
            }

            public void CapNhatThongTinKhachHang(string maKH, string hoTen, string cmnd, string loaiKH, string sdt, DateTime ngaySinh, string diaChi, string gioiTinh, string quocTich)
            {
                string squery = "Update KhachHang set HoTen = N'" + hoTen + "', CMND = '" + cmnd + "', LoaiKH = N'" + loaiKH + "', SDT = '" + sdt + "', NgaySinh = '" + ngaySinh.ToString("yyyy-MM-dd") + "', DiaChi=N'" + diaChi + "', GioiTinh = N'" + gioiTinh + "', QuocTich = N'" + quocTich + "' where MaKH = '" + maKH + "'";
                modify.Command(squery);
            }

            public void XoaKhachHang(string maChiTietDP, string maKH)
            {
                int ktHD = modify.GetInt32("select Count(MaHD) from HoaDon where MaKH = '" + maKH + "'");
                if (ktHD > 0)
                {
                    string maHD = modify.GetID("select MaHD from HoaDon where MaKH = '" + maKH + "'");
                    modify.Command("Delete HoaDonDV where MaHD = '" + maHD + "'");
                    modify.Command("Delete PhieuDatPhong Where MaChiTietDP = '" + maChiTietDP + "'");
                    modify.Command("Delete HoaDonPhong Where MaHD = '" + maHD + "'");
                    modify.Command("Delete ChiTietDatPhong Where MaChiTietDatPhong = '" + maChiTietDP + "'");
                    modify.Command("Delete HoaDon Where MaHD = '" + maHD + "'");
                }
                modify.Command("Delete Khachhang Where MaKH = '" + maKH + "'");
            }
        }
    }



