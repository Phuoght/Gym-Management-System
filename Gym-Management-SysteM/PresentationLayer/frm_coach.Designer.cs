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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
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
            ID = new DataGridViewTextBoxColumn();
            namePT = new DataGridViewTextBoxColumn();
            Gen = new DataGridViewTextBoxColumn();
            DOB = new DataGridViewTextBoxColumn();
            Phone = new DataGridViewTextBoxColumn();
            Experience = new DataGridViewTextBoxColumn();
            Address = new DataGridViewTextBoxColumn();
            cbExperience = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvPT).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI",14F,FontStyle.Bold);
            label1.Location = new Point(179,69);
            label1.Margin = new Padding(2,0,2,0);
            label1.Name = "label1";
            label1.Size = new Size(94,32);
            label1.TabIndex = 0;
            label1.Text = "Họ Tên";
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI",12F,FontStyle.Regular,GraphicsUnit.Point,0);
            txtName.Location = new Point(179,114);
            txtName.Margin = new Padding(2,2,2,2);
            txtName.Name = "txtName";
            txtName.Size = new Size(230,34);
            txtName.TabIndex = 1;
            // 
            // dtpDateOfBirth
            // 
            dtpDateOfBirth.CalendarMonthBackground = Color.White;
            dtpDateOfBirth.Cursor = Cursors.Hand;
            dtpDateOfBirth.Font = new Font("Segoe UI",12F,FontStyle.Regular,GraphicsUnit.Point,0);
            dtpDateOfBirth.Format = DateTimePickerFormat.Short;
            dtpDateOfBirth.Location = new Point(709,115);
            dtpDateOfBirth.Margin = new Padding(2,2,2,2);
            dtpDateOfBirth.Name = "dtpDateOfBirth";
            dtpDateOfBirth.Size = new Size(162,34);
            dtpDateOfBirth.TabIndex = 2;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Red;
            btnSave.Cursor = Cursors.Hand;
            btnSave.Font = new Font("Segoe UI",12F,FontStyle.Bold,GraphicsUnit.Point,0);
            btnSave.ForeColor = SystemColors.ButtonFace;
            btnSave.Location = new Point(608,265);
            btnSave.Margin = new Padding(2,2,2,2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(118,42);
            btnSave.TabIndex = 3;
            btnSave.Text = "Lưu";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI",14F,FontStyle.Bold);
            label2.Location = new Point(485,69);
            label2.Margin = new Padding(2,0,2,0);
            label2.Name = "label2";
            label2.Size = new Size(117,32);
            label2.TabIndex = 4;
            label2.Text = "Giới Tính";
            // 
            // cbGen
            // 
            cbGen.DropDownStyle = ComboBoxStyle.DropDownList;
            cbGen.Font = new Font("Segoe UI",12F,FontStyle.Regular,GraphicsUnit.Point,0);
            cbGen.FormattingEnabled = true;
            cbGen.Items.AddRange(new object[] { "Nam","Nữ" });
            cbGen.Location = new Point(485,114);
            cbGen.Margin = new Padding(2,2,2,2);
            cbGen.Name = "cbGen";
            cbGen.Size = new Size(146,36);
            cbGen.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI",14F,FontStyle.Bold);
            label3.Location = new Point(709,69);
            label3.Margin = new Padding(2,0,2,0);
            label3.Name = "label3";
            label3.Size = new Size(128,32);
            label3.TabIndex = 7;
            label3.Text = "Ngày sinh";
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("Segoe UI",12F,FontStyle.Regular,GraphicsUnit.Point,0);
            txtPhone.Location = new Point(952,114);
            txtPhone.Margin = new Padding(2,2,2,2);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(235,34);
            txtPhone.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI",14F,FontStyle.Bold);
            label4.Location = new Point(952,69);
            label4.Margin = new Padding(2,0,2,0);
            label4.Name = "label4";
            label4.Size = new Size(172,32);
            label4.TabIndex = 8;
            label4.Text = "Số Điện Thoại";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI",14F,FontStyle.Bold);
            label5.Location = new Point(179,170);
            label5.Margin = new Padding(2,0,2,0);
            label5.Name = "label5";
            label5.Size = new Size(159,32);
            label5.TabIndex = 10;
            label5.Text = "Kinh nghiệm";
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Segoe UI",12F,FontStyle.Regular,GraphicsUnit.Point,0);
            txtAddress.Location = new Point(485,215);
            txtAddress.Margin = new Padding(2,2,2,2);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(402,32);
            txtAddress.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI",14F,FontStyle.Bold);
            label7.Location = new Point(485,170);
            label7.Margin = new Padding(2,0,2,0);
            label7.Name = "label7";
            label7.Size = new Size(92,32);
            label7.TabIndex = 14;
            label7.Text = "Địa chỉ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Black",20F,FontStyle.Bold,GraphicsUnit.Point,0);
            label6.ForeColor = Color.Red;
            label6.Location = new Point(581,7);
            label6.Margin = new Padding(2,0,2,0);
            label6.Name = "label6";
            label6.Size = new Size(189,46);
            label6.TabIndex = 16;
            label6.Text = "Quản lí PT";
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.Red;
            btnEdit.Cursor = Cursors.Hand;
            btnEdit.Font = new Font("Segoe UI",12F,FontStyle.Bold,GraphicsUnit.Point,0);
            btnEdit.ForeColor = SystemColors.ButtonFace;
            btnEdit.Location = new Point(485,628);
            btnEdit.Margin = new Padding(2,2,2,2);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(118,42);
            btnEdit.TabIndex = 17;
            btnEdit.Text = "Chỉnh Sửa";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDel
            // 
            btnDel.BackColor = Color.Red;
            btnDel.Cursor = Cursors.Hand;
            btnDel.Font = new Font("Segoe UI",12F,FontStyle.Bold,GraphicsUnit.Point,0);
            btnDel.ForeColor = SystemColors.ButtonFace;
            btnDel.Location = new Point(721,628);
            btnDel.Margin = new Padding(2,2,2,2);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(118,42);
            btnDel.TabIndex = 18;
            btnDel.Text = "Xóa";
            btnDel.UseVisualStyleBackColor = false;
            btnDel.Click += btnDel_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI",16F,FontStyle.Bold,GraphicsUnit.Point,0);
            label8.ForeColor = Color.Red;
            label8.Location = new Point(581,318);
            label8.Margin = new Padding(2,0,2,0);
            label8.Name = "label8";
            label8.Size = new Size(187,37);
            label8.TabIndex = 19;
            label8.Text = "Danh sách PT";
            // 
            // dgvPT
            // 
            dgvPT.BackgroundColor = Color.IndianRed;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.Red;
            dataGridViewCellStyle1.Font = new Font("Segoe UI",11F,FontStyle.Bold,GraphicsUnit.Point,0);
            dataGridViewCellStyle1.ForeColor = Color.Yellow;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvPT.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvPT.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPT.Columns.AddRange(new DataGridViewColumn[] { ID,namePT,Gen,DOB,Phone,Experience,Address });
            dgvPT.Cursor = Cursors.Hand;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.LightGray;
            dataGridViewCellStyle3.Font = new Font("Segoe UI Semibold",13F,FontStyle.Bold,GraphicsUnit.Point,0);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlDarkDark;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvPT.DefaultCellStyle = dataGridViewCellStyle3;
            dgvPT.Location = new Point(24,357);
            dgvPT.Margin = new Padding(2,2,2,2);
            dgvPT.MultiSelect = false;
            dgvPT.Name = "dgvPT";
            dgvPT.RowHeadersWidth = 62;
            dgvPT.Size = new Size(1191,257);
            dgvPT.TabIndex = 20;
            // 
            // ID
            // 
            ID.DataPropertyName = "ID";
            ID.HeaderText = "ID";
            ID.MinimumWidth = 70;
            ID.Name = "ID";
            ID.Width = 70;
            // 
            // namePT
            // 
            namePT.DataPropertyName = "name";
            namePT.HeaderText = "Họ Tên";
            namePT.MinimumWidth = 200;
            namePT.Name = "namePT";
            namePT.Width = 250;
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
            // Experience
            // 
            Experience.DataPropertyName = "Experience";
            Experience.HeaderText = "Kinh Nghiệm";
            Experience.MinimumWidth = 100;
            Experience.Name = "Experience";
            Experience.Width = 190;
            // 
            // Address
            // 
            Address.DataPropertyName = "Address";
            Address.HeaderText = "Địa Chỉ";
            Address.MinimumWidth = 350;
            Address.Name = "Address";
            Address.Width = 395;
            // 
            // cbExperience
            // 
            cbExperience.DropDownStyle = ComboBoxStyle.DropDownList;
            cbExperience.Font = new Font("Segoe UI",12F,FontStyle.Regular,GraphicsUnit.Point,0);
            cbExperience.FormattingEnabled = true;
            cbExperience.Items.AddRange(new object[] { "1","2","3","4","5","6","7","8","9","10","11","12","13","14","15","16","17","18","19","20" });
            cbExperience.Location = new Point(182,215);
            cbExperience.Margin = new Padding(2,2,2,2);
            cbExperience.Name = "cbExperience";
            cbExperience.Size = new Size(146,36);
            cbExperience.TabIndex = 21;
            // 
            // frm_coach
            // 
            AutoScaleDimensions = new SizeF(8F,20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1272,680);
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
            Margin = new Padding(2,2,2,2);
            Name = "frm_coach";
            Text = "frm_coach";
            Load += frm_coach_Load;
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
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn namePT;
        private DataGridViewTextBoxColumn Gen;
        private DataGridViewTextBoxColumn DOB;
        private DataGridViewTextBoxColumn Phone;
        private DataGridViewTextBoxColumn Experience;
        private DataGridViewTextBoxColumn Address;
    }
}