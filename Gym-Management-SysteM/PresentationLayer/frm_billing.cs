using BusinessLayer;
using DataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TransferObject;

namespace Gym_Management_System
{
    public partial class frm_billing : Form
    {
        private BillingBL billingBL;
        private ReceptionistBL receptionistBL;
        private MemberBL memberBL;
        private PromotionBL promotionBL;
        private string phone;
        public frm_billing(string receptionist, string member, DateTime date, string cost, string total, string phone)
        {
            InitializeComponent();
            receptionistBL = new ReceptionistBL();
            memberBL = new MemberBL();
            promotionBL = new PromotionBL();
            billingBL = new BillingBL();
            lbReceptionist.Text = receptionist;
            lbMember.Text = member;
            lbCost.Text = cost;
            lbTotal.Text = total;
            lbDate.Text = date.ToString("dd-MM-yyyy");
            this.phone = phone;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string promotionID;
            int receptionist, member;
            double cost, total;
            DateTime date;
            int discount;
            receptionist = receptionistBL.GetReceptionistID(lbReceptionist.Text);
            member = memberBL.GetMemberId(lbMember.Text, this.phone);
            date = Convert.ToDateTime(lbDate.Text);
            cost = double.Parse(lbCost.Text);
            total = double.Parse(lbTotal.Text);
            if (txtPromotion.Text == "")
            {
                promotionID = "";
            }
            else
            {
                promotionID = txtPromotion.Text;
                List<string> discountStartEnd = promotionBL.GetDiscountStartEnd(promotionID);
                discount = int.Parse(discountStartEnd[0]);
                DateTime startDate = DateTime.Parse(discountStartEnd[1]);
                DateTime endDate = DateTime.Parse(discountStartEnd[2]);
                if (promotionBL.GetActivePromotions(DateTime.Now, startDate, endDate) == false)
                {
                    MessageBox.Show("Khuyến mãi không còn hiệu lực !");
                    return;
                }
                total = total - (total * discount / 100);
                lbTotal.Text = total.ToString();
            }
            try
            {
                Billing billing = new Billing(receptionist, member, date, cost, promotionID, total);
                if (billingBL.AddBilling(billing) > 0)
                {
                    MessageBox.Show("Xác nhận thanh toán thành công !");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Xác nhận thanh toán thất bại !");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
    }
}
