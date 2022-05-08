using restaurant_management.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restaurant_management.DAO
{
    public class ThucPhamDAO
    {
        private static ThucPhamDAO instance;

        public static ThucPhamDAO Instance
        {
            get => instance == null ? instance = new ThucPhamDAO() : instance;
            private set => instance = value;
        }

        public ThucPhamDAO() { }

        public List<ThucPham> GetListThucPham()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("EXEC USP_GetListThucPham");
            List<ThucPham> list = new List<ThucPham>();
            foreach (DataRow item in data.Rows)
            {
                ThucPham tp = new ThucPham(item);
                list.Add(tp);
            }
            return list;
        }

        public DataTable GetDataTableThucPham()
        {
            return DataProvider.Instance.ExecuteQuery("EXEC USP_GetListThucPham");
        }

        public DataTable SearchThucPham(string textSearch)
        {
            return DataProvider.Instance.ExecuteQuery("EXEC USP_SearchThucPham @textSearch ", new object[] { textSearch });
        }

        public bool InsertThucPham(string tenThucPham, string donViTinh)
        {
            int count = DataProvider.Instance.ExecuteNonQuery("EXEC USP_InsertThucPham @tenThucPham , @donViTinh ", new object[] { tenThucPham, donViTinh });
            return count > 0;
        }

        public bool UpdateThucPham(int maThucPham, string tenThucPham, string donViTinh)
        {
            int count = DataProvider.Instance.ExecuteNonQuery("EXEC USP_UpdateThucPham @maThucPham , @tenThucPham , @donViTinh ", new object[] { maThucPham, tenThucPham, donViTinh });
            return count > 0;
        }

        public bool DeleteThucPham(int maThucPham)
        {
            int count = DataProvider.Instance.ExecuteNonQuery("EXEC USP_DeleteThucPham " + maThucPham);
            return count > 0;
        }
        public bool CheckTenThucPhamExist(string tenThucPham)
        {
            return DataProvider.Instance.ExecuteQuery("EXEC USP_GetThucPhamByName @tenThucPham ", new object[] { tenThucPham }).Rows.Count > 0;
        }
        public List<string> GetListDonViTinh()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("EXEC USP_GetListUnit");
            List<string> list = new List<string>();
            foreach (DataRow item in data.Rows)
            {
                list.Add(item[0].ToString());
            }
            return list;
        }
    }
}
