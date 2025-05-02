namespace Gym_Management_System
{
    partial class frm_equipment
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
            dgvEquipment = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            nameEquipment = new DataGridViewTextBoxColumn();
            type = new DataGridViewTextBoxColumn();
            amount = new DataGridViewTextBoxColumn();
            statusEquipment = new DataGridViewTextBoxColumn();
            lastMaintain = new DataGridViewTextBoxColumn();
            nextMaintain = new DataGridViewTextBoxColumn();
            label8 = new Label();
            label6 = new Label();
            label3 = new Label();
            cbStatus = new ComboBox();
            label2 = new Label();
            btnSave = new Button();
            dtpLastMainTain = new DateTimePicker();
            txtNameEquipment = new TextBox();
            label1 = new Label();
            label4 = new Label();
            dtpNextMainTain = new DateTimePicker();
            btnDel = new Button();
            btnEdit = new Button();
            label5 = new Label();
            cbTypeEquipment = new ComboBox();
            label7 = new Label();
            cbAmount = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvEquipment).BeginInit();
            SuspendLayout();
            // 
            // dgvEquipment
            // 
            dgvEquipment.BackgroundColor = Color.IndianRed;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.Red;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Yellow;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvEquipment.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvEquipment.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEquipment.Columns.AddRange(new DataGridViewColumn[] { ID, nameEquipment, type, amount, statusEquipment, lastMaintain, nextMaintain });
            dgvEquipment.Cursor = Cursors.Hand;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.LightGray;
            dataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlDarkDark;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvEquipment.DefaultCellStyle = dataGridViewCellStyle3;
            dgvEquipment.Location = new Point(37, 476);
            dgvEquipment.Margin = new Padding(2);
            dgvEquipment.MultiSelect = false;
            dgvEquipment.Name = "dgvEquipment";
            dgvEquipment.RowHeadersWidth = 62;
            dgvEquipment.Size = new Size(1465, 307);
            dgvEquipment.TabIndex = 36;
            // 
            // ID
            // 
            ID.DataPropertyName = "ID";
            ID.HeaderText = "ID";
            ID.MinimumWidth = 70;
            ID.Name = "ID";
            ID.Width = 70;
            // 
            // nameEquipment
            // 
            nameEquipment.DataPropertyName = "name";
            nameEquipment.HeaderText = "Tên Thiết Bị";
            nameEquipment.MinimumWidth = 200;
            nameEquipment.Name = "nameEquipment";
            nameEquipment.Width = 250;
            // 
            // type
            // 
            type.DataPropertyName = "type";
            type.HeaderText = "Loại";
            type.MinimumWidth = 8;
            type.Name = "type";
            type.Width = 150;
            // 
            // amount
            // 
            amount.DataPropertyName = "amount";
            amount.HeaderText = "Số Lượng";
            amount.MinimumWidth = 8;
            amount.Name = "amount";
            amount.Width = 150;
            // 
            // statusEquipment
            // 
            statusEquipment.DataPropertyName = "status";
            statusEquipment.HeaderText = "Trạng Thái";
            statusEquipment.MinimumWidth = 100;
            statusEquipment.Name = "statusEquipment";
            statusEquipment.Width = 200;
            // 
            // lastMaintain
            // 
            lastMaintain.DataPropertyName = "lastmaintain";
            dataGridViewCellStyle2.NullValue = null;
            lastMaintain.DefaultCellStyle = dataGridViewCellStyle2;
            lastMaintain.HeaderText = "Ngày Bảo Trì Cuối Cùng";
            lastMaintain.MinimumWidth = 130;
            lastMaintain.Name = "lastMaintain";
            lastMaintain.Width = 300;
            // 
            // nextMaintain
            // 
            nextMaintain.DataPropertyName = "nextmaintain";
            nextMaintain.HeaderText = "Ngày Bảo Trì Kế Tiếp";
            nextMaintain.MinimumWidth = 100;
            nextMaintain.Name = "nextMaintain";
            nextMaintain.Width = 280;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Red;
            label8.Location = new Point(682, 421);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(301, 45);
            label8.TabIndex = 35;
            label8.Text = "Danh Sách Thiết Bị";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Black", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Red;
            label6.Location = new Point(649, 9);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(334, 54);
            label6.TabIndex = 34;
            label6.Text = "Quản Lí Thiết Bị";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label3.Location = new Point(456, 221);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(328, 38);
            label3.TabIndex = 28;
            label3.Text = "Ngày Bảo Trì Cuối Cùng";
            // 
            // cbStatus
            // 
            cbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cbStatus.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbStatus.FormattingEnabled = true;
            cbStatus.Items.AddRange(new object[] { "Hoạt Động", "Hư", "Đang Bảo Trì" });
            cbStatus.Location = new Point(1268, 151);
            cbStatus.Margin = new Padding(2);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(182, 40);
            cbStatus.TabIndex = 27;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label2.Location = new Point(1268, 95);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(155, 38);
            label2.TabIndex = 26;
            label2.Text = "Trạng Thái";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Red;
            btnSave.Cursor = Cursors.Hand;
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = SystemColors.ButtonFace;
            btnSave.Location = new Point(752, 348);
            btnSave.Margin = new Padding(2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(148, 52);
            btnSave.TabIndex = 25;
            btnSave.Text = "Lưu";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // dtpLastMainTain
            // 
            dtpLastMainTain.CalendarMonthBackground = Color.White;
            dtpLastMainTain.Cursor = Cursors.Hand;
            dtpLastMainTain.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpLastMainTain.Format = DateTimePickerFormat.Short;
            dtpLastMainTain.Location = new Point(465, 279);
            dtpLastMainTain.Margin = new Padding(2);
            dtpLastMainTain.Name = "dtpLastMainTain";
            dtpLastMainTain.Size = new Size(202, 39);
            dtpLastMainTain.TabIndex = 24;
            // 
            // txtNameEquipment
            // 
            txtNameEquipment.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNameEquipment.Location = new Point(132, 151);
            txtNameEquipment.Margin = new Padding(2);
            txtNameEquipment.Name = "txtNameEquipment";
            txtNameEquipment.Size = new Size(286, 39);
            txtNameEquipment.TabIndex = 23;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.Location = new Point(132, 95);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(171, 38);
            label1.TabIndex = 22;
            label1.Text = "Tên Thiết Bị";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label4.Location = new Point(842, 221);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(322, 38);
            label4.TabIndex = 38;
            label4.Text = "Ngày Bảo Trì Tiếp Theo";
            // 
            // dtpNextMainTain
            // 
            dtpNextMainTain.CalendarMonthBackground = Color.White;
            dtpNextMainTain.Cursor = Cursors.Hand;
            dtpNextMainTain.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpNextMainTain.Format = DateTimePickerFormat.Short;
            dtpNextMainTain.Location = new Point(851, 279);
            dtpNextMainTain.Margin = new Padding(2);
            dtpNextMainTain.Name = "dtpNextMainTain";
            dtpNextMainTain.Size = new Size(202, 39);
            dtpNextMainTain.TabIndex = 37;
            // 
            // btnDel
            // 
            btnDel.BackColor = Color.Red;
            btnDel.Cursor = Cursors.Hand;
            btnDel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDel.ForeColor = SystemColors.ButtonFace;
            btnDel.Location = new Point(905, 787);
            btnDel.Margin = new Padding(2);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(148, 52);
            btnDel.TabIndex = 40;
            btnDel.Text = "Xóa";
            btnDel.UseVisualStyleBackColor = false;
            btnDel.Click += btnDel_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.Red;
            btnEdit.Cursor = Cursors.Hand;
            btnEdit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEdit.ForeColor = SystemColors.ButtonFace;
            btnEdit.Location = new Point(624, 787);
            btnEdit.Margin = new Padding(2);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(148, 52);
            btnEdit.TabIndex = 39;
            btnEdit.Text = "Chỉnh Sửa";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label5.Location = new Point(501, 95);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(71, 38);
            label5.TabIndex = 41;
            label5.Text = "Loại";
            // 
            // cbTypeEquipment
            // 
            cbTypeEquipment.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTypeEquipment.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbTypeEquipment.FormattingEnabled = true;
            cbTypeEquipment.Items.AddRange(new object[] { "Cardio", "Máy tập sức mạnh/tăng cơ", "Tạ tự do", "Ghế tập và khung hỗ trợ", "Thiết bị tập chức năng/đa năng", "Thiết bị dùng trọng lượng cơ thể", "Thiết bị giãn cơ/phục hồi" });
            cbTypeEquipment.Location = new Point(501, 150);
            cbTypeEquipment.Margin = new Padding(2);
            cbTypeEquipment.Name = "cbTypeEquipment";
            cbTypeEquipment.Size = new Size(365, 40);
            cbTypeEquipment.TabIndex = 42;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label7.Location = new Point(956, 95);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(143, 38);
            label7.TabIndex = 43;
            label7.Text = "Số Lượng";
            // 
            // cbAmount
            // 
            cbAmount.DropDownStyle = ComboBoxStyle.DropDownList;
            cbAmount.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbAmount.FormattingEnabled = true;
            cbAmount.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50" });
            cbAmount.Location = new Point(956, 151);
            cbAmount.Margin = new Padding(2);
            cbAmount.Name = "cbAmount";
            cbAmount.Size = new Size(182, 40);
            cbAmount.TabIndex = 44;
            // 
            // frm_equipment
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1590, 850);
            Controls.Add(cbAmount);
            Controls.Add(label7);
            Controls.Add(cbTypeEquipment);
            Controls.Add(label5);
            Controls.Add(btnDel);
            Controls.Add(btnEdit);
            Controls.Add(label4);
            Controls.Add(dtpNextMainTain);
            Controls.Add(dgvEquipment);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(cbStatus);
            Controls.Add(label2);
            Controls.Add(btnSave);
            Controls.Add(dtpLastMainTain);
            Controls.Add(txtNameEquipment);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frm_equipment";
            Text = "Equipment";
            Load += Equipment_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEquipment).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvEquipment;
        private Label label8;
        private Label label6;
        private Label label3;
        private ComboBox cbStatus;
        private Label label2;
        private Button btnSave;
        private DateTimePicker dtpLastMainTain;
        private TextBox txtNameEquipment;
        private Label label1;
        private Label label4;
        private DateTimePicker dtpNextMainTain;
        private Button btnDel;
        private Button btnEdit;
        private Label label5;
        private ComboBox cbTypeEquipment;
        private Label label7;
        private ComboBox cbAmount;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn nameEquipment;
        private DataGridViewTextBoxColumn type;
        private DataGridViewTextBoxColumn amount;
        private DataGridViewTextBoxColumn statusEquipment;
        private DataGridViewTextBoxColumn lastMaintain;
        private DataGridViewTextBoxColumn nextMaintain;
    }
}