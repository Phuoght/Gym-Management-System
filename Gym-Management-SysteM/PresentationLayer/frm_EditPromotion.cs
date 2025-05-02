using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
using TransferObject;
using System.Data.SqlClient;

namespace Gym_Management_System
{
    public partial class frm_EditPromotion : Form
    {
        private string code;
        private PromotionBL promotionBL;
        public frm_EditPromotion(string code, string discount, string describe, DateTime startDate, DateTime endDate)
        {
            InitializeComponent();
            this.code = code;
            this.cbDiscount.Text = discount;
            this.txtDescribe.Text = describe;
            this.dtpStartDate.Value = startDate;
            this.dtpEndDate.Value = endDate;
            promotionBL = new PromotionBL();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string discount, describe;
            DateTime startDate, endDate;
            if (string.IsNullOrWhiteSpace(txtDescribe.Text) ||
                cbDiscount.SelectedIndex == -1
                )
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin !");
                return;
            }
            discount = cbDiscount.Text;
            describe = txtDescribe.Text;
            startDate = dtpStartDate.Value;
            endDate = dtpEndDate.Value;
            if (endDate < startDate)
            {
                MessageBox.Show("Ngày kết thúc không được nhỏ hơn ngày bắt đầu !");
                return;
            }
            try
            {
                Promotion promotion = new Promotion(code, discount, describe, startDate, endDate);
                promotionBL.EditPromotion(promotion);
                MessageBox.Show("Cập nhật khuyến mãi thành công !");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
    }
}
