using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restaurant_management.DTO
{
    public class KhachHang
    {
        public KhachHang(int maKhachHang, string hoTen, DateTime ngaySinh, string gioiTinh, string sdt, int diemTichLuy)
        {
            this.maKhachHang = maKhachHang;
            this.hoTen = hoTen;
            this.ngaySinh = ngaySinh;
            this.gioiTinh = gioiTinh;
            this.sdt = sdt;
            this.diemTichLuy = diemTichLuy;
        }
        public KhachHang(DataRow row)
        {
            this.maKhachHang = (int)row["maKhachHang"];
            this.hoTen = row["hoTen"].ToString();
            this.ngaySinh = DateTime.Parse(row["ngaySinh"].ToString());
            this.gioiTinh = row["gioiTinh"].ToString();
            this.sdt = row["sdt"].ToString();
            this.diemTichLuy = (int)row["diemTichLuy"];
        }

        private int maKhachHang;
        private string hoTen;
        private DateTime ngaySinh;
        private string gioiTinh;
        private string sdt;
        private int diemTichLuy;

        public int MaKhachHang { get => maKhachHang; set => maKhachHang = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public int DiemTichLuy { get => diemTichLuy; set => diemTichLuy = value; }
    }
}
