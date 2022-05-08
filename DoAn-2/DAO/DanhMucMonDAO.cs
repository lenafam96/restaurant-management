using restaurant_management.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restaurant_management.DAO
{
    class DanhMucMonDAO
    {
        private static DanhMucMonDAO instance;

        public static DanhMucMonDAO Instance
        {
            get => instance == null ? instance = new DanhMucMonDAO() : instance;
            private set => instance = value;
        }

        private DanhMucMonDAO()
        {

        }

        public static int GroupBoxWidth = 500;

        public List<DanhMucMon> GetListDanhMucMon()
        {
            List<DanhMucMon> listDanhMucMon = new List<DanhMucMon>();

            DataTable data = DataProvider.Instance.ExecuteQuery("USP_GetListDanhMucMon");

            foreach (DataRow row in data.Rows)
            {
                DanhMucMon danhMucMon = new DanhMucMon(row);
                listDanhMucMon.Add(danhMucMon);
            }

            return listDanhMucMon;
        }

        public DataTable GetDataTableDanhMucMon()
        {
            return DataProvider.Instance.ExecuteQuery("USP_GetListDanhMucMon");
        }

        public bool InsertDanhMucMon(string tenDanhMucMon)
        {
            int count = DataProvider.Instance.ExecuteNonQuery("EXEC USP_InsertDanhMucMon @tenDanhMucMon ", new object[] { tenDanhMucMon });
            return count > 0;
        }

        public bool UpdateDanhMucMon(int maDanhMucMon, string tenDanhMucMon)
        {
            int count = DataProvider.Instance.ExecuteNonQuery("EXEC USP_UpdateDanhMucMon @maDanhMucMon , @tenDanhMucMon ", new object[] { maDanhMucMon, tenDanhMucMon });
            return count > 0;
        }

        public bool DeleteDanhMucMon(int maDanhMucMon)
        {
            int count = DataProvider.Instance.ExecuteNonQuery("EXEC USP_DeleteDanhMucMon " + maDanhMucMon);
            return count > 0;
        }
        public bool CheckTenDanhMucMonExist(string tenDanhMucMon)
        {
            return DataProvider.Instance.ExecuteQuery("EXEC USP_GetDanhMucMonByName @tenDanhMucMon ", new object[] { tenDanhMucMon }).Rows.Count > 0;
        }
    }
}
