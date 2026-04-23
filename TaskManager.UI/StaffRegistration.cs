using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using TaskManager.Core.Models;
using TaskManager.Data.Repositories;

namespace TaskManager.UI
{
    public partial class StaffRegistration : Form
    {
        public StaffRegistration()
        {
            InitializeComponent();
        }

        private void StaffRegistration_Load(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            var newStaff = new User
            {
                Name = txtFullname.Text,
                Username = txtUsername.Text,
                Password = txtPassword.Text // I-type ra ang plain text, ang Repository na mo-hash
            };

            UserRepository repo = new UserRepository();
            if (repo.RegisterUser(newStaff))
            {
                MessageBox.Show("Staff Registered Successfully!");
                LoginForm login = new LoginForm();
                login.Show();

                // 👇 HIDE THIS FORM
                this.Hide();

            }
            else
            {
                MessageBox.Show("Registration Failed.");
            }
        }
    }
}
