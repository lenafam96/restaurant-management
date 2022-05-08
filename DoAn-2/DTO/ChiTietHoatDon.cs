using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restaurant_management.DTO
{
    class ChiTietHoatDon
    {
        //Vì món ăn nằm trong hoá đơn nên chỉ cần hiển thị tên món, số lượng, giá tiền và thành tiền
        public ChiTietHoatDon(string tenMonAn, int soLuong, int gia, int thanhTien = 0)
        {
            this.tenMonAn = tenMonAn;
            this.soLuong = soLuong;
            this.gia = gia;
            this.thanhTien = thanhTien;
        }

        public ChiTietHoatDon(DataRow row)
        {
            this.tenMonAn = row["tenMonAn"].ToString();
            this.soLuong = (int)row["soLuong"];
            this.gia = (int)row["gia"];
            this.thanhTien = this.soLuong * this.gia;
        }

        private string tenMonAn;
        private int soLuong;
        private int gia;
        private int thanhTien;

        public string TenMonAn { get => tenMonAn; set => tenMonAn = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public int Gia { get => gia; set => gia = value; }
        public int ThanhTien { get => thanhTien; set => thanhTien = value; }
    }
}
