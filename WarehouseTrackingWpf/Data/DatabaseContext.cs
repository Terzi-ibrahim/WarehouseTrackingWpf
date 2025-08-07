using Microsoft.Data.SqlClient;
using System.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseTrackingWpf.Data
{
    class DatabaseContext
    {
        private readonly string _connectionString;

        public DatabaseContext()
        {
            _connectionString = ConfigurationManager
                .ConnectionStrings["DefaultConnection"]
                .ConnectionString;
        }

        public SqlConnection CreateConnection()
        {
            return new SqlConnection(_connectionString);
        }
    }
}
