using BusinessLayer;
using DataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using TransferObject;

namespace Gym_Management_System
{
    public partial class frm_receptionist : Form
    {
        private ReceptionistBL receptionistBL;
        public frm_receptionist()
        {
            InitializeComponent();
            receptionistBL = new ReceptionistBL();
        }
        public void load_receptionist()
        {
            try
            {
                dgvLetan.AutoGenerateColumns = false;
                dgvLetan.DataSource = receptionistBL.GetReceptionists();

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
            string name, gender, phone, pass, address;
            string role = "";
            DateTime dob;
            name = txtName_letan.Text;
            gender = cbGen_letan.Text;
            dob = dtpDateOfBirth_letan.Value;
            phone = txtPhone_letan.Text;
            pass = txtPass_letan.Text;
            address = txtAddress_letan.Text;
            if (string.IsNullOrWhiteSpace(txtName_letan.Text) ||
                string.IsNullOrWhiteSpace(txtPhone_letan.Text) ||
                string.IsNullOrWhiteSpace(txtAddress_letan.Text) ||
                string.IsNullOrWhiteSpace(txtPass_letan.Text) ||
                cbGen_letan.SelectedIndex == -1
                )
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin !");
                return;
            }
            if (!Regex.IsMatch(phone, @"^\d{10}$"))
            {
                MessageBox.Show("Số điện thoại không hợp lệ !");
                return;
            }

            Receptionist receptionist = new Receptionist(name, gender, dob, phone, pass, address, role);
            try
            {
                receptionistBL.AddReceptionist(receptionist);
                MessageBox.Show("Thêm thông tin lễ tân thành công !");
                load_receptionist();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi thêm thông tin lễ tân " + ex.Message);
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
                    receptionistBL.DeleteReceptionist(id);
                    MessageBox.Show("Xóa thông tin lễ tân thành công !");
                    load_receptionist();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Lỗi xóa thông tin lễ tân: " + ex.Message);
                    throw;
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn thông tin lễ tân cần xóa !");
            }
        }
        private void btnEdit_letan_Click(object sender, EventArgs e)
        {
            if (dgvLetan.SelectedRows != null && dgvLetan.CurrentRow != null)
            {
                int id = (int)dgvLetan.CurrentRow.Cells["ID"].Value;
                string name = (string)dgvLetan.CurrentRow.Cells["Name"].Value;
                string gender = (string)dgvLetan.CurrentRow.Cells["Gender"].Value;
                DateTime dob = Convert.ToDateTime(dgvLetan.CurrentRow.Cells[3].Value);
                string phone = (string)dgvLetan.CurrentRow.Cells["PhoneNumber"].Value;
                string pass = (string)dgvLetan.CurrentRow.Cells["Password"].Value;
                string address = (string)dgvLetan.CurrentRow.Cells["Address"].Value;
                string role = (string)dgvLetan.CurrentRow.Cells["Role"].Value;

                frm_EditReceptionist frmEditReceptionists = new frm_EditReceptionist(id, name, gender, dob, phone, pass, address, role);

                if (frmEditReceptionists.ShowDialog() == DialogResult.OK)
                {
                    load_receptionist();
                }
            }
        }
        private void frm_receptionists_Load(object sender, EventArgs e)
        {
            load_receptionist();
        }

        private void btnEdit_letan_Click_1(object sender, EventArgs e)
        {

        }
    }
}
