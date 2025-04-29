using System.Windows.Forms;

namespace Gym_Management_System
{
    public partial class frm_Main : Form
    {
        public frm_Main()
        {
            InitializeComponent();
        }
        private void openFormLogin()
        {
            frm_login login = new frm_login();
            DialogResult result = login.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.Show();
                openFormPT(new frm_coach());
            }
            else
            {
                Application.Exit();
            }
        }
        private void openFormPT(Form form)
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
            openFormPT(new frm_coach());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            openFormLogin();
        }
    }
}
