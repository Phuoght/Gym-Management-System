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
    public partial class frm_promotion : Form
    {
        private PromotionBL promotionBL;
        public frm_promotion()
        {
            InitializeComponent();
            promotionBL = new PromotionBL();
        }
        private void load_promotion()
        {
            try
            {
                dgvPromotion.DataSource = promotionBL.GetAllPromotions();
                dgvPromotion.AutoGenerateColumns = false;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void frm_promotion_Load(object sender, EventArgs e)
        {
            load_promotion();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string code, describe;
            int discount;
            DateTime startDate, endDate;
            if (string.IsNullOrWhiteSpace(txtCode.Text) ||
                string.IsNullOrWhiteSpace(txtDescribe.Text) ||
                cbDiscount.SelectedIndex == -1
                )
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin !");
                return;
            }
            code = txtCode.Text;
            discount = int.Parse(cbDiscount.Text);
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
                promotionBL.AddPromotion(promotion);
                MessageBox.Show("Thêm mã khuyến mãi thành công !");
                load_promotion();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                txtCode.Clear();
                txtDescribe.Clear();
                cbDiscount.SelectedIndex = -1;
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (dgvPromotion.CurrentRow != null && !dgvPromotion.CurrentRow.IsNewRow)
            {
                string code = dgvPromotion.CurrentRow.Cells["code"].Value.ToString();
                try
                {
                    promotionBL.DeletePromotion(code);
                    MessageBox.Show("Xóa mã khuyến mãi thành công !");
                    load_promotion();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn mã khuyến mãi để xóa !");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvPromotion.CurrentRow != null && !dgvPromotion.CurrentRow.IsNewRow)
                {
                    string code = dgvPromotion.CurrentRow.Cells["code"].Value.ToString();
                    int discount = Convert.ToInt32(dgvPromotion.CurrentRow.Cells["discount"].Value);
                    string describe = dgvPromotion.CurrentRow.Cells["describe"].Value.ToString();
                    DateTime startDate = (DateTime)dgvPromotion.CurrentRow.Cells["startDate"].Value;
                    DateTime endDate = (DateTime)dgvPromotion.CurrentRow.Cells["endDate"].Value;

                    frm_EditPromotion frm_editPromotion = new frm_EditPromotion(code, discount, describe, startDate, endDate);
                    frm_editPromotion.ShowDialog();
                    if (frm_editPromotion.DialogResult == DialogResult.OK)
                    {
                        load_promotion();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
    }
}
