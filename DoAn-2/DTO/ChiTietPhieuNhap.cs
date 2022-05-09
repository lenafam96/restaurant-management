using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restaurant_management.DTO
{
    public class ChiTietPhieuNhap
    {
        public ChiTietPhieuNhap(int maThucPham, string tenThucPham, int soLuong, string donViTinh, int gia)
        {
            this.MaThucPham = maThucPham;
            this.TenThucPham = tenThucPham;
            this.SoLuong = soLuong;
            this.DonViTinh = donViTinh;
            this.Gia = gia;
        }

        public ChiTietPhieuNhap(DataRow row)
        {
            this.MaThucPham = (int)row["maThucPham"];
            this.TenThucPham = row["tenThucPham"].ToString();
            this.SoLuong = (int)row["soLuong"];
            this.DonViTinh = row["donViTinh"].ToString();
            this.Gia = (int)row["gia"];
        }

        private int maThucPham;
        private string tenThucPham;
        private int soLuong;
        private string donViTinh;
        private int gia;

        public int MaThucPham { get => maThucPham; set => maThucPham = value; }
        public string TenThucPham { get => tenThucPham; set => tenThucPham = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public string DonViTinh { get => donViTinh; set => donViTinh = value; }
        public int Gia { get => gia; set => gia = value; }
    }
}
