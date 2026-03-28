using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace TaskManager.Data.Database
{
    public static class DatabaseManager
    {
        private static string connectionString = "Data Source=taskmanager.db";

        public static SQLiteConnection GetConnection()
        {
            return new SQLiteConnection(connectionString);
        }
    }
}