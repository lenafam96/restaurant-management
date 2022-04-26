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
    }
}
