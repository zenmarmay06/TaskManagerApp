namespace TaskManager.UI
{
    partial class StaffDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffDashboard));
            pictureBox1 = new PictureBox();
            lblTaskManagerApp = new Label();
            lblWelcome = new Label();
            btnLogout = new Button();
            lblOverdue = new Label();
            lblPendingTasks = new Label();
            lblTotalTasks = new Label();
            lblCompletedTasks = new Label();
            btnTasks = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(47, 20);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(46, 39);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // lblTaskManagerApp
            // 
            lblTaskManagerApp.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblTaskManagerApp.ForeColor = Color.White;
            lblTaskManagerApp.Location = new Point(98, 22);
            lblTaskManagerApp.Name = "lblTaskManagerApp";
            lblTaskManagerApp.Size = new Size(206, 38);
            lblTaskManagerApp.TabIndex = 13;
            lblTaskManagerApp.Text = "Task Manager";
            // 
            // lblWelcome
            // 
            lblWelcome.BackColor = Color.FromArgb(39, 39, 42);
            lblWelcome.Font = new Font("Verdana", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblWelcome.ForeColor = Color.White;
            lblWelcome.Location = new Point(47, 86);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(308, 40);
            lblWelcome.TabIndex = 7;
            lblWelcome.Text = "WELCOME";
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(234, 46, 82);
            btnLogout.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(754, 23);
            btnLogout.Margin = new Padding(3, 2, 3, 2);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(126, 36);
            btnLogout.TabIndex = 12;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // lblOverdue
            // 
            lblOverdue.BackColor = Color.Gray;
            lblOverdue.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblOverdue.ForeColor = Color.White;
            lblOverdue.Location = new Point(705, 256);
            lblOverdue.Name = "lblOverdue";
            lblOverdue.Size = new Size(175, 75);
            lblOverdue.TabIndex = 8;
            lblOverdue.Text = "Overdue Tasks";
            lblOverdue.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPendingTasks
            // 
            lblPendingTasks.BackColor = Color.Gray;
            lblPendingTasks.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblPendingTasks.ForeColor = Color.Transparent;
            lblPendingTasks.Location = new Point(256, 256);
            lblPendingTasks.Name = "lblPendingTasks";
            lblPendingTasks.Size = new Size(175, 75);
            lblPendingTasks.TabIndex = 9;
            lblPendingTasks.Text = "Pending Tasks";
            lblPendingTasks.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTotalTasks
            // 
            lblTotalTasks.BackColor = Color.Gray;
            lblTotalTasks.FlatStyle = FlatStyle.Popup;
            lblTotalTasks.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblTotalTasks.ForeColor = Color.White;
            lblTotalTasks.ImageAlign = ContentAlignment.MiddleLeft;
            lblTotalTasks.Location = new Point(47, 256);
            lblTotalTasks.Name = "lblTotalTasks";
            lblTotalTasks.Size = new Size(175, 75);
            lblTotalTasks.TabIndex = 10;
            lblTotalTasks.Text = "Total Tasks";
            lblTotalTasks.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCompletedTasks
            // 
            lblCompletedTasks.BackColor = Color.Gray;
            lblCompletedTasks.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblCompletedTasks.ForeColor = Color.White;
            lblCompletedTasks.Location = new Point(478, 256);
            lblCompletedTasks.Name = "lblCompletedTasks";
            lblCompletedTasks.Size = new Size(175, 75);
            lblCompletedTasks.TabIndex = 11;
            lblCompletedTasks.Text = "Completed Tasks";
            lblCompletedTasks.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnTasks
            // 
            btnTasks.BackColor = Color.FromArgb(234, 46, 82);
            btnTasks.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnTasks.ForeColor = Color.White;
            btnTasks.Location = new Point(46, 366);
            btnTasks.Margin = new Padding(3, 2, 3, 2);
            btnTasks.Name = "btnTasks";
            btnTasks.Size = new Size(176, 35);
            btnTasks.TabIndex = 6;
            btnTasks.Text = "View Tasks";
            btnTasks.UseVisualStyleBackColor = false;
            btnTasks.Click += btnTasks_Click;
            // 
            // StaffDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(39, 39, 42);
            ClientSize = new Size(926, 420);
            Controls.Add(pictureBox1);
            Controls.Add(lblTaskManagerApp);
            Controls.Add(lblWelcome);
            Controls.Add(btnLogout);
            Controls.Add(lblOverdue);
            Controls.Add(lblPendingTasks);
            Controls.Add(lblTotalTasks);
            Controls.Add(lblCompletedTasks);
            Controls.Add(btnTasks);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "StaffDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StaffDashboard";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblTaskManagerApp;
        private Label lblWelcome;
        private Button btnLogout;
        private Label lblOverdue;
        private Label lblPendingTasks;
        private Label lblTotalTasks;
        private Label lblCompletedTasks;
        private Button btnTasks;
    }
}