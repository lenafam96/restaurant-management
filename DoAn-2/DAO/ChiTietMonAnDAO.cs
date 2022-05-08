using restaurant_management.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restaurant_management.DAO
{
    public class ChiTietMonAnDAO
    {
        private static ChiTietMonAnDAO instance;

        internal static ChiTietMonAnDAO Instance
        {
            get => instance == null ? instance = new ChiTietMonAnDAO() : instance;
            private set => instance = value;
        }

        public ChiTietMonAnDAO() { }

        public List<ChiTietMonAn> GetListThucPhamByMaMonAn(int maMonAn)
        {
            List<ChiTietMonAn> list = new List<ChiTietMonAn>();

            string query = "EXEC USP_GetListThucPhamByMaMonAn " + maMonAn;

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                ChiTietMonAn tmp = new ChiTietMonAn(item);
                list.Add(tmp);
            }

            return list;
        }
        public bool CheckThucPhamTrongMonAn(int maMonAn, int maThucPham)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("EXEC USP_CheckThucPhamTrongMonAn @maMonAn , @maThucPham ", new object[] { maMonAn, maThucPham });
            return data.Rows.Count > 0;
        }

        public bool ThemThucPhamVaoMonAn(int maMonAn, int maThucPham, int soLuong)
        {
            if (soLuong < 0)
                soLuong = 0;
            int count = DataProvider.Instance.ExecuteNonQuery("USP_InsertChiTietMonAn @maMonAn , @maThucPham , @soLuong ", new object[] { maMonAn, maThucPham, soLuong });
            return count > 0;
        }

        public bool CapNhatThucPhamVaoMonAn(int maMonAn, int maThucPham, int soLuong)
        {
            int count = DataProvider.Instance.ExecuteNonQuery("USP_UpdateChiTietMonAn @maMonAn , @maThucPham , @soLuong ", new object[] { maMonAn, maThucPham, soLuong });
            return count > 0;
        }
    }
}
