using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;
using TaskManager.Core.Models;

namespace TaskManager.UI
{
    public partial class LoginForm : Form
    {
        private readonly HttpClient client = new HttpClient();
        // Suwayi ni kung wala kay .htaccess file
        private readonly string baseApi = "http://localhost/Hotel-Management-System-main/api/";

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                var payload = new
                {
                    username = txtUsername.Text.Trim(),
                    password = txtPassword.Text.Trim()
                };

                var content = new StringContent(
                    JsonConvert.SerializeObject(payload),
                    Encoding.UTF8,
                    "application/json"
                );

                // Pag-send sa request sa index.php (login route)
                var response = client.PostAsync(baseApi + "login", content).Result;
                var json = response.Content.ReadAsStringAsync().Result;

                // ❗ DEBUG: I-check ang HTTP status code ug ang message gikan sa PHP
                if (!response.IsSuccessStatusCode)
                {
                    // Imbis "Invalid Login" lang, ipakita nato ang message gikan sa PHP index.php
                    // Pananglitan: {"error": "Invalid password"} o {"error": "User not found"}
                    MessageBox.Show("Server Error: " + json, "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // ❗ PROTECT: Siguroha nga dili HTML (sama sa PHP error notices) ang nibalik
                if (string.IsNullOrWhiteSpace(json) || json.TrimStart().StartsWith("<"))
                {
                    MessageBox.Show("Server returned an invalid response (HTML). Check your PHP logs.\n\nResponse: " + json);
                    return;
                }

                // ❗ DESERIALIZE: I-convert ang JSON string ngadto sa User object
                var user = JsonConvert.DeserializeObject<User>(json);

                if (user == null)
                {
                    MessageBox.Show("Failed to process user data.");
                    return;
                }

                // ROUTING: Base sa Role nga gikan sa Database
                if (user.Role == "Admin")
                {
                    new DashboardForm(user).Show();
                }
                else
                {
                    new StaffDashboard(user).Show();
                }

                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection Error: " + ex.Message);
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

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            // 1. I-hide ang Login Form
            this.Hide();

            // 2. I-open ang Staff Registration Form
            StaffRegistration staff = new StaffRegistration();

            // Naggamit ta og ShowDialog aron mohunong ang code diri 
            // hangtod dili ma-close ang Registration window
            staff.ShowDialog();

            // 3. Inig close sa Registration, mo-pakita na sab ang Login Form
            this.Show();
        }
    }
}
