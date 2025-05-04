using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TransferObject;
using Microsoft.Data.SqlClient;
using BusinessLayer;

namespace Gym_Management_System
{
    public partial class frm_login : Form
    {
        private LoginBL loginBL;
        public string userRole { get; set; }
        public string name { get; set; }
        public frm_login()
        {
            InitializeComponent();
            loginBL = new LoginBL();
            this.KeyPreview = true;
            userRole = "";
            name = "";
        }
        private bool checkLogin(Receptionist receptionist)
        {
            try
            {
                return (loginBL.checkLogin(receptionist));
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }

        private void loginClick()
        {
            string userName, passWord;
            userName = txtUserName.Text;
            passWord = txtPwd.Text;
            Receptionist receptionist;
            if (userName == "admin")
            {
                receptionist = new Receptionist(userName, DateTime.Now, "", "", "", passWord, "admin");
            }
            else
            {
                receptionist = new Receptionist(userName, DateTime.Now, "", "", "", passWord, "lễ tân");

            }
            if (checkLogin(receptionist))
            {
                userRole = receptionist.Role;
                name = receptionist.Name;
                this.Enabled = false;
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                string msg = "Tài khoản hoặc mật khẩu không đúng!";
                DialogResult result = MessageBox.Show(msg, "Đăng nhập", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                if (result == DialogResult.Cancel)
                {
                    Application.Exit();
                }
                else
                {
                    txtUserName.Text = "";
                    txtPwd.Text = "";
                    txtUserName.Focus();
                }
            }
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            loginClick();
        }

        private void frm_login_Shown(object sender, EventArgs e)
        {
            txtUserName.Focus();
        }

        private void frm_login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                loginClick();
                e.SuppressKeyPress = true;
            }
        }
    }
}
