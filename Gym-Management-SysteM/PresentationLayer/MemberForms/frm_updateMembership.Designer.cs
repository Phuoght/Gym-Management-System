namespace Gym_Management_System.MemberForms
{
    partial class frm_updateMembership
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
            label1 = new Label();
            cb_UpdateMbs_MembershipE = new ComboBox();
            lbl_member_membership = new Label();
            lbl_member_ngaythamgia = new Label();
            dtp_updateMbs_JoinDay = new DateTimePicker();
            btn_UpdateMbs_SaveE = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI",18F,FontStyle.Bold,GraphicsUnit.Point,0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(139,23);
            label1.Margin = new Padding(2,0,2,0);
            label1.Name = "label1";
            label1.Size = new Size(430,41);
            label1.TabIndex = 69;
            label1.Text = "Chỉnh Sửa Thông Tin Gói Tập";
            // 
            // cb_UpdateMbs_MembershipE
            // 
            cb_UpdateMbs_MembershipE.Font = new Font("Segoe UI",12F,FontStyle.Regular,GraphicsUnit.Point,0);
            cb_UpdateMbs_MembershipE.FormattingEnabled = true;
            cb_UpdateMbs_MembershipE.Location = new Point(399,167);
            cb_UpdateMbs_MembershipE.Margin = new Padding(2);
            cb_UpdateMbs_MembershipE.Name = "cb_UpdateMbs_MembershipE";
            cb_UpdateMbs_MembershipE.Size = new Size(146,36);
            cb_UpdateMbs_MembershipE.TabIndex = 73;
            // 
            // lbl_member_membership
            // 
            lbl_member_membership.AutoSize = true;
            lbl_member_membership.Font = new Font("Segoe UI",14F,FontStyle.Bold);
            lbl_member_membership.Location = new Point(399,122);
            lbl_member_membership.Margin = new Padding(2,0,2,0);
            lbl_member_membership.Name = "lbl_member_membership";
            lbl_member_membership.Size = new Size(97,32);
            lbl_member_membership.TabIndex = 72;
            lbl_member_membership.Text = "Gói tập";
            // 
            // lbl_member_ngaythamgia
            // 
            lbl_member_ngaythamgia.AutoSize = true;
            lbl_member_ngaythamgia.Font = new Font("Segoe UI",14F,FontStyle.Bold);
            lbl_member_ngaythamgia.Location = new Point(175,122);
            lbl_member_ngaythamgia.Margin = new Padding(2,0,2,0);
            lbl_member_ngaythamgia.Name = "lbl_member_ngaythamgia";
            lbl_member_ngaythamgia.Size = new Size(181,32);
            lbl_member_ngaythamgia.TabIndex = 71;
            lbl_member_ngaythamgia.Text = "Ngày tham gia";
            // 
            // dtp_updateMbs_JoinDay
            // 
            dtp_updateMbs_JoinDay.CalendarMonthBackground = Color.White;
            dtp_updateMbs_JoinDay.Cursor = Cursors.Hand;
            dtp_updateMbs_JoinDay.Font = new Font("Segoe UI",12F,FontStyle.Regular,GraphicsUnit.Point,0);
            dtp_updateMbs_JoinDay.Format = DateTimePickerFormat.Short;
            dtp_updateMbs_JoinDay.Location = new Point(175,169);
            dtp_updateMbs_JoinDay.Margin = new Padding(2);
            dtp_updateMbs_JoinDay.Name = "dtp_updateMbs_JoinDay";
            dtp_updateMbs_JoinDay.Size = new Size(162,34);
            dtp_updateMbs_JoinDay.TabIndex = 70;
            // 
            // btn_UpdateMbs_SaveE
            // 
            btn_UpdateMbs_SaveE.BackColor = Color.Red;
            btn_UpdateMbs_SaveE.Cursor = Cursors.Hand;
            btn_UpdateMbs_SaveE.Font = new Font("Segoe UI",12F,FontStyle.Bold,GraphicsUnit.Point,0);
            btn_UpdateMbs_SaveE.ForeColor = SystemColors.ButtonFace;
            btn_UpdateMbs_SaveE.Location = new Point(298,262);
            btn_UpdateMbs_SaveE.Margin = new Padding(2);
            btn_UpdateMbs_SaveE.Name = "btn_UpdateMbs_SaveE";
            btn_UpdateMbs_SaveE.Size = new Size(118,42);
            btn_UpdateMbs_SaveE.TabIndex = 74;
            btn_UpdateMbs_SaveE.Text = "Lưu";
            btn_UpdateMbs_SaveE.UseVisualStyleBackColor = false;
            btn_UpdateMbs_SaveE.Click += btn_UpdateMbs_SaveE_Click;
            // 
            // frm_updateMembership
            // 
            AutoScaleDimensions = new SizeF(8F,20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(735,372);
            Controls.Add(btn_UpdateMbs_SaveE);
            Controls.Add(cb_UpdateMbs_MembershipE);
            Controls.Add(lbl_member_membership);
            Controls.Add(lbl_member_ngaythamgia);
            Controls.Add(dtp_updateMbs_JoinDay);
            Controls.Add(label1);
            Name = "frm_updateMembership";
            Text = "frm_updateMembership";
            Load += frm_updateMembership_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cb_UpdateMbs_MembershipE;
        private Label lbl_member_membership;
        private Label lbl_member_ngaythamgia;
        private DateTimePicker dtp_updateMbs_JoinDay;
        private Button btn_UpdateMbs_SaveE;
    }
}