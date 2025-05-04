namespace Gym_Management_System
{
    partial class frm_EditPromotion
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
            btnSave = new Button();
            label6 = new Label();
            txtDescribe = new TextBox();
            cbDiscount = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            dtpEndDate = new DateTimePicker();
            dtpStartDate = new DateTimePicker();
            label5 = new Label();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Red;
            btnSave.Cursor = Cursors.Hand;
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = SystemColors.ButtonFace;
            btnSave.Location = new Point(512, 433);
            btnSave.Margin = new Padding(2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(148, 52);
            btnSave.TabIndex = 67;
            btnSave.Text = "Lưu";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Black", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Red;
            label6.Location = new Point(400, 23);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(462, 54);
            label6.TabIndex = 68;
            label6.Text = "Chỉnh Sửa Khuyến Mãi";
            // 
            // txtDescribe
            // 
            txtDescribe.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDescribe.Location = new Point(708, 175);
            txtDescribe.Multiline = true;
            txtDescribe.Name = "txtDescribe";
            txtDescribe.Size = new Size(508, 39);
            txtDescribe.TabIndex = 74;
            // 
            // cbDiscount
            // 
            cbDiscount.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDiscount.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbDiscount.FormattingEnabled = true;
            cbDiscount.Items.AddRange(new object[] { "5", "10", "15", "20", "25", "30", "35", "40", "45", "50", "55", "60", "65", "70", "75", "80", "85", "90", "95", "100" });
            cbDiscount.Location = new Point(228, 174);
            cbDiscount.Name = "cbDiscount";
            cbDiscount.Size = new Size(182, 40);
            cbDiscount.TabIndex = 73;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label4.Location = new Point(708, 118);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(95, 38);
            label4.TabIndex = 72;
            label4.Text = "Mô tả";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label3.Location = new Point(708, 283);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(209, 38);
            label3.TabIndex = 71;
            label3.Text = "Ngày Kết Thúc";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label2.Location = new Point(228, 118);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(137, 38);
            label2.TabIndex = 70;
            label2.Text = "Giảm Giá";
            // 
            // dtpEndDate
            // 
            dtpEndDate.CalendarMonthBackground = Color.White;
            dtpEndDate.Cursor = Cursors.Hand;
            dtpEndDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpEndDate.Format = DateTimePickerFormat.Short;
            dtpEndDate.Location = new Point(708, 341);
            dtpEndDate.Margin = new Padding(2);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(202, 39);
            dtpEndDate.TabIndex = 69;
            // 
            // dtpStartDate
            // 
            dtpStartDate.CalendarMonthBackground = Color.White;
            dtpStartDate.Cursor = Cursors.Hand;
            dtpStartDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpStartDate.Format = DateTimePickerFormat.Short;
            dtpStartDate.Location = new Point(228, 341);
            dtpStartDate.Margin = new Padding(2);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(202, 39);
            dtpStartDate.TabIndex = 76;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label5.Location = new Point(228, 283);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(199, 38);
            label5.TabIndex = 75;
            label5.Text = "Ngày Bắt Đầu";
            // 
            // frm_EditPromotion
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1244, 530);
            Controls.Add(dtpStartDate);
            Controls.Add(label5);
            Controls.Add(txtDescribe);
            Controls.Add(cbDiscount);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dtpEndDate);
            Controls.Add(label6);
            Controls.Add(btnSave);
            Name = "frm_EditPromotion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Chỉnh Sửa Khuyến Mãi";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private Label label6;
        private TextBox txtDescribe;
        private ComboBox cbDiscount;
        private Label label4;
        private Label label3;
        private Label label2;
        private DateTimePicker dtpEndDate;
        private DateTimePicker dtpStartDate;
        private Label label5;
    }
}