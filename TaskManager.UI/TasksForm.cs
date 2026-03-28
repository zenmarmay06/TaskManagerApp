using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskManager.Business.Services;
using TaskManager.Core.Models;
using TaskManager.UI.Helpers;

namespace TaskManager.UI
{
    public partial class TasksForm : Form
    {
        private TaskService _taskService;
        private User _currentUser;
        private bool _isUpdatingFromGrid = false;
        private bool _isEditing = false;
        private bool _isDateManuallyChanged = false;

        public event Action OnTaskChanged;

        public TasksForm(User user)
        {
            InitializeComponent();
            _taskService = new TaskService();
            _currentUser = user;
            LoadTasks();
        }

        private void LoadTasks()
        {
            dgvTasks.DataSource = null;
            dgvTasks.DataSource = _taskService.GetUserTasks(_currentUser.Id);
        }

        private void HideColumns()
        {
            dgvTasks.Columns["Id"].Visible = false;
            dgvTasks.Columns["UserId"].Visible = false;
            dgvTasks.Columns["IsCompleted"].Visible = false;
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitle.Text))
            {
                MessageBox.Show("Task title cannot be empty");
                return;
            }

            TaskItem task = new TaskItem
            {
                Title = txtTitle.Text,
                Description = txtDescription.Text,
                DueDate = dtDueDate.Value,
                IsCompleted = false,
                UserId = _currentUser.Id,
                Priority = cmbPriority.SelectedItem?.ToString() ?? "Low",
            };

            _taskService.CreateTask(task);
            txtTitle.Clear();
            txtDescription.Clear();
            dtDueDate.Value = DateTime.Now;
            LoadTasks();
            HideColumns();
            OnTaskChanged?.Invoke();
        }

        private void btnDeleteTask_Click(object sender, EventArgs e)
        {
            if (dgvTasks.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a task first");
                return;
            }

            int taskId = Convert.ToInt32(dgvTasks.SelectedRows[0].Cells["Id"].Value);
            _taskService.DeleteTask(taskId);
            LoadTasks();
            HideColumns();
            OnTaskChanged?.Invoke();
        }

        private void btnCompleteTask_Click(object sender, EventArgs e)
        {
            if (dgvTasks.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a task first");
                return;
            }

            int taskId = Convert.ToInt32(dgvTasks.SelectedRows[0].Cells["Id"].Value);
            _taskService.CompleteTask(taskId);
            LoadTasks();
            HideColumns();
            OnTaskChanged?.Invoke();
        }

        private void btnEditTask_Click(object sender, EventArgs e)
        {
            if (dgvTasks.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a task first");
                return;
            }

            _isEditing = true;

            var row = dgvTasks.SelectedRows[0];

            int taskId = Convert.ToInt32(row.Cells["Id"].Value);
            string currentTitle = row.Cells["Title"].Value?.ToString();
            string currentDescription = row.Cells["Description"].Value?.ToString();
            DateTime currentDueDate = Convert.ToDateTime(row.Cells["DueDate"].Value);

            string newTitle = string.IsNullOrWhiteSpace(txtTitle.Text) ? currentTitle : txtTitle.Text;
            string newDescription = string.IsNullOrWhiteSpace(txtDescription.Text) ? currentDescription : txtDescription.Text;
            DateTime newDueDate = _isDateManuallyChanged ? dtDueDate.Value.Date : currentDueDate;

            if (string.IsNullOrWhiteSpace(newTitle))
            {
                MessageBox.Show("Task title cannot be empty");
                _isEditing = false;
                return;
            }

            TaskItem updatedTask = new TaskItem
            {
                Id = taskId,
                Title = newTitle,
                Description = newDescription,
                DueDate = newDueDate,
                UserId = _currentUser.Id,
                Priority = cmbPriority.SelectedItem?.ToString() ?? "Low",
            };

            _taskService.UpdateTask(updatedTask);

            LoadTasks();
            HideColumns();

            txtTitle.Clear();
            txtDescription.Clear();

            _isEditing = false;
            _isDateManuallyChanged = false;

            OnTaskChanged?.Invoke();
            MessageBox.Show("Task updated successfully");
        }

        private void dgvTasks_SelectionChanged(object sender, EventArgs e)
        {
            if (_isEditing) return;
            if (dgvTasks.SelectedRows.Count == 0) return;

            _isUpdatingFromGrid = true;

            var row = dgvTasks.SelectedRows[0];
            txtTitle.Text = row.Cells["Title"].Value?.ToString();
            txtDescription.Text = row.Cells["Description"].Value?.ToString();
            dtDueDate.Value = Convert.ToDateTime(row.Cells["DueDate"].Value);
            cmbPriority.SelectedItem = row.Cells["Priority"].Value?.ToString();

            _isUpdatingFromGrid = false;
            _isDateManuallyChanged = false;
        }

        private void dtDueDate_ValueChanged(object sender, EventArgs e)
        {
            if (_isUpdatingFromGrid) return;
            _isDateManuallyChanged = true;
        }

        private void TasksForm_Load(object sender, EventArgs e)
        {
            dgvTasks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTasks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTasks.MultiSelect = false;
            dgvTasks.RowTemplate.Height = 36;

            dgvTasks.Font = new Font("Segoe UI", 10);
            dgvTasks.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            dgvTasks.EnableHeadersVisualStyles = false;
            dgvTasks.BorderStyle = BorderStyle.None;

            dgvTasks.BackgroundColor = Color.FromArgb(20, 20, 20);
            dgvTasks.DefaultCellStyle.BackColor = Color.FromArgb(24, 24, 24);
            dgvTasks.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(28, 28, 28);
            dgvTasks.DefaultCellStyle.ForeColor = Color.FromArgb(220, 220, 220);
            dgvTasks.GridColor = Color.FromArgb(40, 40, 40);

            dgvTasks.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(30, 30, 30);
            dgvTasks.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            dgvTasks.DefaultCellStyle.SelectionBackColor = Color.FromArgb(60, 90, 160);
            dgvTasks.DefaultCellStyle.SelectionForeColor = Color.White;

            dgvTasks.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvTasks.RowHeadersVisible = false;

            HideColumns();

            dgvTasks.CellFormatting += dgvTasks_CellFormatting;
            dgvTasks.CellPainting += dgvTasks_CellPainting;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            var tasks = _taskService.GetUserTasks(_currentUser.Id);
            string search = txtSearch.Text.ToLower();

            var filtered = tasks
                .Where(t =>
                    (t.Title ?? "").ToLower().Contains(search) ||
                    (t.Description ?? "").ToLower().Contains(search))
                .ToList();

            dgvTasks.DataSource = null;
            dgvTasks.DataSource = filtered;
            HideColumns();
        }

        private void dgvTasks_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dgvTasks.Rows[e.RowIndex];
            bool completed = Convert.ToBoolean(row.Cells["IsCompleted"].Value ?? false);
            DateTime dueDate = Convert.ToDateTime(row.Cells["DueDate"].Value);
            bool isOverdue = !completed && dueDate.Date < DateTime.Today;

            if (completed)
            {
                row.DefaultCellStyle.ForeColor = Color.Gray;
                row.DefaultCellStyle.Font = new Font(dgvTasks.Font, FontStyle.Strikeout);
            }
            else if (isOverdue)
            {
                row.DefaultCellStyle.ForeColor = Color.FromArgb(255, 120, 120);
                row.DefaultCellStyle.BackColor = Color.FromArgb(40, 20, 20);
                row.DefaultCellStyle.Font = new Font(dgvTasks.Font, FontStyle.Bold);
            }
            else
            {
                row.DefaultCellStyle.ForeColor = Color.Gainsboro;
                row.DefaultCellStyle.BackColor = Color.FromArgb(24, 24, 24);
                row.DefaultCellStyle.Font = new Font(dgvTasks.Font, FontStyle.Regular);
            }
        }

        private void dgvTasks_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex != dgvTasks.Columns["Priority"].Index)
                return;

            e.PaintBackground(e.CellBounds, true);

            string text = e.Value?.ToString();
            Color bg = Color.Gray;

            if (text == "High") bg = Color.FromArgb(220, 70, 70);
            else if (text == "Medium") bg = Color.FromArgb(240, 170, 60);
            else if (text == "Low") bg = Color.FromArgb(70, 160, 110);

            Rectangle rect = new Rectangle(
                e.CellBounds.X + 8,
                e.CellBounds.Y + 6,
                e.CellBounds.Width - 16,
                e.CellBounds.Height - 12
            );

            using (Brush b = new SolidBrush(bg))
            {
                e.Graphics.FillRoundedRectangle(b, rect, 12);
            }

            TextRenderer.DrawText(
                e.Graphics,
                text,
                new Font("Segoe UI", 9, FontStyle.Bold),
                rect,
                Color.White,
                TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter
            );

            e.Handled = true;
        }

        private void dgvTasks_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void cmbPriority_SelectedIndexChanged(object sender, EventArgs e) { }
    }
}