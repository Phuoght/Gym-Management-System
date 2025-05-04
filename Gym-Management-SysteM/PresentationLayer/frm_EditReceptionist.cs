using BusinessLayer;
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
    public partial class frm_EditReceptionist : Form
    {
        private int id;
        private ReceptionistBL receptionistBL;

        public frm_EditReceptionist(int id, string name, string gender, DateTime dob, string phone,
            string pass, string address, string role)
        {
            receptionistBL = new ReceptionistBL();
            InitializeComponent();
            this.id = id;
            this.txtEdit_name.Text = name;
            this.cbEdit_gen.Text = gender;
            this.dtpEdit_dob.Value = dob;
            this.txtEdit_phone.Text = phone;
            this.txtEdit_pass.Text = pass;
            this.txtEdit_address.Text = address;
        }
        private void btnEdit_save_Click(object sender, EventArgs e)
        {
            string name, gender, phone, pass, address;
            int id = 0;
            DateTime dob;
            string role = "";
            name = txtEdit_name.Text;
            gender = cbEdit_gen.Text;
            dob = dtpEdit_dob.Value;
            phone = txtEdit_phone.Text;
            pass = txtEdit_pass.Text;
            address = txtEdit_address.Text;
            if (string.IsNullOrWhiteSpace(txtEdit_name.Text) ||
                string.IsNullOrWhiteSpace(txtEdit_phone.Text) ||
                string.IsNullOrWhiteSpace(txtEdit_address.Text) ||
                string.IsNullOrWhiteSpace(txtEdit_pass.Text) ||
                cbEdit_gen.SelectedIndex == -1
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
            Receptionist receptionist = new Receptionist(id, name, gender, dob, phone, pass, address, role);
            try
            {
                receptionistBL.EditReceptionist(receptionist);
                MessageBox.Show("Sửa lễ tân thành công !");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi sửa lễ tân: " + ex.Message);
            }
        }

    }
}
