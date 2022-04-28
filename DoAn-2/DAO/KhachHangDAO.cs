using restaurant_management.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restaurant_management.DAO
{
    public class KhachHangDAO
    {
        private static KhachHangDAO instance;

        public static KhachHangDAO Instance
        {
            get => instance == null ? instance = new KhachHangDAO() : instance;
            private set => instance = value;
        }

        public KhachHangDAO() { }

        public KhachHang GetKhachHangByID(int maKhachHang)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("USP_GetKhachHangByID " + maKhachHang);
            return data.Rows.Count > 0 ? new KhachHang(data.Rows[0]) : null;
        }
    }
}
