namespace Gym_Management_System
{
    partial class frm_checkin
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            label1 = new Label();
            button1 = new Button();
            label2 = new Label();
            txtMemberName = new TextBox();
            label3 = new Label();
            dgvCheckin = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            memberName = new DataGridViewTextBoxColumn();
            Gen = new DataGridViewTextBoxColumn();
            membership = new DataGridViewTextBoxColumn();
            pt = new DataGridViewTextBoxColumn();
            Phone = new DataGridViewTextBoxColumn();
            status = new DataGridViewTextBoxColumn();
            checkin = new DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvCheckin).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(202, 91);
            label1.Name = "label1";
            label1.Size = new Size(254, 45);
            label1.TabIndex = 0;
            label1.Text = "Tên thành viên";
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Yellow;
            button1.Location = new Point(975, 91);
            button1.Name = "button1";
            button1.Size = new Size(181, 52);
            button1.TabIndex = 1;
            button1.Text = "Tìm kiếm";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(695, 9);
            label2.Name = "label2";
            label2.Size = new Size(213, 60);
            label2.TabIndex = 3;
            label2.Text = "Check-in";
            // 
            // txtMemberName
            // 
            txtMemberName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMemberName.Location = new Point(499, 98);
            txtMemberName.Name = "txtMemberName";
            txtMemberName.Size = new Size(428, 39);
            txtMemberName.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(695, 181);
            label3.Name = "label3";
            label3.Size = new Size(183, 45);
            label3.TabIndex = 5;
            label3.Text = "Danh Sách";
            // 
            // dgvCheckin
            // 
            dgvCheckin.BackgroundColor = Color.IndianRed;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.Red;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Yellow;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvCheckin.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvCheckin.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCheckin.Columns.AddRange(new DataGridViewColumn[] { ID, memberName, Gen, membership, pt, Phone, status, checkin });
            dgvCheckin.Cursor = Cursors.Hand;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.LightGray;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvCheckin.DefaultCellStyle = dataGridViewCellStyle2;
            dgvCheckin.Location = new Point(95, 252);
            dgvCheckin.Margin = new Padding(2);
            dgvCheckin.MultiSelect = false;
            dgvCheckin.Name = "dgvCheckin";
            dgvCheckin.RowHeadersWidth = 62;
            dgvCheckin.Size = new Size(1335, 412);
            dgvCheckin.TabIndex = 21;
            dgvCheckin.CellContentClick += dgvCheckin_CellContentClick;
            // 
            // ID
            // 
            ID.DataPropertyName = "ID";
            ID.HeaderText = "ID";
            ID.MinimumWidth = 70;
            ID.Name = "ID";
            ID.Width = 70;
            // 
            // memberName
            // 
            memberName.DataPropertyName = "Name";
            memberName.HeaderText = "Họ Tên";
            memberName.MinimumWidth = 200;
            memberName.Name = "memberName";
            memberName.Width = 250;
            // 
            // Gen
            // 
            Gen.DataPropertyName = "Gender";
            Gen.HeaderText = "Giới Tính";
            Gen.MinimumWidth = 100;
            Gen.Name = "Gen";
            Gen.Width = 140;
            // 
            // membership
            // 
            membership.DataPropertyName = "Membership";
            membership.HeaderText = "Gói";
            membership.MinimumWidth = 8;
            membership.Name = "membership";
            membership.Width = 150;
            // 
            // pt
            // 
            pt.DataPropertyName = "PT";
            pt.HeaderText = "PT";
            pt.MinimumWidth = 8;
            pt.Name = "pt";
            pt.Width = 150;
            // 
            // Phone
            // 
            Phone.DataPropertyName = "PhoneNumber";
            Phone.HeaderText = "Số Điện Thoại";
            Phone.MinimumWidth = 100;
            Phone.Name = "Phone";
            Phone.Width = 200;
            // 
            // status
            // 
            status.DataPropertyName = "Status";
            status.HeaderText = "Trạng thái";
            status.MinimumWidth = 100;
            status.Name = "status";
            status.Width = 190;
            // 
            // checkin
            // 
            checkin.HeaderText = "Check-in";
            checkin.MinimumWidth = 8;
            checkin.Name = "checkin";
            checkin.Width = 120;
            // 
            // frm_checkin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1590, 850);
            Controls.Add(dgvCheckin);
            Controls.Add(label3);
            Controls.Add(txtMemberName);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frm_checkin";
            Text = "Check-in";
            KeyDown += frm_checkin_KeyDown;
            ((System.ComponentModel.ISupportInitialize)dgvCheckin).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Label label2;
        private TextBox txtMemberName;
        private Label label3;
        private DataGridView dgvCheckin;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn memberName;
        private DataGridViewTextBoxColumn Gen;
        private DataGridViewTextBoxColumn membership;
        private DataGridViewTextBoxColumn pt;
        private DataGridViewTextBoxColumn Phone;
        private DataGridViewTextBoxColumn status;
        private DataGridViewCheckBoxColumn checkin;
    }
}