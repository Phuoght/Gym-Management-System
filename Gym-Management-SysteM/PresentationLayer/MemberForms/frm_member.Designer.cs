namespace Gym_Management_System
{
    partial class frm_member
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
            if(disposing && (components != null))
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dgvMember = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            NameMember = new DataGridViewTextBoxColumn();
            Gender = new DataGridViewTextBoxColumn();
            DOB = new DataGridViewTextBoxColumn();
            JD = new DataGridViewTextBoxColumn();
            Membership = new DataGridViewTextBoxColumn();
            PT = new DataGridViewTextBoxColumn();
            Phone = new DataGridViewTextBoxColumn();
            Timing = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            lbl_member_Danhsach = new Label();
            btn_member_Del = new Button();
            btn_member_Edit = new Button();
            label6 = new Label();
            label7 = new Label();
            txt_member_Phone = new TextBox();
            lbl_member_sdt = new Label();
            lbl_member_ngaysinh = new Label();
            cb_member_Gen = new ComboBox();
            lbl_member_gioitinh = new Label();
            btn_member_Save = new Button();
            dtp_member_DateOfBirth = new DateTimePicker();
            txt_member_Name = new TextBox();
            lbl_member_hoten = new Label();
            dtp_menber_JoinDay = new DateTimePicker();
            lbl_member_ngaythamgia = new Label();
            cb_member_Membership = new ComboBox();
            lbl_member_membership = new Label();
            cb_member_PT = new ComboBox();
            lbl_member_PT = new Label();
            lbl_member_Status = new Label();
            cb_member_Timing = new ComboBox();
            cb_member_Status = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvMember).BeginInit();
            SuspendLayout();
            // 
            // dgvMember
            // 
            dgvMember.BackgroundColor = Color.IndianRed;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Red;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.Yellow;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvMember.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvMember.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMember.Columns.AddRange(new DataGridViewColumn[] { ID, NameMember, Gender, DOB, JD, Membership, PT, Phone, Timing, Status });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.LightGray;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvMember.DefaultCellStyle = dataGridViewCellStyle2;
            dgvMember.Location = new Point(17, 359);
            dgvMember.Margin = new Padding(2);
            dgvMember.Name = "dgvMember";
            dgvMember.RowHeadersWidth = 62;
            dgvMember.Size = new Size(1238, 257);
            dgvMember.TabIndex = 38;
            // 
            // ID
            // 
            ID.DataPropertyName = "ID";
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.Width = 80;
            // 
            // NameMember
            // 
            NameMember.DataPropertyName = "Name";
            NameMember.HeaderText = "Họ tên";
            NameMember.MinimumWidth = 6;
            NameMember.Name = "NameMember";
            NameMember.Width = 125;
            // 
            // Gender
            // 
            Gender.DataPropertyName = "Gender";
            Gender.HeaderText = "Giới tính";
            Gender.MinimumWidth = 6;
            Gender.Name = "Gender";
            Gender.Width = 80;
            // 
            // DOB
            // 
            DOB.DataPropertyName = "Dob";
            DOB.HeaderText = "Ngày sinh";
            DOB.MinimumWidth = 6;
            DOB.Name = "DOB";
            DOB.Width = 125;
            // 
            // JD
            // 
            JD.DataPropertyName = "JoinDate";
            JD.HeaderText = "Ngày đăng ký";
            JD.MinimumWidth = 6;
            JD.Name = "JD";
            JD.Width = 125;
            // 
            // Membership
            // 
            Membership.DataPropertyName = "Membership";
            Membership.HeaderText = "Tên gói";
            Membership.MinimumWidth = 6;
            Membership.Name = "Membership";
            Membership.Width = 125;
            // 
            // PT
            // 
            PT.DataPropertyName = "PT";
            PT.HeaderText = "PT";
            PT.MinimumWidth = 6;
            PT.Name = "PT";
            PT.Width = 125;
            // 
            // Phone
            // 
            Phone.DataPropertyName = "PhoneNumber";
            Phone.HeaderText = "Số điện thoại";
            Phone.MinimumWidth = 6;
            Phone.Name = "Phone";
            Phone.Width = 125;
            // 
            // Timing
            // 
            Timing.DataPropertyName = "Timing";
            Timing.HeaderText = "Thời gian";
            Timing.MinimumWidth = 6;
            Timing.Name = "Timing";
            Timing.Width = 125;
            // 
            // Status
            // 
            Status.DataPropertyName = "Status";
            Status.HeaderText = "Trạng thái";
            Status.MinimumWidth = 6;
            Status.Name = "Status";
            Status.Width = 125;
            // 
            // lbl_member_Danhsach
            // 
            lbl_member_Danhsach.AutoSize = true;
            lbl_member_Danhsach.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_member_Danhsach.ForeColor = Color.Red;
            lbl_member_Danhsach.Location = new Point(514, 320);
            lbl_member_Danhsach.Margin = new Padding(2, 0, 2, 0);
            lbl_member_Danhsach.Name = "lbl_member_Danhsach";
            lbl_member_Danhsach.Size = new Size(339, 45);
            lbl_member_Danhsach.TabIndex = 37;
            lbl_member_Danhsach.Text = "Danh sách thành viên";
            // 
            // btn_member_Del
            // 
            btn_member_Del.BackColor = Color.Red;
            btn_member_Del.FlatStyle = FlatStyle.Popup;
            btn_member_Del.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_member_Del.ForeColor = SystemColors.ButtonFace;
            btn_member_Del.Location = new Point(714, 630);
            btn_member_Del.Margin = new Padding(2);
            btn_member_Del.Name = "btn_member_Del";
            btn_member_Del.Size = new Size(118, 42);
            btn_member_Del.TabIndex = 36;
            btn_member_Del.Text = "Xóa";
            btn_member_Del.UseVisualStyleBackColor = false;
            btn_member_Del.Click += btn_member_Del_Click;
            // 
            // btn_member_Edit
            // 
            btn_member_Edit.BackColor = Color.Red;
            btn_member_Edit.FlatStyle = FlatStyle.Popup;
            btn_member_Edit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_member_Edit.ForeColor = SystemColors.ButtonFace;
            btn_member_Edit.Location = new Point(478, 630);
            btn_member_Edit.Margin = new Padding(2);
            btn_member_Edit.Name = "btn_member_Edit";
            btn_member_Edit.Size = new Size(118, 42);
            btn_member_Edit.TabIndex = 35;
            btn_member_Edit.Text = "Chỉnh Sửa";
            btn_member_Edit.UseVisualStyleBackColor = false;
            btn_member_Edit.Click += btn_member_Edit_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(546, 9);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(288, 45);
            label6.TabIndex = 34;
            label6.Text = "Quản lí thành viên";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label7.Location = new Point(409, 172);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(182, 38);
            label7.TabIndex = 32;
            label7.Text = "Đo thời gian";
            // 
            // txt_member_Phone
            // 
            txt_member_Phone.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_member_Phone.Location = new Point(172, 217);
            txt_member_Phone.Margin = new Padding(2);
            txt_member_Phone.Name = "txt_member_Phone";
            txt_member_Phone.Size = new Size(172, 39);
            txt_member_Phone.TabIndex = 30;
            // 
            // lbl_member_sdt
            // 
            lbl_member_sdt.AutoSize = true;
            lbl_member_sdt.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lbl_member_sdt.Location = new Point(172, 172);
            lbl_member_sdt.Margin = new Padding(2, 0, 2, 0);
            lbl_member_sdt.Name = "lbl_member_sdt";
            lbl_member_sdt.Size = new Size(200, 38);
            lbl_member_sdt.TabIndex = 29;
            lbl_member_sdt.Text = "Số Điện Thoại";
            // 
            // lbl_member_ngaysinh
            // 
            lbl_member_ngaysinh.AutoSize = true;
            lbl_member_ngaysinh.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lbl_member_ngaysinh.Location = new Point(622, 71);
            lbl_member_ngaysinh.Margin = new Padding(2, 0, 2, 0);
            lbl_member_ngaysinh.Name = "lbl_member_ngaysinh";
            lbl_member_ngaysinh.Size = new Size(148, 38);
            lbl_member_ngaysinh.TabIndex = 28;
            lbl_member_ngaysinh.Text = "Ngày sinh";
            // 
            // cb_member_Gen
            // 
            cb_member_Gen.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_member_Gen.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cb_member_Gen.FormattingEnabled = true;
            cb_member_Gen.Items.AddRange(new object[] { "Nam", "Nữ" });
            cb_member_Gen.Location = new Point(409, 116);
            cb_member_Gen.Margin = new Padding(2);
            cb_member_Gen.Name = "cb_member_Gen";
            cb_member_Gen.Size = new Size(146, 40);
            cb_member_Gen.TabIndex = 27;
            // 
            // lbl_member_gioitinh
            // 
            lbl_member_gioitinh.AutoSize = true;
            lbl_member_gioitinh.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lbl_member_gioitinh.Location = new Point(409, 71);
            lbl_member_gioitinh.Margin = new Padding(2, 0, 2, 0);
            lbl_member_gioitinh.Name = "lbl_member_gioitinh";
            lbl_member_gioitinh.Size = new Size(137, 38);
            lbl_member_gioitinh.TabIndex = 26;
            lbl_member_gioitinh.Text = "Giới Tính";
            // 
            // btn_member_Save
            // 
            btn_member_Save.BackColor = Color.Red;
            btn_member_Save.FlatStyle = FlatStyle.Popup;
            btn_member_Save.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_member_Save.ForeColor = SystemColors.ButtonFace;
            btn_member_Save.Location = new Point(601, 267);
            btn_member_Save.Margin = new Padding(2);
            btn_member_Save.Name = "btn_member_Save";
            btn_member_Save.Size = new Size(118, 42);
            btn_member_Save.TabIndex = 25;
            btn_member_Save.Text = "Đăng Kí";
            btn_member_Save.UseVisualStyleBackColor = false;
            btn_member_Save.Click += btn_member_Save_Click;
            // 
            // dtp_member_DateOfBirth
            // 
            dtp_member_DateOfBirth.CalendarMonthBackground = Color.White;
            dtp_member_DateOfBirth.Cursor = Cursors.Hand;
            dtp_member_DateOfBirth.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtp_member_DateOfBirth.Format = DateTimePickerFormat.Short;
            dtp_member_DateOfBirth.Location = new Point(622, 118);
            dtp_member_DateOfBirth.Margin = new Padding(2);
            dtp_member_DateOfBirth.Name = "dtp_member_DateOfBirth";
            dtp_member_DateOfBirth.Size = new Size(162, 39);
            dtp_member_DateOfBirth.TabIndex = 24;
            // 
            // txt_member_Name
            // 
            txt_member_Name.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_member_Name.Location = new Point(172, 116);
            txt_member_Name.Margin = new Padding(2);
            txt_member_Name.Name = "txt_member_Name";
            txt_member_Name.Size = new Size(170, 39);
            txt_member_Name.TabIndex = 23;
            // 
            // lbl_member_hoten
            // 
            lbl_member_hoten.AutoSize = true;
            lbl_member_hoten.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lbl_member_hoten.Location = new Point(172, 71);
            lbl_member_hoten.Margin = new Padding(2, 0, 2, 0);
            lbl_member_hoten.Name = "lbl_member_hoten";
            lbl_member_hoten.Size = new Size(108, 38);
            lbl_member_hoten.TabIndex = 22;
            lbl_member_hoten.Text = "Họ Tên";
            // 
            // dtp_menber_JoinDay
            // 
            dtp_menber_JoinDay.CalendarMonthBackground = Color.White;
            dtp_menber_JoinDay.Cursor = Cursors.Hand;
            dtp_menber_JoinDay.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtp_menber_JoinDay.Format = DateTimePickerFormat.Short;
            dtp_menber_JoinDay.Location = new Point(832, 118);
            dtp_menber_JoinDay.Margin = new Padding(2);
            dtp_menber_JoinDay.Name = "dtp_menber_JoinDay";
            dtp_menber_JoinDay.Size = new Size(162, 39);
            dtp_menber_JoinDay.TabIndex = 40;
            // 
            // lbl_member_ngaythamgia
            // 
            lbl_member_ngaythamgia.AutoSize = true;
            lbl_member_ngaythamgia.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lbl_member_ngaythamgia.Location = new Point(832, 71);
            lbl_member_ngaythamgia.Margin = new Padding(2, 0, 2, 0);
            lbl_member_ngaythamgia.Name = "lbl_member_ngaythamgia";
            lbl_member_ngaythamgia.Size = new Size(211, 38);
            lbl_member_ngaythamgia.TabIndex = 41;
            lbl_member_ngaythamgia.Text = "Ngày tham gia";
            // 
            // cb_member_Membership
            // 
            cb_member_Membership.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_member_Membership.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cb_member_Membership.FormattingEnabled = true;
            cb_member_Membership.Items.AddRange(new object[] { "Nam", "Nữ" });
            cb_member_Membership.Location = new Point(1056, 116);
            cb_member_Membership.Margin = new Padding(2);
            cb_member_Membership.Name = "cb_member_Membership";
            cb_member_Membership.Size = new Size(146, 40);
            cb_member_Membership.TabIndex = 43;
            // 
            // lbl_member_membership
            // 
            lbl_member_membership.AutoSize = true;
            lbl_member_membership.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lbl_member_membership.Location = new Point(1056, 71);
            lbl_member_membership.Margin = new Padding(2, 0, 2, 0);
            lbl_member_membership.Name = "lbl_member_membership";
            lbl_member_membership.Size = new Size(113, 38);
            lbl_member_membership.TabIndex = 42;
            lbl_member_membership.Text = "Gói tập";
            // 
            // cb_member_PT
            // 
            cb_member_PT.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_member_PT.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cb_member_PT.FormattingEnabled = true;
            cb_member_PT.Location = new Point(1056, 217);
            cb_member_PT.Margin = new Padding(2);
            cb_member_PT.Name = "cb_member_PT";
            cb_member_PT.Size = new Size(146, 40);
            cb_member_PT.TabIndex = 45;
            // 
            // lbl_member_PT
            // 
            lbl_member_PT.AutoSize = true;
            lbl_member_PT.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lbl_member_PT.Location = new Point(1056, 172);
            lbl_member_PT.Margin = new Padding(2, 0, 2, 0);
            lbl_member_PT.Name = "lbl_member_PT";
            lbl_member_PT.Size = new Size(50, 38);
            lbl_member_PT.TabIndex = 44;
            lbl_member_PT.Text = "PT";
            // 
            // lbl_member_Status
            // 
            lbl_member_Status.AutoSize = true;
            lbl_member_Status.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lbl_member_Status.Location = new Point(727, 174);
            lbl_member_Status.Margin = new Padding(2, 0, 2, 0);
            lbl_member_Status.Name = "lbl_member_Status";
            lbl_member_Status.Size = new Size(150, 38);
            lbl_member_Status.TabIndex = 46;
            lbl_member_Status.Text = "Trạng thái";
            // 
            // cb_member_Timing
            // 
            cb_member_Timing.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cb_member_Timing.FormattingEnabled = true;
            cb_member_Timing.Items.AddRange(new object[] { "6AM - 8AM", "8AM - 10AM", "10AM - 1PM", "1PM - 3PM", "3PM - 5PM", "5PM - 7PM" });
            cb_member_Timing.Location = new Point(409, 215);
            cb_member_Timing.Margin = new Padding(2);
            cb_member_Timing.Name = "cb_member_Timing";
            cb_member_Timing.Size = new Size(227, 40);
            cb_member_Timing.TabIndex = 48;
            // 
            // cb_member_Status
            // 
            cb_member_Status.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_member_Status.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cb_member_Status.FormattingEnabled = true;
            cb_member_Status.Items.AddRange(new object[] { "Hoạt Động", "Đã hủy" });
            cb_member_Status.Location = new Point(727, 217);
            cb_member_Status.Margin = new Padding(2);
            cb_member_Status.Name = "cb_member_Status";
            cb_member_Status.Size = new Size(227, 40);
            cb_member_Status.TabIndex = 49;
            // 
            // frm_member
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1272, 680);
            Controls.Add(cb_member_Status);
            Controls.Add(cb_member_Timing);
            Controls.Add(lbl_member_Status);
            Controls.Add(cb_member_PT);
            Controls.Add(lbl_member_PT);
            Controls.Add(cb_member_Membership);
            Controls.Add(lbl_member_membership);
            Controls.Add(lbl_member_ngaythamgia);
            Controls.Add(dtp_menber_JoinDay);
            Controls.Add(dgvMember);
            Controls.Add(lbl_member_Danhsach);
            Controls.Add(btn_member_Del);
            Controls.Add(btn_member_Edit);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(txt_member_Phone);
            Controls.Add(lbl_member_sdt);
            Controls.Add(lbl_member_ngaysinh);
            Controls.Add(cb_member_Gen);
            Controls.Add(lbl_member_gioitinh);
            Controls.Add(btn_member_Save);
            Controls.Add(dtp_member_DateOfBirth);
            Controls.Add(txt_member_Name);
            Controls.Add(lbl_member_hoten);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frm_member";
            Text = "frm_member";
            Load += frm_member_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMember).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgvMember;
        private Label lbl_member_Danhsach;
        private Button btn_member_Del;
        private Button btn_member_Edit;
        private Label label6;
        private Label label7;
        private TextBox txt_member_Phone;
        private Label lbl_member_sdt;
        private Label lbl_member_ngaysinh;
        private ComboBox cb_member_Gen;
        private Label lbl_member_gioitinh;
        private Button btn_member_Save;
        private DateTimePicker dtp_member_DateOfBirth;
        private TextBox txt_member_Name;
        private Label lbl_member_hoten;
        private DateTimePicker dtp_menber_JoinDay;
        private Label lbl_member_ngaythamgia;
        private ComboBox cb_member_Membership;
        private Label lbl_member_membership;
        private ComboBox cb_member_PT;
        private Label lbl_member_PT;
        private Label lbl_member_Status;
        private ComboBox cb_member_Timing;
        private ComboBox cb_member_Status;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn NameMember;
        private DataGridViewTextBoxColumn Gender;
        private DataGridViewTextBoxColumn DOB;
        private DataGridViewTextBoxColumn JD;
        private DataGridViewTextBoxColumn Membership;
        private DataGridViewTextBoxColumn PT;
        private DataGridViewTextBoxColumn Phone;
        private DataGridViewTextBoxColumn Timing;
        private DataGridViewTextBoxColumn Status;
    }
}