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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            label6 = new Label();
            label7 = new Label();
            btnPrint = new Button();
            dgvReport = new DataGridView();
            label8 = new Label();
            lbTotalRevenue = new Label();
            dtpStartDate = new DateTimePicker();
            dtpEndDate = new DateTimePicker();
            label2 = new Label();
            ID = new DataGridViewTextBoxColumn();
            receptionist = new DataGridViewComboBoxColumn();
            member = new DataGridViewComboBoxColumn();
            date = new DataGridViewTextBoxColumn();
            cost = new DataGridViewTextBoxColumn();
            promotionID = new DataGridViewTextBoxColumn();
            total = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvReport).BeginInit();
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
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label7.Location = new Point(443, 112);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(52, 38);
            label7.TabIndex = 45;
            label7.Text = "Từ";
            // 
            // btnPrint
            // 
            btnPrint.BackColor = Color.Red;
            btnPrint.Cursor = Cursors.Hand;
            btnPrint.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPrint.ForeColor = SystemColors.ButtonFace;
            btnPrint.Location = new Point(679, 190);
            btnPrint.Margin = new Padding(2);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(194, 52);
            btnPrint.TabIndex = 47;
            btnPrint.Text = "Xuất Báo Cáo";
            btnPrint.UseVisualStyleBackColor = false;
            btnPrint.Click += btnPrint_Click;
            // 
            // dgvReport
            // 
            dgvReport.BackgroundColor = Color.IndianRed;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.Red;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Yellow;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvReport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReport.Columns.AddRange(new DataGridViewColumn[] { ID, receptionist, member, date, cost, promotionID, total });
            dgvReport.Cursor = Cursors.Hand;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.LightGray;
            dataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlDarkDark;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvReport.DefaultCellStyle = dataGridViewCellStyle3;
            dgvReport.Location = new Point(61, 346);
            dgvReport.Margin = new Padding(2);
            dgvReport.MultiSelect = false;
            dgvReport.Name = "dgvReport";
            dgvReport.RowHeadersWidth = 62;
            dgvReport.Size = new Size(1444, 418);
            dgvReport.TabIndex = 49;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Red;
            label8.Location = new Point(659, 273);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(267, 45);
            label8.TabIndex = 48;
            label8.Text = "Báo Cáo Chi Tiết";
            // 
            // lbTotalRevenue
            // 
            lbTotalRevenue.AutoSize = true;
            lbTotalRevenue.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTotalRevenue.ForeColor = Color.Red;
            lbTotalRevenue.Location = new Point(514, 783);
            lbTotalRevenue.Margin = new Padding(2, 0, 2, 0);
            lbTotalRevenue.Name = "lbTotalRevenue";
            lbTotalRevenue.Size = new Size(0, 45);
            lbTotalRevenue.TabIndex = 51;
            // 
            // dtpStartDate
            // 
            dtpStartDate.CalendarMonthBackground = Color.White;
            dtpStartDate.Cursor = Cursors.Hand;
            dtpStartDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpStartDate.Format = DateTimePickerFormat.Short;
            dtpStartDate.Location = new Point(530, 112);
            dtpStartDate.Margin = new Padding(2);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(202, 39);
            dtpStartDate.TabIndex = 77;
            // 
            // dtpEndDate
            // 
            dtpEndDate.CalendarMonthBackground = Color.White;
            dtpEndDate.Cursor = Cursors.Hand;
            dtpEndDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpEndDate.Format = DateTimePickerFormat.Short;
            dtpEndDate.Location = new Point(935, 112);
            dtpEndDate.Margin = new Padding(2);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(202, 39);
            dtpEndDate.TabIndex = 79;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label2.Location = new Point(844, 112);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(70, 38);
            label2.TabIndex = 78;
            label2.Text = "Đến";
            // 
            // ID
            // 
            ID.DataPropertyName = "id";
            ID.HeaderText = "ID";
            ID.MinimumWidth = 70;
            ID.Name = "ID";
            ID.Width = 70;
            // 
            // receptionist
            // 
            receptionist.DataPropertyName = "receptionist";
            receptionist.HeaderText = "Mã Nhân Viên";
            receptionist.MinimumWidth = 200;
            receptionist.Name = "receptionist";
            receptionist.Resizable = DataGridViewTriState.True;
            receptionist.SortMode = DataGridViewColumnSortMode.Automatic;
            receptionist.Width = 200;
            // 
            // member
            // 
            member.DataPropertyName = "member";
            member.HeaderText = "Mã Thành Viên";
            member.MinimumWidth = 8;
            member.Name = "member";
            member.Resizable = DataGridViewTriState.True;
            member.SortMode = DataGridViewColumnSortMode.Automatic;
            member.Width = 220;
            // 
            // date
            // 
            date.DataPropertyName = "date";
            date.HeaderText = "Ngày Lập";
            date.MinimumWidth = 8;
            date.Name = "date";
            date.Width = 210;
            // 
            // cost
            // 
            cost.DataPropertyName = "cost";
            cost.HeaderText = "Giá Tiền";
            cost.MinimumWidth = 100;
            cost.Name = "cost";
            cost.Width = 200;
            // 
            // promotionID
            // 
            promotionID.DataPropertyName = "promotionID";
            dataGridViewCellStyle2.NullValue = null;
            promotionID.DefaultCellStyle = dataGridViewCellStyle2;
            promotionID.HeaderText = "Mã Giảm Giá";
            promotionID.MinimumWidth = 130;
            promotionID.Name = "promotionID";
            promotionID.Width = 200;
            // 
            // total
            // 
            total.DataPropertyName = "total";
            total.HeaderText = "Tổng";
            total.MinimumWidth = 100;
            total.Name = "total";
            total.Width = 280;
            // 
            // frm_revenue
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1590, 850);
            Controls.Add(dtpEndDate);
            Controls.Add(label2);
            Controls.Add(dtpStartDate);
            Controls.Add(lbTotalRevenue);
            Controls.Add(dgvReport);
            Controls.Add(label8);
            Controls.Add(btnPrint);
            Controls.Add(label7);
            Controls.Add(label6);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frm_revenue";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frm_revenue";
            ((System.ComponentModel.ISupportInitialize)dgvReport).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private Label label7;
        private Button btnPrint;
        private DataGridView dgvReport;
        private Label label8;
        private Label lbTotalRevenue;
        private DateTimePicker dtpStartDate;
        private DateTimePicker dtpEndDate;
        private Label label2;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewComboBoxColumn receptionist;
        private DataGridViewComboBoxColumn member;
        private DataGridViewTextBoxColumn date;
        private DataGridViewTextBoxColumn cost;
        private DataGridViewTextBoxColumn promotionID;
        private DataGridViewTextBoxColumn total;
    }
}