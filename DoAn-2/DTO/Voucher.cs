using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restaurant_management.DTO
{
    public class Voucher
    {
        public Voucher(int maVoucher, DateTime ngayBatDau, DateTime ngayKetThuc, string moTa, int giaTri, string loai)
        {
            this.maVoucher = maVoucher;
            this.ngayBatDau = ngayBatDau;
            this.ngayKetThuc = ngayKetThuc;
            this.moTa = moTa;
            this.giaTri = giaTri;
            this.loai = loai;
        }

        public Voucher(DataRow row)
        {
            this.maVoucher = (int)row["maVoucher"];
            this.ngayBatDau = DateTime.Parse(row["ngayBatDau"].ToString());
            this.ngayKetThuc = DateTime.Parse(row["ngayKetThuc"].ToString());
            this.moTa = row["moTa"].ToString();
            this.giaTri = (int)row["giaTri"];
            this.loai = (int)row["loai"]==0?"Phần trăm":"Tiền mặt";
        }

        private int maVoucher;
        private DateTime ngayBatDau;
        private DateTime ngayKetThuc;
        private string moTa;
        private int giaTri;
        private string loai;

        public int MaVoucher { get => maVoucher; set => maVoucher = value; }
        public DateTime NgayBatDau { get => ngayBatDau; set => ngayBatDau = value; }
        public DateTime NgayKetThuc { get => ngayKetThuc; set => ngayKetThuc = value; }
        public string MoTa { get => moTa; set => moTa = value; }
        public int GiaTri { get => giaTri; set => giaTri = value; }
        public string Loai { get => loai; set => loai = value; }
    }
}
