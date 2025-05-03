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
            label6 = new Label();
            label7 = new Label();
            label4 = new Label();
            label2 = new Label();
            btnConfirm = new Button();
            label1 = new Label();
            label3 = new Label();
            label5 = new Label();
            lbTotal = new Label();
            lbDate = new Label();
            lbCost = new Label();
            lbMember = new Label();
            lbReceptionist = new Label();
            txtPromotion = new TextBox();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Black", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Red;
            label6.Location = new Point(397, 9);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(253, 54);
            label6.TabIndex = 34;
            label6.Text = "Thanh Toán";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label7.Location = new Point(249, 247);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(140, 38);
            label7.TabIndex = 32;
            label7.Text = "Ngày Lập";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label4.Location = new Point(255, 322);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(119, 38);
            label4.TabIndex = 29;
            label4.Text = "Giá tiền";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label2.Location = new Point(234, 174);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(166, 38);
            label2.TabIndex = 26;
            label2.Text = "Thành Viên";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnConfirm
            // 
            btnConfirm.BackColor = Color.Red;
            btnConfirm.Cursor = Cursors.Hand;
            btnConfirm.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfirm.ForeColor = SystemColors.ButtonFace;
            btnConfirm.Location = new Point(422, 561);
            btnConfirm.Margin = new Padding(2);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(191, 58);
            btnConfirm.TabIndex = 25;
            btnConfirm.Text = "Xác Nhận";
            btnConfirm.UseVisualStyleBackColor = false;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.Location = new Point(234, 106);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(155, 38);
            label1.TabIndex = 22;
            label1.Text = "Người Lập";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label3.Location = new Point(229, 396);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(187, 38);
            label3.TabIndex = 35;
            label3.Text = "Mã Giảm Giá";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label5.Location = new Point(208, 467);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(244, 38);
            label5.TabIndex = 36;
            label5.Text = "Tổng Thanh Toán";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbTotal
            // 
            lbTotal.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lbTotal.ForeColor = Color.LightCoral;
            lbTotal.Location = new Point(454, 467);
            lbTotal.Margin = new Padding(2, 0, 2, 0);
            lbTotal.Name = "lbTotal";
            lbTotal.Size = new Size(566, 38);
            lbTotal.TabIndex = 42;
            lbTotal.Text = "Tổng Thanh Toán";
            lbTotal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbDate
            // 
            lbDate.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lbDate.ForeColor = Color.LightCoral;
            lbDate.Location = new Point(495, 247);
            lbDate.Margin = new Padding(2, 0, 2, 0);
            lbDate.Name = "lbDate";
            lbDate.Size = new Size(462, 38);
            lbDate.TabIndex = 40;
            lbDate.Text = "Ngày Lập";
            lbDate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbCost
            // 
            lbCost.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lbCost.ForeColor = Color.LightCoral;
            lbCost.Location = new Point(501, 322);
            lbCost.Margin = new Padding(2, 0, 2, 0);
            lbCost.Name = "lbCost";
            lbCost.Size = new Size(441, 38);
            lbCost.TabIndex = 39;
            lbCost.Text = "Giá tiền";
            lbCost.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbMember
            // 
            lbMember.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lbMember.ForeColor = Color.LightCoral;
            lbMember.Location = new Point(480, 174);
            lbMember.Margin = new Padding(2, 0, 2, 0);
            lbMember.Name = "lbMember";
            lbMember.Size = new Size(488, 38);
            lbMember.TabIndex = 38;
            lbMember.Text = "Thành Viên";
            lbMember.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbReceptionist
            // 
            lbReceptionist.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lbReceptionist.ForeColor = Color.LightCoral;
            lbReceptionist.Location = new Point(480, 106);
            lbReceptionist.Margin = new Padding(2, 0, 2, 0);
            lbReceptionist.Name = "lbReceptionist";
            lbReceptionist.Size = new Size(477, 38);
            lbReceptionist.TabIndex = 37;
            lbReceptionist.Text = "Người Lập";
            lbReceptionist.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtPromotion
            // 
            txtPromotion.Location = new Point(637, 396);
            txtPromotion.Name = "txtPromotion";
            txtPromotion.Size = new Size(181, 39);
            txtPromotion.TabIndex = 43;
            // 
            // frm_billing
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1141, 670);
            Controls.Add(txtPromotion);
            Controls.Add(lbTotal);
            Controls.Add(lbDate);
            Controls.Add(lbCost);
            Controls.Add(lbMember);
            Controls.Add(lbReceptionist);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(btnConfirm);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "frm_billing";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thanh Toán";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label6;
        private Label label7;
        private Label label4;
        private Label label2;
        private Button btnConfirm;
        private Label label1;
        private Label label3;
        private Label label5;
        private Label lbTotal;
        private Label lbDate;
        private Label lbCost;
        private Label lbMember;
        private Label lbReceptionist;
        private TextBox txtPromotion;
    }
}