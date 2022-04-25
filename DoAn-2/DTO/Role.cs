using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restaurant_management.DTO
{
    class Role
    {
        public Role(int idRole, string nameRole, bool quyenBan, bool quyenNhanVien, bool quyenKhachHang, bool quyenVoucher, bool quyenThongKe, bool quyenKho, bool quyenThietLap)
        {
            this.idRole = idRole;
            this.nameRole = nameRole;
            this.quyenBan = quyenBan;
            this.quyenNhanVien = quyenNhanVien;
            this.quyenKhachHang = quyenKhachHang;
            this.quyenVoucher = quyenVoucher;
            this.quyenThongKe = quyenThongKe;
            this.quyenKho = quyenKho;
            this.quyenThietLap = quyenThietLap;
        }

        public Role(DataRow row)
        {
            this.idRole = (int)row["role"];
            this.nameRole = row["nameRole"].ToString();
            this.quyenBan = (bool)row["quyenBan"];
            this.quyenNhanVien = (bool)row["quyenNhanVien"];
            this.quyenKhachHang = (bool)row["quyenKhachHang"];
            this.quyenVoucher = (bool)row["quyenVoucher"];
            this.quyenThongKe = (bool)row["quyenThongKe"];
            this.quyenKho = (bool)row["quyenKho"];
            this.quyenThietLap = (bool)row["quyenThietLap"];
        }

        private int idRole;
        private string nameRole;
        private bool quyenBan;
        private bool quyenNhanVien;
        private bool quyenKhachHang;
        private bool quyenVoucher;
        private bool quyenThongKe;
        private bool quyenKho;
        private bool quyenThietLap;

        public int IdRole { get => idRole; set => idRole = value; }
        public string NameRole { get => nameRole; set => nameRole = value; }
        public bool QuyenBan { get => quyenBan; set => quyenBan = value; }
        public bool QuyenNhanVien { get => quyenNhanVien; set => quyenNhanVien = value; }
        public bool QuyenKhachHang { get => quyenKhachHang; set => quyenKhachHang = value; }
        public bool QuyenVoucher { get => quyenVoucher; set => quyenVoucher = value; }
        public bool QuyenKho { get => quyenKho; set => quyenKho = value; }
        public bool QuyenThietLap { get => quyenThietLap; set => quyenThietLap = value; }
        public bool QuyenThongKe { get => quyenThongKe; set => quyenThongKe = value; }
    }
}
