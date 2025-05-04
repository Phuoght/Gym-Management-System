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
using Gym_Management_System.MemberForms;


namespace Gym_Management_System
{
    public partial class frm_member : Form
    {
        private MemberBL memberBL;
        private ReceptionistsBL receptionistBL;
        public frm_member()
        {
            InitializeComponent();
            memberBL = new MemberBL();
            receptionistBL = new ReceptionistsBL();
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
            try
            {
                MembershipBL membershipBL = new MembershipBL();
                List<Membership> listMembership = membershipBL.GetMemberships();
                if(listMembership == null || listMembership.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy danh sách Membership!");
                    return;
                }

                cb_member_Membership.DataSource = listMembership;
                cb_member_Membership.DisplayMember = "Name";
                cb_member_Membership.ValueMember = "ID";
                cb_member_Membership.SelectedIndex = -1; // Đặt giá trị mặc định là không chọn
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách Membership: " + ex.Message);
            }
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

                // Xử lý sự kiện khi ấn nút đăng kí hiện bill 
                string receptionistID, memberID, date, cost, promotionID, total;
                frm_Main frm_Main = new frm_Main();
                receptionistID = receptionistBL.GetReceptionistID(frm_Main.nameReceptionist).ToString();
                memberID = memberBL.GetMemberId(name, phone).ToString();

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
            if(dgvMember.CurrentRow != null && !dgvMember.CurrentRow.IsNewRow)
            {
                int id = Convert.ToInt32(dgvMember.CurrentRow.Cells["ID"].Value);
                string name = (string)dgvMember.CurrentRow.Cells["NameMember"].Value;
                string gen = (string)dgvMember.CurrentRow.Cells["Gender"].Value;
                DateTime dob = (DateTime)dgvMember.CurrentRow.Cells["DOB"].Value;
                DateTime jd = (DateTime)dgvMember.CurrentRow.Cells["JD"].Value;
                int membershipId = Convert.ToInt32(dgvMember.CurrentRow.Cells["Membership"].Value);
                int ptId = Convert.ToInt32(dgvMember.CurrentRow.Cells["PT"].Value);
                string phone = (string)dgvMember.CurrentRow.Cells["Phone"].Value;
                string timing = (string)dgvMember.CurrentRow.Cells["Timing"].Value;
                string status = (string)dgvMember.CurrentRow.Cells["Status"].Value;

                frm_EditMember frmEditMember = new frm_EditMember(id,name,gen,dob,jd,membershipId,ptId,phone,timing,status);
                frmEditMember.ShowDialog();

                if(frmEditMember.DialogResult == DialogResult.OK)
                {
                    load_Member();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn hội viên để chỉnh sửa!");

            }
        }
    }
}
