namespace TaskManager.UI
{
    partial class DashboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardForm));
            btnTasks = new Button();
            lblWelcome = new Label();
            lblCompletedTasks = new Label();
            lblPendingTasks = new Label();
            btnLogout = new Button();
            lblOverdue = new Label();
            lblTotalTasks = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            lblTaskManagerApp = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnTasks
            // 
            btnTasks.BackColor = Color.FromArgb(234, 46, 82);
            btnTasks.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnTasks.ForeColor = Color.White;
            btnTasks.Location = new Point(28, 470);
            btnTasks.Name = "btnTasks";
            btnTasks.Size = new Size(201, 47);
            btnTasks.TabIndex = 0;
            btnTasks.Text = "View Tasks";
            btnTasks.UseVisualStyleBackColor = false;
            btnTasks.Click += btnTasks_Click;
            // 
            // lblWelcome
            // 
            lblWelcome.BackColor = Color.FromArgb(39, 39, 42);
            lblWelcome.Font = new Font("Verdana", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblWelcome.ForeColor = Color.White;
            lblWelcome.Location = new Point(29, 96);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(352, 53);
            lblWelcome.TabIndex = 1;
            lblWelcome.Text = "WELCOME";
          
            // 
            // lblCompletedTasks
            // 
            lblCompletedTasks.BackColor = Color.Gray;
            lblCompletedTasks.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblCompletedTasks.ForeColor = Color.White;
            lblCompletedTasks.Location = new Point(521, 322);
            lblCompletedTasks.Name = "lblCompletedTasks";
            lblCompletedTasks.Size = new Size(200, 100);
            lblCompletedTasks.TabIndex = 2;
            lblCompletedTasks.Text = "Completed Tasks";
            lblCompletedTasks.TextAlign = ContentAlignment.MiddleCenter;

            // 
            // lblPendingTasks
            // 
            lblPendingTasks.BackColor = Color.Gray;
            lblPendingTasks.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblPendingTasks.ForeColor = Color.Transparent;
            lblPendingTasks.Location = new Point(268, 322);
            lblPendingTasks.Name = "lblPendingTasks";
            lblPendingTasks.Size = new Size(200, 100);
            lblPendingTasks.TabIndex = 2;
            lblPendingTasks.Text = "Pending Tasks";
            lblPendingTasks.TextAlign = ContentAlignment.MiddleCenter;
         
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(234, 46, 82);
            btnLogout.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(837, 12);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(144, 48);
            btnLogout.TabIndex = 3;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // lblOverdue
            // 
            lblOverdue.BackColor = Color.Gray;
            lblOverdue.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblOverdue.ForeColor = Color.White;
            lblOverdue.Location = new Point(781, 322);
            lblOverdue.Name = "lblOverdue";
            lblOverdue.Size = new Size(200, 100);
            lblOverdue.TabIndex = 2;
            lblOverdue.Text = "Overdue Tasks";
            lblOverdue.TextAlign = ContentAlignment.MiddleCenter;
     
            // 
            // lblTotalTasks
            // 
            lblTotalTasks.BackColor = Color.Gray;
            lblTotalTasks.FlatStyle = FlatStyle.Popup;
            lblTotalTasks.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblTotalTasks.ForeColor = Color.White;
            lblTotalTasks.ImageAlign = ContentAlignment.MiddleLeft;
            lblTotalTasks.Location = new Point(29, 322);
            lblTotalTasks.Name = "lblTotalTasks";
            lblTotalTasks.Size = new Size(200, 100);
            lblTotalTasks.TabIndex = 2;
            lblTotalTasks.Text = "Total Tasks";
            lblTotalTasks.TextAlign = ContentAlignment.MiddleCenter;
           
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(lblTaskManagerApp);
            panel1.Controls.Add(btnLogout);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1058, 66);
            panel1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(29, 8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(52, 52);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // lblTaskManagerApp
            // 
            lblTaskManagerApp.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblTaskManagerApp.ForeColor = Color.White;
            lblTaskManagerApp.Location = new Point(87, 10);
            lblTaskManagerApp.Name = "lblTaskManagerApp";
            lblTaskManagerApp.Size = new Size(235, 50);
            lblTaskManagerApp.TabIndex = 4;
            lblTaskManagerApp.Text = "Task Manager";
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(39, 39, 42);
            ClientSize = new Size(1058, 560);
            Controls.Add(panel1);
            Controls.Add(lblWelcome);
            Controls.Add(lblOverdue);
            Controls.Add(lblPendingTasks);
            Controls.Add(lblTotalTasks);
            Controls.Add(lblCompletedTasks);
            Controls.Add(btnTasks);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "DashboardForm";
            Text = "DashboardForm";
            Load += DashboardForm_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnTasks;
        private Label lblWelcome;

        private Label lblCompletedTasks;
        private Label lblPendingTasks;
        private Button btnLogout;
        private Label lblOverdue;
        private Label lblTotalTasks;
        private Panel panel1;
        private Label lblTaskManagerApp;
        private PictureBox pictureBox1;
     
    }
}