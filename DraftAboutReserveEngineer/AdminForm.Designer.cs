namespace DraftAboutReserveEngineer
{
    partial class AdminForm
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
            lblWelcome = new Label();
            btnShowPawnedAssets = new Button();
            btnLogout = new Button();
            dataGridView1 = new DataGridView();
            btnViewLogs = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblWelcome.Location = new Point(343, 23);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(52, 21);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "label1";
            // 
            // btnShowPawnedAssets
            // 
            btnShowPawnedAssets.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnShowPawnedAssets.Location = new Point(605, 21);
            btnShowPawnedAssets.Name = "btnShowPawnedAssets";
            btnShowPawnedAssets.Size = new Size(151, 60);
            btnShowPawnedAssets.TabIndex = 1;
            btnShowPawnedAssets.Text = "Show Pawned Assets";
            btnShowPawnedAssets.UseVisualStyleBackColor = true;
            btnShowPawnedAssets.Click += btnShowPawnedAssets_Click;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(32, 23);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(79, 27);
            btnLogout.TabIndex = 2;
            btnLogout.Text = "Log out";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(-15, 113);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(815, 345);
            dataGridView1.TabIndex = 3;
            // 
            // btnViewLogs
            // 
            btnViewLogs.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnViewLogs.Location = new Point(322, 61);
            btnViewLogs.Name = "btnViewLogs";
            btnViewLogs.Size = new Size(89, 50);
            btnViewLogs.TabIndex = 4;
            btnViewLogs.Text = "View Logs";
            btnViewLogs.UseVisualStyleBackColor = true;
            btnViewLogs.Click += btnViewLogs_Click;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnViewLogs);
            Controls.Add(dataGridView1);
            Controls.Add(btnLogout);
            Controls.Add(btnShowPawnedAssets);
            Controls.Add(lblWelcome);
            Name = "AdminForm";
            Text = "AdminForm";
            Load += AdminForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblWelcome;
        private Button btnShowPawnedAssets;
        private Button btnLogout;
        private DataGridView dataGridView1;
        private Button btnViewLogs;
    }
}