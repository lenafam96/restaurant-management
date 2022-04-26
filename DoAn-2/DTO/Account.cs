using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restaurant_management.DTO
{
    public class Account
    {
        public Account(string userName, int maNhanVien, string displayName, int role, string password = null)
        {
            this.UserName = userName;
            this.maNhanVien = maNhanVien;
            this.DisplayName = displayName;
            this.Role = role;
            this.Password = password;
        }

        public Account(DataRow row)
        {
            this.UserName = row["userName"].ToString();
            this.maNhanVien = (int)row["maNhanVien"];
            this.DisplayName = row["displayName"].ToString();
            this.Role = (int)row["role"];
            //this.Password = row["matKhau"].ToString();
        }

        private string userName;
        private int maNhanVien;
        private string displayName;
        private string password;
        private int role;

        public string UserName { get => userName; set => userName = value; }
        public string DisplayName { get => displayName; set => displayName = value; }
        public string Password { get => password; set => password = value; }
        public int Role { get => role; set => role = value; }
        public int MaNhanVien { get => maNhanVien; set => maNhanVien = value; }
    }
}
