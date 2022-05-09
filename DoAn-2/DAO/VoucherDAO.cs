using restaurant_management.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restaurant_management.DAO
{
    public class VoucherDAO
    {
        private static VoucherDAO instance;

        public static VoucherDAO Instance
        {
            get => instance == null ? instance = new VoucherDAO() : instance;
            private set => instance = value;
        }

        public VoucherDAO() { }

        public Voucher GetVoucherByID(int maVoucher)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("USP_GetVoucherByID " + maVoucher);
            return data.Rows.Count > 0 ? new Voucher(data.Rows[0]) : null;
        }

        public DataTable GetListVoucher()
        {
            return DataProvider.Instance.ExecuteQuery("EXEC USP_GetListVoucher");
        }

        public DataTable GetListVoucherCmb()
        {
            return DataProvider.Instance.ExecuteQuery("EXEC USP_GetListVoucherCmb");
        }

        public bool InsertVoucher(DateTime ngayBatDau, DateTime ngayKetThuc, string moTa, int giaTri, int loai)
        {
            int count = DataProvider.Instance.ExecuteNonQuery("EXEC USP_InsertVoucher @ngayBatDau , @ngayKetThuc , @moTa , @giaTri , @loai ", new object[] { ngayBatDau.ToString("yyyy-MM-dd"), ngayKetThuc.ToString("yyyy-MM-dd"), moTa, giaTri, loai });
            return count > 0;
        }

        public bool UpdateVoucher(int maVoucher, DateTime ngayBatDau, DateTime ngayKetThuc, string moTa, int giaTri, int loai)
        {
            int count = DataProvider.Instance.ExecuteNonQuery("EXEC USP_UpdateVoucher @maVoucher , @ngayBatDau , @ngayKetThuc , @moTa , @giaTri , @loai ", new object[] { maVoucher, ngayBatDau.ToString("yyyy-MM-dd"), ngayKetThuc.ToString("yyyy-MM-dd"), moTa, giaTri, loai });
            return count > 0;
        }

        public bool DeleteVoucher(int maVoucher)
        {
            int count = DataProvider.Instance.ExecuteNonQuery("EXEC USP_DeleteVoucher " + maVoucher);
            return count > 0;
        }
    }
}
