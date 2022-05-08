using restaurant_management.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restaurant_management.DAO
{
    class MonAnDAO
    {
        private static MonAnDAO instance;

        public static MonAnDAO Instance
        {
            get => instance == null ? instance = new MonAnDAO() : instance;
            private set => instance = value;
        }

        private MonAnDAO()
        {

        }

        public static int Width = 100;
        public static int Height = 50;

        public List<MonAn> GetListMonAnByMaDanhMucMon(int maDanhMucMon)
        {
            List<MonAn> listMonAn = new List<MonAn>();

            DataTable data = DataProvider.Instance.ExecuteQuery("USP_GetListMonAnByMaDanhMuc " + maDanhMucMon);

            foreach (DataRow row in data.Rows)
            {
                MonAn monAn = new MonAn(row);
                listMonAn.Add(monAn);
            }

            return listMonAn;
        }

        public DataTable GetDataTableMonAn()
        {
            return DataProvider.Instance.ExecuteQuery("USP_GetListMonAn");
        }

        public bool InsertMonAn(string tenMonAn, int gia, int maDanhMuc)
        {
            int count = DataProvider.Instance.ExecuteNonQuery("EXEC USP_InsertMonAn @tenMonAn , @gia , @maDanhMucMon ", new object[] { tenMonAn, gia, maDanhMuc });
            return count > 0;
        }

        public bool UpdateMonAn(int maMonAn, string tenMonAn, int gia, int maDanhMuc)
        {
            int count = DataProvider.Instance.ExecuteNonQuery("EXEC USP_UpdateMonAn @maMonAn , @tenMonAn , @gia , @maDanhMucMon ", new object[] { maMonAn, tenMonAn, gia, maDanhMuc });
            return count > 0;
        }

        public bool DeleteMonAn(int maMonAn)
        {
            int count = DataProvider.Instance.ExecuteNonQuery("EXEC USP_DeleteMonAn " + maMonAn);
            return count > 0;
        }
        public bool CheckTenMonAnExist(string tenMonAn)
        {
            return DataProvider.Instance.ExecuteQuery("EXEC USP_GetMonAnByName @tenDanhMucMon ", new object[] { tenMonAn }).Rows.Count > 0;
        }
    }
}
