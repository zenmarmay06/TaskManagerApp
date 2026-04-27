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
            lblRoomNo = new Label();
            dgvTasks = new DataGridView();
            lblDueDate = new Label();
            txtSearch = new TextBox();
            btnCompleteTask = new Button();
            btnAccept = new Button();
            label1 = new Label();
            label4 = new Label();
            txtNote = new TextBox();
            txtRoom = new TextBox();
            txtPriority = new TextBox();
            txtDate = new TextBox();
            pbRefresh = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvTasks).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbRefresh).BeginInit();
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
            dgvTasks.CellClick += dgvTasks_CellClick;
            dgvTasks.CellFormatting += dgvTasks_CellFormatting;
            dgvTasks.SelectionChanged += dgvTasks_SelectionChanged;
            // 
            // lblDueDate
            // 
            lblDueDate.AutoSize = true;
            lblDueDate.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblDueDate.ForeColor = Color.White;
            lblDueDate.Location = new Point(933, 177);
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
            btnCompleteTask.Location = new Point(1068, 410);
            btnCompleteTask.Margin = new Padding(3, 2, 3, 2);
            btnCompleteTask.Name = "btnCompleteTask";
            btnCompleteTask.Size = new Size(109, 26);
            btnCompleteTask.TabIndex = 19;
            btnCompleteTask.Text = "Complete Task";
            btnCompleteTask.UseVisualStyleBackColor = false;
            btnCompleteTask.Click += btnCompleteTask_Click;
            // 
            // btnAccept
            // 
            btnAccept.BackColor = Color.FromArgb(39, 39, 42);
            btnAccept.ForeColor = Color.White;
            btnAccept.Location = new Point(927, 410);
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
            label1.Location = new Point(925, 249);
            label1.Name = "label1";
            label1.Size = new Size(73, 23);
            label1.TabIndex = 27;
            label1.Text = "Note:";
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label4.ForeColor = Color.White;
            label4.Location = new Point(1047, 105);
            label4.Name = "label4";
            label4.Size = new Size(100, 23);
            label4.TabIndex = 33;
            label4.Text = "Priority Level:";
            // 
            // txtNote
            // 
            txtNote.BackColor = Color.LightGray;
            txtNote.Location = new Point(925, 288);
            txtNote.Multiline = true;
            txtNote.Name = "txtNote";
            txtNote.Size = new Size(252, 88);
            txtNote.TabIndex = 37;
            // 
            // txtRoom
            // 
            txtRoom.BackColor = Color.LightGray;
            txtRoom.Location = new Point(930, 131);
            txtRoom.Name = "txtRoom";
            txtRoom.Size = new Size(68, 23);
            txtRoom.TabIndex = 38;
            // 
            // txtPriority
            // 
            txtPriority.BackColor = Color.LightGray;
            txtPriority.Location = new Point(1047, 131);
            txtPriority.Name = "txtPriority";
            txtPriority.Size = new Size(68, 23);
            txtPriority.TabIndex = 39;
            // 
            // txtDate
            // 
            txtDate.BackColor = Color.LightGray;
            txtDate.Location = new Point(930, 213);
            txtDate.Name = "txtDate";
            txtDate.Size = new Size(227, 23);
            txtDate.TabIndex = 40;
            // 
            // pbRefresh
            // 
            pbRefresh.Image = Properties.Resources.icons8_refresh_30__1_;
            pbRefresh.Location = new Point(884, 74);
            pbRefresh.Margin = new Padding(3, 2, 3, 2);
            pbRefresh.Name = "pbRefresh";
            pbRefresh.Size = new Size(22, 23);
            pbRefresh.SizeMode = PictureBoxSizeMode.Zoom;
            pbRefresh.TabIndex = 41;
            pbRefresh.TabStop = false;
            pbRefresh.Click += pbRefresh_Click;
            // 
            // StaffTaskForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(39, 39, 42);
            ClientSize = new Size(1199, 505);
            Controls.Add(pbRefresh);
            Controls.Add(txtDate);
            Controls.Add(txtPriority);
            Controls.Add(txtRoom);
            Controls.Add(txtNote);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(btnAccept);
            Controls.Add(lblTasksText);
            Controls.Add(pictureBox1);
            Controls.Add(lblRoomNo);
            Controls.Add(dgvTasks);
            Controls.Add(lblDueDate);
            Controls.Add(txtSearch);
            Controls.Add(btnCompleteTask);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "StaffTaskForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StaffTaskForm";
            Load += StaffTaskForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvTasks).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbRefresh).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTasksText;
        private PictureBox pictureBox1;
        private Label lblRoomNo;
        private DataGridView dgvTasks;
        private Label lblDueDate;
        private TextBox txtSearch;
        private Button btnCompleteTask;
        private Button btnAccept;
        private Label label1;
        private Label label4;
        private TextBox txtNote;
        private TextBox txtRoom;
        private TextBox txtPriority;
        private TextBox txtDate;
        private PictureBox pbRefresh;
    }
}