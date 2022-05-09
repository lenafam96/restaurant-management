using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restaurant_management.DTO
{
    public class PhieuNhap
    {
        public PhieuNhap(int maPhieuNhap, string tenNhaCungCap, DateTime ngayNhap, int tongTien)
        {
            this.MaPhieuNhap = maPhieuNhap;
            this.TenNhaCungCap = tenNhaCungCap;
            this.NgayNhap = ngayNhap;
            this.TongTien = tongTien;
        }

        public PhieuNhap(DataRow row)
        {
            this.MaPhieuNhap = (int)row["maPhieuNhap"];
            this.TenNhaCungCap = row["tenNhaCungCap"].ToString();
            this.NgayNhap = (DateTime)row["ngayNhap"];
            this.TongTien = (int)row["tongTien"];
        }

        private int maPhieuNhap;
        private string tenNhaCungCap;
        private DateTime ngayNhap;
        private int tongTien;

        public int MaPhieuNhap { get => maPhieuNhap; set => maPhieuNhap = value; }
        public string TenNhaCungCap { get => tenNhaCungCap; set => tenNhaCungCap = value; }
        public DateTime NgayNhap { get => ngayNhap; set => ngayNhap = value; }
        public int TongTien { get => tongTien; set => tongTien = value; }
    }
}
