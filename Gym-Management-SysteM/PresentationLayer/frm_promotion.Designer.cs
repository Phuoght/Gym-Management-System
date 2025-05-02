namespace Gym_Management_System
{
    partial class frm_promotion
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
            dgvPromotion = new DataGridView();
            Code = new DataGridViewTextBoxColumn();
            Discount = new DataGridViewTextBoxColumn();
            Describe = new DataGridViewTextBoxColumn();
            StartDate = new DataGridViewTextBoxColumn();
            EndDate = new DataGridViewTextBoxColumn();
            label8 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btnSave = new Button();
            dtpEndDate = new DateTimePicker();
            txtCode = new TextBox();
            label1 = new Label();
            btnDel = new Button();
            btnEdit = new Button();
            dtpStartDate = new DateTimePicker();
            cbDiscount = new ComboBox();
            txtDescribe = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvPromotion).BeginInit();
            SuspendLayout();
            // 
            // dgvPromotion
            // 
            dgvPromotion.BackgroundColor = Color.IndianRed;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.Red;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Yellow;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvPromotion.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvPromotion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPromotion.Columns.AddRange(new DataGridViewColumn[] { Code, Discount, Describe, StartDate, EndDate });
            dgvPromotion.Cursor = Cursors.Hand;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.LightGray;
            dataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlDarkDark;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvPromotion.DefaultCellStyle = dataGridViewCellStyle3;
            dgvPromotion.Location = new Point(28, 462);
            dgvPromotion.Margin = new Padding(2);
            dgvPromotion.MultiSelect = false;
            dgvPromotion.Name = "dgvPromotion";
            dgvPromotion.RowHeadersWidth = 62;
            dgvPromotion.Size = new Size(1475, 321);
            dgvPromotion.TabIndex = 36;
            // 
            // Code
            // 
            Code.DataPropertyName = "code";
            Code.HeaderText = "Mã Khuyến Mãi";
            Code.MinimumWidth = 70;
            Code.Name = "Code";
            Code.Width = 250;
            // 
            // Discount
            // 
            Discount.DataPropertyName = "discount";
            Discount.HeaderText = "Giảm Giá";
            Discount.MinimumWidth = 200;
            Discount.Name = "Discount";
            Discount.Width = 200;
            // 
            // Describe
            // 
            Describe.DataPropertyName = "describe";
            Describe.HeaderText = "Mô Tả";
            Describe.MinimumWidth = 100;
            Describe.Name = "Describe";
            Describe.Width = 500;
            // 
            // StartDate
            // 
            StartDate.DataPropertyName = "startDate";
            dataGridViewCellStyle2.NullValue = null;
            StartDate.DefaultCellStyle = dataGridViewCellStyle2;
            StartDate.HeaderText = "Ngày Bắt Đầu";
            StartDate.MinimumWidth = 130;
            StartDate.Name = "StartDate";
            StartDate.Width = 230;
            // 
            // EndDate
            // 
            EndDate.DataPropertyName = "endDate";
            EndDate.HeaderText = "Ngày Kết Thúc";
            EndDate.MinimumWidth = 100;
            EndDate.Name = "EndDate";
            EndDate.Width = 230;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Red;
            label8.Location = new Point(671, 408);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(355, 45);
            label8.TabIndex = 35;
            label8.Text = "Danh sách khuyến mãi";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Black", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Red;
            label6.Location = new Point(660, 19);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(414, 54);
            label6.TabIndex = 34;
            label6.Text = "Quản Lí Khuyến Mãi";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label5.Location = new Point(234, 221);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(199, 38);
            label5.TabIndex = 31;
            label5.Text = "Ngày Bắt Đầu";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label4.Location = new Point(887, 95);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(95, 38);
            label4.TabIndex = 29;
            label4.Text = "Mô tả";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label3.Location = new Point(616, 221);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(209, 38);
            label3.TabIndex = 28;
            label3.Text = "Ngày Kết Thúc";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label2.Location = new Point(616, 95);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(137, 38);
            label2.TabIndex = 26;
            label2.Text = "Giảm Giá";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Red;
            btnSave.Cursor = Cursors.Hand;
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = SystemColors.ButtonFace;
            btnSave.Location = new Point(770, 340);
            btnSave.Margin = new Padding(2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(148, 52);
            btnSave.TabIndex = 25;
            btnSave.Text = "Lưu";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // dtpEndDate
            // 
            dtpEndDate.CalendarMonthBackground = Color.White;
            dtpEndDate.Cursor = Cursors.Hand;
            dtpEndDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpEndDate.Format = DateTimePickerFormat.Short;
            dtpEndDate.Location = new Point(616, 279);
            dtpEndDate.Margin = new Padding(2);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(202, 39);
            dtpEndDate.TabIndex = 24;
            // 
            // txtCode
            // 
            txtCode.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCode.Location = new Point(234, 151);
            txtCode.Margin = new Padding(2);
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(286, 39);
            txtCode.TabIndex = 23;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.Location = new Point(234, 95);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(224, 38);
            label1.TabIndex = 22;
            label1.Text = "Mã Khuyến Mãi";
            // 
            // btnDel
            // 
            btnDel.BackColor = Color.Red;
            btnDel.Cursor = Cursors.Hand;
            btnDel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDel.ForeColor = SystemColors.ButtonFace;
            btnDel.Location = new Point(887, 787);
            btnDel.Margin = new Padding(2);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(148, 52);
            btnDel.TabIndex = 39;
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
            btnEdit.Location = new Point(592, 787);
            btnEdit.Margin = new Padding(2);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(148, 52);
            btnEdit.TabIndex = 38;
            btnEdit.Text = "Chỉnh Sửa";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // dtpStartDate
            // 
            dtpStartDate.CalendarMonthBackground = Color.White;
            dtpStartDate.Cursor = Cursors.Hand;
            dtpStartDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpStartDate.Format = DateTimePickerFormat.Short;
            dtpStartDate.Location = new Point(234, 279);
            dtpStartDate.Margin = new Padding(2);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(202, 39);
            dtpStartDate.TabIndex = 40;
            // 
            // cbDiscount
            // 
            cbDiscount.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDiscount.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbDiscount.FormattingEnabled = true;
            cbDiscount.Items.AddRange(new object[] { "5%", "10%", "15%", "20%", "25%", "30%", "35%", "40%", "45%", "50%", "55%", "60%", "65%", "70%", "75%", "80%", "85%", "90%", "95%", "100%" });
            cbDiscount.Location = new Point(616, 151);
            cbDiscount.Name = "cbDiscount";
            cbDiscount.Size = new Size(182, 40);
            cbDiscount.TabIndex = 41;
            // 
            // txtDescribe
            // 
            txtDescribe.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDescribe.Location = new Point(887, 152);
            txtDescribe.Multiline = true;
            txtDescribe.Name = "txtDescribe";
            txtDescribe.Size = new Size(508, 39);
            txtDescribe.TabIndex = 42;
            // 
            // frm_promotion
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1590, 850);
            Controls.Add(txtDescribe);
            Controls.Add(cbDiscount);
            Controls.Add(dtpStartDate);
            Controls.Add(btnDel);
            Controls.Add(btnEdit);
            Controls.Add(dgvPromotion);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnSave);
            Controls.Add(dtpEndDate);
            Controls.Add(txtCode);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frm_promotion";
            Text = "frm_promotion";
            Load += frm_promotion_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPromotion).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbExperience;
        private DataGridView dgvPromotion;
        private Label label8;
        private Label label6;
        private TextBox txtAddress;
        private Label label7;
        private Label label5;
        private TextBox txtPhone;
        private Label label4;
        private Label label3;
        private ComboBox cbGen;
        private Label label2;
        private Button btnSave;
        private DateTimePicker dtpEndDate;
        private TextBox txtCode;
        private Label label1;
        private Button btnDel;
        private Button btnEdit;
        private DateTimePicker dtpStartDate;
        private ComboBox cbDiscount;
        private TextBox txtDescribe;
        private DataGridViewTextBoxColumn Code;
        private DataGridViewTextBoxColumn Discount;
        private DataGridViewTextBoxColumn Describe;
        private DataGridViewTextBoxColumn StartDate;
        private DataGridViewTextBoxColumn EndDate;
    }
}