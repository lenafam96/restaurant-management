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

            DataTable data = DataProvider.Instance.ExecuteQuery("USP_GetListMonAn " + maDanhMucMon);

            foreach (DataRow row in data.Rows)
            {
                MonAn monAn = new MonAn(row);
                listMonAn.Add(monAn);
            }

            return listMonAn;
        }
    }
}
