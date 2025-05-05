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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
            this.Text = "Admin Dashboard";
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = $"Welcome, {GlobalUser.CurrentUser.Username}(Admin)";
        }

        private void btnViewLogs_Click(object sender, EventArgs e)
        {
            using var db = new AppDbContext();
            var logs = db.AuditLogs
                         .OrderBy(log => log.Id)
                         .Select(log => new
                         {
                             log.Id,
                             log.UserId,
                             log.Action,
                             Time = log.DateTime.ToString("yyyy-MM-dd HH:mm:ss")
                         }).ToList();
            dataGridView1.DataSource = logs;
        }
        private void btnShowPawnedAssets_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this);
            this.Hide();
            form2.ShowDialog();
            this.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //LoginForm loginForm = new LoginForm();
            //loginForm.ShowDialog();
            //this.Close();

            //this.Close();
            var confirmResult = MessageBox.Show("Are you sure you want to log out ?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmResult == DialogResult.Yes)
            {
                this.Hide();
                GlobalUser.CurrentUser = null;

                var loginForm = new LoginForm();
                loginForm.ShowDialog();
                this.Close();
            }
        }


    }
}
