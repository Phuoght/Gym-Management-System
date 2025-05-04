namespace Gym_Management_System
{
    partial class frm_EditReceptionist
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
            label1 = new Label();
            btnEdit_save = new Button();
            SuspendLayout();
            // 
            // btnEdit_save
            // 
            btnEdit_save.BackColor = Color.Red;
            btnEdit_save.Cursor = Cursors.Hand;
            btnEdit_save.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEdit_save.ForeColor = SystemColors.ControlLightLight;
            btnEdit_save.Location = new Point(505, 460);
            btnEdit_save.Margin = new Padding(4);
            btnEdit_save.Name = "btnEdit_save";
            btnEdit_save.Size = new Size(202, 71);
            btnEdit_save.TabIndex = 7;
            btnEdit_save.Text = "Lưu";
            btnEdit_save.UseVisualStyleBackColor = false;
            btnEdit_save.Click += btnEdit_save_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(119, 160);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(125, 45);
            label2.TabIndex = 1;
            label2.Text = "Họ tên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(119, 260);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(153, 45);
            label3.TabIndex = 2;
            label3.Text = "Giới tính";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(119, 351);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(168, 45);
            label4.TabIndex = 3;
            label4.Text = "Mật khẩu";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(655, 160);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(225, 45);
            label5.TabIndex = 4;
            label5.Text = "Số điện thoại";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(655, 260);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(175, 45);
            label6.TabIndex = 5;
            label6.Text = "Ngày sinh";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(655, 351);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(125, 45);
            label7.TabIndex = 6;
            label7.Text = "Địa chỉ";
            // 
            // txtEdit_name
            // 
            txtEdit_name.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEdit_name.Location = new Point(315, 160);
            txtEdit_name.Margin = new Padding(4);
            txtEdit_name.Name = "txtEdit_name";
            txtEdit_name.Size = new Size(293, 44);
            txtEdit_name.TabIndex = 8;
            // 
            // txtEdit_phone
            // 
            txtEdit_phone.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEdit_phone.Location = new Point(902, 160);
            txtEdit_phone.Margin = new Padding(4);
            txtEdit_phone.Name = "txtEdit_phone";
            txtEdit_phone.Size = new Size(293, 44);
            txtEdit_phone.TabIndex = 9;
            // 
            // txtEdit_address
            // 
            txtEdit_address.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEdit_address.Location = new Point(812, 351);
            txtEdit_address.Margin = new Padding(4);
            txtEdit_address.Name = "txtEdit_address";
            txtEdit_address.Size = new Size(383, 44);
            txtEdit_address.TabIndex = 10;
            // 
            // txtEdit_pass
            // 
            txtEdit_pass.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEdit_pass.Location = new Point(315, 351);
            txtEdit_pass.Margin = new Padding(4);
            txtEdit_pass.Name = "txtEdit_pass";
            txtEdit_pass.Size = new Size(293, 44);
            txtEdit_pass.TabIndex = 11;
            // 
            // cbEdit_gen
            // 
            cbEdit_gen.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbEdit_gen.FormattingEnabled = true;
            cbEdit_gen.Items.AddRange(new object[] { "Nam", "Nữ" });
            cbEdit_gen.Location = new Point(315, 259);
            cbEdit_gen.Margin = new Padding(4);
            cbEdit_gen.Name = "cbEdit_gen";
            cbEdit_gen.Size = new Size(293, 46);
            cbEdit_gen.TabIndex = 12;
            // 
            // dtpEdit_dob
            // 
            dtpEdit_dob.CalendarFont = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpEdit_dob.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpEdit_dob.Format = DateTimePickerFormat.Short;
            dtpEdit_dob.Location = new Point(902, 260);
            dtpEdit_dob.Margin = new Padding(4);
            dtpEdit_dob.Name = "dtpEdit_dob";
            dtpEdit_dob.Size = new Size(293, 44);
            dtpEdit_dob.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(338, 23);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(567, 54);
            label1.TabIndex = 58;
            label1.Text = "Chỉnh Sửa Thông Tin Lễ Tân";
            // 
            // frm_EditReceptionists
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1275, 572);
            Controls.Add(label1);
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
            Margin = new Padding(4);
            Name = "frm_EditReceptionists";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Chỉnh Sửa Thông Tin Lễ Tân";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
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
        private Label label1;
    }
}