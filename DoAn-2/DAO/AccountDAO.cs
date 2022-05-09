using restaurant_management.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace restaurant_management.DAO
{
    class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance
        {
            get => instance == null ? instance = new AccountDAO() : instance;
            private set => instance = value;
        }

        private AccountDAO()
        {

        }
        
        public bool Login(string userName, string passWord)
        {
            string query = "EXEC dbo.USP_Login @userName , @passWord ";

            DataTable data = DataProvider.Instance.ExecuteQuery(query,new object[] { userName, HasPass(passWord) });
            return data.Rows.Count > 0;
        }

        public DataTable GetAccountList()
        {
            string query = "EXEC dbo.USP_GetAccountList";

            return DataProvider.Instance.ExecuteQuery(query);
        }

        public Account GetAccountByUserName(string userName)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("EXEC USP_GetAccountByUserName '" + userName + "' ");
            foreach (DataRow item in data.Rows)
            {
                Account account = new Account(item);
                return account;
            }
            return null;
        }

        string HasPass(string pass)
        {
            byte[] temp = ASCIIEncoding.ASCII.GetBytes(pass);
            byte[] hasData = new MD5CryptoServiceProvider().ComputeHash(temp);

            string hasPass = "";
            foreach (byte item in hasData)
            {
                hasPass += item;
            }

            var list = hasData.Reverse();

            string hassPassRev = "";
            foreach (byte item in list)
            {
                hassPassRev += item;
            }
            return hassPassRev;
        }

        public bool UpdateAccountInfo(string userName, int maNhanVien, string passWord, int role)
        {

            int count = DataProvider.Instance.ExecuteNonQuery("EXEC dbo.USP_UpdateAccount @userName , @maNhanVien , @passWord , @newPassWord , @role ", new object[] { userName, maNhanVien, HasPass(passWord), role });
            return count > 0;
        }

        public bool UpdateAccountRole(string userName, int maNhanVien, int role)
        {

            int count = DataProvider.Instance.ExecuteNonQuery("EXEC dbo.USP_UpdateRoleAccount @userName , @maNhanVien , @role ", new object[] { userName, maNhanVien, role });
            return count > 0;
        }

        public bool CreateNewAccount(string userName, int maNhanVien, int role)
        {
            int count = DataProvider.Instance.ExecuteNonQuery("EXEC dbo.USP_InsertAccount @userName , @maNhanVien , @role ", new object[] { userName, maNhanVien, role });
            return count > 0;
        }

        public bool EditAccountInfo(string userName, int maNhanVien, int role)
        {
            int count = DataProvider.Instance.ExecuteNonQuery("UPDATE dbo.TaiKhoan SET maNhanVien = '" + maNhanVien + "', role = " + role + " WHERE userName = N'" + userName + "' ");
            return count > 0;
        }

        public List<Account> SreachAccoutByName(string name)
        {
            string query = "EXEC dbo.USP_SreachUserByName @name ";

            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { name });

            List<Account> listAccount = new List<Account>();
            foreach (DataRow item in data.Rows)
            {
                Account account = new Account(item);
                listAccount.Add(account);
            }
            return listAccount;
        }
        public bool DeleteAccountByUserName(string userName)
        {
            string query = "EXEC dbo.USP_DeleteAccount @userName ";

            int count = DataProvider.Instance.ExecuteNonQuery(query, new object[] { userName });
            return count > 0;
        }

        public bool ResetPassWord(string userName)
        {
            string query = "EXEC dbo.USP_ResetPassword @userName ";

            int count = DataProvider.Instance.ExecuteNonQuery(query, new object[] { userName });
            return count > 0;
        }
    }
}
