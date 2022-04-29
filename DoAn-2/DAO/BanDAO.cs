using restaurant_management.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restaurant_management.DAO
{
    public class BanDAO
    {
        private static BanDAO instance;

        internal static BanDAO Instance 
        {
            get => instance == null ? instance = new BanDAO() : instance; 
            set => instance = value; 
        }

        public static int BanWidth = 120;

        public static int BanHeight = 120;

        private BanDAO() { }

        public List<Ban> GetListBan()
        {
            List<Ban> listBan = new List<Ban>();

            DataTable data = DataProvider.Instance.ExecuteQuery("EXEC dbo.USP_GetListBan");

            foreach (DataRow row in data.Rows)
            {
                Ban ban = new Ban(row);
                listBan.Add(ban);
            }

            return listBan;
        }

        public List<Ban> GetListBanCoTheChuyen()
        {
            List<Ban> listBan = new List<Ban>();

            DataTable data = DataProvider.Instance.ExecuteQuery("EXEC dbo.USP_GetListBanTrong");

            foreach (DataRow row in data.Rows)
            {
                Ban ban = new Ban(row);
                listBan.Add(ban);
            }

            return listBan;
        }
    }
}
