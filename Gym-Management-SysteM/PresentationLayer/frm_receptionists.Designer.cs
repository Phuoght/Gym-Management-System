namespace Gym_Management_System
{
    partial class frm_receptionists
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dgvLetan = new DataGridView();
            label8 = new Label();
            btnDel_letan = new Button();
            btnEdit_letan = new Button();
            label6 = new Label();
            txtAddress_letan = new TextBox();
            label7 = new Label();
            label5 = new Label();
            txtPhone_letan = new TextBox();
            label4 = new Label();
            label3 = new Label();
            cbGen_letan = new ComboBox();
            label2 = new Label();
            btnSave_letan = new Button();
            dtpDateOfBirth_letan = new DateTimePicker();
            txtName_letan = new TextBox();
            label1 = new Label();
            textBox1 = new TextBox();
            ID = new DataGridViewTextBoxColumn();
            name_letan = new DataGridViewTextBoxColumn();
            Gen = new DataGridViewTextBoxColumn();
            DOB = new DataGridViewTextBoxColumn();
            Phone = new DataGridViewTextBoxColumn();
            Password = new DataGridViewTextBoxColumn();
            Address = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvLetan).BeginInit();
            SuspendLayout();
            // 
            // dgvLetan
            // 
            dgvLetan.BackgroundColor = Color.IndianRed;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.Red;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Yellow;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvLetan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvLetan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLetan.Columns.AddRange(new DataGridViewColumn[] { ID, name_letan, Gen, DOB, Phone, Password, Address });
            dgvLetan.Cursor = Cursors.Hand;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.LightGray;
            dataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlDarkDark;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvLetan.DefaultCellStyle = dataGridViewCellStyle3;
            dgvLetan.Location = new Point(-1, 369);
            dgvLetan.Margin = new Padding(2);
            dgvLetan.MultiSelect = false;
            dgvLetan.Name = "dgvLetan";
            dgvLetan.RowHeadersWidth = 62;
            dgvLetan.Size = new Size(1191, 257);
            dgvLetan.TabIndex = 38;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Red;
            label8.Location = new Point(531, 320);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(226, 37);
            label8.TabIndex = 37;
            label8.Text = "Danh sách lễ tân";
            // 
            // btnDel_letan
            // 
            btnDel_letan.BackColor = Color.Red;
            btnDel_letan.Cursor = Cursors.Hand;
            btnDel_letan.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDel_letan.ForeColor = SystemColors.ButtonFace;
            btnDel_letan.Location = new Point(698, 630);
            btnDel_letan.Margin = new Padding(2);
            btnDel_letan.Name = "btnDel_letan";
            btnDel_letan.Size = new Size(118, 42);
            btnDel_letan.TabIndex = 36;
            btnDel_letan.Text = "Xóa";
            btnDel_letan.UseVisualStyleBackColor = false;
            // 
            // btnEdit_letan
            // 
            btnEdit_letan.BackColor = Color.Red;
            btnEdit_letan.Cursor = Cursors.Hand;
            btnEdit_letan.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEdit_letan.ForeColor = SystemColors.ButtonFace;
            btnEdit_letan.Location = new Point(462, 630);
            btnEdit_letan.Margin = new Padding(2);
            btnEdit_letan.Name = "btnEdit_letan";
            btnEdit_letan.Size = new Size(118, 42);
            btnEdit_letan.TabIndex = 35;
            btnEdit_letan.Text = "Chỉnh Sửa";
            btnEdit_letan.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Black", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Red;
            label6.Location = new Point(531, 9);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(237, 46);
            label6.TabIndex = 34;
            label6.Text = "Quản lí lễ tân";
            // 
            // txtAddress_letan
            // 
            txtAddress_letan.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAddress_letan.Location = new Point(462, 217);
            txtAddress_letan.Margin = new Padding(2);
            txtAddress_letan.Multiline = true;
            txtAddress_letan.Name = "txtAddress_letan";
            txtAddress_letan.Size = new Size(402, 32);
            txtAddress_letan.TabIndex = 33;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label7.Location = new Point(462, 172);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(92, 32);
            label7.TabIndex = 32;
            label7.Text = "Địa chỉ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label5.Location = new Point(156, 172);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(121, 32);
            label5.TabIndex = 31;
            label5.Text = "Mật khẩu";
            // 
            // txtPhone_letan
            // 
            txtPhone_letan.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPhone_letan.Location = new Point(929, 116);
            txtPhone_letan.Margin = new Padding(2);
            txtPhone_letan.Name = "txtPhone_letan";
            txtPhone_letan.Size = new Size(235, 34);
            txtPhone_letan.TabIndex = 30;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label4.Location = new Point(929, 71);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(172, 32);
            label4.TabIndex = 29;
            label4.Text = "Số Điện Thoại";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label3.Location = new Point(686, 71);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(128, 32);
            label3.TabIndex = 28;
            label3.Text = "Ngày sinh";
            // 
            // cbGen_letan
            // 
            cbGen_letan.DropDownStyle = ComboBoxStyle.DropDownList;
            cbGen_letan.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbGen_letan.FormattingEnabled = true;
            cbGen_letan.Items.AddRange(new object[] { "Nam", "Nữ" });
            cbGen_letan.Location = new Point(462, 116);
            cbGen_letan.Margin = new Padding(2);
            cbGen_letan.Name = "cbGen_letan";
            cbGen_letan.Size = new Size(146, 36);
            cbGen_letan.TabIndex = 27;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label2.Location = new Point(462, 71);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(117, 32);
            label2.TabIndex = 26;
            label2.Text = "Giới Tính";
            // 
            // btnSave_letan
            // 
            btnSave_letan.BackColor = Color.Red;
            btnSave_letan.Cursor = Cursors.Hand;
            btnSave_letan.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave_letan.ForeColor = SystemColors.ButtonFace;
            btnSave_letan.Location = new Point(585, 267);
            btnSave_letan.Margin = new Padding(2);
            btnSave_letan.Name = "btnSave_letan";
            btnSave_letan.Size = new Size(118, 42);
            btnSave_letan.TabIndex = 25;
            btnSave_letan.Text = "Lưu";
            btnSave_letan.UseVisualStyleBackColor = false;
            // 
            // dtpDateOfBirth_letan
            // 
            dtpDateOfBirth_letan.CalendarMonthBackground = Color.White;
            dtpDateOfBirth_letan.Cursor = Cursors.Hand;
            dtpDateOfBirth_letan.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpDateOfBirth_letan.Format = DateTimePickerFormat.Short;
            dtpDateOfBirth_letan.Location = new Point(686, 117);
            dtpDateOfBirth_letan.Margin = new Padding(2);
            dtpDateOfBirth_letan.Name = "dtpDateOfBirth_letan";
            dtpDateOfBirth_letan.Size = new Size(162, 34);
            dtpDateOfBirth_letan.TabIndex = 24;
            // 
            // txtName_letan
            // 
            txtName_letan.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtName_letan.Location = new Point(156, 116);
            txtName_letan.Margin = new Padding(2);
            txtName_letan.Name = "txtName_letan";
            txtName_letan.Size = new Size(230, 34);
            txtName_letan.TabIndex = 23;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.Location = new Point(156, 71);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(94, 32);
            label1.TabIndex = 22;
            label1.Text = "Họ Tên";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(156, 217);
            textBox1.Margin = new Padding(2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(235, 34);
            textBox1.TabIndex = 39;
            // 
            // ID
            // 
            ID.DataPropertyName = "ID";
            ID.HeaderText = "ID";
            ID.MinimumWidth = 70;
            ID.Name = "ID";
            ID.Width = 70;
            // 
            // name_letan
            // 
            name_letan.DataPropertyName = "name";
            name_letan.HeaderText = "Họ Tên";
            name_letan.MinimumWidth = 200;
            name_letan.Name = "name_letan";
            name_letan.Width = 250;
            // 
            // Gen
            // 
            Gen.DataPropertyName = "Gender";
            Gen.HeaderText = "Giới Tính";
            Gen.MinimumWidth = 100;
            Gen.Name = "Gen";
            Gen.Width = 140;
            // 
            // DOB
            // 
            DOB.DataPropertyName = "Dob";
            dataGridViewCellStyle2.NullValue = null;
            DOB.DefaultCellStyle = dataGridViewCellStyle2;
            DOB.HeaderText = "Ngày Sinh";
            DOB.MinimumWidth = 130;
            DOB.Name = "DOB";
            DOB.Width = 180;
            // 
            // Phone
            // 
            Phone.DataPropertyName = "PhoneNumber";
            Phone.HeaderText = "Số Điện Thoại";
            Phone.MinimumWidth = 100;
            Phone.Name = "Phone";
            Phone.Width = 200;
            // 
            // Password
            // 
            Password.HeaderText = "Mật khẩu";
            Password.MinimumWidth = 6;
            Password.Name = "Password";
            Password.Width = 250;
            // 
            // Address
            // 
            Address.DataPropertyName = "Address";
            Address.HeaderText = "Địa Chỉ";
            Address.MinimumWidth = 350;
            Address.Name = "Address";
            Address.Width = 395;
            // 
            // frm_receptionists
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1690, 670);
            Controls.Add(textBox1);
            Controls.Add(dgvLetan);
            Controls.Add(label8);
            Controls.Add(btnDel_letan);
            Controls.Add(btnEdit_letan);
            Controls.Add(label6);
            Controls.Add(txtAddress_letan);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(txtPhone_letan);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(cbGen_letan);
            Controls.Add(label2);
            Controls.Add(btnSave_letan);
            Controls.Add(dtpDateOfBirth_letan);
            Controls.Add(txtName_letan);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "frm_receptionists";
            Text = "Receptionists";
            ((System.ComponentModel.ISupportInitialize)dgvLetan).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvLetan;
        private Label label8;
        private Button btnDel_letan;
        private Button btnEdit_letan;
        private Label label6;
        private TextBox txtAddress_letan;
        private Label label7;
        private Label label5;
        private TextBox txtPhone_letan;
        private Label label4;
        private Label label3;
        private ComboBox cbGen_letan;
        private Label label2;
        private Button btnSave_letan;
        private DateTimePicker dtpDateOfBirth_letan;
        private TextBox txtName_letan;
        private Label label1;
        private TextBox textBox1;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn name_letan;
        private DataGridViewTextBoxColumn Gen;
        private DataGridViewTextBoxColumn DOB;
        private DataGridViewTextBoxColumn Phone;
        private DataGridViewTextBoxColumn Password;
        private DataGridViewTextBoxColumn Address;
    }
}