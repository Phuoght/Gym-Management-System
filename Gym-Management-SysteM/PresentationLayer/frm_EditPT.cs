using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using TransferObject;
using BusinessLayer;
using Microsoft.Data.SqlClient;

namespace Gym_Management_System
{
    public partial class frm_EditPT : Form
    {
        private int id;
        private ptBL ptBL;
        public frm_EditPT(int id, string name, string gender, DateTime dob, string phone, string experience, string address)
        {
            ptBL = new ptBL();
            InitializeComponent();
            this.id = id;
            this.txtNameE.Text = name;
            this.cbGenE.Text = gender;
            this.dtpDayOfBirthE.Value = dob;
            this.txtPhoneE.Text = phone;
            this.cbExperienceE.Text = experience;
            this.txtAddressE.Text = address;
        }

        private void btnSaveE_Click(object sender, EventArgs e)
        {
            string name, gender, phone, experience, address;
            DateTime dob;

            name = txtNameE.Text;
            gender = cbGenE.Text;
            dob = dtpDayOfBirthE.Value;
            phone = txtPhoneE.Text;
            experience = cbExperienceE.Text;
            address = txtAddressE.Text;
            if (string.IsNullOrWhiteSpace(txtNameE.Text) ||
                string.IsNullOrWhiteSpace(txtPhoneE.Text) ||
                string.IsNullOrWhiteSpace(txtAddressE.Text) ||
                cbGenE.SelectedIndex == -1 ||
                cbExperienceE.SelectedIndex == -1
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

            PT pt = new PT(id, name, gender, dob, phone, experience, address);
            try
            {
                ptBL.EditPT(pt);
                MessageBox.Show("Sửa PT thành công !");
                this.DialogResult = DialogResult.OK;
                this.Close();
                
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi sửa PT: " + ex.Message);
            }
            finally
            {
                txtNameE.Clear();
                cbGenE.Text = "";
                txtPhoneE.Clear();
                cbExperienceE.Text = "";
                txtAddressE.Clear();
            }

        }
    }
}
