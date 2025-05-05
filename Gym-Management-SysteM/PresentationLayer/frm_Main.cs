using System.Data;
using System.Windows.Forms;

namespace Gym_Management_System
{
    public partial class frm_Main : Form
    {
        public string role { get; set; }
        public string nameReceptionist { get; set; }
        public frm_Main()
        {
            InitializeComponent();
            role = "";
            nameReceptionist = "";
        }
        private void UpdateUI()
        {
            if(role == "admin")
            {
                btnReceptionist.Visible = true;
                ptbReceptionist.Visible = true;
                btnEquipment.Visible = true;
                ptbEquipment.Visible = true;
                btnPromotion.Visible = true;
                ptbPromotion.Visible = true;
                btnRevenue.Visible = true;
                ptbRevenue.Visible = true;
                btnCheckin.Visible = true;
                ptbCheckin.Visible = true;
            }
            else
            {
                // ẩn cho người dùng không phải admin
                btnReceptionist.Visible = false;
                ptbReceptionist.Visible = false;
                btnEquipment.Visible = false;
                ptbEquipment.Visible = false;
                btnPromotion.Visible = false;
                ptbPromotion.Visible = false;
                btnRevenue.Visible = false;
                ptbRevenue.Visible = false;
                btnCheckin.Visible = false;
                ptbCheckin.Visible = false;
            }
        }
        private void openFormLogin()
        {
            frm_login login = new frm_login();
            DialogResult result = login.ShowDialog();
            if(result == DialogResult.OK)
            {
                role = login.userRole;
                nameReceptionist = login.name;
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


        private void frm_Main_Load(object sender,EventArgs e)
        {
            openFormLogin();
        }

        private void btnPT_Click(object sender,EventArgs e)
        {
            openForm(new frm_coach());
        }

        private void btnLogout_Click(object sender,EventArgs e)
        {
            this.Hide();
            openFormLogin();
        }

        private void btnMemberShip_Click(object sender,EventArgs e)
        {
            openForm(new frm_membership());
        }

        private void btnCheckin_Click(object sender,EventArgs e)
        {
            openForm(new frm_checkin());
        }

        private void btnEquipment_Click(object sender,EventArgs e)
        {
            openForm(new frm_equipment());
        }

        private void btnPromotion_Click(object sender,EventArgs e)
        {
            openForm(new frm_promotion());
        }

        private void btnRevenue_Click(object sender,EventArgs e)
        {
            openForm(new frm_revenue());
        }

        private void btnReceptionist_Click(object sender, EventArgs e)
        {
            openForm(new frm_receptionist());
        }

        private void btnMember_Click(object sender, EventArgs e)
        {
            openForm(new frm_member(nameReceptionist));
        }
    }
}
