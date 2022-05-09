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
        public HoaDon GetHoaDonByMaHoaDon(int maHoaDon)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("EXEC USP_GetHoaDonByMaHoaDon " + maHoaDon);
            return data.Rows.Count > 0 ? new HoaDon(data.Rows[0]) : null;
        }
        public bool ThanhToanHoaDon(int maHoaDon, int maKhachHang, int diemCong, int diemTru, int tongTien, int maVoucher)
        {
            int count = DataProvider.Instance.ExecuteNonQuery("EXEC USP_ThanhToanHoaDon @maHoaDon , @maKhachHang , @diemCong , @diemTru , @tongTien , @maVoucher ", new object[] { maHoaDon, maKhachHang, diemCong, diemTru, tongTien, maVoucher });
            return count > 0;
        }

        public bool UpdateHoaDon(int maHoaDon, int maNhanVien, DateTime ngayTao, DateTime ngayThanhToan)
        {
            int count = DataProvider.Instance.ExecuteNonQuery("EXEC USP_UpdateHoaDon @maHoaDon , @maNhanVien , @ngayTao , @ngayThanhToan ", new object[] { maHoaDon, maNhanVien, ngayTao.ToString("yyyy-MM-dd HH:mm:ss"), ngayThanhToan.ToString("yyyy-MM-dd HH:mm:ss") });
            return count > 0;
        }
        public bool DeleteHoaDon(int maHoaDon)
        {
            int count = DataProvider.Instance.ExecuteNonQuery("EXEC USP_DeleteHoaDon @maHoaDon ", new object[] { maHoaDon });
            return count > 0;
        }

        public bool ChuyenHoaDonSangBanMoi(int maHoaDon, int maBanMoi)
        {
            int count = DataProvider.Instance.ExecuteNonQuery("EXEC USP_ChuyenHoaDonSangBanMoi @maHoaDon , @maBanMoi ", new object[] { maHoaDon, maBanMoi });
            return count > 0;
        }

        public DataTable GetHoaDon30Day()
        {
            return DataProvider.Instance.ExecuteQuery("EXEC USP_GetHoaDon30Day");
        }

        public int GetSoLuongHoaDon(DateTime dateFrom, DateTime DateTo)
        {
            return (int)DataProvider.Instance.ExecuteScalar("EXEC USP_GetNumHoaDonByDate @datefrom , @dateto ", new object[] { dateFrom, DateTo });
        }

        public DataTable GetDataTableHoaDon(DateTime dateFrom, DateTime DateTo, int page, int pageRows)
        {
            return DataProvider.Instance.ExecuteQuery("EXECUTE USP_GetListHoaDonByDateAndPage @datefrom , @dateto , @page , @pageRows ", new object[] { dateFrom, DateTo, page, pageRows });
        }
    }
}
