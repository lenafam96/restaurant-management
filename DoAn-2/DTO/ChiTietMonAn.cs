using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restaurant_management.DTO
{
    public class ChiTietMonAn
    {
        public ChiTietMonAn(string tenThucPham, int soLuong, string donViTinh)
        {
            this.TenThucPham = tenThucPham;
            this.SoLuong = soLuong;
            this.DonViTinh = donViTinh;
        }

        public ChiTietMonAn(DataRow row)
        {
            this.TenThucPham = row["tenThucPham"].ToString();
            this.SoLuong = (int)row["soLuong"];
            this.DonViTinh = row["donViTinh"].ToString();
        }

        private string tenThucPham;
        private int soLuong;
        private string donViTinh;

        public string TenThucPham { get => tenThucPham; set => tenThucPham = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public string DonViTinh { get => donViTinh; set => donViTinh = value; }
    }
}
