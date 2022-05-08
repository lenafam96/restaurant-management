using restaurant_management.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restaurant_management.DAO
{
    public class KhachHangDAO
    {
        private static KhachHangDAO instance;

        public static KhachHangDAO Instance
        {
            get => instance == null ? instance = new KhachHangDAO() : instance;
            private set => instance = value;
        }

        public KhachHangDAO() { }

        public KhachHang GetKhachHangByID(int maKhachHang)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("USP_GetKhachHangByID " + maKhachHang);
            return data.Rows.Count > 0 ? new KhachHang(data.Rows[0]) : null;
        }

        public DataTable GetListKhachHang()
        {
            return DataProvider.Instance.ExecuteQuery("EXEC USP_GetListKhachHang");
        }

        public DataTable SearchKhachHang(string textSearch)
        {
            return DataProvider.Instance.ExecuteQuery("EXEC USP_SearchKhachHang @textSearch ", new object[] { textSearch });
        }

        public bool InsertKhachHang(string tenKhachHang, DateTime ngaySinh, string gioiTinh, string sdt)
        {
            int count = DataProvider.Instance.ExecuteNonQuery("EXEC USP_InsertKhachHang @hoTen , @ngaySinh , @gioiTinh , @sdt ", new object[] { tenKhachHang, ngaySinh.ToString("yyyy-MM-dd"), gioiTinh, sdt });
            return count > 0;
        }

        public bool UpdateKhachHang(int maKhachHang, string tenKhachHang, DateTime ngaySinh, string gioiTinh, string sdt)
        {
            int count = DataProvider.Instance.ExecuteNonQuery("EXEC USP_UpdateKhachHang @maKhachHang , @hoTen , @ngaySinh , @gioiTinh , @sdt ", new object[] { maKhachHang, tenKhachHang, ngaySinh.ToString("yyyy-MM-dd"), gioiTinh, sdt });
            return count > 0;
        }

        public bool DeleteKhachHang(int maKhachHang)
        {
            int count = DataProvider.Instance.ExecuteNonQuery("EXEC USP_DeleteKhachHang " + maKhachHang);
            return count > 0;
        }
    }
}
