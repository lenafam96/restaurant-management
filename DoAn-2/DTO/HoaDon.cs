using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restaurant_management.DTO
{
    public class HoaDon
    {
        public HoaDon(int maHoaDon, int maNhanVien, int maKhachHang, int maBan, int diemCong, int diemTru, DateTime ngayTao, DateTime ngayThanhToan, int tongTien, int maVoucher, int trangThai)
        {
            this.maHoaDon = maHoaDon;
            this.maNhanVien = maNhanVien;
            this.MaKhachHang = maKhachHang;
            this.maBan = maBan;
            this.diemCong = diemCong;
            this.diemTru = diemTru;
            this.ngayTao = ngayTao;
            this.ngayThanhToan = ngayThanhToan;
            this.tongTien = tongTien;
            this.maVoucher = maVoucher;
            this.trangThai = trangThai;
        }

        public HoaDon(DataRow row)
        {
            this.maHoaDon = (int)row["maHoaDon"];
            this.maNhanVien = (int)row["maNhanVien"];
            this.MaKhachHang = (int)row["maKhachHang"];
            this.maBan = (int)row["maBan"];
            this.diemCong = (int)row["diemCong"];
            this.diemTru = (int)row["diemTru"];
            this.ngayTao = (DateTime)row["ngayTao"];
            this.ngayThanhToan = (DateTime)row["ngayThanhToan"];
            this.tongTien = (int)row["tongTien"];
            this.maVoucher = (int)row["maVoucher"];
            this.trangThai = (int)row["trangThai"];
        }

        private int maHoaDon;
        private int maNhanVien;
        private int maKhachHang;
        private int maBan;
        private int diemCong;
        private int diemTru;
        private DateTime ngayTao;
        private DateTime ngayThanhToan;
        private int tongTien;
        private int maVoucher;
        private int trangThai;

        public int MaHoaDon { get => maHoaDon; set => maHoaDon = value; }
        public int MaNhanVien { get => maNhanVien; set => maNhanVien = value; }
        public int MaKhachHang { get => maKhachHang; set => maKhachHang = value; }
        public int MaBan { get => maBan; set => maBan = value; }
        public int DiemCong { get => diemCong; set => diemCong = value; }
        public int DiemTru { get => diemTru; set => diemTru = value; }
        public DateTime NgayTao { get => ngayTao; set => ngayTao = value; }
        public DateTime NgayThanhToan { get => ngayThanhToan; set => ngayThanhToan = value; }
        public int TongTien { get => tongTien; set => tongTien = value; }
        public int MaVoucher { get => maVoucher; set => maVoucher = value; }
        public int TrangThai { get => trangThai; set => trangThai = value; }
    }
}
