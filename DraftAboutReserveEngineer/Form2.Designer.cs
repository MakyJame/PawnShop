namespace DraftAboutReserveEngineer
{
    partial class Form2
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnOpenAdminForm = new Button();
            btnSort = new Button();
            btnUpdate = new Button();
            dataGridView1 = new DataGridView();
            btnRemove = new Button();
            btnAdd = new Button();
            btnReset = new Button();
            btnSearch = new Button();
            cbField = new ComboBox();
            txtSearch = new TextBox();
            label8 = new Label();
            txtBrand = new TextBox();
            txtFullName = new TextBox();
            txtStorageLocation = new TextBox();
            txtPhoneNumber = new TextBox();
            txtPawnPrice = new TextBox();
            txtVehicleNumber = new TextBox();
            txtPawnDate = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnLogout = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnOpenAdminForm
            // 
            btnOpenAdminForm.Location = new Point(710, 11);
            btnOpenAdminForm.Name = "btnOpenAdminForm";
            btnOpenAdminForm.Size = new Size(81, 32);
            btnOpenAdminForm.TabIndex = 49;
            btnOpenAdminForm.Text = "Admin Mod";
            btnOpenAdminForm.UseVisualStyleBackColor = true;
            btnOpenAdminForm.Click += btnOpenAdminForm_Click;
            // 
            // btnSort
            // 
            btnSort.Location = new Point(678, 206);
            btnSort.Name = "btnSort";
            btnSort.Size = new Size(120, 37);
            btnSort.TabIndex = 48;
            btnSort.Text = "Order by Days";
            btnSort.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(244, 175);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.RightToLeft = RightToLeft.Yes;
            btnUpdate.Size = new Size(98, 34);
            btnUpdate.TabIndex = 47;
            btnUpdate.Text = "UPDATE";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 255);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(795, 192);
            dataGridView1.TabIndex = 46;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // btnRemove
            // 
            btnRemove.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRemove.Location = new Point(244, 214);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(98, 35);
            btnRemove.TabIndex = 45;
            btnRemove.Text = "REMOVE";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.OrangeRed;
            btnAdd.Location = new Point(138, 227);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(100, 25);
            btnAdd.TabIndex = 44;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnReset
            // 
            btnReset.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReset.Location = new Point(10, 227);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(70, 30);
            btnReset.TabIndex = 43;
            btnReset.Text = "RESET";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(365, 31);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 42;
            btnSearch.Text = "Find";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // cbField
            // 
            cbField.FormattingEnabled = true;
            cbField.Location = new Point(471, 3);
            cbField.Name = "cbField";
            cbField.Size = new Size(121, 23);
            cbField.TabIndex = 41;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(365, 3);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(100, 23);
            txtSearch.TabIndex = 40;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(303, 6);
            label8.Name = "label8";
            label8.Size = new Size(56, 15);
            label8.TabIndex = 39;
            label8.Text = "Key word";
            // 
            // txtBrand
            // 
            txtBrand.Location = new Point(138, 198);
            txtBrand.Name = "txtBrand";
            txtBrand.Size = new Size(100, 23);
            txtBrand.TabIndex = 38;
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(138, 163);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(100, 23);
            txtFullName.TabIndex = 37;
            // 
            // txtStorageLocation
            // 
            txtStorageLocation.Location = new Point(138, 127);
            txtStorageLocation.Name = "txtStorageLocation";
            txtStorageLocation.Size = new Size(100, 23);
            txtStorageLocation.TabIndex = 36;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(138, 96);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(100, 23);
            txtPhoneNumber.TabIndex = 35;
            // 
            // txtPawnPrice
            // 
            txtPawnPrice.Location = new Point(138, 64);
            txtPawnPrice.Name = "txtPawnPrice";
            txtPawnPrice.Size = new Size(100, 23);
            txtPawnPrice.TabIndex = 34;
            // 
            // txtVehicleNumber
            // 
            txtVehicleNumber.Location = new Point(138, 32);
            txtVehicleNumber.Name = "txtVehicleNumber";
            txtVehicleNumber.Size = new Size(100, 23);
            txtVehicleNumber.TabIndex = 33;
            // 
            // txtPawnDate
            // 
            txtPawnDate.Location = new Point(138, 3);
            txtPawnDate.Name = "txtPawnDate";
            txtPawnDate.Size = new Size(100, 23);
            txtPawnDate.TabIndex = 32;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(66, 206);
            label7.Name = "label7";
            label7.Size = new Size(38, 15);
            label7.TabIndex = 31;
            label7.Text = "Brand";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(56, 171);
            label6.Name = "label6";
            label6.Size = new Size(61, 15);
            label6.TabIndex = 30;
            label6.Text = "Full Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(36, 135);
            label5.Name = "label5";
            label5.Size = new Size(96, 15);
            label5.TabIndex = 29;
            label5.Text = "Storage Location";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(41, 104);
            label4.Name = "label4";
            label4.Size = new Size(88, 15);
            label4.TabIndex = 28;
            label4.Text = "Phone Number";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(52, 72);
            label3.Name = "label3";
            label3.Size = new Size(65, 15);
            label3.TabIndex = 27;
            label3.Text = "Pawn Price";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 40);
            label2.Name = "label2";
            label2.Size = new Size(91, 15);
            label2.TabIndex = 26;
            label2.Text = "Vehicle Number";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 11);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 25;
            label1.Text = "Pawn Date";
            // 
            // btnLogout
            // 
            btnLogout.Font = new Font("Segoe UI Emoji", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = Color.Red;
            btnLogout.Location = new Point(699, 49);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(86, 38);
            btnLogout.TabIndex = 50;
            btnLogout.Text = "Log out";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // Form2
            // 
            AcceptButton = btnAdd;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLogout);
            Controls.Add(btnOpenAdminForm);
            Controls.Add(btnSort);
            Controls.Add(btnUpdate);
            Controls.Add(dataGridView1);
            Controls.Add(btnRemove);
            Controls.Add(btnAdd);
            Controls.Add(btnReset);
            Controls.Add(btnSearch);
            Controls.Add(cbField);
            Controls.Add(txtSearch);
            Controls.Add(label8);
            Controls.Add(txtBrand);
            Controls.Add(txtFullName);
            Controls.Add(txtStorageLocation);
            Controls.Add(txtPhoneNumber);
            Controls.Add(txtPawnPrice);
            Controls.Add(txtVehicleNumber);
            Controls.Add(txtPawnDate);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form1";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOpenAdminForm;
        private Button btnSort;
        private Button btnUpdate;
        private DataGridView dataGridView1;
        private Button btnRemove;
        private Button btnAdd;
        private Button btnReset;
        private Button btnSearch;
        private ComboBox cbField;
        private TextBox txtSearch;
        private Label label8;
        private TextBox txtBrand;
        private TextBox txtFullName;
        private TextBox txtStorageLocation;
        private TextBox txtPhoneNumber;
        private TextBox txtPawnPrice;
        private TextBox txtVehicleNumber;
        private TextBox txtPawnDate;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnLogout;
    }
}
