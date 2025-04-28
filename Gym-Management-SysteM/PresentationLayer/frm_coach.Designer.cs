namespace Gym_Management_System
{
    partial class frm_coach
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
            txtName = new TextBox();
            dtpDateOfBirth = new DateTimePicker();
            btnSave = new Button();
            label2 = new Label();
            cbGen = new ComboBox();
            label3 = new Label();
            txtPhone = new TextBox();
            label4 = new Label();
            label5 = new Label();
            txtAddress = new TextBox();
            label7 = new Label();
            label6 = new Label();
            btnEdit = new Button();
            btnDel = new Button();
            label8 = new Label();
            dgvPT = new DataGridView();
            cbExperience = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvPT).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.Location = new Point(224, 86);
            label1.Name = "label1";
            label1.Size = new Size(108, 38);
            label1.TabIndex = 0;
            label1.Text = "Họ Tên";
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtName.Location = new Point(224, 143);
            txtName.Name = "txtName";
            txtName.Size = new Size(287, 39);
            txtName.TabIndex = 1;
            // 
            // dtpDateOfBirth
            // 
            dtpDateOfBirth.CalendarMonthBackground = Color.White;
            dtpDateOfBirth.Cursor = Cursors.Hand;
            dtpDateOfBirth.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpDateOfBirth.Format = DateTimePickerFormat.Short;
            dtpDateOfBirth.Location = new Point(886, 144);
            dtpDateOfBirth.Name = "dtpDateOfBirth";
            dtpDateOfBirth.Size = new Size(202, 39);
            dtpDateOfBirth.TabIndex = 2;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Red;
            btnSave.FlatStyle = FlatStyle.Popup;
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = SystemColors.ButtonFace;
            btnSave.Location = new Point(760, 331);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(148, 53);
            btnSave.TabIndex = 3;
            btnSave.Text = "Lưu";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label2.Location = new Point(606, 86);
            label2.Name = "label2";
            label2.Size = new Size(137, 38);
            label2.TabIndex = 4;
            label2.Text = "Giới Tính";
            // 
            // cbGen
            // 
            cbGen.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbGen.FormattingEnabled = true;
            cbGen.Items.AddRange(new object[] { "Nam", "Nữ" });
            cbGen.Location = new Point(606, 143);
            cbGen.Name = "cbGen";
            cbGen.Size = new Size(181, 40);
            cbGen.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label3.Location = new Point(886, 86);
            label3.Name = "label3";
            label3.Size = new Size(148, 38);
            label3.TabIndex = 7;
            label3.Text = "Ngày sinh";
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPhone.Location = new Point(1190, 143);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(293, 39);
            txtPhone.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label4.Location = new Point(1190, 86);
            label4.Name = "label4";
            label4.Size = new Size(200, 38);
            label4.TabIndex = 8;
            label4.Text = "Số Điện Thoại";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label5.Location = new Point(224, 212);
            label5.Name = "label5";
            label5.Size = new Size(185, 38);
            label5.TabIndex = 10;
            label5.Text = "Kinh nghiệm";
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAddress.Location = new Point(606, 269);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(501, 39);
            txtAddress.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label7.Location = new Point(606, 212);
            label7.Name = "label7";
            label7.Size = new Size(107, 38);
            label7.TabIndex = 14;
            label7.Text = "Địa chỉ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(726, 9);
            label6.Name = "label6";
            label6.Size = new Size(170, 45);
            label6.TabIndex = 16;
            label6.Text = "Quản lí PT";
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.Red;
            btnEdit.FlatStyle = FlatStyle.Popup;
            btnEdit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEdit.ForeColor = SystemColors.ButtonFace;
            btnEdit.Location = new Point(606, 785);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(148, 53);
            btnEdit.TabIndex = 17;
            btnEdit.Text = "Chỉnh Sửa";
            btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnDel
            // 
            btnDel.BackColor = Color.Red;
            btnDel.FlatStyle = FlatStyle.Popup;
            btnDel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDel.ForeColor = SystemColors.ButtonFace;
            btnDel.Location = new Point(901, 785);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(148, 53);
            btnDel.TabIndex = 18;
            btnDel.Text = "Xóa";
            btnDel.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Red;
            label8.Location = new Point(726, 398);
            label8.Name = "label8";
            label8.Size = new Size(221, 45);
            label8.TabIndex = 19;
            label8.Text = "Danh sách PT";
            // 
            // dgvPT
            // 
            dgvPT.BackgroundColor = SystemColors.Control;
            dgvPT.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPT.Location = new Point(30, 446);
            dgvPT.Name = "dgvPT";
            dgvPT.RowHeadersWidth = 62;
            dgvPT.Size = new Size(1548, 321);
            dgvPT.TabIndex = 20;
            // 
            // cbExperience
            // 
            cbExperience.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbExperience.FormattingEnabled = true;
            cbExperience.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20" });
            cbExperience.Location = new Point(228, 269);
            cbExperience.Name = "cbExperience";
            cbExperience.Size = new Size(181, 40);
            cbExperience.TabIndex = 21;
            // 
            // frm_coach
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1590, 850);
            Controls.Add(cbExperience);
            Controls.Add(dgvPT);
            Controls.Add(label8);
            Controls.Add(btnDel);
            Controls.Add(btnEdit);
            Controls.Add(label6);
            Controls.Add(txtAddress);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(txtPhone);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(cbGen);
            Controls.Add(label2);
            Controls.Add(btnSave);
            Controls.Add(dtpDateOfBirth);
            Controls.Add(txtName);
            Controls.Add(label1);
            ForeColor = SystemColors.ControlDarkDark;
            FormBorderStyle = FormBorderStyle.None;
            Name = "frm_coach";
            Text = "frm_coach";
            ((System.ComponentModel.ISupportInitialize)dgvPT).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtName;
        private DateTimePicker dtpDateOfBirth;
        private Button btnSave;
        private Label label2;
        private ComboBox cbGen;
        private Label label3;
        private TextBox txtPhone;
        private Label label4;
        private Label label5;
        private TextBox txtAddress;
        private Label label7;
        private Label label6;
        private Button btnEdit;
        private Button btnDel;
        private Label label8;
        private DataGridView dgvPT;
        private ComboBox cbExperience;
    }
}