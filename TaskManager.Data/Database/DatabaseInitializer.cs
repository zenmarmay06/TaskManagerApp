using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;


namespace TaskManager.Data.Database
{
    public static class DatabaseInitializer
    {
        public static void Initialize()
        {
            using var connection = DatabaseManager.GetConnection();
            connection.Open();

            string createUsersTable = @"
            CREATE TABLE IF NOT EXISTS Users (
                Id INTEGER PRIMARY KEY AUTOINCREMENT,
                Username TEXT NOT NULL UNIQUE,
                Password TEXT NOT NULL,
                Role TEXT NOT NULL
            );";

            string createTasksTable = @"
            CREATE TABLE IF NOT EXISTS Tasks (
                Id INTEGER PRIMARY KEY AUTOINCREMENT,
                Title TEXT NOT NULL,
                Description TEXT,
                DueDate TEXT,
                IsCompleted INTEGER,
                UserId INTEGER,
                Priority TEXT
            );";

            new SQLiteCommand(createUsersTable, connection).ExecuteNonQuery();
            new SQLiteCommand(createTasksTable, connection).ExecuteNonQuery();

            // 🔥 Eski DB'ler için (Priority kolonu yoksa ekler)
            try
            {
                new SQLiteCommand("ALTER TABLE Tasks ADD COLUMN Priority TEXT;", connection).ExecuteNonQuery();
            }
            catch
            {
                // zaten varsa hata verir → ignore
            }

            string insertAdmin = @"
            INSERT OR IGNORE INTO Users (Id, Username, Password, Role)
            VALUES (1, 'admin', 'admin123', 'Admin');";

            new SQLiteCommand(insertAdmin, connection).ExecuteNonQuery();
        }
    }
}