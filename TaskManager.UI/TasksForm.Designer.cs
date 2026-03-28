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
            txtDescription = new TextBox();
            btnAddTask = new Button();
            dtDueDate = new DateTimePicker();
            dgvTasks = new DataGridView();
            btnCompleteTask = new Button();
            btnDeleteTask = new Button();
            txtSearch = new TextBox();
            btnEditTask = new Button();
            lblTitle = new Label();
            lblDescription = new Label();
            lblDueDate = new Label();
            cmbPriority = new ComboBox();
            panel1 = new Panel();
            lblTasksText = new Label();
            pictureBox1 = new PictureBox();
            txtTitle = new TextBox();
            lblPriority = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvTasks).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtDescription
            // 
            txtDescription.BackColor = Color.FromArgb(30, 30, 30);
            txtDescription.ForeColor = Color.White;
            txtDescription.Location = new Point(1068, 300);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.ScrollBars = ScrollBars.Vertical;
            txtDescription.Size = new Size(283, 80);
            txtDescription.TabIndex = 0;
            // 
            // btnAddTask
            // 
            btnAddTask.BackColor = Color.FromArgb(39, 39, 42);
            btnAddTask.ForeColor = Color.White;
            btnAddTask.Location = new Point(1072, 558);
            btnAddTask.Name = "btnAddTask";
            btnAddTask.Size = new Size(125, 35);
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
            dtDueDate.Location = new Point(1068, 432);
            dtDueDate.Name = "dtDueDate";
            dtDueDate.Size = new Size(287, 27);
            dtDueDate.TabIndex = 2;
           
            // 
            // dgvTasks
            // 
            dgvTasks.BackgroundColor = SystemColors.ActiveCaptionText;
            dgvTasks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTasks.Location = new Point(29, 132);
            dgvTasks.MultiSelect = false;
            dgvTasks.Name = "dgvTasks";
            dgvTasks.RowHeadersWidth = 51;
            dgvTasks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTasks.Size = new Size(1012, 513);
            dgvTasks.TabIndex = 3;
            dgvTasks.CellContentClick += dgvTasks_CellContentClick;
            dgvTasks.CellFormatting += dgvTasks_CellFormatting;
            // 
            // btnCompleteTask
            // 
            btnCompleteTask.BackColor = Color.FromArgb(39, 39, 42);
            btnCompleteTask.ForeColor = Color.White;
            btnCompleteTask.Location = new Point(1072, 610);
            btnCompleteTask.Name = "btnCompleteTask";
            btnCompleteTask.Size = new Size(125, 35);
            btnCompleteTask.TabIndex = 4;
            btnCompleteTask.Text = "Complete Task";
            btnCompleteTask.UseVisualStyleBackColor = false;
            btnCompleteTask.Click += btnCompleteTask_Click;
            // 
            // btnDeleteTask
            // 
            btnDeleteTask.BackColor = Color.FromArgb(39, 39, 42);
            btnDeleteTask.ForeColor = Color.White;
            btnDeleteTask.Location = new Point(1223, 610);
            btnDeleteTask.Name = "btnDeleteTask";
            btnDeleteTask.Size = new Size(125, 35);
            btnDeleteTask.TabIndex = 4;
            btnDeleteTask.Text = "Delete Task";
            btnDeleteTask.UseVisualStyleBackColor = false;
            btnDeleteTask.Click += btnDeleteTask_Click;
            // 
            // txtSearch
            // 
            txtSearch.BackColor = Color.FromArgb(30, 30, 30);
            txtSearch.ForeColor = Color.White;
            txtSearch.Location = new Point(29, 91);
            txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "🔍 Search Tasks...";
            txtSearch.Size = new Size(225, 35);
            txtSearch.TabIndex = 5;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // btnEditTask
            // 
            btnEditTask.BackColor = Color.FromArgb(39, 39, 42);
            btnEditTask.ForeColor = Color.White;
            btnEditTask.Location = new Point(1226, 558);
            btnEditTask.Name = "btnEditTask";
            btnEditTask.Size = new Size(125, 35);
            btnEditTask.TabIndex = 6;
            btnEditTask.Text = "Edit Task";
            btnEditTask.UseVisualStyleBackColor = false;
            btnEditTask.Click += btnEditTask_Click;
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(1065, 132);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(76, 31);
            lblTitle.TabIndex = 7;
            lblTitle.Text = "Title";
            // 
            // lblDescription
            // 
            lblDescription.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblDescription.ForeColor = Color.White;
            lblDescription.Location = new Point(1065, 267);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(129, 30);
            lblDescription.TabIndex = 8;
            lblDescription.Text = "Description";
            // 
            // lblDueDate
            // 
            lblDueDate.AutoSize = true;
            lblDueDate.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblDueDate.ForeColor = Color.White;
            lblDueDate.Location = new Point(1065, 404);
            lblDueDate.Name = "lblDueDate";
            lblDueDate.Size = new Size(86, 25);
            lblDueDate.TabIndex = 8;
            lblDueDate.Text = "Due Date";
            // 
            // cmbPriority
            // 
            cmbPriority.BackColor = Color.FromArgb(30, 30, 30);
            cmbPriority.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPriority.ForeColor = Color.White;
            cmbPriority.FormattingEnabled = true;
            cmbPriority.Items.AddRange(new object[] { "Low", "Medium", "High" });
            cmbPriority.Location = new Point(1068, 510);
            cmbPriority.Name = "cmbPriority";
            cmbPriority.Size = new Size(283, 28);
            cmbPriority.TabIndex = 9;
            cmbPriority.SelectedIndexChanged += cmbPriority_SelectedIndexChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblTasksText);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1772, 85);
            panel1.TabIndex = 10;
            // 
            // lblTasksText
            // 
            lblTasksText.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblTasksText.ForeColor = Color.White;
            lblTasksText.Location = new Point(87, 14);
            lblTasksText.Name = "lblTasksText";
            lblTasksText.Size = new Size(235, 50);
            lblTasksText.TabIndex = 1;
            lblTasksText.Text = "Tasks";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(29, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(52, 52);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // txtTitle
            // 
            txtTitle.BackColor = Color.FromArgb(30, 30, 30);
            txtTitle.ForeColor = Color.White;
            txtTitle.Location = new Point(1065, 166);
            txtTitle.Multiline = true;
            txtTitle.Name = "txtTitle";
            txtTitle.ScrollBars = ScrollBars.Vertical;
            txtTitle.Size = new Size(283, 80);
            txtTitle.TabIndex = 0;
            // 
            // lblPriority
            // 
            lblPriority.AutoSize = true;
            lblPriority.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblPriority.ForeColor = Color.White;
            lblPriority.Location = new Point(1068, 482);
            lblPriority.Name = "lblPriority";
            lblPriority.Size = new Size(68, 25);
            lblPriority.TabIndex = 8;
            lblPriority.Text = "Priority";
            // 
            // TasksForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(39, 39, 42);
            ClientSize = new Size(1772, 673);
            Controls.Add(panel1);
            Controls.Add(cmbPriority);
            Controls.Add(lblPriority);
            Controls.Add(lblDueDate);
            Controls.Add(lblDescription);
            Controls.Add(lblTitle);
            Controls.Add(btnEditTask);
            Controls.Add(txtSearch);
            Controls.Add(btnDeleteTask);
            Controls.Add(btnCompleteTask);
            Controls.Add(dgvTasks);
            Controls.Add(dtDueDate);
            Controls.Add(btnAddTask);
            Controls.Add(txtTitle);
            Controls.Add(txtDescription);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "TasksForm";
            Text = "TasksForm";
            Load += TasksForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTasks).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtDescription;
        private Button btnAddTask;
        private DateTimePicker dtDueDate;
        private DataGridView dgvTasks;
        private Button btnCompleteTask;
        private Button btnDeleteTask;
        private TextBox txtSearch;
        private Button btnEditTask;
        private Label lblTitle;
        private Label lblDescription;
        private Label lblDueDate;
        private ComboBox cmbPriority;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label lblTasksText;
        private TextBox txtTitle;
        private Label lblPriority;
    }
}