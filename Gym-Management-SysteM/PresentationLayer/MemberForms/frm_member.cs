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
using BusinessLayer;
using TransferObject;


namespace Gym_Management_System
{
    public partial class frm_member : Form
    {
        private MemberBL memberBL;
        public frm_member()
        {
            InitializeComponent();
            memberBL = new MemberBL();
        }

        private void frm_member_Load(object sender,EventArgs e)
        {
            GetPTs();
            Getmemberships();
            load_Member();
        }

        private void load_Member()
        {
            try
            {
                dgvMember.AutoGenerateColumns = false;
                dgvMember.DataSource = memberBL.GetMember();
                // Đặt màu chữ
                dgvMember.DefaultCellStyle.ForeColor = Color.Black;
            }
            catch(Exception)
            {
                throw;
            }
        }

        private void GetPTs()
        {
            ptBL ptBL = new ptBL();
            List<PT> listPT = ptBL.GetPTs();
            cb_member_PT.DataSource = listPT;
            cb_member_PT.DisplayMember = "Name";// Thuộc tính hiển thị
            cb_member_PT.ValueMember = "ID";// Giá trị thực (dùng để lưu hoặc xử lý)
            cb_member_PT.SelectedIndex = -1; // Đặt giá trị mặc định là không chọn gì
        }

        private void Getmemberships()
        {
            MembershipBL membershipBL = new MembershipBL();
            List<Membership> listMembership = membershipBL.GetMemberships();
            cb_member_Membership.DataSource = listMembership;
            cb_member_Membership.DisplayMember = "Name";// Thuộc tính hiển thị
            cb_member_Membership.ValueMember = "ID";// Giá trị thực (dùng để lưu hoặc xử lý)
            cb_member_Membership.SelectedIndex = -1; // Đặt giá trị mặc định là không chọn gì

        }

        private void btn_member_Save_Click(object sender,EventArgs e)
        {
            string name, gen,  phone, timing, status;
            DateTime dob, jd;
            int membership, pt;
            name = txt_member_Name.Text;
            gen = cb_member_Gen.Text;
            dob = dtp_member_DateOfBirth.Value;
            jd = dtp_menber_JoinDay.Value;
            membership = Convert.ToInt32(cb_member_Membership.SelectedValue);
            pt = Convert.ToInt32(cb_member_PT.SelectedValue);
            phone = txt_member_Phone.Text;
            timing = cb_member_Timing.Text;
            status = cb_member_Status.Text;
            if(string.IsNullOrWhiteSpace(txt_member_Name.Text) ||
                string.IsNullOrWhiteSpace(cb_member_Gen.Text) ||
                string.IsNullOrWhiteSpace(cb_member_Membership.Text) ||
                string.IsNullOrWhiteSpace(cb_member_PT.Text) ||
                string.IsNullOrWhiteSpace(txt_member_Phone.Text) ||
                string.IsNullOrWhiteSpace(cb_member_Timing.Text) ||
                string.IsNullOrWhiteSpace(cb_member_Status.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin !");
                return;
            }
            Member member = new Member(name,gen,dob,jd,membership,pt,phone,timing,status);
            try
            {
                memberBL.AddMember(member);
                MessageBox.Show("Thêm hội viên thành công!");
                load_Member(); // load lại DataGridView
            }
            catch(SqlException ex)
            {
                MessageBox.Show("Lỗi thêm hội viên: " + ex.Message);
            }
            finally
            {
                txt_member_Name.Clear();
                cb_member_Gen.SelectedIndex = -1;
                dtp_member_DateOfBirth.Value = DateTime.Now;
                dtp_menber_JoinDay.Value = DateTime.Now;
                cb_member_Membership.SelectedIndex = -1;
                cb_member_PT.SelectedIndex = -1;
                txt_member_Phone.Clear();
                cb_member_Timing.SelectedIndex = -1;
                cb_member_Status.SelectedIndex = -1;
            }

        }

        private void btn_member_Del_Click(object sender,EventArgs e)
        {
            if(dgvMember.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgvMember.SelectedRows[0].Cells["ID"].Value);
                try
                {
                    memberBL.DeleteMember(id);
                    MessageBox.Show("Xóa hội viên thành công!");
                    load_Member(); // load lại DataGridView
                }
                catch(SqlException ex)
                {
                    MessageBox.Show("Lỗi xóa hội viên: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn hội viên để xóa!");
            }
        }

        private void btn_member_Edit_Click(object sender,EventArgs e)
        {
            try
            {
                if (dgvMember.CurrentRow !=null && !dgvMember.CurrentRow.IsNewRow)
                {
                    int id = Convert.ToInt32(dgvMember.CurrentRow.Cells["ID"].Value);
                    int ptId = Convert.ToInt32(cb_member_PT.SelectedValue);
                    int membershipId = Convert.ToInt32(cb_member_Membership.SelectedValue);
                    string name, gen, phone, timing, status;
                    DateTime dob, jd;
                    name = txt_member_Name.Text;
                    gen = cb_member_Gen.Text;
                    dob = dtp_member_DateOfBirth.Value;
                    jd = dtp_menber_JoinDay.Value;
                    phone = txt_member_Phone.Text;
                    timing = cb_member_Timing.Text;
                    status = cb_member_Status.Text;
                    Member member = new Member(id,name,gen,dob,jd,membershipId,ptId,phone,timing,status);
                    memberBL.EditMember(member);
                    MessageBox.Show("Sửa hội viên thành công!");
                    load_Member(); // load lại DataGridView
                }
            }
            catch(Exception)
            {

                throw;
            }
        }
    }
}
