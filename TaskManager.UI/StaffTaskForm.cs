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
    public partial class StaffTaskForm : Form
    {
        private TaskService _taskService;
        private User _currentUser;
        public event Action OnTaskChanged;

        public StaffTaskForm(User user)
        {
            InitializeComponent();
            _taskService = new TaskService();
            _currentUser = user;

            LoadStaffTasks();
        }

        private void LoadStaffTasks()
        {
            // Atong i-load ang tanan tasks para sa iyang ID
            var allTasks = _taskService.GetStaffTasks(_currentUser.Name);

            dgvTasks.DataSource = null;
            dgvTasks.DataSource = allTasks;

            HideColumns();
        }

        private void HideColumns()
        {
            if (dgvTasks.Columns["Id"] != null) dgvTasks.Columns["Id"].Visible = false;
            if (dgvTasks.Columns["UserId"] != null) dgvTasks.Columns["UserId"].Visible = false;
            if (dgvTasks.Columns["IsCompleted"] != null) dgvTasks.Columns["IsCompleted"].Visible = false;
        }

        private void btnCompleteTask_Click(object sender, EventArgs e)
        {
            if (dgvTasks.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select the task you finished.");
                return;
            }

            // KUHAA ANG TASK ITEM OBJECT GIKAN SA ROW
            var selectedTask = (TaskItem)dgvTasks.SelectedRows[0].DataBoundItem;

            // Siguroha nga gi-Accept una ang task sa dili pa i-complete
            if (selectedTask.Status == "Pending")
            {
                MessageBox.Show("You must 'Accept' the task first before completing it.");
                return;
            }

            // I-pass ang tibuok object sa Service
            _taskService.MarkTaskAsComplete(selectedTask);

            MessageBox.Show($"Room {selectedTask.RoomNo} maintenance completed! It is now Available in the Hotel System.");

            LoadStaffTasks();
            OnTaskChanged?.Invoke();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (dgvTasks.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a task to accept.");
                return;
            }

            var row = dgvTasks.SelectedRows[0];
            int taskId = Convert.ToInt32(row.Cells["Id"].Value);
            string roomNo = row.Cells["RoomNo"].Value.ToString();

            // Usbon ang status ngadto sa 'In Progress'
            _taskService.AcceptTask(taskId, _currentUser.Name);

            MessageBox.Show($"Task for Room {roomNo} has been accepted. Start cleaning now!");

            LoadStaffTasks();
            OnTaskChanged?.Invoke();
        }

        private void dgvTasks_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvTasks.CurrentRow == null) return;

            var row = dgvTasks.CurrentRow;

            try
            {
                txtRoom.Text = (row.Cells["RoomNo"]?.Value?.ToString() ?? "N/A");
                txtPriority.Text =  (row.Cells["Priority"]?.Value?.ToString() ?? "N/A");

                if (row.Cells["DueDate"]?.Value != null && row.Cells["DueDate"].Value != DBNull.Value)
                {
                    txtDate.Text = Convert.ToDateTime(row.Cells["DueDate"].Value).ToShortDateString();
                }
                else
                {
                    txtDate.Text = "Due: N/A";
                }

                txtNote.Text = row.Cells["Note"]?.Value?.ToString() ?? "No notes available";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading task details: " + ex.Message);
            }
        }

        private void StaffTaskForm_Load(object sender, EventArgs e)
        {
            dgvTasks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTasks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTasks.RowTemplate.Height = 40;
            dgvTasks.CellFormatting += dgvTasks_CellFormatting;
            dgvTasks.MultiSelect = false;
        }

        private void dgvTasks_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var row = dgvTasks.Rows[e.RowIndex];
            string status = row.Cells["Status"].Value?.ToString() ?? "Pending";

            if (status == "Complete")
            {
                row.DefaultCellStyle.ForeColor = Color.Gray;
                row.DefaultCellStyle.Font = new Font(dgvTasks.Font, FontStyle.Strikeout);
            }
            else if (status == "In Progress")
            {
                row.DefaultCellStyle.BackColor = Color.FromArgb(40, 60, 80); // Dark Blue background para klaro
                row.DefaultCellStyle.ForeColor = Color.White;
            }
        }

        private void dgvTasks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvTasks_SelectionChanged(sender, e);
        }

        private void cbPriority_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
