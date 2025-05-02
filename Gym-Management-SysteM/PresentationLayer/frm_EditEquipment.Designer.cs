namespace Gym_Management_System
{
    partial class frm_EditEquipment
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
            cbAmount = new ComboBox();
            label7 = new Label();
            cbTypeEquipment = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            dtpNextMainTain = new DateTimePicker();
            label3 = new Label();
            cbStatus = new ComboBox();
            label2 = new Label();
            dtpLastMainTain = new DateTimePicker();
            txtNameEquipment = new TextBox();
            label1 = new Label();
            label6 = new Label();
            btnSave = new Button();
            SuspendLayout();
            // 
            // cbAmount
            // 
            cbAmount.DropDownStyle = ComboBoxStyle.DropDownList;
            cbAmount.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbAmount.FormattingEnabled = true;
            cbAmount.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50" });
            cbAmount.Location = new Point(276, 366);
            cbAmount.Margin = new Padding(2);
            cbAmount.Name = "cbAmount";
            cbAmount.Size = new Size(182, 40);
            cbAmount.TabIndex = 56;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label7.Location = new Point(22, 366);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(143, 38);
            label7.TabIndex = 55;
            label7.Text = "Số Lượng";
            // 
            // cbTypeEquipment
            // 
            cbTypeEquipment.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTypeEquipment.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbTypeEquipment.FormattingEnabled = true;
            cbTypeEquipment.Items.AddRange(new object[] { "Cardio", "Máy tập sức mạnh/tăng cơ", "Tạ tự do", "Ghế tập và khung hỗ trợ", "Thiết bị tập chức năng/đa năng", "Thiết bị dùng trọng lượng cơ thể", "Thiết bị giãn cơ/phục hồi" });
            cbTypeEquipment.Location = new Point(182, 263);
            cbTypeEquipment.Margin = new Padding(2);
            cbTypeEquipment.Name = "cbTypeEquipment";
            cbTypeEquipment.Size = new Size(365, 40);
            cbTypeEquipment.TabIndex = 54;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label5.Location = new Point(51, 261);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(71, 38);
            label5.TabIndex = 53;
            label5.Text = "Loại";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label4.Location = new Point(661, 368);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(322, 38);
            label4.TabIndex = 52;
            label4.Text = "Ngày Bảo Trì Tiếp Theo";
            // 
            // dtpNextMainTain
            // 
            dtpNextMainTain.CalendarMonthBackground = Color.White;
            dtpNextMainTain.Cursor = Cursors.Hand;
            dtpNextMainTain.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpNextMainTain.Format = DateTimePickerFormat.Short;
            dtpNextMainTain.Location = new Point(1085, 364);
            dtpNextMainTain.Margin = new Padding(2);
            dtpNextMainTain.Name = "dtpNextMainTain";
            dtpNextMainTain.Size = new Size(202, 39);
            dtpNextMainTain.TabIndex = 51;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label3.Location = new Point(661, 260);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(328, 38);
            label3.TabIndex = 50;
            label3.Text = "Ngày Bảo Trì Cuối Cùng";
            // 
            // cbStatus
            // 
            cbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cbStatus.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbStatus.FormattingEnabled = true;
            cbStatus.Items.AddRange(new object[] { "Hoạt Động", "Hư", "Đang Bảo Trì" });
            cbStatus.Location = new Point(1085, 149);
            cbStatus.Margin = new Padding(2);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(182, 40);
            cbStatus.TabIndex = 49;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label2.Location = new Point(754, 151);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(155, 38);
            label2.TabIndex = 48;
            label2.Text = "Trạng Thái";
            // 
            // dtpLastMainTain
            // 
            dtpLastMainTain.CalendarMonthBackground = Color.White;
            dtpLastMainTain.Cursor = Cursors.Hand;
            dtpLastMainTain.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpLastMainTain.Format = DateTimePickerFormat.Short;
            dtpLastMainTain.Location = new Point(1085, 260);
            dtpLastMainTain.Margin = new Padding(2);
            dtpLastMainTain.Name = "dtpLastMainTain";
            dtpLastMainTain.Size = new Size(202, 39);
            dtpLastMainTain.TabIndex = 47;
            // 
            // txtNameEquipment
            // 
            txtNameEquipment.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNameEquipment.Location = new Point(237, 153);
            txtNameEquipment.Margin = new Padding(2);
            txtNameEquipment.Name = "txtNameEquipment";
            txtNameEquipment.Size = new Size(286, 39);
            txtNameEquipment.TabIndex = 46;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.Location = new Point(22, 151);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(171, 38);
            label1.TabIndex = 45;
            label1.Text = "Tên Thiết Bị";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Black", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Red;
            label6.Location = new Point(495, 22);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(382, 54);
            label6.TabIndex = 57;
            label6.Text = "Chỉnh Sửa Thiết Bị";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Red;
            btnSave.Cursor = Cursors.Hand;
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = SystemColors.ButtonFace;
            btnSave.Location = new Point(584, 513);
            btnSave.Margin = new Padding(2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(148, 52);
            btnSave.TabIndex = 58;
            btnSave.Text = "Lưu";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // frm_EditEquipment
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1318, 607);
            Controls.Add(btnSave);
            Controls.Add(label6);
            Controls.Add(cbAmount);
            Controls.Add(label7);
            Controls.Add(cbTypeEquipment);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(dtpNextMainTain);
            Controls.Add(label3);
            Controls.Add(cbStatus);
            Controls.Add(label2);
            Controls.Add(dtpLastMainTain);
            Controls.Add(txtNameEquipment);
            Controls.Add(label1);
            Name = "frm_EditEquipment";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Chỉnh Sửa Thiết Bị";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbAmount;
        private Label label7;
        private ComboBox cbTypeEquipment;
        private Label label5;
        private Label label4;
        private DateTimePicker dtpNextMainTain;
        private Label label3;
        private ComboBox cbStatus;
        private Label label2;
        private DateTimePicker dtpLastMainTain;
        private TextBox txtNameEquipment;
        private Label label1;
        private Label label6;
        private Button btnSave;
    }
}