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
using DataLayer;


namespace Gym_Management_System
{
    public partial class frm_member : Form
    {
        private string nameReceptionist;
        private MemberBL memberBL;
        private ReceptionistBL receptionistBL;
        private MembershipBL membershipBL;
        public frm_member(string nameReceptionist)
        {
            InitializeComponent();
            memberBL = new MemberBL();
            receptionistBL = new ReceptionistBL();
            membershipBL = new MembershipBL();
            this.nameReceptionist = nameReceptionist;
        }

        private void GetMemberShipsForDGV()
        {
            MembershipBL membershipBL = new MembershipBL();
            List<Membership> listMemberships = membershipBL.GetMemberships();
            Membership.DataSource = listMemberships;
            Membership.DisplayMember = "Name";
            Membership.ValueMember = "ID";
        }
        private void GetPTsForDGV()
        {
            ptBL PtBL = new ptBL();
            List<PT> listPTs = PtBL.GetPTs();
            PT.DataSource = listPTs;
            PT.DisplayMember = "Name";
            PT.ValueMember = "ID";

        }

        private void frm_member_Load(object sender,EventArgs e)
        {
            memberBL.UpdateExpiredMemberships();
            AddExpirationDateColumn();
            GetPTs();
            Getmemberships();
            load_Member();
            cb_member_Status.SelectedIndex = 0; // Chọn giá trị đầu tiên trong ComboBox
        }

        private void load_Member()
        {
            try
            {
                dgvMember.AutoGenerateColumns = false;

                List<Member> members = memberBL.GetMember();
                List<Membership> memberships = membershipBL.GetMemberships();

                // Tạo danh sách mới để gán vào DataGridView

                List<object> memberViewList = new List<object>();

                foreach(Member m in members)
                {
                    // Tìm gói tập tương ứng
                    Membership membership = null;
                    foreach(Membership ms in memberships)
                    {
                        if(ms.ID == m.Membership)
                        {
                            membership = ms;
                            break;
                        }
                    }

                    int duration = 0;
                    if(membership != null && membership.Duration != null)
                    {
                        int temp;
                        if(int.TryParse(membership.Duration,out temp))
                        {
                            duration = temp;
                        }
                    }

                    // Tính ngày hết hạn
                    DateTime expiration = m.JD.AddMonths(duration);

                    // Tạo đối tượng chứa thông tin hội viên
                    var memberInfo = new
                    {
                        ID = m.ID,
                        Name = m.Name,
                        Gender = m.Gender,
                        Dob = m.Dob,
                        Joinday = m.JD,
                        Membership = m.Membership,
                        PT = m.PT,
                        PhoneNumber = m.Phone,
                        Status = m.Status,
                        ExpirationDate = expiration.ToShortDateString()
                    };

                    memberViewList.Add(memberInfo);
                }
                GetMemberShipsForDGV();
                GetPTsForDGV();

                dgvMember.DataSource = memberViewList;


                dgvMember.DefaultCellStyle.ForeColor = Color.Black;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách hội viên: " + ex.Message);
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
            string name, gen, phone, status;
            DateTime dob, jd;
            int membership, pt;
            name = txt_member_Name.Text;
            gen = cb_member_Gen.Text;
            dob = dtp_member_DateOfBirth.Value;
            jd = dtp_menber_JoinDay.Value;
            membership = Convert.ToInt32(cb_member_Membership.SelectedValue);
            pt = Convert.ToInt32(cb_member_PT.SelectedValue);
            phone = txt_member_Phone.Text;
            status = cb_member_Status.Text;
            if(string.IsNullOrWhiteSpace(txt_member_Name.Text) ||
                string.IsNullOrWhiteSpace(cb_member_Gen.Text) ||
                string.IsNullOrWhiteSpace(cb_member_Membership.Text) ||
                string.IsNullOrWhiteSpace(cb_member_PT.Text) ||
                string.IsNullOrWhiteSpace(txt_member_Phone.Text) ||
                string.IsNullOrWhiteSpace(cb_member_Status.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin !");
                return;
            }
            if(!Regex.IsMatch(phone,@"^\d{10}$"))
            {
                MessageBox.Show("Số điện thoại không hợp lệ !");
                return;
            }

            Member member = new Member(name,gen,dob,jd,membership,pt,phone,status);
            try
            {
                memberBL.AddMember(member);
                // Xử lý sự kiện khi ấn nút đăng kí hiện bill 
                string receptionistName, memberName, cost, total;
                DateTime date;
                receptionistName = this.nameReceptionist;
                memberName = name;
                date = DateTime.Now;
                cost = membershipBL.FindPriceMembership(membership).ToString();
                total = cost;
                frm_billing frm_Billing = new frm_billing(receptionistName,memberName,date,cost,total,phone);
                frm_Billing.ShowDialog();
                if(frm_Billing.DialogResult == DialogResult.OK)
                {
                    MessageBox.Show("Đăng ký thành viên thành công!");
                    load_Member(); // load lại DataGridView
                }
                else
                {
                    MessageBox.Show("Đăng ký thành viên thất bại!");
                }
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
                cb_member_Status.SelectedIndex = -1;
            }
        }

        private void btn_member_Del_Click(object sender,EventArgs e)
        {
            if(dgvMember.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgvMember.SelectedRows[0].Cells["ID"].Value);
                string Status = (string)dgvMember.SelectedRows[0].Cells["Status"].Value;
                if(Status == "Hoạt Động")
                {
                    MessageBox.Show("Không thể xóa thành viên đang hoạt động!");
                    return;
                }
                try
                {
                    memberBL.DeleteMember(id);
                    MessageBox.Show("Xóa thành viên thành công!");
                    load_Member(); // load lại DataGridView
                }
                catch(SqlException ex)
                {
                    MessageBox.Show("Lỗi xóa thành viên: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn thành viên để xóa!");
            }
        }

        private void btn_member_Edit_Click(object sender,EventArgs e)
        {
            if(dgvMember.CurrentRow != null && !dgvMember.CurrentRow.IsNewRow)
            {
                int id = Convert.ToInt32(dgvMember.CurrentRow.Cells[0].Value);
                string name = (string)dgvMember.CurrentRow.Cells[1].Value;
                string gen = (string)dgvMember.CurrentRow.Cells[2].Value;
                DateTime dob = (DateTime)dgvMember.CurrentRow.Cells[3].Value;
                DateTime jd = (DateTime)dgvMember.CurrentRow.Cells[4].Value;
                int membershipId = Convert.ToInt32(dgvMember.CurrentRow.Cells[5].Value);
                int ptId = Convert.ToInt32(dgvMember.CurrentRow.Cells[6].Value);
                string phone = (string)dgvMember.CurrentRow.Cells[7].Value;
                string status = (string)dgvMember.CurrentRow.Cells[8].Value;

                frm_EditMember frmEditMember = new frm_EditMember(id,name,gen,dob,jd,membershipId,ptId,phone,status);
                frmEditMember.ShowDialog();

                if(frmEditMember.DialogResult == DialogResult.OK)
                {
                    load_Member();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn thành viên để chỉnh sửa!");

            }
        }
        private void AddExpirationDateColumn()
        {
            if(!dgvMember.Columns.Contains("ExpirationDate"))
            {
                DataGridViewTextBoxColumn colExpiration = new DataGridViewTextBoxColumn();
                colExpiration.HeaderText = "Ngày hết hạn";
                colExpiration.Name = "ExpirationDate";
                colExpiration.DataPropertyName = "ExpirationDate"; // để binding dữ liệu
                colExpiration.ReadOnly = true;
                dgvMember.Columns.Add(colExpiration);
            }
        }

        private void btnEditmembership_Click(object sender,EventArgs e)
        {
            int id = Convert.ToInt32(dgvMember.CurrentRow.Cells[0].Value);
            int membershipId = Convert.ToInt32(dgvMember.CurrentRow.Cells[5].Value);
            frm_updateMembership updateMembership = new frm_updateMembership(id,membershipId,this.nameReceptionist);
            updateMembership.ShowDialog();
            if(updateMembership.DialogResult == DialogResult.OK)
            {
                load_Member();
            }
            else
            {
                MessageBox.Show("Cập nhật không thành công");

            }
        }
    }
}
