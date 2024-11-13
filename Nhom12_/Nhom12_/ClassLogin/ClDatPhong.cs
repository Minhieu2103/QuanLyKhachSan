using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhom12_.ClassLogin
{
    public class ClDatPhong
    {
        private Modify modify = new Modify();

        public DataTable LoadDanhSachDatPhong()
        {
            string squery = "Select ct.MaChiTietDatPhong, kh.HoTen, kh.CMND, ct.TenLoai, ct.NgayNhan, ct.NgayTra from ChiTietDatPhong ct, KhachHang kh where ct.MaKH = kh.Makh";
            return modify.GetDataTable(squery);
        }

        public bool DatPhongMoi(string id_kh, string HoTen, string CMND, string LoaiKH, string sdt, string NgaySinh, string DiaChi, string GioiTinh, string QuocTich)
        {
            try
            {
                string squery = $"insert into KhachHang values('{id_kh}', N'{HoTen}', '{CMND}', N'{LoaiKH}', '{sdt}', '{NgaySinh}', N'{DiaChi}', N'{GioiTinh}', N'{QuocTich}')";
                modify.Command(squery);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool ThemChiTietDatPhong(string id_ctdp, string NgayNhan, string NgayTra, int SoDem, string id_kh, string LoaiPhong)
        {
            try
            {
                string squery = $"insert into ChiTietDatPhong values('{id_ctdp}', '{NgayNhan}', '{NgayTra}', '{SoDem}', '{id_kh}', '{LoaiPhong}')";
                modify.Command(squery);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public DataTable TimKhachHang(string cmnd)
        {
            string squery = $"select * from KhachHang kh where kh.CMND like '%{cmnd}%'";
            return modify.GetDataTable(squery);
        }
    }
}
