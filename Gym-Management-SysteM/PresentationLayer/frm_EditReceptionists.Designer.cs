namespace Gym_Management_System
{
    partial class frm_EditReceptionists
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
            Button btnEdit_save;
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtEdit_name = new TextBox();
            txtEdit_phone = new TextBox();
            txtEdit_address = new TextBox();
            txtEdit_pass = new TextBox();
            cbEdit_gen = new ComboBox();
            dtpEdit_dob = new DateTimePicker();
            btnEdit_save = new Button();
            SuspendLayout();
            // 
            // btnEdit_save
            // 
            btnEdit_save.BackColor = Color.Red;
            btnEdit_save.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEdit_save.ForeColor = SystemColors.ControlLightLight;
            btnEdit_save.Location = new Point(426, 405);
            btnEdit_save.Name = "btnEdit_save";
            btnEdit_save.Size = new Size(162, 57);
            btnEdit_save.TabIndex = 7;
            btnEdit_save.Text = "Lưu";
            btnEdit_save.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlLightLight;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(319, 40);
            label1.Name = "label1";
            label1.Size = new Size(360, 38);
            label1.TabIndex = 0;
            label1.Text = "Chỉnh sửa thông tin lễ tân";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(95, 128);
            label2.Name = "label2";
            label2.Size = new Size(106, 38);
            label2.TabIndex = 1;
            label2.Text = "Họ tên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(95, 208);
            label3.Name = "label3";
            label3.Size = new Size(132, 38);
            label3.TabIndex = 2;
            label3.Text = "Giới tính";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(95, 281);
            label4.Name = "label4";
            label4.Size = new Size(143, 38);
            label4.TabIndex = 3;
            label4.Text = "Mật khẩu";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(524, 128);
            label5.Name = "label5";
            label5.Size = new Size(192, 38);
            label5.TabIndex = 4;
            label5.Text = "Số điện thoại";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(524, 208);
            label6.Name = "label6";
            label6.Size = new Size(148, 38);
            label6.TabIndex = 5;
            label6.Text = "Ngày sinh";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(524, 281);
            label7.Name = "label7";
            label7.Size = new Size(107, 38);
            label7.TabIndex = 6;
            label7.Text = "Địa chỉ";
            // 
            // txtEdit_name
            // 
            txtEdit_name.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEdit_name.Location = new Point(252, 128);
            txtEdit_name.Name = "txtEdit_name";
            txtEdit_name.Size = new Size(235, 38);
            txtEdit_name.TabIndex = 8;
            // 
            // txtEdit_phone
            // 
            txtEdit_phone.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEdit_phone.Location = new Point(722, 128);
            txtEdit_phone.Name = "txtEdit_phone";
            txtEdit_phone.Size = new Size(235, 38);
            txtEdit_phone.TabIndex = 9;
            // 
            // txtEdit_address
            // 
            txtEdit_address.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEdit_address.Location = new Point(650, 281);
            txtEdit_address.Name = "txtEdit_address";
            txtEdit_address.Size = new Size(307, 38);
            txtEdit_address.TabIndex = 10;
            // 
            // txtEdit_pass
            // 
            txtEdit_pass.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEdit_pass.Location = new Point(252, 281);
            txtEdit_pass.Name = "txtEdit_pass";
            txtEdit_pass.Size = new Size(235, 38);
            txtEdit_pass.TabIndex = 11;
            // 
            // cbEdit_gen
            // 
            cbEdit_gen.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbEdit_gen.FormattingEnabled = true;
            cbEdit_gen.Items.AddRange(new object[] { "Nam", "Nữ" });
            cbEdit_gen.Location = new Point(252, 207);
            cbEdit_gen.Name = "cbEdit_gen";
            cbEdit_gen.Size = new Size(235, 39);
            cbEdit_gen.TabIndex = 12;
            // 
            // dtpEdit_dob
            // 
            dtpEdit_dob.CalendarFont = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpEdit_dob.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpEdit_dob.Format = DateTimePickerFormat.Short;
            dtpEdit_dob.Location = new Point(722, 208);
            dtpEdit_dob.Name = "dtpEdit_dob";
            dtpEdit_dob.Size = new Size(235, 38);
            dtpEdit_dob.TabIndex = 13;
            // 
            // frm_EditReceptionist
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 553);
            Controls.Add(dtpEdit_dob);
            Controls.Add(cbEdit_gen);
            Controls.Add(txtEdit_pass);
            Controls.Add(txtEdit_address);
            Controls.Add(txtEdit_phone);
            Controls.Add(txtEdit_name);
            Controls.Add(btnEdit_save);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frm_EditReceptionist";
            Text = "EditReceptionist";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtEdit_name;
        private TextBox txtEdit_phone;
        private TextBox txtEdit_address;
        private TextBox txtEdit_pass;
        private ComboBox cbEdit_gen;
        private DateTimePicker dtpEdit_dob;
    }
}