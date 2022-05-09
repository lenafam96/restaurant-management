using restaurant_management.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restaurant_management.DAO
{
    public class PhieuNhapDAO
    {
        private static PhieuNhapDAO instance;

        public static PhieuNhapDAO Instance
        {
            get => instance == null ? instance = new PhieuNhapDAO() : instance;
            private set => instance = value;
        }

        private PhieuNhapDAO()
        {

        }

        public List<PhieuNhap> GetListPhieuNhap()
        {
            List<PhieuNhap> listPhieuNhap = new List<PhieuNhap>();

            DataTable data = DataProvider.Instance.ExecuteQuery("USP_GetListPhieuNhap");

            foreach (DataRow row in data.Rows)
            {
                PhieuNhap phieuNhap = new PhieuNhap(row);
                listPhieuNhap.Add(phieuNhap);
            }

            return listPhieuNhap;
        }

        public DataTable GetDataTablePhieuNhap()
        {
            return DataProvider.Instance.ExecuteQuery("USP_GetListPhieuNhap");
        }

        public bool InsertPhieuNhap(int maNhaCungCap, DateTime ngayNhap)
        {
            int count = DataProvider.Instance.ExecuteNonQuery("EXEC USP_InsertPhieuNhap @maNhaCungCap , @ngayNhap ", new object[] { maNhaCungCap, ngayNhap.ToString("yyyy-MM-dd") });
            return count > 0;
        }

        public bool UpdatePhieuNhap(int maPhieuNhap, int maNhaCungCap, DateTime ngayNhap)
        {
            int count = DataProvider.Instance.ExecuteNonQuery("EXEC USP_UpdatePhieuNhap @maPhieuNhap , @maNhaCungCap , @ngayNhap ", new object[] { maPhieuNhap, maNhaCungCap, ngayNhap.ToString("yyyy-MM-dd") });
            return count > 0;
        }

        public bool DeletePhieuNhap(int maPhieuNhap)
        {
            int count = DataProvider.Instance.ExecuteNonQuery("EXEC USP_DeletePhieuNhap " + maPhieuNhap);
            return count > 0;
        }
        public bool UpdateTongTienPhieuNhap(int maPhieuNhap, int tongTien)
        {
            int count = DataProvider.Instance.ExecuteNonQuery("EXEC USP_UpdateTongTienPhieuNhap @maPhieuNhap , @tongTien ", new object[] { maPhieuNhap, tongTien });
            return count > 0;
        }
    }
}
