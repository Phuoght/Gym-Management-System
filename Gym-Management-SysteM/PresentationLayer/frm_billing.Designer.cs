namespace Gym_Management_System
{
    partial class frm_billing
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
            dgvBilling = new DataGridView();
            label8 = new Label();
            btnDel_billing = new Button();
            btnEdit_billing = new Button();
            label6 = new Label();
            txtGoal_billing = new TextBox();
            label7 = new Label();
            txtCost_billing = new TextBox();
            label4 = new Label();
            label2 = new Label();
            btnSave_billing = new Button();
            txtName_billing = new TextBox();
            label1 = new Label();
            txtDuration_billing = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvBilling).BeginInit();
            SuspendLayout();
            // 
            // dgvBilling
            // 
            dgvBilling.BackgroundColor = Color.IndianRed;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.Red;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Yellow;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvBilling.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvBilling.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBilling.Cursor = Cursors.Hand;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.LightGray;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvBilling.DefaultCellStyle = dataGridViewCellStyle2;
            dgvBilling.Location = new Point(65, 369);
            dgvBilling.Margin = new Padding(2);
            dgvBilling.MultiSelect = false;
            dgvBilling.Name = "dgvBilling";
            dgvBilling.RowHeadersWidth = 62;
            dgvBilling.Size = new Size(1191, 257);
            dgvBilling.TabIndex = 38;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Red;
            label8.Location = new Point(522, 311);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(236, 37);
            label8.TabIndex = 37;
            label8.Text = "Danh sách billing";
            // 
            // btnDel_billing
            // 
            btnDel_billing.BackColor = Color.Red;
            btnDel_billing.Cursor = Cursors.Hand;
            btnDel_billing.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDel_billing.ForeColor = SystemColors.ButtonFace;
            btnDel_billing.Location = new Point(693, 630);
            btnDel_billing.Margin = new Padding(2);
            btnDel_billing.Name = "btnDel_billing";
            btnDel_billing.Size = new Size(118, 42);
            btnDel_billing.TabIndex = 36;
            btnDel_billing.Text = "Xóa";
            btnDel_billing.UseVisualStyleBackColor = false;
            // 
            // btnEdit_billing
            // 
            btnEdit_billing.BackColor = Color.Red;
            btnEdit_billing.Cursor = Cursors.Hand;
            btnEdit_billing.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEdit_billing.ForeColor = SystemColors.ButtonFace;
            btnEdit_billing.Location = new Point(457, 630);
            btnEdit_billing.Margin = new Padding(2);
            btnEdit_billing.Name = "btnEdit_billing";
            btnEdit_billing.Size = new Size(118, 42);
            btnEdit_billing.TabIndex = 35;
            btnEdit_billing.Text = "Chỉnh Sửa";
            btnEdit_billing.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Black", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Red;
            label6.Location = new Point(553, 9);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(126, 46);
            label6.TabIndex = 34;
            label6.Text = "Billing";
            // 
            // txtGoal_billing
            // 
            txtGoal_billing.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtGoal_billing.Location = new Point(804, 118);
            txtGoal_billing.Margin = new Padding(2);
            txtGoal_billing.Multiline = true;
            txtGoal_billing.Name = "txtGoal_billing";
            txtGoal_billing.Size = new Size(402, 32);
            txtGoal_billing.TabIndex = 33;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label7.Location = new Point(804, 71);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(115, 32);
            label7.TabIndex = 32;
            label7.Text = "Mục tiêu";
            // 
            // txtCost_billing
            // 
            txtCost_billing.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCost_billing.Location = new Point(151, 219);
            txtCost_billing.Margin = new Padding(2);
            txtCost_billing.Name = "txtCost_billing";
            txtCost_billing.Size = new Size(235, 34);
            txtCost_billing.TabIndex = 30;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label4.Location = new Point(143, 172);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(102, 32);
            label4.TabIndex = 29;
            label4.Text = "Giá tiền";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label2.Location = new Point(457, 71);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(139, 32);
            label2.TabIndex = 26;
            label2.Text = "Thời lượng";
            // 
            // btnSave_billing
            // 
            btnSave_billing.BackColor = Color.Red;
            btnSave_billing.Cursor = Cursors.Hand;
            btnSave_billing.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave_billing.ForeColor = SystemColors.ButtonFace;
            btnSave_billing.Location = new Point(580, 267);
            btnSave_billing.Margin = new Padding(2);
            btnSave_billing.Name = "btnSave_billing";
            btnSave_billing.Size = new Size(118, 42);
            btnSave_billing.TabIndex = 25;
            btnSave_billing.Text = "Lưu";
            btnSave_billing.UseVisualStyleBackColor = false;
            // 
            // txtName_billing
            // 
            txtName_billing.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtName_billing.Location = new Point(151, 116);
            txtName_billing.Margin = new Padding(2);
            txtName_billing.Name = "txtName_billing";
            txtName_billing.Size = new Size(230, 34);
            txtName_billing.TabIndex = 23;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.Location = new Point(151, 71);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(94, 32);
            label1.TabIndex = 22;
            label1.Text = "Họ Tên";
            // 
            // txtDuration_billing
            // 
            txtDuration_billing.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDuration_billing.Location = new Point(463, 116);
            txtDuration_billing.Margin = new Padding(2);
            txtDuration_billing.Name = "txtDuration_billing";
            txtDuration_billing.Size = new Size(235, 34);
            txtDuration_billing.TabIndex = 39;
            // 
            // frm_billing
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1690, 670);
            Controls.Add(txtDuration_billing);
            Controls.Add(dgvBilling);
            Controls.Add(label8);
            Controls.Add(btnDel_billing);
            Controls.Add(btnEdit_billing);
            Controls.Add(label6);
            Controls.Add(txtGoal_billing);
            Controls.Add(label7);
            Controls.Add(txtCost_billing);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(btnSave_billing);
            Controls.Add(txtName_billing);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "frm_billing";
            Text = "Billing";
            ((System.ComponentModel.ISupportInitialize)dgvBilling).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvBilling;
        private Label label8;
        private Button btnDel_billing;
        private Button btnEdit_billing;
        private Label label6;
        private TextBox txtGoal_billing;
        private Label label7;
        private TextBox txtCost_billing;
        private Label label4;
        private Label label2;
        private Button btnSave_billing;
        private TextBox txtName_billing;
        private Label label1;
       
        private TextBox txtDuration_billing;
    }
}