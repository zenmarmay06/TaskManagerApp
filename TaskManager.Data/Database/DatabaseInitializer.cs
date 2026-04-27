using System;
using MySql.Data.MySqlClient;
using BCrypt.Net;

namespace TaskManager.Data.Database
{
    public static class DatabaseInitializer
    {
        public static void Initialize()
        {
            using var connection = DatabaseManager.GetConnection();
            connection.Open();

            // =========================
            // USERS TABLE (MYSQL)
            // =========================
            string createUsersTable = @"
CREATE TABLE IF NOT EXISTS users (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    Name VARCHAR(100),
    Username VARCHAR(100) NOT NULL UNIQUE,
    Password VARCHAR(255) NOT NULL,
    Role VARCHAR(20) NOT NULL
);";

            // =========================
            // TASKS TABLE (MYSQL)
            // =========================
            string createTasksTable = @"
CREATE TABLE IF NOT EXISTS tasks (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    RoomNo VARCHAR(50),
    Priority VARCHAR(20),
    AssignedTo VARCHAR(100),
    DueDate DATE,
    CompleteDate DATE,
    Status VARCHAR(20) DEFAULT 'Pending',
    UserId INT,
    Note TEXT
);";

            new MySqlCommand(createUsersTable, connection).ExecuteNonQuery();
            new MySqlCommand(createTasksTable, connection).ExecuteNonQuery();

            // =========================
            // CHECK ADMIN COUNT
            // =========================
            string checkAdmin = "SELECT COUNT(*) FROM users WHERE Role='Admin'";
            using var checkCmd = new MySqlCommand(checkAdmin, connection);
            long adminCount = Convert.ToInt64(checkCmd.ExecuteScalar());

            // =========================
            // DEFAULT ADMIN (ONLY ONCE)
            // =========================
            if (adminCount == 0)
            {
                string adminHashedPassword =
                    BCrypt.Net.BCrypt.HashPassword("admin123");

                string insertAdmin = @"
INSERT INTO users (Name, Username, Password, Role)
VALUES (@name, @username, @password, @role);";

                using var insertCmd = new MySqlCommand(insertAdmin, connection);
                insertCmd.Parameters.AddWithValue("@name", "Administrator");
                insertCmd.Parameters.AddWithValue("@username", "admin");
                insertCmd.Parameters.AddWithValue("@password", adminHashedPassword);
                insertCmd.Parameters.AddWithValue("@role", "Admin");

                insertCmd.ExecuteNonQuery();
            }
        }
    }
}