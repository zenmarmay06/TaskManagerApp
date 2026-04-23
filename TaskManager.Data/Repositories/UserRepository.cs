using BCrypt.Net;
using TaskManager.Core.Models;
using TaskManager.Data.Database;
using System.Data.SQLite;
using System;

namespace TaskManager.Data.Repositories
{
    public class UserRepository
    {
        public bool RegisterUser(User user)
        {
            using var connection = DatabaseManager.GetConnection();
            connection.Open();

            // I-hash ang password para secure
            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(user.Password);

            // Gi-hardcode na nato ang 'Staff' sa query mismo
            string query = "INSERT INTO Users (Name, Username, Password, Role) VALUES (@name, @username, @password, 'Staff')";

            using var cmd = new SQLiteCommand(query, connection);
            cmd.Parameters.AddWithValue("@name", user.Name);
            cmd.Parameters.AddWithValue("@username", user.Username);
            cmd.Parameters.AddWithValue("@password", hashedPassword);

            return cmd.ExecuteNonQuery() > 0;
        }

        public User GetUser(string username, string password)
        {
            using var connection = DatabaseManager.GetConnection();
            connection.Open();

            string query = "SELECT * FROM Users WHERE Username=@username";
            using var cmd = new SQLiteCommand(query, connection);
            cmd.Parameters.AddWithValue("@username", username);

            using var reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                string storedHash = reader["Password"].ToString();

                if (BCrypt.Net.BCrypt.Verify(password, storedHash))
                {
                    return new User
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        Name = reader["Name"].ToString(),
                        Username = reader["Username"].ToString(),
                        Role = reader["Role"].ToString() // Kinahanglan gihapon ni para sa app logic
                    };
                }
            }
            return null;
        }
    }
}