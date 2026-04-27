using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskManager.Core.Models;
using TaskManager.Business.Services;

namespace TaskManager.UI
{
    public partial class DashboardForm : Form
    {
        private User _currentUser;
        private TaskService _taskService;

        public DashboardForm(User user)
        {
            InitializeComponent();
            _currentUser = user;
            _taskService = new TaskService();

            LoadDashboard();
        }

        private void LoadDashboard()
        {
            List<TaskItem> tasks;

            // Check kung Admin ba ang naka-login
            if (_currentUser.Role == "Admin")
            {
                // Kung admin, kuhaa ang tanang tasks (overall)
                tasks = _taskService.GetAllTasks();
            }
            else
            {
                // Kung staff, iyang kaugalingon ra nga tasks
                tasks = _taskService.GetUserTasks(_currentUser.Id);
            }

            // Display Welcome Message
            lblWelcome.Text = $"Welcome, {_currentUser.Role}: {_currentUser.Name}";

            // 1. Total Tasks (Overall na kini kung Admin)
            lblTotalTasks.Text = "Total: " + tasks.Count;

            // 2. Completed Tasks
            lblCompletedTasks.Text = "Completed: " + tasks.Count(t => t.Status == "Complete");

            // 3. Pending Tasks
            lblPendingTasks.Text = "Pending: " + tasks.Count(t => t.Status == "Pending");

            // 4. Overdue
            lblOverdue.Text = "Overdue: " + tasks.Count(t =>
                t.Status != "Complete" &&
                t.DueDate.Date < DateTime.Today
            );
        }
        private void btnTasks_Click(object sender, EventArgs e)
        {
            // 1. I-hide ang current dashboard form
            this.Hide();

            TasksForm tasksForm = new TasksForm(_currentUser);

            // I-refresh ang dashboard data kung naay nausab sa tasks
            tasksForm.OnTaskChanged += () => { LoadDashboard(); };

            // 2. I-show ang TasksForm isip Dialog
            // Ang code mohunong diri hangtod i-close sa user ang TasksForm
            tasksForm.ShowDialog();

            // 3. Inig close sa TasksForm, mo-pakita na sab ang DashboardForm
            this.Show();
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {

        }



        private void btnLogout_Click(object sender, EventArgs e)
        {

            LoginForm login = new LoginForm();
            login.Show();

            // Hide lang ang dashboard imbes i-close dayon 
            // aron dili ma-shutdown ang app kung kini ang main form
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }
    }
}


