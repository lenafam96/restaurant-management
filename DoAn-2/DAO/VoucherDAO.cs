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
    }
}
