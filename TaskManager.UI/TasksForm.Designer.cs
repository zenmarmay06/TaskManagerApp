namespace TaskManager.UI
{
    partial class TasksForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TasksForm));
            btnAddTask = new Button();
            dtDueDate = new DateTimePicker();
            dgvTasks = new DataGridView();
            btnDeleteTask = new Button();
            txtSearch = new TextBox();
            btnEditTask = new Button();
            lblDueDate = new Label();
            panel1 = new Panel();
            lblTasksText = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            cbAssigned = new ComboBox();
            label2 = new Label();
            txtNote = new TextBox();
            label3 = new Label();
            label4 = new Label();
            cbPriority = new ComboBox();
            pbRefresh = new PictureBox();
            txtRoom = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvTasks).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbRefresh).BeginInit();
            SuspendLayout();
            // 
            // btnAddTask
            // 
            btnAddTask.BackColor = Color.FromArgb(39, 39, 42);
            btnAddTask.ForeColor = Color.White;
            btnAddTask.Location = new Point(932, 458);
            btnAddTask.Margin = new Padding(3, 2, 3, 2);
            btnAddTask.Name = "btnAddTask";
            btnAddTask.Size = new Size(109, 26);
            btnAddTask.TabIndex = 1;
            btnAddTask.Text = "Add Task";
            btnAddTask.UseVisualStyleBackColor = false;
            btnAddTask.Click += btnAddTask_Click;
            // 
            // dtDueDate
            // 
            dtDueDate.CalendarForeColor = SystemColors.InfoText;
            dtDueDate.CalendarMonthBackground = Color.White;
            dtDueDate.CalendarTitleBackColor = Color.FromArgb(224, 224, 224);
            dtDueDate.CalendarTitleForeColor = Color.Gray;
            dtDueDate.CalendarTrailingForeColor = Color.DimGray;
            dtDueDate.Location = new Point(932, 280);
            dtDueDate.Margin = new Padding(3, 2, 3, 2);
            dtDueDate.Name = "dtDueDate";
            dtDueDate.Size = new Size(252, 23);
            dtDueDate.TabIndex = 2;
            // 
            // dgvTasks
            // 
            dgvTasks.BackgroundColor = SystemColors.ActiveCaptionText;
            dgvTasks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTasks.Location = new Point(25, 99);
            dgvTasks.Margin = new Padding(3, 2, 3, 2);
            dgvTasks.MultiSelect = false;
            dgvTasks.Name = "dgvTasks";
            dgvTasks.RowHeadersWidth = 51;
            dgvTasks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTasks.Size = new Size(886, 385);
            dgvTasks.TabIndex = 3;
            dgvTasks.CellClick += dgvTasks_CellClick;
            dgvTasks.CellContentClick += dgvTasks_CellContentClick;
            dgvTasks.CellFormatting += dgvTasks_CellFormatting;
            // 
            // btnDeleteTask
            // 
            btnDeleteTask.BackColor = Color.FromArgb(39, 39, 42);
            btnDeleteTask.ForeColor = Color.White;
            btnDeleteTask.Location = new Point(1071, 458);
            btnDeleteTask.Margin = new Padding(3, 2, 3, 2);
            btnDeleteTask.Name = "btnDeleteTask";
            btnDeleteTask.Size = new Size(109, 26);
            btnDeleteTask.TabIndex = 4;
            btnDeleteTask.Text = "Delete Task";
            btnDeleteTask.UseVisualStyleBackColor = false;
            btnDeleteTask.Click += btnDeleteTask_Click;
            // 
            // txtSearch
            // 
            txtSearch.BackColor = Color.FromArgb(30, 30, 30);
            txtSearch.ForeColor = Color.White;
            txtSearch.Location = new Point(25, 68);
            txtSearch.Margin = new Padding(3, 2, 3, 2);
            txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "🔍 Search Tasks...";
            txtSearch.Size = new Size(197, 27);
            txtSearch.TabIndex = 5;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // btnEditTask
            // 
            btnEditTask.BackColor = Color.FromArgb(39, 39, 42);
            btnEditTask.ForeColor = Color.White;
            btnEditTask.Location = new Point(1071, 419);
            btnEditTask.Margin = new Padding(3, 2, 3, 2);
            btnEditTask.Name = "btnEditTask";
            btnEditTask.Size = new Size(109, 26);
            btnEditTask.TabIndex = 6;
            btnEditTask.Text = "Edit Task";
            btnEditTask.UseVisualStyleBackColor = false;
            btnEditTask.Click += btnEditTask_Click;
            // 
            // lblDueDate
            // 
            lblDueDate.AutoSize = true;
            lblDueDate.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblDueDate.ForeColor = Color.White;
            lblDueDate.Location = new Point(938, 245);
            lblDueDate.Name = "lblDueDate";
            lblDueDate.Size = new Size(72, 20);
            lblDueDate.TabIndex = 8;
            lblDueDate.Text = "Due Date";
            // 
            // panel1
            // 
            panel1.Controls.Add(lblTasksText);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1199, 64);
            panel1.TabIndex = 10;
            // 
            // lblTasksText
            // 
            lblTasksText.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblTasksText.ForeColor = Color.White;
            lblTasksText.Location = new Point(76, 10);
            lblTasksText.Name = "lblTasksText";
            lblTasksText.Size = new Size(206, 38);
            lblTasksText.TabIndex = 1;
            lblTasksText.Text = "Tasks";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(25, 9);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(46, 39);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.White;
            label1.Location = new Point(932, 174);
            label1.Name = "label1";
            label1.Size = new Size(113, 22);
            label1.TabIndex = 11;
            label1.Text = "Assigned to:";
            // 
            // cbAssigned
            // 
            cbAssigned.BackColor = Color.FromArgb(30, 30, 30);
            cbAssigned.DropDownStyle = ComboBoxStyle.DropDownList;
            cbAssigned.ForeColor = Color.White;
            cbAssigned.FormattingEnabled = true;
            cbAssigned.Items.AddRange(new object[] { "Low", "Medium", "High" });
            cbAssigned.Location = new Point(932, 209);
            cbAssigned.Margin = new Padding(3, 2, 3, 2);
            cbAssigned.Name = "cbAssigned";
            cbAssigned.Size = new Size(248, 23);
            cbAssigned.TabIndex = 12;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.White;
            label2.Location = new Point(932, 99);
            label2.Name = "label2";
            label2.Size = new Size(73, 23);
            label2.TabIndex = 13;
            label2.Text = "Room no:";
            // 
            // txtNote
            // 
            txtNote.BackColor = Color.LightGray;
            txtNote.Location = new Point(932, 344);
            txtNote.Multiline = true;
            txtNote.Name = "txtNote";
            txtNote.Size = new Size(252, 48);
            txtNote.TabIndex = 30;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.ForeColor = Color.White;
            label3.Location = new Point(932, 318);
            label3.Name = "label3";
            label3.Size = new Size(73, 23);
            label3.TabIndex = 29;
            label3.Text = "Note:";
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label4.ForeColor = Color.White;
            label4.Location = new Point(1071, 99);
            label4.Name = "label4";
            label4.Size = new Size(100, 23);
            label4.TabIndex = 31;
            label4.Text = "Priority Level:";
            // 
            // cbPriority
            // 
            cbPriority.BackColor = Color.FromArgb(30, 30, 30);
            cbPriority.DropDownStyle = ComboBoxStyle.DropDownList;
            cbPriority.ForeColor = Color.White;
            cbPriority.FormattingEnabled = true;
            cbPriority.Items.AddRange(new object[] { "Low", "Medium", "High" });
            cbPriority.Location = new Point(1071, 136);
            cbPriority.Margin = new Padding(3, 2, 3, 2);
            cbPriority.Name = "cbPriority";
            cbPriority.Size = new Size(109, 23);
            cbPriority.TabIndex = 32;
            // 
            // pbRefresh
            // 
            pbRefresh.Image = Properties.Resources.icons8_refresh_30__1_;
            pbRefresh.Location = new Point(878, 72);
            pbRefresh.Margin = new Padding(3, 2, 3, 2);
            pbRefresh.Name = "pbRefresh";
            pbRefresh.Size = new Size(22, 23);
            pbRefresh.SizeMode = PictureBoxSizeMode.Zoom;
            pbRefresh.TabIndex = 2;
            pbRefresh.TabStop = false;
            pbRefresh.Click += pbRefresh_Click;
            // 
            // txtRoom
            // 
            txtRoom.BackColor = Color.LightGray;
            txtRoom.Location = new Point(938, 136);
            txtRoom.Name = "txtRoom";
            txtRoom.Size = new Size(63, 23);
            txtRoom.TabIndex = 33;
            // 
            // TasksForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(39, 39, 42);
            ClientSize = new Size(1199, 505);
            Controls.Add(txtRoom);
            Controls.Add(pbRefresh);
            Controls.Add(cbPriority);
            Controls.Add(label4);
            Controls.Add(txtNote);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(cbAssigned);
            Controls.Add(label1);
            Controls.Add(dgvTasks);
            Controls.Add(panel1);
            Controls.Add(lblDueDate);
            Controls.Add(btnEditTask);
            Controls.Add(txtSearch);
            Controls.Add(btnDeleteTask);
            Controls.Add(dtDueDate);
            Controls.Add(btnAddTask);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "TasksForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TasksForm";
            Load += TasksForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTasks).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbRefresh).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnAddTask;
        private DateTimePicker dtDueDate;
        private DataGridView dgvTasks;
        private Button btnDeleteTask;
        private TextBox txtSearch;
        private Button btnEditTask;
        private Label lblDueDate;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label lblTasksText;
        private Label label1;
        private ComboBox cbAssigned;
        private Label label2;
        private TextBox txtNote;
        private Label label3;
        private Label label4;
        private ComboBox cbPriority;
        private PictureBox pbRefresh;
        private TextBox txtRoom;
    }
}