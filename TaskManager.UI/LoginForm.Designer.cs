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
            label3 = new Label();
            btnRegister = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.ForeColor = Color.White;
            lblUsername.Location = new Point(94, 204);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(60, 15);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "Username";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.ForeColor = Color.White;
            lblPassword.Location = new Point(94, 266);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(57, 15);
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
            btnLogin.Location = new Point(94, 343);
            btnLogin.Margin = new Padding(3, 2, 3, 2);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(145, 22);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(94, 221);
            txtUsername.Margin = new Padding(3, 2, 3, 2);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(146, 23);
            txtUsername.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(94, 283);
            txtPassword.Margin = new Padding(3, 2, 3, 2);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(146, 23);
            txtPassword.TabIndex = 1;
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(420, 0);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(512, 420);
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
            lblWelcomeAdminText.Location = new Point(76, 116);
            lblWelcomeAdminText.Name = "lblWelcomeAdminText";
            lblWelcomeAdminText.Size = new Size(262, 33);
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
            label1.Location = new Point(46, 165);
            label1.Name = "label1";
            label1.Size = new Size(281, 25);
            label1.TabIndex = 4;
            label1.Text = "Sign in to manage your tasks";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(84, 40);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(55, 44);
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
            label2.Location = new Point(130, 52);
            label2.Name = "label2";
            label2.Size = new Size(209, 46);
            label2.TabIndex = 4;
            label2.Text = "Task Manager";
            label2.TextAlign = ContentAlignment.TopCenter;
            label2.Click += lblWelcomeAdminText_Click;
            // 
            // label3
            // 
            label3.BackColor = Color.Transparent;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.ForeColor = Color.White;
            label3.Location = new Point(46, 386);
            label3.Name = "label3";
            label3.Size = new Size(281, 25);
            label3.TabIndex = 6;
            label3.Text = "Don't have an account?";
            label3.TextAlign = ContentAlignment.TopCenter;
            label3.Click += label3_Click;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.FromArgb(39, 39, 42);
            btnRegister.FlatAppearance.BorderColor = Color.White;
            btnRegister.FlatAppearance.BorderSize = 0;
            btnRegister.FlatAppearance.MouseDownBackColor = Color.DarkRed;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(268, 379);
            btnRegister.Margin = new Padding(3, 2, 3, 2);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(86, 29);
            btnRegister.TabIndex = 8;
            btnRegister.Text = "Sign Up";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // LoginForm
            // 
            AcceptButton = btnLogin;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(39, 39, 42);
            ClientSize = new Size(932, 420);
            Controls.Add(btnRegister);
            Controls.Add(label3);
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
            Margin = new Padding(3, 2, 3, 2);
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
        private Label label3;
        private Button btnRegister;
    }
}