using System;
using System.Collections.Generic;
using TaskManager.Core.Models;
using TaskManager.Data.Repositories;

namespace TaskManager.Business.Services
{
    public class TaskService
    {
        private readonly TaskRepository _taskRepository;

        public TaskService()
        {
            _taskRepository = new TaskRepository();
        }

        public List<TaskItem> GetUserTasks(int userId)
        {
            return _taskRepository.GetTasksByUser(userId);
        }

        public List<TaskItem> GetStaffTasks(string staffName)
        {
            return _taskRepository.GetTasksByStaff(staffName);
        }

        public void CreateTask(TaskItem task)
        {
            if (task == null)
                throw new ArgumentNullException(nameof(task));

            _taskRepository.AddTask(task);
        }

        public void DeleteTask(int taskId)
        {
            if (taskId <= 0)
                throw new ArgumentException("Invalid task id");

            _taskRepository.DeleteTask(taskId);
        }

        public void UpdateTask(TaskItem task)
        {
            _taskRepository.UpdateTask(task);
        }

        // --- GI-UPDATE NGA MGA METHODS PARA SA INTEGRATION ---

        // 1. Pag-accept sa Task (Staff side)
        public void AcceptTask(int taskId, string staffName)
        {
            if (taskId <= 0) throw new ArgumentException("Invalid task id");

            // Gamiton nato ang UpdateTaskStatus gikan sa Repository
            _taskRepository.UpdateTaskStatus(taskId, "In Progress");

            // Pwede sab nimo i-update kinsay naka-assign kung wala pa na-set
            // Depende sa imong UI logic
        }

        // 2. Pag-complete sa Task ug pag-update sa Hotel System
        public void MarkTaskAsComplete(int taskId, string roomNo)
        {
            if (taskId <= 0) throw new ArgumentException("Invalid task id");

            // I-update ang SQLite status
            _taskRepository.UpdateTaskStatus(taskId, "Complete");

            // IMPORTANTE: I-update ang MySQL Room Status balik sa 'Available'
            if (!string.IsNullOrEmpty(roomNo))
            {
                _taskRepository.UpdateRoomStatusInHotelSystem(roomNo, "Available");
            }
        }

        // 3. Mokuha sa mga rooms nga naay status nga 'Maintenance' gikan sa MySQL
        public List<string> GetMaintenanceRooms()
        {
            return _taskRepository.GetRoomsByStatus("Maintenance");
        }

        // 4. Mokuha sa cleaners (Pahinumdom: Siguroha nga naa kay GetStaffByWork sa Repository)
        public List<string> GetStaffByWork()
        {
            // Note: Kung wala pa nimo na-add ang GetStaffByWork sa Repository, 
            // gamita lang una ang GetRoomsByStatus as pattern.
            return _taskRepository.GetStaffByWork("Cleaner"); // Pananglitan lang
        }
    }
}