namespace DraftAboutReserveEngineer
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
            lblTitle = new Label();
            pictureBox1 = new PictureBox();
            txtUsername = new TextBox();
            panel1 = new Panel();
            txtPassword = new TextBox();
            panel2 = new Panel();
            btnLogin = new Button();
            btnExit = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(376, 58);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(78, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Login";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(35, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(216, 191);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // txtUsername
            // 
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Location = new Point(336, 128);
            txtUsername.Multiline = true;
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(150, 34);
            txtUsername.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Location = new Point(309, 168);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 10);
            panel1.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Location = new Point(336, 195);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(162, 40);
            txtPassword.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.Location = new Point(310, 238);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 10);
            panel2.TabIndex = 3;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(33, 150, 243);
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(364, 345);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(90, 41);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.Location = new Point(364, 388);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(90, 28);
            btnExit.TabIndex = 6;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // LoginForm
            // 
            AcceptButton = btnLogin;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSlateGray;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExit);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(txtUsername);
            Controls.Add(pictureBox1);
            Controls.Add(lblTitle);
            Name = "LoginForm";
            Text = "LoginForm";
            Load += LoginForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private PictureBox pictureBox1;
        private TextBox txtUsername;
        private Panel panel1;
        private TextBox txtPassword;
        private Panel panel2;
        private Button btnLogin;
        private Button btnExit;
    }
}