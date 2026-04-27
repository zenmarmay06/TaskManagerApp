using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using TaskManager.Core.Models;

namespace TaskManager.Data.Repositories
{
    public class TaskRepository
    {
        private readonly string baseApi = "http://localhost/Hotel-Management-System-main/api/";

        private readonly HttpClient client = new HttpClient();

        // ============================
        // GET ALL TASKS
        // GET /api/tasks
        // ============================
        public List<TaskItem> GetAllTasks()
        {
            var response = client
                .GetAsync(baseApi + "tasks")
                .Result;

            var json = response.Content.ReadAsStringAsync().Result;

            return JsonConvert.DeserializeObject<List<TaskItem>>(json);
        }

        // ============================
        // CREATE TASK
        // POST /api/tasks
        // ============================
        public void AddTask(TaskItem task)
        {
            var payload = new
            {
                roomNo = task.RoomNo,
                priority = task.Priority,
                assignedTo = task.AssignedTo,
                dueDate = task.DueDate.ToString("yyyy-MM-dd"),
                status = task.Status,
                note = task.Note
            };

            var content = new StringContent(
                JsonConvert.SerializeObject(payload),
                System.Text.Encoding.UTF8,
                "application/json"
            );

            client.PostAsync(baseApi + "tasks", content).Wait();
        }

        // ============================
        // UPDATE TASK
        // PUT /api/tasks/{id}
        // ============================
        public void UpdateTask(TaskItem task)
        {
            var payload = new
            {
                roomNo = task.RoomNo,
                priority = task.Priority,
                assignedTo = task.AssignedTo,
                dueDate = task.DueDate.ToString("yyyy-MM-dd"),
                status = task.Status,
                note = task.Note
            };

            var content = new StringContent(
                JsonConvert.SerializeObject(payload),
                System.Text.Encoding.UTF8,
                "application/json"
            );

            client.PutAsync(baseApi + "tasks/" + task.Id, content).Wait();
        }

        // ============================
        // DELETE TASK
        // DELETE /api/tasks/{id}
        // ============================
        public void DeleteTask(int taskId)
        {
            client.DeleteAsync(baseApi + "tasks/" + taskId).Wait();
        }

        // ============================
        // UPDATE STATUS
        // PATCH /api/tasks/{id}/status
        // ============================
        public void UpdateTaskStatus(int taskId, string status)
        {
            var payload = new
            {
                status = status
            };

            var content = new StringContent(
                JsonConvert.SerializeObject(payload),
                System.Text.Encoding.UTF8,
                "application/json"
            );

            var request = new HttpRequestMessage(new HttpMethod("PATCH"),
                baseApi + "tasks/" + taskId + "/status")
            {
                Content = content
            };

            client.SendAsync(request).Wait();
        }

        // ============================
        // ROOMS
        // GET /api/rooms?status=Maintenance
        // ============================
        public List<string> GetRoomsByStatus(string status)
        {
            var json = client
                .GetStringAsync(baseApi + "room?status=" + status)
                .Result;

            return JsonConvert.DeserializeObject<List<string>>(json);
        }

        // ============================
        // STAFF
        // GET /api/staff?work=Cleaner
        // ============================
        public List<string> GetStaffByWork(string work)
        {
            var json = client
                .GetStringAsync(baseApi + "staff?work=" + work)
                .Result;

            return JsonConvert.DeserializeObject<List<string>>(json);
        }

        // ============================
        // ROOM STATUS UPDATE
        // PUT /api/rooms/{roomNo}
        // ============================
        public void UpdateRoomStatusInHotelSystem(string roomNo, string status)
        {
            var payload = new
            {
                status = status
            };

            var content = new StringContent(
                JsonConvert.SerializeObject(payload),
                System.Text.Encoding.UTF8,
                "application/json"
            );

            client.PutAsync(baseApi + "room/" + roomNo, content).Wait();
        }
    }
}