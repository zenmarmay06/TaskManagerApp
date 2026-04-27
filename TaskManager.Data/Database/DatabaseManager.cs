using System;
using MySql.Data.MySqlClient;

namespace TaskManager.Data.Database
{
    public static class DatabaseManager
    {
        // 🔥 MySQL Connection String (EDIT NI BASE SA IMONG XAMPP)
        private static string connectionString =
            "server=localhost;database=bluebirdhotel;uid=root;pwd=;";

        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }
    }
}