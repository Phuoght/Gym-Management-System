namespace Gym_Management_System
{
    partial class frm_login
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
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label4 = new Label();
            txtUser = new TextBox();
            txtPwd = new TextBox();
            btnLogin = new Button();
            linkAdmin = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(0, 64, 64);
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(-1, -2);
            label1.Name = "label1";
            label1.Size = new Size(244, 521);
            label1.TabIndex = 0;
            label1.Text = "GYM CENTER";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(308, 9);
            label2.Name = "label2";
            label2.Size = new Size(512, 48);
            label2.TabIndex = 1;
            label2.Text = "Hệ thống quản lí phòng Gym";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo3;
            pictureBox1.Location = new Point(441, 75);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(213, 122);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(0, 192, 192);
            label3.Location = new Point(324, 223);
            label3.Name = "label3";
            label3.Size = new Size(144, 38);
            label3.TabIndex = 3;
            label3.Text = "Tài khoản";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(0, 192, 192);
            label4.Location = new Point(325, 306);
            label4.Name = "label4";
            label4.Size = new Size(143, 38);
            label4.TabIndex = 4;
            label4.Text = "Mật khẩu";
            // 
            // txtUser
            // 
            txtUser.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUser.Location = new Point(324, 264);
            txtUser.Name = "txtUser";
            txtUser.PlaceholderText = "Tên tài khoản";
            txtUser.Size = new Size(336, 39);
            txtUser.TabIndex = 5;
            // 
            // txtPwd
            // 
            txtPwd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPwd.Location = new Point(325, 347);
            txtPwd.Name = "txtPwd";
            txtPwd.PasswordChar = '*';
            txtPwd.Size = new Size(336, 39);
            txtPwd.TabIndex = 6;
            txtPwd.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Teal;
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatStyle = FlatStyle.Popup;
            btnLogin.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.MintCream;
            btnLogin.Location = new Point(423, 403);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(217, 53);
            btnLogin.TabIndex = 7;
            btnLogin.Text = "Đăng nhập";
            btnLogin.UseVisualStyleBackColor = false;
            // 
            // linkAdmin
            // 
            linkAdmin.AutoSize = true;
            linkAdmin.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkAdmin.LinkColor = Color.Teal;
            linkAdmin.Location = new Point(476, 469);
            linkAdmin.Name = "linkAdmin";
            linkAdmin.Size = new Size(102, 32);
            linkAdmin.TabIndex = 8;
            linkAdmin.TabStop = true;
            linkAdmin.Text = "Admin?";
            // 
            // frm_login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(872, 521);
            Controls.Add(linkAdmin);
            Controls.Add(btnLogin);
            Controls.Add(txtPwd);
            Controls.Add(txtUser);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = SystemColors.ButtonFace;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frm_login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng nhập";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label4;
        private TextBox txtUser;
        private TextBox txtPwd;
        private Button btnLogin;
        private LinkLabel linkAdmin;
    }
}