namespace TaskManager.UI
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            lblUsername = new Label();
            lblPassword = new Label();
            btnLogin = new Button();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            pictureBox1 = new PictureBox();
            lblWelcomeAdminText = new Label();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.ForeColor = Color.White;
            lblUsername.Location = new Point(107, 272);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(75, 20);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "Username";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.ForeColor = Color.White;
            lblPassword.Location = new Point(107, 354);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(70, 20);
            lblPassword.TabIndex = 1;
            lblPassword.Text = "Password";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(234, 46, 82);
            btnLogin.FlatAppearance.BorderColor = Color.White;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatAppearance.MouseDownBackColor = Color.DarkRed;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(107, 457);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(166, 29);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(107, 295);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(166, 27);
            txtUsername.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(107, 377);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(166, 27);
            txtPassword.TabIndex = 1;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(553, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(512, 560);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // lblWelcomeAdminText
            // 
            lblWelcomeAdminText.BackColor = Color.Transparent;
            lblWelcomeAdminText.FlatStyle = FlatStyle.Flat;
            lblWelcomeAdminText.Font = new Font("Verdana", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblWelcomeAdminText.ForeColor = Color.White;
            lblWelcomeAdminText.Location = new Point(87, 154);
            lblWelcomeAdminText.Name = "lblWelcomeAdminText";
            lblWelcomeAdminText.Size = new Size(300, 44);
            lblWelcomeAdminText.TabIndex = 4;
            lblWelcomeAdminText.Text = "Welcome Back";
            lblWelcomeAdminText.TextAlign = ContentAlignment.TopCenter;
            lblWelcomeAdminText.Click += lblWelcomeAdminText_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.White;
            label1.Location = new Point(52, 220);
            label1.Name = "label1";
            label1.Size = new Size(321, 33);
            label1.TabIndex = 4;
            label1.Text = "Sign in to manage your tasks";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(96, 54);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(63, 58);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Verdana", 15F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.White;
            label2.Location = new Point(148, 69);
            label2.Name = "label2";
            label2.Size = new Size(239, 62);
            label2.TabIndex = 4;
            label2.Text = "Task Manager";
            label2.TextAlign = ContentAlignment.TopCenter;
            label2.Click += lblWelcomeAdminText_Click;
            // 
            // LoginForm
            // 
            AcceptButton = btnLogin;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(39, 39, 42);
            ClientSize = new Size(1065, 560);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(lblWelcomeAdminText);
            Controls.Add(pictureBox1);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(btnLogin);
            Controls.Add(lblPassword);
            Controls.Add(lblUsername);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Task Manager";
            TopMost = true;
            Load += LoginForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private Label lblUsername;
        private Label lblPassword;
        private Button btnLogin;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private PictureBox pictureBox1;
        private Label lblWelcomeAdminText;
        private Label label1;
        private PictureBox pictureBox2;
        private Label label2;
    }
}