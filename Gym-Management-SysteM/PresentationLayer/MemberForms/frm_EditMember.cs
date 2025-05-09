using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TransferObject;
using BusinessLayer;

namespace Gym_Management_System.MemberForms
{
    public partial class frm_EditMember : Form
    {
        private int id, membershipId, ptId;
        private MemberBL memberBL;

        public frm_EditMember(int id,string name,string gender,DateTime dob,DateTime jd,int membership,int pt,string phone,string status)
        {
            InitializeComponent();
            memberBL = new MemberBL();
            this.id = id;
            this.membershipId = membership;
            this.ptId = pt;
            this.txt_member_NameE.Text = name;
            this.cb_member_GenE.Text = gender;
            this.txt_member_PhoneE.Text = phone;
            this.dtp_member_DateOfBirthE.Value = dob;
            this.dtp_menber_JoinDayE.Value = jd;
            this.cb_member_StatusE.Text = status;

        }

        private void GetPTs()
        {
            ptBL ptBL = new ptBL();
            List<PT> listPT = ptBL.GetPTs();
            cb_member_PTE.DataSource = listPT;
            cb_member_PTE.DisplayMember = "Name";
            cb_member_PTE.ValueMember = "ID";
            cb_member_PTE.SelectedValue = ptId;
        }
        private void GetMemberships()
        {
            MembershipBL membershipBL = new MembershipBL();
            List<Membership> listMembership = membershipBL.GetMemberships();
            cb_member_MembershipE.DataSource = listMembership;
            cb_member_MembershipE.DisplayMember = "Name";
            cb_member_MembershipE.ValueMember = "ID";
            cb_member_MembershipE.SelectedValue = membershipId;
        }

        private void frmEditMember_Load(object sender,EventArgs e)
        {
            GetPTs();
            GetMemberships();
        }

        private void btn_member_SaveE_Click(object sender,EventArgs e)
        {
            int membership, pt;
            string name, gen, phone, status;
            DateTime dob, jd;

            name = txt_member_NameE.Text;
            gen = cb_member_GenE.Text;
            membership = Convert.ToInt32(cb_member_MembershipE.SelectedValue);
            pt = Convert.ToInt32(cb_member_PTE.SelectedValue);
            phone = txt_member_PhoneE.Text;
            dob = dtp_member_DateOfBirthE.Value;
            jd = dtp_menber_JoinDayE.Value;
            status = cb_member_StatusE.Text;

            if(string.IsNullOrWhiteSpace(txt_member_NameE.Text) ||
                string.IsNullOrWhiteSpace(cb_member_GenE.Text) ||
                string.IsNullOrWhiteSpace(cb_member_MembershipE.Text) ||
                string.IsNullOrWhiteSpace(cb_member_PTE.Text) ||
                string.IsNullOrWhiteSpace(txt_member_PhoneE.Text) ||
                string.IsNullOrWhiteSpace(cb_member_StatusE.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin !");
                return;
            }

            Member member = new Member(id,name,gen,dob,jd,membership,pt,phone,status);
            try
            {
                memberBL.EditMember(member);
                MessageBox.Show("Sửa hội viên thành công!");
                this.DialogResult = DialogResult.OK; // Set the dialog result to OK
                this.Close();

            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi sửa hội viên: " + ex.Message);
            }
            finally
            {
                txt_member_NameE.Clear();
                cb_member_GenE.SelectedIndex = -1;
                dtp_member_DateOfBirthE.Value = DateTime.Now;
                dtp_menber_JoinDayE.Value = DateTime.Now;
                cb_member_MembershipE.SelectedIndex = -1;
                cb_member_PTE.SelectedIndex = -1;
                txt_member_PhoneE.Clear();
                cb_member_StatusE.SelectedIndex = -1;
            }
        }

    }
}
