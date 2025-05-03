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
        private int id;
        private MemberBL memberBL;

        public frm_EditMember(int id,string name,string gender,DateTime dob,DateTime jd,string membership,string pt,string phone,string timing,string status)
        {
            InitializeComponent();
            memberBL = new MemberBL();
            this.id = id;
            this.txt_member_NameE.Text = name;
            this.cb_member_GenE.Text = gender;
            this.txt_member_PhoneE.Text = phone;
            this.dtp_member_DateOfBirthE.Value = dob;
            this.dtp_menber_JoinDayE.Value = jd;
            this.cb_member_MembershipE.Text = membership;
            this.cb_member_PTE.Text = pt;
            this.cb_member_TimingE.Text = timing;
            this.cb_member_StatusE.Text = status;

        }

        private void GetPTs()
        {
            ptBL ptBL = new ptBL();
            List<PT> listPT = ptBL.GetPTs();
            cb_member_PTE.DataSource = listPT;
            cb_member_PTE.DisplayMember = "Name";
            cb_member_PTE.ValueMember = "ID";
            cb_member_PTE.SelectedIndex = -1;
        }
        private void GetMemberships()
        {
            MembershipBL membershipBL = new MembershipBL();
            List<Membership> listMembership = membershipBL.GetMemberships();
            cb_member_MembershipE.DataSource = listMembership;
            cb_member_MembershipE.DisplayMember = "Name";
            cb_member_MembershipE.ValueMember = "ID";
            cb_member_MembershipE.SelectedIndex = -1;
        }

        private void frmEditMember_Load(object sender,EventArgs e)
        {
            GetPTs();
            GetMemberships();
        }

        private void btn_member_SaveE_Click(object sender,EventArgs e)
        {
            int membership, pt;
            string name, gen, phone, timing, status;
            DateTime dob, jd;

            name = txt_member_NameE.Text;
            gen = cb_member_GenE.Text;
            membership = Convert.ToInt32(cb_member_MembershipE.SelectedValue);
            pt = Convert.ToInt32(cb_member_PTE.SelectedValue);
            phone = txt_member_PhoneE.Text;
            dob = dtp_member_DateOfBirthE.Value;
            jd = dtp_menber_JoinDayE.Value;
            timing = cb_member_TimingE.Text;
            status = cb_member_StatusE.Text;

            if(string.IsNullOrWhiteSpace(txt_member_NameE.Text) ||
                string.IsNullOrWhiteSpace(cb_member_GenE.Text) ||
                string.IsNullOrWhiteSpace(cb_member_MembershipE.Text) ||
                string.IsNullOrWhiteSpace(cb_member_PTE.Text) ||
                string.IsNullOrWhiteSpace(txt_member_PhoneE.Text) ||
                string.IsNullOrWhiteSpace(cb_member_TimingE.Text) ||
                string.IsNullOrWhiteSpace(cb_member_StatusE.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin !");
                return;
            }

            Console.WriteLine($"Membership: {membership}, PT: {pt}");  // Check the selected IDs

            Member member = new Member(id,name,gen,dob,jd,membership,pt,phone,timing,status);
            try
            {
                memberBL.EditMember(member);
                MessageBox.Show("Sửa hội viên thành công!");
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
                cb_member_TimingE.SelectedIndex = -1;
                cb_member_StatusE.SelectedIndex = -1;
            }
        }

    }
}
