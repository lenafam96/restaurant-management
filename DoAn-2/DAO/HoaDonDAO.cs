using restaurant_management.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restaurant_management.DAO
{
    public class HoaDonDAO
    {
        private static HoaDonDAO instance;

        public static HoaDonDAO Instance
        {
            get => instance == null ? instance = new HoaDonDAO() : instance;
            private set => instance = value;
        }

        public HoaDonDAO() { }

        public bool TaoHoaDon(int maNhanVien, int maBan)
        {
            int count = DataProvider.Instance.ExecuteNonQuery("EXEC USP_CreateHoaDon @maNhanVien , @maBan", new object[] { maNhanVien, maBan });
            return count > 0;
        }

        public HoaDon GetHoaDonByMaBan(int maBan)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("EXEC USP_GetHoaDonByMaBan " + maBan);
            return data.Rows.Count > 0 ? new HoaDon(data.Rows[0]) : null;
        }
        public bool ThanhToanHoaDon(int maHoaDon, int maKhachHang, int diemCong, int diemTru, int tongTien, int maVoucher)
        {
            int count = DataProvider.Instance.ExecuteNonQuery("EXEC USP_ThanhToanHoaDon @maHoaDon , @maKhachHang , @diemCong , @diemTru , @tongTien , @maVoucher ", new object[] { maHoaDon, maKhachHang, diemCong, diemTru, tongTien, maVoucher });
            return count > 0;
        }

        public bool ChuyenHoaDonSangBanMoi(int maHoaDon, int maBanMoi)
        {
            int count = DataProvider.Instance.ExecuteNonQuery("EXEC USP_ChuyenHoaDonSangBanMoi @maHoaDon , @maBanMoi ", new object[] { maHoaDon, maBanMoi });
            return count > 0;
        }
    }
}
