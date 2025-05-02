using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using TransferObject;

namespace Gym_Management_System
{
    public partial class frm_receptionists : Form
    {
        private ReceptionistsBL receptionistsBL;
        public frm_receptionists()
            {
                InitializeComponent();
                receptionistsBL = new ReceptionistsBL();
            }
        public void load_receptionists()
        {
            try
            {
                dgvLetan.DataSource = new ReceptionistsBL().GetReceptionists();
                // Sắp xếp thứ tự các cột
                dgvLetan.Columns["ID"].DisplayIndex = 0;
                dgvLetan.Columns["name_letan"].DisplayIndex = 1;
                dgvLetan.Columns["Gender"].DisplayIndex = 2;
                dgvLetan.Columns["DayOfBirth"].DisplayIndex = 3;
                dgvLetan.Columns["PhoneNumber"].DisplayIndex = 4;
                dgvLetan.Columns["Password"].DisplayIndex = 5;
                dgvLetan.Columns["Address"].DisplayIndex = 6;
                // Đặt màu chữ
                dgvLetan.DefaultCellStyle.ForeColor = Color.Black;
            }
            catch (Exception)
            {
                throw;
            }
        }
        private void btnSave_letan_Click(object sender, EventArgs e)
        {
            string name, gen, dob, phone, pass, address;
            string role = "";
            int id = 0;
            name = txtName_letan.Text;
            gen = cbGen_letan.Text;
            dob = dtpDateOfBirth_letan.Text;
            phone = txtPhone_letan.Text;
            pass = txtPass_letan.Text;
            address = txtAddress_letan.Text;
            if (string.IsNullOrWhiteSpace(txtName_letan.Text) ||
                string.IsNullOrWhiteSpace(cbGen_letan.Text) ||
                string.IsNullOrWhiteSpace(dtpDateOfBirth_letan.Text) ||
                string.IsNullOrWhiteSpace(txtPhone_letan.Text) ||
                string.IsNullOrWhiteSpace(txtPass_letan.Text) ||
                string.IsNullOrWhiteSpace(txtAddress_letan.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin !");
                return;
            }
            if (!Regex.IsMatch(phone, @"^\d{10}$"))
            {
                MessageBox.Show("Số điện thoại không hợp lệ !");
                return;
            }
            Receptionist receptionist = new Receptionist(id, name, dob, gen, phone, pass, address, role);
            try
            {

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi thêm lễ tân " + ex.Message);
                throw;
            }
            finally
            {
                txtName_letan.Clear();
                txtPhone_letan.Clear();
                txtPass_letan.Clear();
                txtAddress_letan.Clear();
            }
        }
        private void btnDel_letan_Click(object sender, EventArgs e)
        {
            if (dgvLetan.SelectedRows.Count > 0)
            {
                int id = (int)dgvLetan.SelectedRows[0].Cells["ID"].Value;
                try
                {
                    receptionistsBL.DeleteReceptionist(id);
                    MessageBox.Show("Xóa lễ tân thành công !");
                    load_receptionists();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Lỗi xóa lễ tân: " + ex.Message);
                    throw;
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn lễ tân để xóa !");
            }
        }
        private void btnEdit_letan_Click(object sender, EventArgs e)
        {
            if (dgvLetan.SelectedRows != null && !dgvLetan.CurrentRow.IsNewRow)
            {
                int id = (int)dgvLetan.CurrentRow.Cells["ID"].Value;
                string name = (string)dgvLetan.CurrentRow.Cells["nam_letan"].Value;
                string gen = (string)dgvLetan.CurrentRow.Cells["Gender"].Value;
                string dob = (string)dgvLetan.CurrentRow.Cells["DayOfBirth"].Value;
                string phone = (string)dgvLetan.CurrentRow.Cells["PhoneNumber"].Value;
                string pass = (string)dgvLetan.CurrentRow.Cells["Password"].Value;
                string address = (string)dgvLetan.CurrentRow.Cells["Address"].Value;
            }
        }

        private void frm_receptionists_Load(object sender, EventArgs e)
        {

        }
    }
}
