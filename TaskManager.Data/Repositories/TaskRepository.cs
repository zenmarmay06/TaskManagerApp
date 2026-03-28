using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.Core.Models;
using System.Data.SQLite;
using TaskManager.Data.Database;

namespace TaskManager.Data.Repositories
{
    public class TaskRepository
    {
        public List<TaskItem> GetTasksByUser(int userId)
        {
            List<TaskItem> tasks = new List<TaskItem>();

            using var connection = DatabaseManager.GetConnection();
            connection.Open();

            string query = "SELECT * FROM Tasks WHERE UserId = @userId";

            SQLiteCommand cmd = new SQLiteCommand(query, connection);
            cmd.Parameters.AddWithValue("@userId", userId);

            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                tasks.Add(new TaskItem
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    Title = reader["Title"].ToString(),
                    Description = reader["Description"].ToString(),
                    DueDate = DateTime.Parse(reader["DueDate"].ToString()),
                    IsCompleted = Convert.ToInt32(reader["IsCompleted"]) == 1,
                    UserId = Convert.ToInt32(reader["UserId"]),
                    Priority = reader["Priority"]?.ToString()
                });
            }

            return tasks;
        }
        public void UpdateTask(TaskItem task)
        {
            using (var connection = DatabaseManager.GetConnection())
            {
                connection.Open();

                string query = @"UPDATE Tasks 
                         SET Title = @Title,
                             Description = @Description,
                             DueDate = @DueDate, 
                             Priority = @Priority
                         WHERE Id = @Id";

                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Title", task.Title);
                    command.Parameters.AddWithValue("@Description", task.Description);
                    command.Parameters.AddWithValue("@DueDate", task.DueDate);
                    command.Parameters.AddWithValue("@Id", task.Id);
                    command.Parameters.AddWithValue("@Priority", task.Priority);

                    command.ExecuteNonQuery();
                }
            }
        }
        public void AddTask(TaskItem task)
        {
            using var connection = DatabaseManager.GetConnection();
            connection.Open();

            string query = @"INSERT INTO Tasks (Title, Description, DueDate, IsCompleted, UserId, Priority)
VALUES (@title, @description, @dueDate, @completed, @userId, @priority)";

            SQLiteCommand cmd = new SQLiteCommand(query, connection);

            cmd.Parameters.AddWithValue("@title", task.Title);
            cmd.Parameters.AddWithValue("@description", task.Description);
            cmd.Parameters.AddWithValue("@dueDate", task.DueDate.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@completed", task.IsCompleted ? 1 : 0);
            cmd.Parameters.AddWithValue("@userId", task.UserId);
            cmd.Parameters.AddWithValue("@priority", task.Priority);

            cmd.ExecuteNonQuery();
        }

        public void DeleteTask(int taskId)
        {
            using var connection = DatabaseManager.GetConnection();
            connection.Open();

            string query = "DELETE FROM Tasks WHERE Id=@id";

            SQLiteCommand cmd = new SQLiteCommand(query, connection);
            cmd.Parameters.AddWithValue("@id", taskId);

            cmd.ExecuteNonQuery();
        }

        public void CompleteTask(int taskId)
        {
            using var connection = DatabaseManager.GetConnection();
            connection.Open();

            string query = "UPDATE Tasks SET IsCompleted=1 WHERE Id=@id";

            SQLiteCommand cmd = new SQLiteCommand(query, connection);
            cmd.Parameters.AddWithValue("@id", taskId);

            cmd.ExecuteNonQuery();
        }
     
    }
}