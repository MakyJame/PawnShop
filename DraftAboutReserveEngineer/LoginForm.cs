using DraftAboutReserveEngineer.Helpers;
using DraftAboutReserveEngineer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DraftAboutReserveEngineer
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.SendToBack();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter username and password");
                return;
            }

            string hashedPassword = SecurityHelpers.ComputeSha256Hash(password);

            using (var db = new AppDbContext())
            {
                var user = db.Users.FirstOrDefault(u => u.Username == username && u.Password == hashedPassword);
                if (user != null)
                {
                    GlobalUser.CurrentUser = user;
                    MessageBox.Show($"Hello {user.Username}");

                    this.Hide();

                    if (user.Role == "admin")
                    {
                        var adminForm = new AdminForm();
                        this.Hide();

                        adminForm.ShowDialog();
                        this.Close();

                        TxtInforClear();
                    }
                    else if (user.Role == "staff")
                    {
                        var staffForm = new Form2(); // Form dành cho staff
                        this.Hide();

                        staffForm.ShowDialog();
                        this.Close();

                        TxtInforClear();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid username or password");
                }
            }
        }

        private void TxtInforClear()
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtUsername.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            txtUsername.PlaceholderText = "Username";
            txtPassword.PlaceholderText = "Password";

            txtUsername.Font = new Font("Tahoma", 12);
            txtPassword.Font = new Font("Tahoma", 12);

            txtUsername.ForeColor = Color.DarkBlue;
            txtPassword.ForeColor = Color.DarkBlue;
        }
    }
}
