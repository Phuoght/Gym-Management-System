namespace Gym_Management_System
{
    partial class frm_revenue
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            label6 = new Label();
            cbAmount = new ComboBox();
            label7 = new Label();
            btnSave = new Button();
            dgvEquipment = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            nameEquipment = new DataGridViewTextBoxColumn();
            type = new DataGridViewTextBoxColumn();
            amount = new DataGridViewTextBoxColumn();
            statusEquipment = new DataGridViewTextBoxColumn();
            lastMaintain = new DataGridViewTextBoxColumn();
            nextMaintain = new DataGridViewTextBoxColumn();
            label8 = new Label();
            label1 = new Label();
            lbTotalRevenue = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvEquipment).BeginInit();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Black", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Red;
            label6.Location = new Point(580, 19);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(405, 54);
            label6.TabIndex = 35;
            label6.Text = "Báo Cáo Doanh Thu";
            // 
            // cbAmount
            // 
            cbAmount.DropDownStyle = ComboBoxStyle.DropDownList;
            cbAmount.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbAmount.FormattingEnabled = true;
            cbAmount.Items.AddRange(new object[] { "Ngày", "Tháng", "Quý", "Năm" });
            cbAmount.Location = new Point(670, 125);
            cbAmount.Margin = new Padding(2);
            cbAmount.Name = "cbAmount";
            cbAmount.Size = new Size(182, 40);
            cbAmount.TabIndex = 46;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label7.Location = new Point(432, 125);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(197, 38);
            label7.TabIndex = 45;
            label7.Text = "Báo Cáo Theo";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Red;
            btnSave.Cursor = Cursors.Hand;
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = SystemColors.ButtonFace;
            btnSave.Location = new Point(913, 120);
            btnSave.Margin = new Padding(2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(194, 52);
            btnSave.TabIndex = 47;
            btnSave.Text = "Xuất Báo Cáo";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // dgvEquipment
            // 
            dgvEquipment.BackgroundColor = Color.IndianRed;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.Red;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.Yellow;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvEquipment.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvEquipment.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEquipment.Columns.AddRange(new DataGridViewColumn[] { ID, nameEquipment, type, amount, statusEquipment, lastMaintain, nextMaintain });
            dgvEquipment.Cursor = Cursors.Hand;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = Color.LightGray;
            dataGridViewCellStyle6.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlDarkDark;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvEquipment.DefaultCellStyle = dataGridViewCellStyle6;
            dgvEquipment.Location = new Point(11, 261);
            dgvEquipment.Margin = new Padding(2);
            dgvEquipment.MultiSelect = false;
            dgvEquipment.Name = "dgvEquipment";
            dgvEquipment.RowHeadersWidth = 62;
            dgvEquipment.Size = new Size(1465, 387);
            dgvEquipment.TabIndex = 49;
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
            dataGridViewCellStyle5.NullValue = null;
            lastMaintain.DefaultCellStyle = dataGridViewCellStyle5;
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
            label8.Location = new Point(656, 206);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(267, 45);
            label8.TabIndex = 48;
            label8.Text = "Báo Cáo Chi Tiết";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.Location = new Point(473, 706);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(245, 38);
            label1.TabIndex = 50;
            label1.Text = "Tổng Doanh Thu:";
            // 
            // lbTotalRevenue
            // 
            lbTotalRevenue.AutoSize = true;
            lbTotalRevenue.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lbTotalRevenue.ForeColor = Color.Red;
            lbTotalRevenue.Location = new Point(722, 706);
            lbTotalRevenue.Margin = new Padding(2, 0, 2, 0);
            lbTotalRevenue.Name = "lbTotalRevenue";
            lbTotalRevenue.Size = new Size(245, 38);
            lbTotalRevenue.TabIndex = 51;
            lbTotalRevenue.Text = "Tổng Doanh Thu:";
            // 
            // frm_revenue
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1590, 850);
            Controls.Add(lbTotalRevenue);
            Controls.Add(label1);
            Controls.Add(dgvEquipment);
            Controls.Add(label8);
            Controls.Add(btnSave);
            Controls.Add(cbAmount);
            Controls.Add(label7);
            Controls.Add(label6);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frm_revenue";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frm_revenue";
            ((System.ComponentModel.ISupportInitialize)dgvEquipment).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private ComboBox cbAmount;
        private Label label7;
        private Button btnSave;
        private DataGridView dgvEquipment;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn nameEquipment;
        private DataGridViewTextBoxColumn type;
        private DataGridViewTextBoxColumn amount;
        private DataGridViewTextBoxColumn statusEquipment;
        private DataGridViewTextBoxColumn lastMaintain;
        private DataGridViewTextBoxColumn nextMaintain;
        private Label label8;
        private Label label1;
        private Label lbTotalRevenue;
    }
}