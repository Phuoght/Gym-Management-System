using System.Data;
using System.Windows.Forms;

namespace Gym_Management_System
{
    public partial class frm_Main : Form
    {
        private string role;
        public frm_Main()
        {
            InitializeComponent();
            role = "";
        }
        private void UpdateUI()
        {
            if (role == "admin")
            {
                btnReceptionist.Visible = true;
                ptbReceptionist.Visible = true;
            }
            else
            {
                btnReceptionist.Visible = false;
                ptbReceptionist.Visible = false;
            }
        }
        private void openFormLogin()
        {
            frm_login login = new frm_login();
            DialogResult result = login.ShowDialog();
            if (result == DialogResult.OK)
            {
                role = login.userRole;
                this.Show();
                openForm(new frm_coach());
                UpdateUI();
            }
            else
            {
                Application.Exit();
            }
        }
        private void openForm(Form form)
        {
            form.TopLevel = false;
            pnMain.Controls.Clear();
            pnMain.Controls.Add(form);
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            form.Show();
        }


        private void frm_Main_Load(object sender, EventArgs e)
        {
            openFormLogin();
        }

        private void btnPT_Click(object sender, EventArgs e)
        {
            openForm(new frm_coach());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            openFormLogin();
        }

        private void btnMemberShip_Click(object sender, EventArgs e)
        {
            openForm(new frm_membership());
        }

        private void btnCheckin_Click(object sender, EventArgs e)
        {
            openForm(new frm_checkin());
        }
    }
}
