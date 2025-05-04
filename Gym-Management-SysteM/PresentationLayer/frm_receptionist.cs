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
<<<<<<< HEAD:Gym-Management-SysteM/PresentationLayer/frm_receptionists.cs
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
                dgvLetan.DataSource = receptionistsBL.GetReceptionists();
                dgvLetan.AutoGenerateColumns = false;
=======
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
>>>>>>> 0592495a75859ce27d44a5870e0ae5ca274c7370:Gym-Management-SysteM/PresentationLayer/frm_receptionist.cs
            }
            catch (Exception)
            {
                throw;
            }
        }
        private void frm_receptionists_Load(object sender, EventArgs e)
        {
<<<<<<< HEAD:Gym-Management-SysteM/PresentationLayer/frm_receptionists.cs
            load_receptionists();
            dtpDateOfBirth_letan.MaxDate = DateTime.Now;
        }

        private void btnSave_letan_Click_1(object sender, EventArgs e)
        {
=======
>>>>>>> 0592495a75859ce27d44a5870e0ae5ca274c7370:Gym-Management-SysteM/PresentationLayer/frm_receptionist.cs
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

<<<<<<< HEAD:Gym-Management-SysteM/PresentationLayer/frm_receptionists.cs
            Receptionist receptionist = new Receptionist(name, dob, phone, address, gender, pass, role);
=======
            Receptionist receptionist = new Receptionist(name, gender, dob, phone, pass, address, role);
>>>>>>> 0592495a75859ce27d44a5870e0ae5ca274c7370:Gym-Management-SysteM/PresentationLayer/frm_receptionist.cs
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
                cbGen_letan.SelectedIndex = -1;
            }
        }

        private void btnEdit_letan_Click(object sender, EventArgs e)
        {
            if (dgvLetan.SelectedRows != null && dgvLetan.CurrentRow != null)
            {
                int id = (int)dgvLetan.CurrentRow.Cells["ID"].Value;
                string name = (string)dgvLetan.CurrentRow.Cells["Name"].Value;
                string gender = (string)dgvLetan.CurrentRow.Cells["Gen"].Value;
                DateTime dob = Convert.ToDateTime(dgvLetan.CurrentRow.Cells["DOB"].Value);
                string phone = (string)dgvLetan.CurrentRow.Cells["Phone"].Value;
                string pass = (string)dgvLetan.CurrentRow.Cells["PassWord"].Value;
                string address = (string)dgvLetan.CurrentRow.Cells["Address"].Value;
                string role = (string)dgvLetan.CurrentRow.Cells["Role"].Value;

                frm_EditReceptionists frmEditReceptionists = new frm_EditReceptionists(id, name, gender, dob, phone, pass, address, role);
                frmEditReceptionists.ShowDialog();
                if (frmEditReceptionists.DialogResult == DialogResult.OK)
                {
                    load_receptionists();
                }
            }
        }

        private void btnDel_letan_Click_1(object sender, EventArgs e)
        {
            if (dgvLetan.CurrentRow != null && !dgvLetan.CurrentRow.IsNewRow)
            {
                int id = (int)dgvLetan.CurrentRow.Cells["ID"].Value;
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
<<<<<<< HEAD:Gym-Management-SysteM/PresentationLayer/frm_receptionists.cs
=======
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
>>>>>>> 0592495a75859ce27d44a5870e0ae5ca274c7370:Gym-Management-SysteM/PresentationLayer/frm_receptionist.cs
    }
}
