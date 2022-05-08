using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restaurant_management.DTO
{
    public class NhanVien
    {
        public NhanVien(int maNhanVien, string hoTen, DateTime ngaySinh, string gioiTinh, string chucVu, string sdt, string cccd, int luong)
        {
            this.MaNhanVien = maNhanVien;
            this.HoTen = hoTen;
            this.NgaySinh = ngaySinh;
            this.GioiTinh = gioiTinh;
            this.ChucVu = chucVu;
            this.Sdt = sdt;
            this.Cccd = cccd;
            this.Luong = luong;
        }
        public NhanVien(DataRow row)
        {
            this.MaNhanVien = (int)row["maNhanVien"];
            this.HoTen = row["hoTen"].ToString();
            this.NgaySinh = DateTime.Parse(row["ngaySinh"].ToString());
            this.GioiTinh = row["gioiTinh"].ToString();
            this.ChucVu = row["chucVu"].ToString();
            this.Sdt = row["sdt"].ToString();
            this.Cccd = row["cccd"].ToString();
            this.Luong = (int)row["luong"];
        }

        private int maNhanVien;
        private string hoTen;
        private DateTime ngaySinh;
        private string gioiTinh;
        private string chucVu;
        private string sdt;
        private string cccd;
        private int luong;

        public int MaNhanVien { get => maNhanVien; set => maNhanVien = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string ChucVu { get => chucVu; set => chucVu = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string Cccd { get => cccd; set => cccd = value; }
        public int Luong { get => luong; set => luong = value; }
    }
}
