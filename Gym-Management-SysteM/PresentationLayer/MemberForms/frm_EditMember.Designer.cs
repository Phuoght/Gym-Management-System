namespace Gym_Management_System.MemberForms
{
    partial class frm_EditMember
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
            cb_member_StatusE = new ComboBox();
            lbl_member_Status = new Label();
            cb_member_PTE = new ComboBox();
            lbl_member_PT = new Label();
            cb_member_MembershipE = new ComboBox();
            lbl_member_membership = new Label();
            lbl_member_ngaythamgia = new Label();
            dtp_menber_JoinDayE = new DateTimePicker();
            txt_member_PhoneE = new TextBox();
            lbl_member_sdt = new Label();
            lbl_member_ngaysinh = new Label();
            cb_member_GenE = new ComboBox();
            lbl_member_gioitinh = new Label();
            dtp_member_DateOfBirthE = new DateTimePicker();
            txt_member_NameE = new TextBox();
            lbl_member_hoten = new Label();
            label1 = new Label();
            btn_member_SaveE = new Button();
            SuspendLayout();
            // 
            // cb_member_StatusE
            // 
            cb_member_StatusE.Font = new Font("Segoe UI",12F,FontStyle.Regular,GraphicsUnit.Point,0);
            cb_member_StatusE.FormattingEnabled = true;
            cb_member_StatusE.Items.AddRange(new object[] { "Hoạt Động","Đã hủy" });
            cb_member_StatusE.Location = new Point(290,299);
            cb_member_StatusE.Margin = new Padding(2);
            cb_member_StatusE.Name = "cb_member_StatusE";
            cb_member_StatusE.Size = new Size(227,36);
            cb_member_StatusE.TabIndex = 67;
            // 
            // lbl_member_Status
            // 
            lbl_member_Status.AutoSize = true;
            lbl_member_Status.Font = new Font("Segoe UI",14F,FontStyle.Bold);
            lbl_member_Status.Location = new Point(290,256);
            lbl_member_Status.Margin = new Padding(2,0,2,0);
            lbl_member_Status.Name = "lbl_member_Status";
            lbl_member_Status.Size = new Size(129,32);
            lbl_member_Status.TabIndex = 65;
            lbl_member_Status.Text = "Trạng thái";
            // 
            // cb_member_PTE
            // 
            cb_member_PTE.Font = new Font("Segoe UI",12F,FontStyle.Regular,GraphicsUnit.Point,0);
            cb_member_PTE.FormattingEnabled = true;
            cb_member_PTE.Location = new Point(619,299);
            cb_member_PTE.Margin = new Padding(2);
            cb_member_PTE.Name = "cb_member_PTE";
            cb_member_PTE.Size = new Size(146,36);
            cb_member_PTE.TabIndex = 64;
            // 
            // lbl_member_PT
            // 
            lbl_member_PT.AutoSize = true;
            lbl_member_PT.Font = new Font("Segoe UI",14F,FontStyle.Bold);
            lbl_member_PT.Location = new Point(619,254);
            lbl_member_PT.Margin = new Padding(2,0,2,0);
            lbl_member_PT.Name = "lbl_member_PT";
            lbl_member_PT.Size = new Size(43,32);
            lbl_member_PT.TabIndex = 63;
            lbl_member_PT.Text = "PT";
            // 
            // cb_member_MembershipE
            // 
            cb_member_MembershipE.Enabled = false;
            cb_member_MembershipE.Font = new Font("Segoe UI",12F,FontStyle.Regular,GraphicsUnit.Point,0);
            cb_member_MembershipE.FormattingEnabled = true;
            cb_member_MembershipE.Location = new Point(937,200);
            cb_member_MembershipE.Margin = new Padding(2);
            cb_member_MembershipE.Name = "cb_member_MembershipE";
            cb_member_MembershipE.Size = new Size(146,36);
            cb_member_MembershipE.TabIndex = 62;
            // 
            // lbl_member_membership
            // 
            lbl_member_membership.AutoSize = true;
            lbl_member_membership.Font = new Font("Segoe UI",14F,FontStyle.Bold);
            lbl_member_membership.Location = new Point(937,155);
            lbl_member_membership.Margin = new Padding(2,0,2,0);
            lbl_member_membership.Name = "lbl_member_membership";
            lbl_member_membership.Size = new Size(97,32);
            lbl_member_membership.TabIndex = 61;
            lbl_member_membership.Text = "Gói tập";
            // 
            // lbl_member_ngaythamgia
            // 
            lbl_member_ngaythamgia.AutoSize = true;
            lbl_member_ngaythamgia.Font = new Font("Segoe UI",14F,FontStyle.Bold);
            lbl_member_ngaythamgia.Location = new Point(713,155);
            lbl_member_ngaythamgia.Margin = new Padding(2,0,2,0);
            lbl_member_ngaythamgia.Name = "lbl_member_ngaythamgia";
            lbl_member_ngaythamgia.Size = new Size(181,32);
            lbl_member_ngaythamgia.TabIndex = 60;
            lbl_member_ngaythamgia.Text = "Ngày tham gia";
            // 
            // dtp_menber_JoinDayE
            // 
            dtp_menber_JoinDayE.CalendarMonthBackground = Color.White;
            dtp_menber_JoinDayE.Cursor = Cursors.Hand;
            dtp_menber_JoinDayE.Enabled = false;
            dtp_menber_JoinDayE.Font = new Font("Segoe UI",12F,FontStyle.Regular,GraphicsUnit.Point,0);
            dtp_menber_JoinDayE.Format = DateTimePickerFormat.Short;
            dtp_menber_JoinDayE.Location = new Point(713,202);
            dtp_menber_JoinDayE.Margin = new Padding(2);
            dtp_menber_JoinDayE.Name = "dtp_menber_JoinDayE";
            dtp_menber_JoinDayE.Size = new Size(162,34);
            dtp_menber_JoinDayE.TabIndex = 59;
            // 
            // txt_member_PhoneE
            // 
            txt_member_PhoneE.Font = new Font("Segoe UI",12F,FontStyle.Regular,GraphicsUnit.Point,0);
            txt_member_PhoneE.Location = new Point(53,301);
            txt_member_PhoneE.Margin = new Padding(2);
            txt_member_PhoneE.Name = "txt_member_PhoneE";
            txt_member_PhoneE.Size = new Size(172,34);
            txt_member_PhoneE.TabIndex = 57;
            // 
            // lbl_member_sdt
            // 
            lbl_member_sdt.AutoSize = true;
            lbl_member_sdt.Font = new Font("Segoe UI",14F,FontStyle.Bold);
            lbl_member_sdt.Location = new Point(53,256);
            lbl_member_sdt.Margin = new Padding(2,0,2,0);
            lbl_member_sdt.Name = "lbl_member_sdt";
            lbl_member_sdt.Size = new Size(172,32);
            lbl_member_sdt.TabIndex = 56;
            lbl_member_sdt.Text = "Số Điện Thoại";
            // 
            // lbl_member_ngaysinh
            // 
            lbl_member_ngaysinh.AutoSize = true;
            lbl_member_ngaysinh.Font = new Font("Segoe UI",14F,FontStyle.Bold);
            lbl_member_ngaysinh.Location = new Point(503,155);
            lbl_member_ngaysinh.Margin = new Padding(2,0,2,0);
            lbl_member_ngaysinh.Name = "lbl_member_ngaysinh";
            lbl_member_ngaysinh.Size = new Size(128,32);
            lbl_member_ngaysinh.TabIndex = 55;
            lbl_member_ngaysinh.Text = "Ngày sinh";
            // 
            // cb_member_GenE
            // 
            cb_member_GenE.Font = new Font("Segoe UI",12F,FontStyle.Regular,GraphicsUnit.Point,0);
            cb_member_GenE.FormattingEnabled = true;
            cb_member_GenE.Items.AddRange(new object[] { "Nam","Nữ" });
            cb_member_GenE.Location = new Point(290,200);
            cb_member_GenE.Margin = new Padding(2);
            cb_member_GenE.Name = "cb_member_GenE";
            cb_member_GenE.Size = new Size(146,36);
            cb_member_GenE.TabIndex = 54;
            // 
            // lbl_member_gioitinh
            // 
            lbl_member_gioitinh.AutoSize = true;
            lbl_member_gioitinh.Font = new Font("Segoe UI",14F,FontStyle.Bold);
            lbl_member_gioitinh.Location = new Point(290,155);
            lbl_member_gioitinh.Margin = new Padding(2,0,2,0);
            lbl_member_gioitinh.Name = "lbl_member_gioitinh";
            lbl_member_gioitinh.Size = new Size(117,32);
            lbl_member_gioitinh.TabIndex = 53;
            lbl_member_gioitinh.Text = "Giới Tính";
            // 
            // dtp_member_DateOfBirthE
            // 
            dtp_member_DateOfBirthE.CalendarMonthBackground = Color.White;
            dtp_member_DateOfBirthE.Cursor = Cursors.Hand;
            dtp_member_DateOfBirthE.Font = new Font("Segoe UI",12F,FontStyle.Regular,GraphicsUnit.Point,0);
            dtp_member_DateOfBirthE.Format = DateTimePickerFormat.Short;
            dtp_member_DateOfBirthE.Location = new Point(503,202);
            dtp_member_DateOfBirthE.Margin = new Padding(2);
            dtp_member_DateOfBirthE.Name = "dtp_member_DateOfBirthE";
            dtp_member_DateOfBirthE.Size = new Size(162,34);
            dtp_member_DateOfBirthE.TabIndex = 52;
            // 
            // txt_member_NameE
            // 
            txt_member_NameE.Font = new Font("Segoe UI",12F,FontStyle.Regular,GraphicsUnit.Point,0);
            txt_member_NameE.Location = new Point(53,200);
            txt_member_NameE.Margin = new Padding(2);
            txt_member_NameE.Name = "txt_member_NameE";
            txt_member_NameE.Size = new Size(170,34);
            txt_member_NameE.TabIndex = 51;
            // 
            // lbl_member_hoten
            // 
            lbl_member_hoten.AutoSize = true;
            lbl_member_hoten.Font = new Font("Segoe UI",14F,FontStyle.Bold);
            lbl_member_hoten.Location = new Point(53,155);
            lbl_member_hoten.Margin = new Padding(2,0,2,0);
            lbl_member_hoten.Name = "lbl_member_hoten";
            lbl_member_hoten.Size = new Size(94,32);
            lbl_member_hoten.TabIndex = 50;
            lbl_member_hoten.Text = "Họ Tên";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI",18F,FontStyle.Bold,GraphicsUnit.Point,0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(351,21);
            label1.Margin = new Padding(2,0,2,0);
            label1.Name = "label1";
            label1.Size = new Size(476,41);
            label1.TabIndex = 68;
            label1.Text = "Chỉnh Sửa Thông Tin Thành viên";
            // 
            // btn_member_SaveE
            // 
            btn_member_SaveE.BackColor = Color.Red;
            btn_member_SaveE.Cursor = Cursors.Hand;
            btn_member_SaveE.Font = new Font("Segoe UI",12F,FontStyle.Bold,GraphicsUnit.Point,0);
            btn_member_SaveE.ForeColor = SystemColors.ButtonFace;
            btn_member_SaveE.Location = new Point(487,403);
            btn_member_SaveE.Margin = new Padding(2);
            btn_member_SaveE.Name = "btn_member_SaveE";
            btn_member_SaveE.Size = new Size(118,42);
            btn_member_SaveE.TabIndex = 69;
            btn_member_SaveE.Text = "Lưu";
            btn_member_SaveE.UseVisualStyleBackColor = false;
            btn_member_SaveE.Click += btn_member_SaveE_Click;
            // 
            // frm_EditMember
            // 
            AutoScaleDimensions = new SizeF(8F,20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1139,477);
            Controls.Add(btn_member_SaveE);
            Controls.Add(label1);
            Controls.Add(cb_member_StatusE);
            Controls.Add(lbl_member_Status);
            Controls.Add(cb_member_PTE);
            Controls.Add(lbl_member_PT);
            Controls.Add(cb_member_MembershipE);
            Controls.Add(lbl_member_membership);
            Controls.Add(lbl_member_ngaythamgia);
            Controls.Add(dtp_menber_JoinDayE);
            Controls.Add(txt_member_PhoneE);
            Controls.Add(lbl_member_sdt);
            Controls.Add(lbl_member_ngaysinh);
            Controls.Add(cb_member_GenE);
            Controls.Add(lbl_member_gioitinh);
            Controls.Add(dtp_member_DateOfBirthE);
            Controls.Add(txt_member_NameE);
            Controls.Add(lbl_member_hoten);
            Name = "frm_EditMember";
            Text = "frmEditMember";
            Load += frmEditMember_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cb_member_StatusE;
        private Label lbl_member_Status;
        private ComboBox cb_member_PTE;
        private Label lbl_member_PT;
        private ComboBox cb_member_MembershipE;
        private Label lbl_member_membership;
        private Label lbl_member_ngaythamgia;
        private DateTimePicker dtp_menber_JoinDayE;
        private TextBox txt_member_PhoneE;
        private Label lbl_member_sdt;
        private Label lbl_member_ngaysinh;
        private ComboBox cb_member_GenE;
        private Label lbl_member_gioitinh;
        private DateTimePicker dtp_member_DateOfBirthE;
        private TextBox txt_member_NameE;
        private Label lbl_member_hoten;
        private Label label1;
        private Button btn_member_SaveE;
    }
}