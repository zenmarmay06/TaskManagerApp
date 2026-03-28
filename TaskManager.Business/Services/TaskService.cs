using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        public void CompleteTask(int taskId)
        {
            if (taskId <= 0)
                throw new ArgumentException("Invalid task id");

            _taskRepository.CompleteTask(taskId);
        }
    
    }
}