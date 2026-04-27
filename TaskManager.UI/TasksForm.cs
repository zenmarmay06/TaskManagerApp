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

            var tasks = _taskService.GetAllTasks();

            // 🔥 FILTER: only real created tasks
            var validTasks = tasks
                .Where(t => t.Id > 0)          // ensure gikan sa DB
                .Where(t => !string.IsNullOrEmpty(t.RoomNo))
                .ToList();

            dgvTasks.DataSource = validTasks;

            HideColumns();
        }

        private void HideColumns()
        {
            if (dgvTasks.Columns["Id"] != null) dgvTasks.Columns["Id"].Visible = false;
            if (dgvTasks.Columns["UserId"] != null) dgvTasks.Columns["UserId"].Visible = false;
            if (dgvTasks.Columns["IsCompleted"] != null) dgvTasks.Columns["IsCompleted"].Visible = false;

            // I-display ang Note
            if (dgvTasks.Columns["Note"] != null)
            {
                dgvTasks.Columns["Note"].Visible = true;
                dgvTasks.Columns["Note"].HeaderText = "Special Notes";
                dgvTasks.Columns["Note"].FillWeight = 150;
            }


        }

        private void LoadMaintenanceRooms()
        {
            var rooms = _taskService.GetMaintenanceRooms();
        }

        private void LoadCleaners()
        {
            var cleaners = _taskService.GetStaffByWork();
            cbAssigned.DataSource = cleaners;
        }
        private void btnAddTask_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtRoom.Text)) return;

            // 1. I-check kung ang Room No naa na ba sa Grid (sa tasks list)
            var existingTasks = (List<TaskItem>)dgvTasks.DataSource;
            var existingTask = existingTasks.FirstOrDefault(t => t.RoomNo == txtRoom.Text && t.Status != "Complete");

            if (existingTask != null)
            {
                // 2. KUNG NAA NA: Tawgon ang Update/Edit logic
                existingTask.AssignedTo = cbAssigned.Text;
                existingTask.Priority = cbPriority.Text;
                existingTask.Note = txtNote.Text;
                existingTask.DueDate = dtDueDate.Value;

                _taskService.UpdateTask(existingTask);
                MessageBox.Show("Task added successfully!");
            }
            

            LoadTasks();
            LoadMaintenanceRooms();
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

            var row = dgvTasks.SelectedRows[0];
            int taskId = Convert.ToInt32(row.Cells["Id"].Value);

            _isEditing = true;

            TaskItem updatedTask = new TaskItem
            {
                Id = taskId,
                RoomNo = txtRoom.Text,
                Priority = cbPriority.Text,
                AssignedTo = cbAssigned.Text,
                DueDate = dtDueDate.Value,
                Status = row.Cells["Status"].Value?.ToString() ?? "Pending",
                UserId = _currentUser.Id,

                // ✅ FIXED
                Note = txtNote.Text
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
            if (_isEditing) return;

            if (dgvTasks.CurrentRow == null) return;

            _isUpdatingFromGrid = true;

            var row = dgvTasks.CurrentRow;

            try
            {
                txtRoom.Text = row.Cells["RoomNo"].Value?.ToString();
                cbPriority.Text = row.Cells["Priority"].Value?.ToString();
                cbAssigned.Text = row.Cells["AssignedTo"].Value?.ToString();

                if (row.Cells["DueDate"].Value != DBNull.Value)
                {
                    dtDueDate.Value = Convert.ToDateTime(row.Cells["DueDate"].Value);
                }

                txtNote.Text = row.Cells["Note"].Value?.ToString() ?? "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }

            _isUpdatingFromGrid = false;
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
            // Usba kini gikan sa GetUserTasks ngadto sa GetAllTasks para makita tanan sa Admin
            var tasks = _taskService.GetAllTasks();
            string search = txtSearch.Text.ToLower();

            var filtered = tasks
                .Where(t => (t.RoomNo ?? "").ToLower().Contains(search))
                .ToList();

            dgvTasks.DataSource = null;
            dgvTasks.DataSource = filtered;
            HideColumns();
        }

        private void dgvTasks_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var row = dgvTasks.Rows[e.RowIndex];
            string status = row.Cells["Status"].Value?.ToString() ?? "Pending";

            // 1. Styling base sa Status (Imong karaan nga code)
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

            // 2. KINI: I-hide ang Date Finished kung wala pa nahuman ang task
            if (dgvTasks.Columns[e.ColumnIndex].Name == "CompletedDate")
            {
                if (status != "Complete" || e.Value == null || e.Value == DBNull.Value || Convert.ToDateTime(e.Value) == DateTime.MinValue)
                {
                    e.Value = "---"; // Ipakita ra ang dash kung dili pa complete
                    e.FormattingApplied = true;
                }
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

        private void dgvTasks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvTasks_SelectionChanged(sender, e);
        }

        private void cbRoomNo_Enter(object sender, EventArgs e)
        {
            //LoadMaintenanceRooms();
        }

        private void pbRefresh_Click(object sender, EventArgs e)
        {
            // I-refresh ang Grid (dgvTasks)
            LoadTasks();

            // I-refresh ang ComboBox (cbRoomNo)
            LoadMaintenanceRooms();

            // I-refresh sab ang Staff list para sigurado
            LoadCleaners();

            MessageBox.Show("Data refreshed from server!");
        }
    }
}