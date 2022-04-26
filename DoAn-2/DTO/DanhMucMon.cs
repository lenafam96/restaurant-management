using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restaurant_management.DTO
{
    class DanhMucMon
    {
        public DanhMucMon(int maDanhMucMon, string tenDanhMucMon)
        {
            this.maDanhMucMon = maDanhMucMon;
            this.tenDanhMucMon = tenDanhMucMon;
        }

        public DanhMucMon(DataRow row)
        {
            this.maDanhMucMon = (int)row["maDanhMucMon"];
            this.tenDanhMucMon = row["tenDanhMucMon"].ToString();
        }

        private int maDanhMucMon;
        private string tenDanhMucMon;

        public int MaDanhMucMon { get => maDanhMucMon; set => maDanhMucMon = value; }
        public string TenDanhMucMon { get => tenDanhMucMon; set => tenDanhMucMon = value; }
    }
}
