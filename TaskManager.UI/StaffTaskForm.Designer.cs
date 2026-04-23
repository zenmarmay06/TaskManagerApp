namespace TaskManager.UI
{
    partial class StaffTaskForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffTaskForm));
            lblTasksText = new Label();
            pictureBox1 = new PictureBox();
            cbRoomNo = new ComboBox();
            lblRoomNo = new Label();
            dgvTasks = new DataGridView();
            lblDueDate = new Label();
            txtSearch = new TextBox();
            btnCompleteTask = new Button();
            dtDueDate = new DateTimePicker();
            btnAccept = new Button();
            label1 = new Label();
            txtNote = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvTasks).BeginInit();
            SuspendLayout();
            // 
            // lblTasksText
            // 
            lblTasksText.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblTasksText.ForeColor = Color.White;
            lblTasksText.Location = new Point(71, 16);
            lblTasksText.Name = "lblTasksText";
            lblTasksText.Size = new Size(206, 38);
            lblTasksText.TabIndex = 16;
            lblTasksText.Text = "Tasks";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(20, 15);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(46, 39);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // cbRoomNo
            // 
            cbRoomNo.BackColor = Color.FromArgb(30, 30, 30);
            cbRoomNo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbRoomNo.ForeColor = Color.White;
            cbRoomNo.FormattingEnabled = true;
            cbRoomNo.Items.AddRange(new object[] { "Low", "Medium", "High" });
            cbRoomNo.Location = new Point(927, 142);
            cbRoomNo.Margin = new Padding(3, 2, 3, 2);
            cbRoomNo.Name = "cbRoomNo";
            cbRoomNo.Size = new Size(248, 23);
            cbRoomNo.TabIndex = 25;
            // 
            // lblRoomNo
            // 
            lblRoomNo.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblRoomNo.ForeColor = Color.White;
            lblRoomNo.Location = new Point(927, 105);
            lblRoomNo.Name = "lblRoomNo";
            lblRoomNo.Size = new Size(73, 23);
            lblRoomNo.TabIndex = 24;
            lblRoomNo.Text = "Room no:";
            // 
            // dgvTasks
            // 
            dgvTasks.BackgroundColor = SystemColors.ActiveCaptionText;
            dgvTasks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTasks.Location = new Point(20, 105);
            dgvTasks.Margin = new Padding(3, 2, 3, 2);
            dgvTasks.MultiSelect = false;
            dgvTasks.Name = "dgvTasks";
            dgvTasks.RowHeadersWidth = 51;
            dgvTasks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTasks.Size = new Size(886, 385);
            dgvTasks.TabIndex = 18;
            dgvTasks.CellFormatting += dgvTasks_CellFormatting;
            dgvTasks.SelectionChanged += dgvTasks_SelectionChanged;
            // 
            // lblDueDate
            // 
            lblDueDate.AutoSize = true;
            lblDueDate.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblDueDate.ForeColor = Color.White;
            lblDueDate.Location = new Point(927, 196);
            lblDueDate.Name = "lblDueDate";
            lblDueDate.Size = new Size(72, 20);
            lblDueDate.TabIndex = 21;
            lblDueDate.Text = "Due Date";
            // 
            // txtSearch
            // 
            txtSearch.BackColor = Color.FromArgb(30, 30, 30);
            txtSearch.ForeColor = Color.White;
            txtSearch.Location = new Point(20, 74);
            txtSearch.Margin = new Padding(3, 2, 3, 2);
            txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "🔍 Search Tasks...";
            txtSearch.Size = new Size(197, 27);
            txtSearch.TabIndex = 20;
            // 
            // btnCompleteTask
            // 
            btnCompleteTask.BackColor = Color.FromArgb(39, 39, 42);
            btnCompleteTask.ForeColor = Color.White;
            btnCompleteTask.Location = new Point(1070, 452);
            btnCompleteTask.Margin = new Padding(3, 2, 3, 2);
            btnCompleteTask.Name = "btnCompleteTask";
            btnCompleteTask.Size = new Size(109, 26);
            btnCompleteTask.TabIndex = 19;
            btnCompleteTask.Text = "Complete Task";
            btnCompleteTask.UseVisualStyleBackColor = false;
            btnCompleteTask.Click += btnCompleteTask_Click;
            // 
            // dtDueDate
            // 
            dtDueDate.CalendarForeColor = SystemColors.InfoText;
            dtDueDate.CalendarMonthBackground = Color.White;
            dtDueDate.CalendarTitleBackColor = Color.FromArgb(224, 224, 224);
            dtDueDate.CalendarTitleForeColor = Color.Gray;
            dtDueDate.CalendarTrailingForeColor = Color.DimGray;
            dtDueDate.Location = new Point(927, 236);
            dtDueDate.Margin = new Padding(3, 2, 3, 2);
            dtDueDate.Name = "dtDueDate";
            dtDueDate.Size = new Size(252, 23);
            dtDueDate.TabIndex = 17;
            // 
            // btnAccept
            // 
            btnAccept.BackColor = Color.FromArgb(39, 39, 42);
            btnAccept.ForeColor = Color.White;
            btnAccept.Location = new Point(933, 452);
            btnAccept.Margin = new Padding(3, 2, 3, 2);
            btnAccept.Name = "btnAccept";
            btnAccept.Size = new Size(109, 26);
            btnAccept.TabIndex = 26;
            btnAccept.Text = "Accept Task";
            btnAccept.UseVisualStyleBackColor = false;
            btnAccept.Click += btnAccept_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.White;
            label1.Location = new Point(927, 288);
            label1.Name = "label1";
            label1.Size = new Size(73, 23);
            label1.TabIndex = 27;
            label1.Text = "Note:";
            // 
            // txtNote
            // 
            txtNote.BackColor = Color.LightGray;
            txtNote.Location = new Point(927, 324);
            txtNote.Multiline = true;
            txtNote.Name = "txtNote";
            txtNote.Size = new Size(252, 79);
            txtNote.TabIndex = 28;
            // 
            // StaffTaskForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(39, 39, 42);
            ClientSize = new Size(1199, 505);
            Controls.Add(txtNote);
            Controls.Add(label1);
            Controls.Add(btnAccept);
            Controls.Add(lblTasksText);
            Controls.Add(pictureBox1);
            Controls.Add(cbRoomNo);
            Controls.Add(lblRoomNo);
            Controls.Add(dgvTasks);
            Controls.Add(lblDueDate);
            Controls.Add(txtSearch);
            Controls.Add(btnCompleteTask);
            Controls.Add(dtDueDate);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "StaffTaskForm";
            Text = "StaffTaskForm";
            Load += StaffTaskForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvTasks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTasksText;
        private PictureBox pictureBox1;
        private ComboBox cbRoomNo;
        private Label lblRoomNo;
        private DataGridView dgvTasks;
        private Label lblDueDate;
        private TextBox txtSearch;
        private Button btnCompleteTask;
        private DateTimePicker dtDueDate;
        private Button btnAccept;
        private Label label1;
        private TextBox txtNote;
    }
}