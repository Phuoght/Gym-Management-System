using Microsoft.Data.SqlClient;
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

namespace Gym_Management_System
{
    public partial class frm_EditMembership : Form
    {
        private int id;
        private MembershipBL membershipBL;
        public frm_EditMembership(int id,string name,string duration,string goal,string cost)
        {
            InitializeComponent();
            membershipBL = new MembershipBL();
            this.id = id;
            this.txt_membership_NameE.Text = name;
            this.txt_membership_DurationE.Text = duration;
            this.txt_membership_GoalE.Text = goal;
            this.txt_membership_CostE.Text = cost;
        }

        private void btn_membership_SaveE_Click(object sender,EventArgs e)
        {
            string name, duration, goal, cost;

            name = txt_membership_NameE.Text;
            duration = txt_membership_DurationE.Text;
            goal = txt_membership_GoalE.Text;
            cost = txt_membership_CostE.Text;
            if(string.IsNullOrWhiteSpace(txt_membership_NameE.Text) ||
                string.IsNullOrWhiteSpace(txt_membership_DurationE.Text) ||
                string.IsNullOrWhiteSpace(txt_membership_GoalE.Text) ||
                string.IsNullOrWhiteSpace(txt_membership_CostE.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin !");
                return;
            }
            if(!int.TryParse(duration,out int result) || result <= 0)
            {
                MessageBox.Show("Thời gian không hợp lệ !");
                return;
            }
            if(!int.TryParse(cost,out result) || result <= 0)
            {
                MessageBox.Show("Giá không hợp lệ !");
                return;
            }
            Membership membership = new Membership(id,name,duration,goal,cost);
            try
            {
                membershipBL.EditMembership(membership);
                MessageBox.Show("Sửa gói đăng ký thành công !");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi sửa gói đăng ký " + ex.Message);
            }
            finally
            {
                txt_membership_NameE.Clear();
                txt_membership_DurationE.Clear();
                txt_membership_GoalE.Clear();
                txt_membership_CostE.Clear();
            }
        }
    }
}
