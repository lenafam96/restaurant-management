using restaurant_management.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restaurant_management.DAO
{
    class ChiTietHoaDonDAO
    {
        private static ChiTietHoaDonDAO instance;

        internal static ChiTietHoaDonDAO Instance
        {
            get => instance == null ? instance = new ChiTietHoaDonDAO() : instance;
            private set => instance = value;
        }
        
        public ChiTietHoaDonDAO() { }

        public List<ChiTietHoatDon> GetListMonAnByMaBan(int maBan)
        {
            List<ChiTietHoatDon> list = new List<ChiTietHoatDon>();

            string query = "EXEC USP_GetListMonAnByMaBan " + maBan;

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                ChiTietHoatDon tmp = new ChiTietHoatDon(item);
                list.Add(tmp);
            }

            return list;
        }

        public bool CheckMonAnTrongHoaDon(int maHoaDon, int maMonAn)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("EXEC USP_CheckMonAnTrongHoaDon @maHoaDon , @maMonAn", new object[] { maHoaDon, maMonAn });
            return data.Rows.Count > 0;
        }

        public bool ThemMonAnVaoHoaDon(int maHoaDon, int maMonAn, int soLuong)
        {
            if (soLuong < 0)
                soLuong = 0;
            int count = DataProvider.Instance.ExecuteNonQuery("USP_InsertChiTietHoaDon @maHoaDon , @maMonAn , @soLuong ", new object[] { maHoaDon, maMonAn, soLuong });
            return count > 0;
        }

        public bool CapNhatMonAnVaoHoaDon(int maHoaDon, int maMonAn, int soLuong)
        {
            int count = DataProvider.Instance.ExecuteNonQuery("USP_UpdateChiTietHoaDon @maHoaDon , @maMonAn , @soLuong ", new object[] { maHoaDon, maMonAn, soLuong });
            return count > 0;
        }
    }
}
