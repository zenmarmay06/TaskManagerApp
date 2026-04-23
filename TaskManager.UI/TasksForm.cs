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
            LoadMaintenanceRooms();
            LoadCleaners();
        }

        private void LoadTasks()
        {
            dgvTasks.DataSource = null;
            dgvTasks.DataSource = _taskService.GetUserTasks(_currentUser.Id);
            HideColumns();
        }

        private void HideColumns()
        {
            if (dgvTasks.Columns["Id"] != null) dgvTasks.Columns["Id"].Visible = false;
            if (dgvTasks.Columns["UserId"] != null) dgvTasks.Columns["UserId"].Visible = false;
            // Gidugang nato ang IsCompleted sa pag-hide kay Status na atong gamiton
            if (dgvTasks.Columns["IsCompleted"] != null) dgvTasks.Columns["IsCompleted"].Visible = false;
        }

        private void LoadMaintenanceRooms()
        {
            var rooms = _taskService.GetMaintenanceRooms();
            cbRoomNo.DataSource = rooms;
        }

        private void LoadCleaners()
        {
            var cleaners = _taskService.GetStaffByWork();
            cbAssigned.DataSource = cleaners;
        }
        private void btnAddTask_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(cbRoomNo.Text))
            {
                MessageBox.Show("Please select a room for maintenance.");
                return;
            }

            TaskItem task = new TaskItem
            {
                RoomNo = cbRoomNo.Text,
                AssignedTo = cbAssigned.Text,
                DueDate = dtDueDate.Value,
                Status = "Pending", // Gigamit ang Status string
                UserId = _currentUser.Id,
                Note = "" // Siguroha nga naay default note
            };

            _taskService.CreateTask(task);

            LoadTasks();
            LoadMaintenanceRooms();
            OnTaskChanged?.Invoke();

            MessageBox.Show("Task successfully assigned!");
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
            OnTaskChanged?.Invoke();
        }

        //private void btnCompleteTask_Click(object sender, EventArgs e)
       // {
           // if (dgvTasks.SelectedRows.Count == 0)
           // {
              //  MessageBox.Show("Select a task first");
             //   return;
           // }

           // var row = dgvTasks.SelectedRows[0];
           // int taskId = Convert.ToInt32(row.Cells["Id"].Value);
           // string roomNo = row.Cells["RoomNo"].Value?.ToString();

            // 1. Mark as completed sa Task Manager
           // _taskService.CompleteTask(taskId);

            // 2. I-update ang Room balik sa 'Available' sa Hotel System
            //if (!string.IsNullOrEmpty(roomNo))
           // {
               // _taskService.UpdateRoomToAvailable(roomNo);
                //MessageBox.Show($"Room {roomNo} is now Available for booking!");
           // }

           // LoadTasks();
            //LoadMaintenanceRooms();
            //OnTaskChanged?.Invoke();

        //}

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

            // Kuhaa ang kasamtangan nga Status ug Note para dili ma-blank
            string currentStatus = row.Cells["Status"].Value?.ToString() ?? "Pending";
            string currentNote = row.Cells["Note"].Value?.ToString() ?? "";

            DateTime currentDueDate = Convert.ToDateTime(row.Cells["DueDate"].Value);
            DateTime newDueDate = _isDateManuallyChanged ? dtDueDate.Value.Date : currentDueDate;

            TaskItem updatedTask = new TaskItem
            {
                Id = taskId,
                RoomNo = cbRoomNo.Text,
                AssignedTo = cbAssigned.Text, // Siguroha nga naay sulod ang cbAssigned
                DueDate = newDueDate,
                Status = currentStatus, // KINI ANG IMPORTANTE
                UserId = _currentUser.Id,
                Note = currentNote      // KINI SAB
            };

            _taskService.UpdateTask(updatedTask);

            LoadTasks();
            _isEditing = false;
            _isDateManuallyChanged = false;

            OnTaskChanged?.Invoke();
            MessageBox.Show("Task updated successfully");
        }

        private void dgvTasks_SelectionChanged(object sender, EventArgs e)
        {
            if (_isEditing || dgvTasks.SelectedRows.Count == 0) return;

            _isUpdatingFromGrid = true;
            var row = dgvTasks.SelectedRows[0];

            // I-populate ang controls base sa napili nga row
            cbRoomNo.Text = row.Cells["RoomNo"].Value?.ToString();
            cbAssigned.Text = row.Cells["AssignedTo"].Value?.ToString();
            dtDueDate.Value = Convert.ToDateTime(row.Cells["DueDate"].Value);

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
            // Grid Styling
            dgvTasks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTasks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTasks.MultiSelect = false;
            dgvTasks.RowTemplate.Height = 36;
            dgvTasks.BackgroundColor = Color.FromArgb(20, 20, 20);
            dgvTasks.DefaultCellStyle.BackColor = Color.FromArgb(24, 24, 24);
            dgvTasks.DefaultCellStyle.ForeColor = Color.FromArgb(220, 220, 220);
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
                            (t.RoomNo ?? "").ToLower().Contains(search))
                .ToList();

            dgvTasks.DataSource = null;
            dgvTasks.DataSource = filtered;
            HideColumns();
        }

        private void dgvTasks_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var row = dgvTasks.Rows[e.RowIndex];

            // Atong i-check ang Status column imbes IsCompleted
            string status = row.Cells["Status"].Value?.ToString() ?? "Pending";

            if (status == "Complete")
            {
                row.DefaultCellStyle.ForeColor = Color.Gray;
                row.DefaultCellStyle.Font = new Font(dgvTasks.Font, FontStyle.Strikeout);
            }
            else if (status == "In Progress")
            {
                row.DefaultCellStyle.ForeColor = Color.LightSkyBlue;
                row.DefaultCellStyle.Font = new Font(dgvTasks.Font, FontStyle.Italic);
            }
        }

        private void dgvTasks_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            // Siguroha nga naay column nga named "Priority" sa imong TaskItem model
            if (dgvTasks.Columns[e.ColumnIndex].Name != "Priority") return;

            e.PaintBackground(e.CellBounds, true);
            string text = e.Value?.ToString() ?? "Low";

            Color bg = text == "High" ? Color.FromArgb(220, 70, 70) :
                       text == "Medium" ? Color.FromArgb(240, 170, 60) :
                       Color.FromArgb(70, 160, 110);

            Rectangle rect = new Rectangle(e.CellBounds.X + 8, e.CellBounds.Y + 6, e.CellBounds.Width - 16, e.CellBounds.Height - 12);

            // Paggamit sa helper method para sa rounded rectangles
            using (Brush b = new SolidBrush(bg))
            {
                e.Graphics.FillRoundedRectangle(b, rect, 12);
            }

            TextRenderer.DrawText(e.Graphics, text, new Font("Segoe UI", 9, FontStyle.Bold), rect, Color.White, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
            e.Handled = true;
        }

        private void dgvTasks_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void cmbPriority_SelectedIndexChanged(object sender, EventArgs e) { }

        private void lblDescription_Click(object sender, EventArgs e)
        {

        }
    }
}