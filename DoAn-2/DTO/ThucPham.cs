using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restaurant_management.DTO
{
    public class ThucPham
    {
        public ThucPham(int maThucPham, string tenThucPham, string donViTinh, int tonKho)
        {
            this.MaThucPham = maThucPham;
            this.TenThucPham = tenThucPham;
            this.DonViTinh = donViTinh;
            this.TonKho = tonKho;
        }

        public ThucPham(DataRow row)
        {
            this.MaThucPham = (int)row["maThucPham"];
            this.TenThucPham = row["tenThucPham"].ToString();
            this.DonViTinh = row["donViTinh"].ToString();
            this.TonKho = (int)row["tonKho"];
        }

        private int maThucPham;
        private string tenThucPham;
        private string donViTinh;
        private int tonKho;

        public int MaThucPham { get => maThucPham; set => maThucPham = value; }
        public string TenThucPham { get => tenThucPham; set => tenThucPham = value; }
        public string DonViTinh { get => donViTinh; set => donViTinh = value; }
        public int TonKho { get => tonKho; set => tonKho = value; }
    }
}
