using BusinessLayer;
using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic;
using System.Windows.Forms;
using TransferObject;
using System.Text.RegularExpressions;

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

        public void load_pt()
        {
            try
            {
                dgvPT.DataSource = new ptBL().GetPTs();

                // Sắp xếp thứ tự các cột
                dgvPT.Columns["ID"].DisplayIndex = 0;
                dgvPT.Columns["namePT"].DisplayIndex = 1;
                dgvPT.Columns["Gen"].DisplayIndex = 2;
                dgvPT.Columns["DOB"].DisplayIndex = 3;
                dgvPT.Columns["Phone"].DisplayIndex = 4;
                dgvPT.Columns["Experience"].DisplayIndex = 5;
                dgvPT.Columns["Address"].DisplayIndex = 6;

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
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtPhone.Text) ||
                string.IsNullOrWhiteSpace(txtAddress.Text) ||
                cbGen.SelectedIndex == -1 ||
                cbExperience.SelectedIndex == -1
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

            PT pt = new PT(name, gender, dob, phone, experience, address);
            try
            {
                ptBL.AddPT(pt);
                MessageBox.Show("Thêm PT thành công !");
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
                txtPhone.Clear();
                cbExperience.Text = "";
                txtAddress.Clear();
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (dgvPT.CurrentRow != null && !dgvPT.CurrentRow.IsNewRow)
            {
                int id = (int)dgvPT.CurrentRow.Cells["ID"].Value;

                // Gọi hàm xử lý từ lớp nghiệp vụ
                try
                {
                    ptBL.DeletePT(id);
                    MessageBox.Show("Xóa PT thành công !");
                    load_pt();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi chỉnh sửa: " + ex.Message);
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvPT.CurrentRow != null && !dgvPT.CurrentRow.IsNewRow)
            {
                int id = (int)dgvPT.CurrentRow.Cells["ID"].Value;
                string name = (string)dgvPT.CurrentRow.Cells["namePT"].Value;
                string gender = (string)dgvPT.CurrentRow.Cells["Gen"].Value;
                DateTime dob = Convert.ToDateTime(dgvPT.CurrentRow.Cells["DOB"].Value);
                string phoneNumber = (string)dgvPT.CurrentRow.Cells["Phone"].Value;
                string experience = (string)dgvPT.CurrentRow.Cells["Experience"].Value;
                string address = (string)dgvPT.CurrentRow.Cells["Address"].Value;
                
                frm_EditPT frm_editPT = new frm_EditPT(id, name, gender, dob, phoneNumber, experience, address);
                frm_editPT.ShowDialog();
                if (frm_editPT.DialogResult == DialogResult.OK)
                {
                    load_pt();
                }
            }

        }
    }
}
