using restaurant_management.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restaurant_management.DAO
{
    class RoleDAO
    {
        private static RoleDAO instance;

        public static RoleDAO Instance
        {
            get => instance == null ? instance = new RoleDAO() : instance;
            private set => instance = value;
        }

        private RoleDAO()
        {

        }

        public List<Role> GetRoleList()
        {
            string query = "EXEC dbo.USP_GetListRole";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            List<Role> listRole = new List<Role>();
            foreach (DataRow item in data.Rows)
            {
                Role role = new Role(item);
                listRole.Add(role);
            }
            return listRole;
        }

        public Role GetRoleByID(int id)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("EXEC dbo.USP_GetRoleByID " + id);
            foreach (DataRow item in data.Rows)
            {
                Role role = new Role(item);
                return role;
            }
            return null;
        }

        public bool UpdateRole(int idRole, bool quyenBan, bool quyenNhanVien, bool quyenKhachHang, bool quyenVoucher, bool quyenThongKe, bool quyenKho)
        {

            int count = DataProvider.Instance.ExecuteNonQuery("EXEC dbo.USP_UpdateRoleSetting @role , @quyenBan , @quyenNhanVien , @quyenKhachHang , @quyenVoucher , @quyenThongKe , @quyenKho ", new object[] { idRole, quyenBan, quyenNhanVien, quyenKhachHang, quyenVoucher, quyenThongKe, quyenKho });
            return count > 0;
        }
    }
}
