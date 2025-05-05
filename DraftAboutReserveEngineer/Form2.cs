using DraftAboutReserveEngineer.Helpers;
using DraftAboutReserveEngineer.Models;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace DraftAboutReserveEngineer
{
    public partial class Form2 : Form
    {
        private AdminForm _adminForm;
        public Form2()
        {
            InitializeComponent();


            this.Text = "Form 2";
            using (var db = new AppDbContext())
            {
                db.Database.EnsureCreated();
            }
        }
        public Form2(AdminForm adminForm)
        {
            InitializeComponent();
            _adminForm = adminForm;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            cbField.Items.Clear();
            cbField.Items.AddRange(
                typeof(Asset)
                .GetProperties()
                .Select(p => p.Name)
                .ToArray()
                );
            cbField.SelectedIndex = 2;

            if (GlobalUser.CurrentUser.Role == "staff")
            {
                btnRemove.Enabled = false;
                btnOpenAdminForm.Visible = false;
            }
            LoadAllData();
        }

        private void LoadAllData()
        {
            using var db = new AppDbContext();
            dataGridView1.DataSource = db.Assets.ToList();
        }
        private void TxtAllClear()
        {
            txtPawnDate.Clear();
            txtVehicleNumber.Clear();
            txtPawnPrice.Clear();
            txtPhoneNumber.Clear();
            txtStorageLocation.Clear();
            txtFullName.Clear();
            txtBrand.Clear();
            txtSearch.Clear();
            txtPawnDate.Focus();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtPawnDate.Clear();
            txtVehicleNumber.Clear();
            txtPawnPrice.Clear();
            txtPhoneNumber.Clear();
            txtStorageLocation.Clear();
            txtFullName.Clear();
            txtBrand.Clear();
            txtPawnDate.Focus();
            txtSearch.Clear();
            LoadAllData();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                txtPawnDate.Text = row.Cells["PawnDate"].Value?.ToString();
                txtVehicleNumber.Text = row.Cells["VehicleNumber"].Value?.ToString();
                txtPawnPrice.Text = row.Cells["PawnPrice"].Value?.ToString();
                txtPhoneNumber.Text = row.Cells["PhoneNumber"].Value?.ToString();
                txtStorageLocation.Text = row.Cells["StorageLocation"].Value?.ToString();
                txtFullName.Text = row.Cells["FullName"].Value?.ToString();
                txtBrand.Text = row.Cells["Brand"].Value?.ToString();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtPawnPrice.Text, out var price))
            {
                MessageBox.Show("Please enter a valid number of pawn price");
                return;
            }
            using var db = new AppDbContext();
            bool isDuplicate = db.Assets.Any(a => a.VehicleNumber == txtVehicleNumber.Text);
            if (isDuplicate)
            {
                MessageBox.Show("This vehicle number already exists. Please enter a different one !");
                return;
            }
            DateOnly? pawnDate = DateOnly.TryParse(txtPawnDate.Text, out DateOnly parsedDate) ? parsedDate : null;
            int pawnedDays = pawnDate.HasValue
                ? (DateTime.Now - pawnDate.Value.ToDateTime(new TimeOnly())).Days : 0;

            var asset = new Asset
            {
                PawnDate = pawnDate,
                VehicleNumber = txtVehicleNumber.Text,
                PawnPrice = price,
                PhoneNumber = txtPhoneNumber.Text,
                StorageLocation = txtStorageLocation.Text,
                FullName = txtFullName.Text,
                Brand = txtBrand.Text,
                PawnedDays = (int)pawnedDays,
            };
            db.Assets.Add(asset);
            db.SaveChanges();
            LoadAllData();
            TxtAllClear();

            LogHelper.WriteLog(GlobalUser.CurrentUser.Id, $"Added another motorbike with vehicle number {asset.VehicleNumber},  at Id: {asset.Id}");
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row or more to remove");
                return;
            }
            using var db = new AppDbContext();
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                var value = row.Cells["VehicleNumber"].Value;
                if (value == null)
                {
                    MessageBox.Show("Selected row has no VehicleNumber.");
                    continue;
                }
                string vehicleNumber = value.ToString();
                var asset = db.Assets.Find(vehicleNumber);
                if (asset != null)
                {
                    db.Assets.Remove(asset);
                    db.SaveChanges();
                }
                LogHelper.WriteLog(GlobalUser.CurrentUser.Id, $"Delete the row with infor: Id: {asset.Id}, VN: {asset.VehicleNumber}, FN:{asset.FullName}, Price: {asset.PawnPrice}, Phone: {asset.PhoneNumber}, Brand:{asset.Brand} ");

            }
            LoadAllData();
            TxtAllClear();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtPawnPrice.Text, out var price))
            {
                MessageBox.Show("Please enter a valid number of pawn price");
                return;
            }
            using var db = new AppDbContext();

            string vehicleNumber = (string)dataGridView1.SelectedRows[0].Cells["VehicleNumber"].Value.ToString();

            bool isDuplicate = db.Assets.Any(a => a.VehicleNumber == txtVehicleNumber.Text && a.VehicleNumber != vehicleNumber);
            if (isDuplicate)
            {
                MessageBox.Show("This vehicle number already exists. Please enter a different one !");
                return;
            }

            var asset = db.Assets.Find(vehicleNumber);
            if (asset != null)
            {
                var oldAsset = new
                {
                    asset.PawnDate,
                    asset.PawnPrice,
                    asset.PhoneNumber,
                    asset.StorageLocation,
                    asset.FullName,
                    asset.Brand
                };


                asset.PawnDate = DateOnly.TryParse(txtPawnDate.Text, out DateOnly parsedDate) ? parsedDate : null;
                var pawnDate = asset.PawnDate;
                asset.PawnPrice = price;
                asset.PhoneNumber = txtPhoneNumber.Text;
                asset.StorageLocation = txtStorageLocation.Text;
                asset.FullName = txtFullName.Text;
                asset.Brand = txtBrand.Text;
                asset.PawnedDays = pawnDate.HasValue ? (DateTime.Now - pawnDate.Value.ToDateTime(new TimeOnly())).Days : 0;

                var changes = new StringBuilder();

                if (oldAsset.PawnDate != asset.PawnDate)
                    changes.AppendLine($"PawnDate: '{oldAsset.PawnDate}' → '{asset.PawnDate}'");

                if (oldAsset.PawnPrice != asset.PawnPrice)
                    changes.AppendLine($"PawnPrice: {oldAsset.PawnPrice} → {asset.PawnPrice}");

                if (oldAsset.PhoneNumber != asset.PhoneNumber)
                    changes.AppendLine($"PhoneNumber: '{oldAsset.PhoneNumber}' → '{asset.PhoneNumber}'");

                if (oldAsset.StorageLocation != asset.StorageLocation)
                    changes.AppendLine($"StorageLocation: '{oldAsset.StorageLocation}' → '{asset.StorageLocation}'");

                if (oldAsset.FullName != asset.FullName)
                    changes.AppendLine($"FullName: '{oldAsset.FullName}' → '{asset.FullName}'");

                if (oldAsset.Brand != asset.Brand)
                    changes.AppendLine($"Brand: '{oldAsset.Brand}' → '{asset.Brand}'");

                if (changes.Length > 0)
                {
                    LogHelper.WriteLog(GlobalUser.CurrentUser.Id, $"Edited asset [{asset.VehicleNumber}] with changes: \n{changes}");
                }
            }
            db.SaveChanges();
            LoadAllData();
            TxtAllClear();
        }
        private void btnOpenAdminForm_Click(object sender, EventArgs e)
        {
            this.Close();
            AdminForm adminForm = new AdminForm();
            adminForm.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure you want to log out ?", "Confirm log out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmResult == DialogResult.Yes)
            {
                this.Hide();
                GlobalUser.CurrentUser = null;

                if (_adminForm != null && !_adminForm.IsDisposed)
                {
                    _adminForm.Close();  // đóng AdminForm
                }

                LoginForm login = new LoginForm();
                login.ShowDialog();
                this.Close();
            }
        }
    }
}
