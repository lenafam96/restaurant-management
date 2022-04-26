using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restaurant_management.DTO
{
    class MonAn
    {
        public MonAn(int maMonAn, string tenMonAn, int gia, int maDanhMucMon)
        {
            this.maMonAn = maMonAn;
            this.tenMonAn = tenMonAn;
            this.gia = gia;
            this.maDanhMucMon = maDanhMucMon;
        }

        public MonAn(DataRow row)
        {
            this.maMonAn = (int)row["maMonAn"];
            this.tenMonAn = row["tenMonAn"].ToString();
            this.gia = (int)row["gia"];
            this.maDanhMucMon = (int)row["maDanhMucMon"];
        }

        private int maMonAn;
        private string tenMonAn;
        private int gia;
        private int maDanhMucMon;

        public int MaMonAn { get => maMonAn; set => maMonAn = value; }
        public string TenMonAn { get => tenMonAn; set => tenMonAn = value; }
        public int Gia { get => gia; set => gia = value; }
        public int MaDanhMucMon { get => maDanhMucMon; set => maDanhMucMon = value; }
    }
}
