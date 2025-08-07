using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseTrackingWpf.Interface;

namespace WarehouseTrackingWpf.Account
{
    public class LoginService : ILoginService
    {
        private readonly string _connectionString;

        public LoginService()
        {
            
            _connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        }

        public bool Login(string username, string password)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = "SELECT COUNT(*) FROM Users WHERE Username = @username AND Password = @password";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password); 

                conn.Open();
                int count = (int)cmd.ExecuteScalar();

                return count > 0;
            }
        }

    }
}
