using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using TaskManager.Core.Models;
using TaskManager.Data.Database;

namespace TaskManager.Data.Repositories
{
    public class UserRepository
    {
        public User GetUser(string username, string password)
        {
            using var connection = DatabaseManager.GetConnection();
            connection.Open();

            string query = "SELECT * FROM Users WHERE Username=@username AND Password=@password";

            SQLiteCommand cmd = new SQLiteCommand(query, connection);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);

            using var reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                return new User
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    Username = reader["Username"].ToString(),
                    Role = reader["Role"].ToString()
                };
            }

            return null;
        }
    }
}