using restaurant_management.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restaurant_management.DAO
{
    public class NhanVienDAO
    {
        private static NhanVienDAO instance;

        public static NhanVienDAO Instance
        {
            get => instance == null ? instance = new NhanVienDAO() : instance;
            private set => instance = value;
        }

        public NhanVienDAO() { }

        public DataTable GetDataTableNhanVien()
        {
            return DataProvider.Instance.ExecuteQuery("EXEC USP_GetListNhanVien");
        }

        public List<NhanVien> GetListNhanVien()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("EXEC USP_GetListNhanVien");
            List<NhanVien> list = new List<NhanVien>();
            foreach (DataRow item in data.Rows)
            {
                NhanVien nv = new NhanVien(item);
                list.Add(nv);
            }
            return list;
        }

        public DataTable SearchNhanVien(string textSearch)
        {
            return DataProvider.Instance.ExecuteQuery("EXEC USP_SearchNhanVien @textSearch ", new object[] { textSearch });
        }

        public NhanVien GetNhanVienByID(int maNhanVien)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("EXEC USP_GetNhanVienByID " + maNhanVien);
            return data.Rows.Count > 0 ? new NhanVien(data.Rows[0]) : null;
        }

        public bool InsertNhanVien(string tenNhanVien, DateTime ngaySinh, string gioiTinh, string chucVu, string sdt, string cccd, int luong)
        {
            int count = DataProvider.Instance.ExecuteNonQuery("EXEC USP_InsertNhanVien @hoTen , @ngaySinh , @gioiTinh , @chucVu , @sdt , @cccd , @luong ", new object[] { tenNhanVien, ngaySinh.ToString("yyyy-MM-dd"), gioiTinh, chucVu, sdt, cccd, luong });
            return count > 0;
        }

        public bool UpdateNhanVien(int maNhanVien, string tenNhanVien, DateTime ngaySinh, string gioiTinh, string chucVu, string sdt, string cccd, int luong)
        {
            int count = DataProvider.Instance.ExecuteNonQuery("EXEC USP_UpdateNhanVien @maNhanVien , @hoTen , @ngaySinh , @gioiTinh , @chucVu , @sdt , @cccd , @luong ", new object[] { maNhanVien, tenNhanVien, ngaySinh.ToString("yyyy-MM-dd"), gioiTinh, chucVu, sdt, cccd, luong });
            return count > 0;
        }

        public bool DeleteNhanVien(int maNhanVien)
        {
            int count = DataProvider.Instance.ExecuteNonQuery("EXEC USP_DeleteNhanVien " + maNhanVien);
            return count > 0;
        }
    }
}
