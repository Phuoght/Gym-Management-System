using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TransferObject;
namespace Gym_Management_System
{
    public partial class frm_membership : Form
    {
        private MembershipBL membershipBL;
        public frm_membership()
        {
            InitializeComponent();
            membershipBL = new MembershipBL();
        }

        public void load_membership()
        {
            try
            {
                dgvMembership.DataSource = new MembershipBL().GetMemberships();
                // Sắp xếp thứ tự các cột
                dgvMembership.Columns["ID"].DisplayIndex = 0;
                dgvMembership.Columns["NameMembership"].DisplayIndex = 1;
                dgvMembership.Columns["Duration"].DisplayIndex = 2;
                dgvMembership.Columns["Goal"].DisplayIndex = 3;
                dgvMembership.Columns["Cost"].DisplayIndex = 4;
                // Đặt màu chữ
                dgvMembership.DefaultCellStyle.ForeColor = Color.Black;
            }
            catch(Exception)
            {
                throw;
            }
        }

        private void frm_membership_Load(object sender,EventArgs e)
        {
            load_membership();
        }

        private void btn_membership_Save_Click(object sender,EventArgs e)
        {
            string name, goal;
            int duration, cost;
            name = txt_membership_Name.Text;
            duration = int.Parse(txt_membership_Duration.Text);
            goal = txt_membership_Goal.Text;
            cost = int.Parse(txt_membership_Cost.Text);
            if(string.IsNullOrWhiteSpace(txt_membership_Name.Text) ||
                string.IsNullOrWhiteSpace(txt_membership_Duration.Text) ||
                string.IsNullOrWhiteSpace(txt_membership_Goal.Text) ||
                string.IsNullOrWhiteSpace(txt_membership_Cost.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin !");
                return;
            }
            if(!int.TryParse(txt_membership_Duration.Text,out duration) || duration <= 0)
            {
                MessageBox.Show("Thời gian không hợp lệ !");
                return;
            }
            if(!int.TryParse(txt_membership_Cost.Text,out cost) || cost <= 0)
            {
                MessageBox.Show("Giá không hợp lệ !");
                return;
            }
            Membership membership = new Membership(name,duration,goal,cost);
            try
            {

            }
            catch(SqlException ex)
            {
                MessageBox.Show("Lỗi thêm hội viên: " + ex.Message);
                throw;
            }
            finally
            {
                txt_membership_Name.Clear();
                txt_membership_Duration.Clear();
                txt_membership_Goal.Clear();
                txt_membership_Cost.Clear();
            }
        }

        private void btn_membership_Del_Click(object sender,EventArgs e)
        {
            if(dgvMembership.SelectedRows.Count > 0)
            {
                int id = (int)dgvMembership.SelectedRows[0].Cells["ID"].Value;
                try
                {
                    membershipBL.DeleteMembership(id);
                    MessageBox.Show("Xóa hội viên thành công !");
                    load_membership();
                }
                catch(SqlException ex)
                {
                    MessageBox.Show("Lỗi xóa hội viên: " + ex.Message);
                    throw;
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn hội viên để xóa !");
            }
        }

        private void btn_membership_Edit_Click(object sender,EventArgs e)
        {
            if(dgvMembership.SelectedRows != null && !dgvMembership.CurrentRow.IsNewRow)
            {
                int id = (int)dgvMembership.CurrentRow.Cells["ID"].Value;
                string name = (string)dgvMembership.CurrentRow.Cells["NameMembership"].Value;
                string duration = (string)dgvMembership.CurrentRow.Cells["Duration"].Value;
                string goal = (string)dgvMembership.CurrentRow.Cells["Goal"].Value;
                string cost = (string)dgvMembership.CurrentRow.Cells["Cost"].Value;

                


            }
        }
    }
}
