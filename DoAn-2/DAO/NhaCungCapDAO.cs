using restaurant_management.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restaurant_management.DAO
{
    public class NhaCungCapDAO
    {
        private static NhaCungCapDAO instance;

        public static NhaCungCapDAO Instance
        {
            get => instance == null ? instance = new NhaCungCapDAO() : instance;
            private set => instance = value;
        }

        private NhaCungCapDAO()
        {

        }

        public List<NhaCungCap> GetListNhaCungCap()
        {
            List<NhaCungCap> listNhaCungCap = new List<NhaCungCap>();

            DataTable data = DataProvider.Instance.ExecuteQuery("USP_GetListNhaCungCap");

            foreach (DataRow row in data.Rows)
            {
                NhaCungCap phieuNhap = new NhaCungCap(row);
                listNhaCungCap.Add(phieuNhap);
            }

            return listNhaCungCap;
        }

        public DataTable GetDataTableNhaCungCap()
        {
            return DataProvider.Instance.ExecuteQuery("USP_GetListNhaCungCap");
        }

        public DataTable SearchNhaCungCap(string textSearch)
        {
            return DataProvider.Instance.ExecuteQuery("EXEC USP_SearchNhaCungCap @textSearch ", new object[] { textSearch });
        }

        public bool InsertNhaCungCap(string tenNhaCungCap, string diaChi, string sdt, string email)
        {
            int count = DataProvider.Instance.ExecuteNonQuery("EXEC USP_InsertNhaCungCap @tenNhaCungCap , @diaChi , @sdt , @email ", new object[] { tenNhaCungCap, diaChi, sdt, email });
            return count > 0;
        }

        public bool UpdateNhaCungCap(int maNhaCungCap, string tenNhaCungCap, string diaChi, string sdt, string email)
        {
            int count = DataProvider.Instance.ExecuteNonQuery("EXEC USP_UpdateNhaCungCap @maNhaCungCap , @tenNhaCungCap , @diaChi , @sdt , @email ", new object[] { maNhaCungCap, tenNhaCungCap, diaChi, sdt, email });
            return count > 0;
        }

        public bool DeleteNhaCungCap(int maNhaCungCap)
        {
            int count = DataProvider.Instance.ExecuteNonQuery("EXEC USP_DeleteNhaCungCap " + maNhaCungCap);
            return count > 0;
        }
    }
}
