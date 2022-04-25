using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restaurant_management.DAO
{
    class TestConnection
    {
        private static string connectionString = System.IO.File.ReadAllText("connectionString.txt");

        public static string ConnectionString { get => connectionString; set => connectionString = value; }

        public bool Test()
        {
            System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection(connectionString);

            try
            {
                con.Open();

                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
