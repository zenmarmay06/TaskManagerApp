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

namespace TaskManager.UI
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            AuthService authService = new AuthService();

            var user = authService.Login(txtUsername.Text, txtPassword.Text);

            if (user != null)
            {
                MessageBox.Show("Login successful");

                DashboardForm dashboard = new DashboardForm(user);
                dashboard.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password");
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lblWelcomeAdminText_Click(object sender, EventArgs e)
        {

        }
    }
}
