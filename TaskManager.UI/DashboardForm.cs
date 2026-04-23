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
            // Pagkuha sa tasks gikan sa Service
            var tasks = _taskService.GetUserTasks(_currentUser.Id);

            // Display Welcome Message
            lblWelcome.Text = "Welcome, " + _currentUser.Name; // Mas maayo Name para professional

            // 1. Total Tasks
            lblTotalTasks.Text = "Total: " + tasks.Count();

            // 2. Completed Tasks (Base sa string status)
            lblCompletedTasks.Text = "Completed: " + tasks.Count(t => t.Status == "Complete");

            // 3. Pending Tasks (Wala pa nasugdan)
            lblPendingTasks.Text = "Pending: " + tasks.Count(t => t.Status == "Pending");

            // 4. In Progress (Kadtong gidawat na sa staff)
            // Note: Kung wala pa kay label para ani, pwede nimo i-add sa UI
            // lblInProgress.Text = "In Progress: " + tasks.Count(t => t.Status == "In Progress");

            // 5. Overdue (Wala pa nahuman ug lapas na sa Due Date)
            lblOverdue.Text = "Overdue: " + tasks.Count(t =>
                t.Status != "Complete" &&
                t.DueDate.Date < DateTime.Today
            );
        }
        private void btnTasks_Click(object sender, EventArgs e)
        {
            TasksForm tasksForm = new TasksForm(_currentUser);

            // Inig close sa TasksForm o naay nausab, i-refresh ang dashboard
            tasksForm.OnTaskChanged += () =>
            {
                LoadDashboard();
            };

            tasksForm.Show();
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


