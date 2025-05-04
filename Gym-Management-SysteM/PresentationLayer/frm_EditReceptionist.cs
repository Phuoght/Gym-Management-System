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

<<<<<<< HEAD:Gym-Management-SysteM/PresentationLayer/frm_EditReceptionists.cs
        public frm_EditReceptionists(int id, string name, string gender, DateTime dob, string phone,
=======
        public frm_EditReceptionist(int id, string name, string gender, DateTime dob, string phone,
>>>>>>> 0592495a75859ce27d44a5870e0ae5ca274c7370:Gym-Management-SysteM/PresentationLayer/frm_EditReceptionist.cs
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

        private void btnEdit_save_Click_1(object sender, EventArgs e)
        {
            string name, gender, phone, pass, address;
<<<<<<< HEAD:Gym-Management-SysteM/PresentationLayer/frm_EditReceptionists.cs
            DateTime dob;
=======
            int id = 0;
            DateTime dob;
            string role = "";
>>>>>>> 0592495a75859ce27d44a5870e0ae5ca274c7370:Gym-Management-SysteM/PresentationLayer/frm_EditReceptionist.cs
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
            Receptionist receptionist = new Receptionist(id, name, dob, phone, address, gender, pass, "");
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
