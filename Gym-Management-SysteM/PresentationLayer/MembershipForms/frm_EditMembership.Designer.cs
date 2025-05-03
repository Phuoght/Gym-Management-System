namespace Gym_Management_System
{
    partial class frm_EditMembership
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
            if(disposing && (components != null))
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
            label7 = new Label();
            txt_membership_NameE = new TextBox();
            label1 = new Label();
            txt_membership_GoalE = new TextBox();
            label2 = new Label();
            txt_membership_DurationE = new TextBox();
            label3 = new Label();
            txt_membership_CostE = new TextBox();
            label4 = new Label();
            btn_membership_SaveE = new Button();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI",18F,FontStyle.Bold,GraphicsUnit.Point,0);
            label7.ForeColor = Color.Red;
            label7.Location = new Point(279,9);
            label7.Margin = new Padding(2,0,2,0);
            label7.Name = "label7";
            label7.Size = new Size(424,41);
            label7.TabIndex = 14;
            label7.Text = "Chỉnh Sửa Thông Tin Gói tập";
            // 
            // txt_membership_NameE
            // 
            txt_membership_NameE.Font = new Font("Segoe UI",12F,FontStyle.Regular,GraphicsUnit.Point,0);
            txt_membership_NameE.Location = new Point(156,132);
            txt_membership_NameE.Margin = new Padding(2);
            txt_membership_NameE.Name = "txt_membership_NameE";
            txt_membership_NameE.Size = new Size(244,34);
            txt_membership_NameE.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black",14F,FontStyle.Bold,GraphicsUnit.Point,0);
            label1.Location = new Point(18,131);
            label1.Margin = new Padding(2,0,2,0);
            label1.Name = "label1";
            label1.Size = new Size(101,32);
            label1.TabIndex = 15;
            label1.Text = "Tên gói";
            // 
            // txt_membership_GoalE
            // 
            txt_membership_GoalE.Font = new Font("Segoe UI",12F,FontStyle.Regular,GraphicsUnit.Point,0);
            txt_membership_GoalE.Location = new Point(156,258);
            txt_membership_GoalE.Margin = new Padding(2);
            txt_membership_GoalE.Name = "txt_membership_GoalE";
            txt_membership_GoalE.Size = new Size(244,34);
            txt_membership_GoalE.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black",14F,FontStyle.Bold,GraphicsUnit.Point,0);
            label2.Location = new Point(18,258);
            label2.Margin = new Padding(2,0,2,0);
            label2.Name = "label2";
            label2.Size = new Size(117,32);
            label2.TabIndex = 17;
            label2.Text = "Mục tiêu";
            // 
            // txt_membership_DurationE
            // 
            txt_membership_DurationE.Font = new Font("Segoe UI",12F,FontStyle.Regular,GraphicsUnit.Point,0);
            txt_membership_DurationE.Location = new Point(708,131);
            txt_membership_DurationE.Margin = new Padding(2);
            txt_membership_DurationE.Name = "txt_membership_DurationE";
            txt_membership_DurationE.Size = new Size(244,34);
            txt_membership_DurationE.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black",14F,FontStyle.Bold,GraphicsUnit.Point,0);
            label3.Location = new Point(594,132);
            label3.Margin = new Padding(2,0,2,0);
            label3.Name = "label3";
            label3.Size = new Size(116,32);
            label3.TabIndex = 19;
            label3.Text = "Thời hạn";
            // 
            // txt_membership_CostE
            // 
            txt_membership_CostE.Font = new Font("Segoe UI",12F,FontStyle.Regular,GraphicsUnit.Point,0);
            txt_membership_CostE.Location = new Point(708,256);
            txt_membership_CostE.Margin = new Padding(2);
            txt_membership_CostE.Name = "txt_membership_CostE";
            txt_membership_CostE.Size = new Size(244,34);
            txt_membership_CostE.TabIndex = 22;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black",14F,FontStyle.Bold,GraphicsUnit.Point,0);
            label4.Location = new Point(594,257);
            label4.Margin = new Padding(2,0,2,0);
            label4.Name = "label4";
            label4.Size = new Size(51,32);
            label4.TabIndex = 21;
            label4.Text = "Giá";
            // 
            // btn_membership_SaveE
            // 
            btn_membership_SaveE.BackColor = Color.Red;
            btn_membership_SaveE.Cursor = Cursors.Hand;
            btn_membership_SaveE.Font = new Font("Segoe UI",12F,FontStyle.Bold,GraphicsUnit.Point,0);
            btn_membership_SaveE.ForeColor = SystemColors.ButtonFace;
            btn_membership_SaveE.Location = new Point(445,352);
            btn_membership_SaveE.Margin = new Padding(2);
            btn_membership_SaveE.Name = "btn_membership_SaveE";
            btn_membership_SaveE.Size = new Size(118,42);
            btn_membership_SaveE.TabIndex = 23;
            btn_membership_SaveE.Text = "Lưu";
            btn_membership_SaveE.UseVisualStyleBackColor = false;
            btn_membership_SaveE.Click += btn_membership_SaveE_Click;
            // 
            // frm_EditMembership
            // 
            AutoScaleDimensions = new SizeF(8F,20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1041,416);
            Controls.Add(btn_membership_SaveE);
            Controls.Add(txt_membership_CostE);
            Controls.Add(label4);
            Controls.Add(txt_membership_DurationE);
            Controls.Add(label3);
            Controls.Add(txt_membership_GoalE);
            Controls.Add(label2);
            Controls.Add(txt_membership_NameE);
            Controls.Add(label1);
            Controls.Add(label7);
            Name = "frm_EditMembership";
            Text = "frm_EditMembership";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private TextBox txt_membership_NameE;
        private Label label1;
        private TextBox txt_membership_GoalE;
        private Label label2;
        private TextBox txt_membership_DurationE;
        private Label label3;
        private TextBox txt_membership_CostE;
        private Label label4;
        private Button btn_membership_SaveE;
    }
}