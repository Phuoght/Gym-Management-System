using BusinessLayer;
using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic;
using System.Windows.Forms;
using TransferObject;
namespace Gym_Management_System
{
    public partial class frm_coach : Form
    {
        private ptBL ptBL;
        public frm_coach()
        {
            InitializeComponent();
            ptBL = new ptBL();
        }

        private void load_pt()
        {
            try
            {
                dgvPT.DataSource = new ptBL().GetPTs();

                // Sắp xếp thứ tự các cột
                dgvPT.Columns["namePT"].DisplayIndex = 0;
                dgvPT.Columns["Gen"].DisplayIndex = 1;
                dgvPT.Columns["DOB"].DisplayIndex = 2;
                dgvPT.Columns["Phone"].DisplayIndex = 3;
                dgvPT.Columns["Experience"].DisplayIndex = 4;
                dgvPT.Columns["Address"].DisplayIndex = 5;

                // Đặt màu chữ
                dgvPT.DefaultCellStyle.ForeColor = Color.Black;
            }
            catch (Exception)
            {
                throw;
            }
        }


        private void frm_coach_Load(object sender, EventArgs e)
        {
            dtpDateOfBirth.MaxDate = DateTime.Now;
            load_pt();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string name, gender, phone, experience, address;
            DateTime dob;
            name = txtName.Text;
            gender = cbGen.Text;
            dob = dtpDateOfBirth.Value;
            phone = txtPhone.Text;
            experience = cbExperience.Text;
            address = txtAddress.Text;
            PT pt = new PT(name, gender, dob, phone, experience, address);
            try
            {
                ptBL.AddPT(pt);
                load_pt();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi thêm PT: " + ex.Message);
            }
            finally
            {
                txtName.Clear();
                cbGen.Text = "";
                dtpDateOfBirth.Value = DateTime.Now;
                txtPhone.Clear();
                cbExperience.Text = "";
                txtAddress.Clear();
            }
        }
    }
}
