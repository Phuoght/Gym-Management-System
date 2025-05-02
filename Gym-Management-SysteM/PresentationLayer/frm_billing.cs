using BusinessLayer;
using DataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TransferObject;

namespace Gym_Management_System
{
    public partial class frm_billing : Form
    {
        private BillingBL billingBL;
        public frm_billing()
        {
            InitializeComponent();
            billingBL = new BillingBL();
        }

        public void load_billing()
        {
            try
            {
                dgvBilling.DataSource = new BillingBL().GetBillings();
                // Sắp xếp thứ tự các cột
                dgvBilling.Columns["ID"].DisplayIndex = 0;
                dgvBilling.Columns["NameMembership"].DisplayIndex = 1;
                dgvBilling.Columns["Duration"].DisplayIndex = 2;
                dgvBilling.Columns["Goal"].DisplayIndex = 3;
                dgvBilling.Columns["Cost"].DisplayIndex = 4;
                // Đặt màu chữ
                dgvBilling.DefaultCellStyle.ForeColor = Color.Black;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void frm_billing_Load(object sender, EventArgs e)
        {
            load_billing();
        }

        private void btnSave_billing_Click(object sender, EventArgs e)
        {
            string name, goal;
            int duration, cost;
            name = txtName_billing.Text;
            duration = int.Parse(txtDuration_billing.Text);
            goal = txtGoal_billing.Text;
            cost = int.Parse(txtCost_billing.Text);
            if (string.IsNullOrWhiteSpace(txtName_billing.Text) ||
                string.IsNullOrWhiteSpace(txtDuration_billing.Text) ||
                string.IsNullOrWhiteSpace(txtGoal_billing.Text) ||
                string.IsNullOrWhiteSpace(txtCost_billing.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin !");
                return;
            }
            if (!int.TryParse(txtDuration_billing.Text, out duration) || duration <= 0)
            {
                MessageBox.Show("Thời lượng không hợp lệ !");
                return;
            }
            if (!int.TryParse(txtCost_billing.Text, out cost) || cost <= 0)
            {
                MessageBox.Show("Giá không hợp lệ !");
                return;
            }
            Billing billing = new Billing(name, duration, goal, cost);
            try
            {

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi thêm thanh toán: " + ex.Message);
                throw;
            }
            finally
            {
                txtName_billing.Clear();
                txtDuration_billing.Clear();
                txtGoal_billing.Clear();
                txtCost_billing.Clear();
            }
        }

        private void btnDel_billing_Click(object sender, EventArgs e)
        {
            if (dgvBilling.SelectedRows.Count > 0)
            {
                int id = (int)dgvBilling.SelectedRows[0].Cells["ID"].Value;
                try
                {
                    billingBL.DeleteBilling(id);
                    MessageBox.Show("Xóa thanh toán thành công !");
                    load_billing();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Lỗi xóa thanh toán: " + ex.Message);
                    throw;
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn bill để xóa !");
            }
        }

        private void btnEdit_billing_Click(object sender, EventArgs e)
        {
            if (dgvBilling.SelectedRows != null && !dgvBilling.CurrentRow.IsNewRow)
            {
                int id = (int)dgvBilling.CurrentRow.Cells["ID"].Value;
                string name = (string)dgvBilling.CurrentRow.Cells["NameMembership"].Value;
                string duration = (string)dgvBilling.CurrentRow.Cells["Duration"].Value;
                string goal = (string)dgvBilling.CurrentRow.Cells["Goal"].Value;
                string cost = (string)dgvBilling.CurrentRow.Cells["Cost"].Value;
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
