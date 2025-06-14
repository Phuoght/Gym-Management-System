﻿namespace Gym_Management_System
{
    partial class frm_membership
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
            lbl_membership_Cost = new Label();
            dgvMembership = new DataGridView();
            lbl_membership_Danhsach = new Label();
            btn_membership_Del = new Button();
            btn_membership_Edit = new Button();
            lbl_membership = new Label();
            lbl_membership_Goal = new Label();
            lbl_membership_Duration = new Label();
            btn_membership_Save = new Button();
            txt_membership_Name = new TextBox();
            lbl_membership_hoten = new Label();
            txt_membership_Cost = new TextBox();
            txt_membership_Goal = new TextBox();
            txt_membership_Duration = new TextBox();
            ID = new DataGridViewTextBoxColumn();
            NameMembership = new DataGridViewTextBoxColumn();
            Duration = new DataGridViewTextBoxColumn();
            Goal = new DataGridViewTextBoxColumn();
            Cost = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvMembership).BeginInit();
            SuspendLayout();
            // 
            // lbl_membership_Cost
            // 
            lbl_membership_Cost.AutoSize = true;
            lbl_membership_Cost.Font = new Font("Segoe UI",14F,FontStyle.Bold);
            lbl_membership_Cost.ForeColor = SystemColors.ControlDarkDark;
            lbl_membership_Cost.Location = new Point(1048,71);
            lbl_membership_Cost.Margin = new Padding(2,0,2,0);
            lbl_membership_Cost.Name = "lbl_membership_Cost";
            lbl_membership_Cost.Size = new Size(51,32);
            lbl_membership_Cost.TabIndex = 66;
            lbl_membership_Cost.Text = "Giá";
            // 
            // dgvMembership
            // 
            dgvMembership.BackgroundColor = Color.IndianRed;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Red;
            dataGridViewCellStyle1.Font = new Font("Segoe UI",11F,FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.Yellow;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvMembership.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvMembership.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMembership.Columns.AddRange(new DataGridViewColumn[] { ID,NameMembership,Duration,Goal,Cost });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.LightGray;
            dataGridViewCellStyle2.Font = new Font("Segoe UI",9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvMembership.DefaultCellStyle = dataGridViewCellStyle2;
            dgvMembership.Location = new Point(217,326);
            dgvMembership.Margin = new Padding(2);
            dgvMembership.Name = "dgvMembership";
            dgvMembership.RowHeadersWidth = 62;
            dgvMembership.Size = new Size(932,269);
            dgvMembership.TabIndex = 64;
            // 
            // lbl_membership_Danhsach
            // 
            lbl_membership_Danhsach.AutoSize = true;
            lbl_membership_Danhsach.Font = new Font("Segoe UI",16F,FontStyle.Bold,GraphicsUnit.Point,0);
            lbl_membership_Danhsach.ForeColor = Color.Red;
            lbl_membership_Danhsach.Location = new Point(562,277);
            lbl_membership_Danhsach.Margin = new Padding(2,0,2,0);
            lbl_membership_Danhsach.Name = "lbl_membership_Danhsach";
            lbl_membership_Danhsach.Size = new Size(246,37);
            lbl_membership_Danhsach.TabIndex = 63;
            lbl_membership_Danhsach.Text = "Danh sách gói tập";
            // 
            // btn_membership_Del
            // 
            btn_membership_Del.BackColor = Color.Red;
            btn_membership_Del.FlatStyle = FlatStyle.Popup;
            btn_membership_Del.Font = new Font("Segoe UI",12F,FontStyle.Bold,GraphicsUnit.Point,0);
            btn_membership_Del.ForeColor = SystemColors.ButtonFace;
            btn_membership_Del.Location = new Point(720,617);
            btn_membership_Del.Margin = new Padding(2);
            btn_membership_Del.Name = "btn_membership_Del";
            btn_membership_Del.Size = new Size(118,42);
            btn_membership_Del.TabIndex = 62;
            btn_membership_Del.Text = "Xóa";
            btn_membership_Del.UseVisualStyleBackColor = false;
            btn_membership_Del.Click += btn_membership_Del_Click;
            // 
            // btn_membership_Edit
            // 
            btn_membership_Edit.BackColor = Color.Red;
            btn_membership_Edit.FlatStyle = FlatStyle.Popup;
            btn_membership_Edit.Font = new Font("Segoe UI",12F,FontStyle.Bold,GraphicsUnit.Point,0);
            btn_membership_Edit.ForeColor = SystemColors.ButtonFace;
            btn_membership_Edit.Location = new Point(490,617);
            btn_membership_Edit.Margin = new Padding(2);
            btn_membership_Edit.Name = "btn_membership_Edit";
            btn_membership_Edit.Size = new Size(118,42);
            btn_membership_Edit.TabIndex = 61;
            btn_membership_Edit.Text = "Chỉnh Sửa";
            btn_membership_Edit.UseVisualStyleBackColor = false;
            btn_membership_Edit.Click += btn_membership_Edit_Click;
            // 
            // lbl_membership
            // 
            lbl_membership.AutoSize = true;
            lbl_membership.Font = new Font("Segoe UI Black",20F,FontStyle.Bold);
            lbl_membership.ForeColor = Color.Red;
            lbl_membership.Location = new Point(537,7);
            lbl_membership.Margin = new Padding(2,0,2,0);
            lbl_membership.Name = "lbl_membership";
            lbl_membership.Size = new Size(282,46);
            lbl_membership.TabIndex = 60;
            lbl_membership.Text = "Quản Lí Gói Tập";
            // 
            // lbl_membership_Goal
            // 
            lbl_membership_Goal.AutoSize = true;
            lbl_membership_Goal.Font = new Font("Segoe UI",14F,FontStyle.Bold);
            lbl_membership_Goal.ForeColor = SystemColors.ControlDarkDark;
            lbl_membership_Goal.Location = new Point(758,71);
            lbl_membership_Goal.Margin = new Padding(2,0,2,0);
            lbl_membership_Goal.Name = "lbl_membership_Goal";
            lbl_membership_Goal.Size = new Size(86,32);
            lbl_membership_Goal.TabIndex = 56;
            lbl_membership_Goal.Text = "Mô Tả";
            // 
            // lbl_membership_Duration
            // 
            lbl_membership_Duration.AutoSize = true;
            lbl_membership_Duration.Font = new Font("Segoe UI",14F,FontStyle.Bold);
            lbl_membership_Duration.ForeColor = SystemColors.ControlDarkDark;
            lbl_membership_Duration.Location = new Point(478,71);
            lbl_membership_Duration.Margin = new Padding(2,0,2,0);
            lbl_membership_Duration.Name = "lbl_membership_Duration";
            lbl_membership_Duration.Size = new Size(139,32);
            lbl_membership_Duration.TabIndex = 54;
            lbl_membership_Duration.Text = "Thời lượng";
            // 
            // btn_membership_Save
            // 
            btn_membership_Save.BackColor = Color.Red;
            btn_membership_Save.FlatStyle = FlatStyle.Popup;
            btn_membership_Save.Font = new Font("Segoe UI",12F,FontStyle.Bold,GraphicsUnit.Point,0);
            btn_membership_Save.ForeColor = SystemColors.ButtonFace;
            btn_membership_Save.Location = new Point(620,216);
            btn_membership_Save.Margin = new Padding(2);
            btn_membership_Save.Name = "btn_membership_Save";
            btn_membership_Save.Size = new Size(118,42);
            btn_membership_Save.TabIndex = 53;
            btn_membership_Save.Text = "Lưu";
            btn_membership_Save.UseVisualStyleBackColor = false;
            btn_membership_Save.Click += btn_membership_Save_Click;
            // 
            // txt_membership_Name
            // 
            txt_membership_Name.Font = new Font("Segoe UI",12F,FontStyle.Regular,GraphicsUnit.Point,0);
            txt_membership_Name.Location = new Point(172,116);
            txt_membership_Name.Margin = new Padding(2);
            txt_membership_Name.Name = "txt_membership_Name";
            txt_membership_Name.Size = new Size(218,34);
            txt_membership_Name.TabIndex = 51;
            // 
            // lbl_membership_hoten
            // 
            lbl_membership_hoten.AutoSize = true;
            lbl_membership_hoten.Font = new Font("Segoe UI",14F,FontStyle.Bold);
            lbl_membership_hoten.ForeColor = SystemColors.ControlDarkDark;
            lbl_membership_hoten.Location = new Point(172,71);
            lbl_membership_hoten.Margin = new Padding(2,0,2,0);
            lbl_membership_hoten.Name = "lbl_membership_hoten";
            lbl_membership_hoten.Size = new Size(100,32);
            lbl_membership_hoten.TabIndex = 50;
            lbl_membership_hoten.Text = "Tên Gói";
            // 
            // txt_membership_Cost
            // 
            txt_membership_Cost.Font = new Font("Segoe UI",12F,FontStyle.Regular,GraphicsUnit.Point,0);
            txt_membership_Cost.Location = new Point(1048,116);
            txt_membership_Cost.Margin = new Padding(2);
            txt_membership_Cost.Name = "txt_membership_Cost";
            txt_membership_Cost.Size = new Size(170,34);
            txt_membership_Cost.TabIndex = 68;
            // 
            // txt_membership_Goal
            // 
            txt_membership_Goal.Font = new Font("Segoe UI",12F,FontStyle.Regular,GraphicsUnit.Point,0);
            txt_membership_Goal.Location = new Point(758,116);
            txt_membership_Goal.Margin = new Padding(2);
            txt_membership_Goal.Multiline = true;
            txt_membership_Goal.Name = "txt_membership_Goal";
            txt_membership_Goal.Size = new Size(170,32);
            txt_membership_Goal.TabIndex = 69;
            // 
            // txt_membership_Duration
            // 
            txt_membership_Duration.Font = new Font("Segoe UI",12F,FontStyle.Regular,GraphicsUnit.Point,0);
            txt_membership_Duration.Location = new Point(478,116);
            txt_membership_Duration.Margin = new Padding(2);
            txt_membership_Duration.Name = "txt_membership_Duration";
            txt_membership_Duration.Size = new Size(170,34);
            txt_membership_Duration.TabIndex = 70;
            // 
            // ID
            // 
            ID.DataPropertyName = "ID";
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.Width = 200;
            // 
            // NameMembership
            // 
            NameMembership.DataPropertyName = "Name";
            NameMembership.HeaderText = "Tên Gói";
            NameMembership.MinimumWidth = 6;
            NameMembership.Name = "NameMembership";
            NameMembership.Width = 300;
            // 
            // Duration
            // 
            Duration.DataPropertyName = "Duration";
            Duration.HeaderText = "Thời Lượng";
            Duration.MinimumWidth = 6;
            Duration.Name = "Duration";
            Duration.Width = 200;
            // 
            // Goal
            // 
            Goal.DataPropertyName = "Goal";
            Goal.HeaderText = "Mô tả";
            Goal.MinimumWidth = 6;
            Goal.Name = "Goal";
            Goal.Width = 200;
            // 
            // Cost
            // 
            Cost.DataPropertyName = "Cost";
            Cost.HeaderText = "Giá";
            Cost.MinimumWidth = 6;
            Cost.Name = "Cost";
            Cost.Width = 200;
            // 
            // frm_membership
            // 
            AutoScaleDimensions = new SizeF(8F,20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1272,680);
            Controls.Add(txt_membership_Duration);
            Controls.Add(txt_membership_Goal);
            Controls.Add(txt_membership_Cost);
            Controls.Add(lbl_membership_Cost);
            Controls.Add(dgvMembership);
            Controls.Add(lbl_membership_Danhsach);
            Controls.Add(btn_membership_Del);
            Controls.Add(btn_membership_Edit);
            Controls.Add(lbl_membership);
            Controls.Add(lbl_membership_Goal);
            Controls.Add(lbl_membership_Duration);
            Controls.Add(btn_membership_Save);
            Controls.Add(txt_membership_Name);
            Controls.Add(lbl_membership_hoten);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frm_membership";
            Text = "frm_membership";
            Load += frm_membership_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMembership).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lbl_membership_Cost;
        private DataGridView dgvMembership;
        private Label lbl_membership_Danhsach;
        private Button btn_membership_Del;
        private Button btn_membership_Edit;
        private Label lbl_membership;
        private Label lbl_membership_Goal;
        private Label lbl_membership_Duration;
        private Button btn_membership_Save;
        private TextBox txt_membership_Name;
        private Label lbl_membership_hoten;
        private TextBox txt_membership_Cost;
        private TextBox txt_membership_Goal;
        private TextBox txt_membership_Duration;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn NameMembership;
        private DataGridViewTextBoxColumn Duration;
        private DataGridViewTextBoxColumn Goal;
        private DataGridViewTextBoxColumn Cost;
    }
}