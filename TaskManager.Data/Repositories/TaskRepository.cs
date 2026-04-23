using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Net.Http;
using Newtonsoft.Json;
using TaskManager.Core.Models;
using TaskManager.Data.Database;

namespace TaskManager.Data.Repositories
{
    public class TaskRepository
    {
        // 1. Pag-load sa Tasks (Gikuha ang karaan nga IsCompleted, gipulihan og Status)
        public List<TaskItem> GetTasksByUser(int userId)
        {
            List<TaskItem> tasks = new List<TaskItem>();
            using var connection = DatabaseManager.GetConnection();
            connection.Open();

            string query = "SELECT * FROM Tasks WHERE UserId = @userId";
            using var cmd = new SQLiteCommand(query, connection);
            cmd.Parameters.AddWithValue("@userId", userId);

            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                tasks.Add(new TaskItem
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    RoomNo = reader["RoomNo"].ToString(),
                    AssignedTo = reader["AssignedTo"].ToString(),
                    DueDate = DateTime.Parse(reader["DueDate"].ToString()),
                    Status = reader["Status"].ToString(), // "Pending", "In Progress", "Complete"
                    UserId = Convert.ToInt32(reader["UserId"]),
                    Note = reader["Note"].ToString()
                });
            }
            return tasks;
        }

        public List<TaskItem> GetTasksByStaff(string staffName)
        {
            List<TaskItem> tasks = new List<TaskItem>();

            using var connection = DatabaseManager.GetConnection();
            connection.Open();

            string query = "SELECT * FROM Tasks WHERE AssignedTo = @staffName";
            using var cmd = new SQLiteCommand(query, connection);
            cmd.Parameters.AddWithValue("@staffName", staffName);

            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                tasks.Add(new TaskItem
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    RoomNo = reader["RoomNo"].ToString(),
                    AssignedTo = reader["AssignedTo"].ToString(),
                    DueDate = DateTime.Parse(reader["DueDate"].ToString()),
                    Status = reader["Status"].ToString(),
                    UserId = Convert.ToInt32(reader["UserId"]),
                    Note = reader["Note"].ToString()
                });
            }

            return tasks;
        }

        // 2. Pagdugang og Task (Default status is "Pending")
        public void AddTask(TaskItem task)
        {
            using var connection = DatabaseManager.GetConnection();
            connection.Open();

            string query = @"INSERT INTO Tasks (RoomNo, AssignedTo, DueDate, Status, UserId, Note)
                             VALUES (@roomnum, @assign, @dueDate, @status, @userId, @note)";

            using var cmd = new SQLiteCommand(query, connection);
            cmd.Parameters.AddWithValue("@roomnum", task.RoomNo);
            cmd.Parameters.AddWithValue("@assign", task.AssignedTo);
            cmd.Parameters.AddWithValue("@dueDate", task.DueDate.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@status", "Pending");
            cmd.Parameters.AddWithValue("@userId", task.UserId);
            cmd.Parameters.AddWithValue("@note", task.Note);

            cmd.ExecuteNonQuery();
        }

        // 3. General Update (Para sa Edit feature)
        public void UpdateTask(TaskItem task)
        {
            using var connection = DatabaseManager.GetConnection();
            connection.Open();

            string query = @"UPDATE Tasks 
                             SET RoomNo = @RoomNo,
                                 AssignedTo = @Assigned,
                                 DueDate = @DueDate, 
                                 Status = @Status,
                                 Note = @Note
                             WHERE Id = @Id";

            using var cmd = new SQLiteCommand(query, connection);
            cmd.Parameters.AddWithValue("@RoomNo", task.RoomNo);
            cmd.Parameters.AddWithValue("@Assigned", task.AssignedTo);
            cmd.Parameters.AddWithValue("@DueDate", task.DueDate.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@Status", task.Status);
            cmd.Parameters.AddWithValue("@Note", task.Note);
            cmd.Parameters.AddWithValue("@Id", task.Id);

            cmd.ExecuteNonQuery();
        }

        // 4. Specific Status Update (Gamiton sa Staff inig 'Accept' o 'Complete')
        public void UpdateTaskStatus(int taskId, string newStatus)
        {
            using var connection = DatabaseManager.GetConnection();
            connection.Open();

            string query = "UPDATE Tasks SET Status = @status WHERE Id = @id";
            using var cmd = new SQLiteCommand(query, connection);
            cmd.Parameters.AddWithValue("@status", newStatus);
            cmd.Parameters.AddWithValue("@id", taskId);

            cmd.ExecuteNonQuery();
        }

        public void DeleteTask(int taskId)
        {
            using var connection = DatabaseManager.GetConnection();
            connection.Open();
            string query = "DELETE FROM Tasks WHERE Id=@id";
            using var cmd = new SQLiteCommand(query, connection);
            cmd.Parameters.AddWithValue("@id", taskId);
            cmd.ExecuteNonQuery();
        }

        // --- API METHODS PARA SA HOTEL BLUE BIRD SYNC ---

        // 2. Mokuha sa listahan sa staff gikan sa API (Hotel MySQL DB)

        public List<string> GetStaffByWork(string work)

        {

            try

            {

                using (var client = new HttpClient())

                {

                    string url = $"http://localhost/Hotel-Management-System-main/api/get_staff.php?work={work}";

                    var response = client.GetAsync(url).Result;

                    if (response.IsSuccessStatusCode)

                    {

                        var json = response.Content.ReadAsStringAsync().Result;

                        return JsonConvert.DeserializeObject<List<string>>(json);

                    }

                }

            }

            catch (Exception ex) { }

            return new List<string>();

        }



        public List<string> GetRoomsByStatus(string status)
        {
            try
            {
                using var client = new HttpClient();
                string url = $"http://localhost/Hotel-Management-System-main/api/get_rooms.php?status={status}";
                var response = client.GetAsync(url).Result;
                if (response.IsSuccessStatusCode)
                {
                    var json = response.Content.ReadAsStringAsync().Result;
                    return JsonConvert.DeserializeObject<List<string>>(json);
                }
            }
            catch (Exception ex) { System.Diagnostics.Debug.WriteLine("API Error: " + ex.Message); }
            return new List<string>();
        }

        public void UpdateRoomStatusInHotelSystem(string roomNo, string newStatus)
        {
            try
            {
                using var client = new HttpClient();
                string url = "http://localhost/Hotel-Management-System-main/api/update_room.php";
                var parameters = new Dictionary<string, string> { { "roomNo", roomNo }, { "status", newStatus } };
                var content = new FormUrlEncodedContent(parameters);
                var response = client.PostAsync(url, content).Result;
            }
            catch (Exception ex) { System.Diagnostics.Debug.WriteLine("Sync Error: " + ex.Message); }
        }
    }
}