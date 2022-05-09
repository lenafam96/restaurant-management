using restaurant_management.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restaurant_management.DAO
{
    public class ChiTietPhieuNhapDAO
    {
        private static ChiTietPhieuNhapDAO instance;

        internal static ChiTietPhieuNhapDAO Instance
        {
            get => instance == null ? instance = new ChiTietPhieuNhapDAO() : instance;
            private set => instance = value;
        }

        public ChiTietPhieuNhapDAO() { }

        public List<ChiTietPhieuNhap> GetListThucPhamByMaPhieuNhap(int maPhieuNhap)
        {
            List<ChiTietPhieuNhap> list = new List<ChiTietPhieuNhap>();

            string query = "EXEC USP_GetListThucPhamByMaPhieuNhap " + maPhieuNhap;

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                ChiTietPhieuNhap tmp = new ChiTietPhieuNhap(item);
                list.Add(tmp);
            }

            return list;
        }
        public ChiTietPhieuNhap CheckThucPhamTrongPhieuNhap(int maPhieuNhap, int maThucPham)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("EXEC USP_CheckThucPhamTrongPhieuNhap @maPhieuNhap , @maThucPham ", new object[] { maPhieuNhap, maThucPham });
            return data.Rows.Count > 0 ? new ChiTietPhieuNhap(data.Rows[0]) : null;
        }

        public bool ThemThucPhamVaoPhieuNhap(int maPhieuNhap, int maThucPham, int soLuong, int gia)
        {
            if (soLuong < 0)
                soLuong = 0;
            int count = DataProvider.Instance.ExecuteNonQuery("USP_InsertChiTietPhieuNhap @maPhieuNhap , @maThucPham , @soLuong , @gia ", new object[] { maPhieuNhap, maThucPham, soLuong, gia });
            return count > 0;
        }

        public bool CapNhatThucPhamVaoPhieuNhap(int maPhieuNhap, int maThucPham, int soLuong, int gia)
        {
            int count = DataProvider.Instance.ExecuteNonQuery("USP_UpdateChiTietPhieuNhap @maPhieuNhap , @maThucPham , @soLuong , @gia ", new object[] { maPhieuNhap, maThucPham, soLuong, gia });
            return count > 0;
        }
    }
}
