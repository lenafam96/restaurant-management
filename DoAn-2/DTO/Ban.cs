using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restaurant_management.DTO
{
    public class Ban
    {
        public Ban(int maBan, int trangThai)
        {
            this.maBan = maBan;
            this.trangThai = trangThai;
        }

        public Ban(DataRow row)
        {
            this.maBan = (int)row["maBan"];
            this.trangThai = (int)row["trangThai"];
        }

        private int maBan;
        private int trangThai;

        public int MaBan { get => maBan; set => maBan = value; }
        public int TrangThai { get => trangThai; set => trangThai = value; }
    }
}
