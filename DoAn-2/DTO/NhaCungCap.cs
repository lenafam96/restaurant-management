using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restaurant_management.DTO
{
    public class NhaCungCap
    {
        public NhaCungCap(int maNhaCungCap, string tenNhaCungCap, string diaChi, string sdt, string email)
        {
            this.MaNhaCungCap = maNhaCungCap;
            this.TenNhaCungCap = tenNhaCungCap;
            this.DiaChi = diaChi;
            this.Sdt = sdt;
            this.Email = email;
        }

        public NhaCungCap(DataRow row)
        {
            this.MaNhaCungCap = (int)row["maNhaCungCap"];
            this.TenNhaCungCap = row["tenNhaCungCap"].ToString();
            this.DiaChi = row["diaChi"].ToString();
            this.Sdt = row["sdt"].ToString();
            this.Email = row["email"].ToString();
        }

        private int maNhaCungCap;
        private string tenNhaCungCap;
        private string diaChi;
        private string sdt;
        private string email;

        public int MaNhaCungCap { get => maNhaCungCap; set => maNhaCungCap = value; }
        public string TenNhaCungCap { get => tenNhaCungCap; set => tenNhaCungCap = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string Email { get => email; set => email = value; }
    }
}
