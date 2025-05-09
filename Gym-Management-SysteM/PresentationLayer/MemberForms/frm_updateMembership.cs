using BusinessLayer;
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

namespace Gym_Management_System.MemberForms
{
    public partial class frm_updateMembership : Form
    {
        private int memberID, membershipID;
        private string nameReceptionist;
        public frm_updateMembership(int memberID,int membershipID,string nameReceptionist)
        {
            InitializeComponent();
            this.memberID = memberID;
            this.membershipID = membershipID;
            this.nameReceptionist = nameReceptionist;
        }

        private void GetMemberships()
        {
            MembershipBL membershipBL = new MembershipBL();
            List<Membership> listMembership = membershipBL.GetMemberships();
            cb_UpdateMbs_MembershipE.DataSource = listMembership;
            cb_UpdateMbs_MembershipE.DisplayMember = "Name";
            cb_UpdateMbs_MembershipE.ValueMember = "ID";
            cb_UpdateMbs_MembershipE.SelectedValue = membershipID;
        }

        private void btn_UpdateMbs_SaveE_Click(object sender,EventArgs e)
        {
            int newMembershipId = Convert.ToInt32(cb_UpdateMbs_MembershipE.SelectedValue);
            DateTime newJoinDate = dtp_updateMbs_JoinDay.Value;
            MemberBL memberBL = new MemberBL();
            MembershipBL membershipBL = new MembershipBL();

            try
            {
                // Cập nhật membership và ngày gia nhập mới
                memberBL.EditMemberMembership(memberID,newMembershipId,newJoinDate);

                // Lấy thông tin hội viên để hiển thị bill
                Member member = memberBL.GetMemberById(memberID); 
                if(member != null)
                {
                    string memberName = member.Name;
                    string phone = member.Phone;
                    string cost = membershipBL.FindPriceMembership(newMembershipId).ToString();
                    string total = cost;
                    DateTime date = DateTime.Now;

                    frm_billing billingForm = new frm_billing(nameReceptionist,memberName,date,cost,total,phone);
                    billingForm.ShowDialog();

                    if(billingForm.DialogResult == DialogResult.OK)
                    {
                        MessageBox.Show("Cập nhật hội viên thành công");
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("Hiển thị hóa đơn thất bại");
                    }
                }
                else
                {
                    MessageBox.Show("Không tìm thấy hội viên để hiển thị hóa đơn");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi cập nhật hội viên: " + ex.Message);
            }

            this.Close();
        }

        private void frm_updateMembership_Load(object sender,EventArgs e)
        {
            GetMemberships();
            dtp_updateMbs_JoinDay.Value = DateTime.Now; 
        }
    }
}
