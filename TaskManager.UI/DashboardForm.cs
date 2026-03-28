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

        public event Action OnTaskChanged;
        private void btnTasks_Click(object sender, EventArgs e)
        {
            TasksForm tasksForm = new TasksForm(_currentUser);

            tasksForm.OnTaskChanged += () =>
            {
                LoadDashboard();
            };

            tasksForm.Show();
        }
        public DashboardForm(User user)
        {
            InitializeComponent();
            _currentUser = user;
            _taskService = new TaskService();

            LoadDashboard();
        }

        private void LoadDashboard()
        {
            var tasks = _taskService.GetUserTasks(_currentUser.Id);

            lblWelcome.Text = "Welcome " + _currentUser.Username;
            lblTotalTasks.Text = "Total : " + tasks.Count();
            lblCompletedTasks.Text = "Completed: " + tasks.Count(t => t.IsCompleted);
            lblPendingTasks.Text = "Pending: " + tasks.Count(t => !t.IsCompleted);
            lblOverdue.Text = "Overdue: " + tasks.Count(t => !t.IsCompleted && t.DueDate.Date < DateTime.Today);

            lblTotalTasks.Text = "Total : " + tasks.Count();

            lblCompletedTasks.Text = "Completed: " + tasks.Count(t => t.IsCompleted);

            lblOverdue.Text = "Overdue: " + tasks.Count(t =>
                !t.IsCompleted && t.DueDate.Date < DateTime.Today
            );

            lblPendingTasks.Text = "Pending: " + tasks.Count(t =>
                !t.IsCompleted && t.DueDate.Date >= DateTime.Today
            );
        }
        private void DashboardForm_Load(object sender, EventArgs e)
        {

        }



        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Close();
        }

 
        }
    }


