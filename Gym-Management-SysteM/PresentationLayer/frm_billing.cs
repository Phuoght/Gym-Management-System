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
        public frm_billing()
        {
            InitializeComponent();
            billingBL = new BillingBL();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string promotionID;
            int receptionist, member;
            double cost, total;
            DateTime date;
            receptionist = int.Parse(lbReceptionist.Text);
            member = int.Parse(lbMember.Text);
            date = Convert.ToDateTime(lbDate.Text);
            cost = double.Parse(lbCost.Text);
            if (txtPromotion.Text == "")
            {
                promotionID = "";
            }
            else
            {
                promotionID = txtPromotion.Text;
            }
            total = double.Parse(lbTotal.Text);
            try
            {
                Billing billing = new Billing(receptionist, member, date, cost, promotionID, total);
                if (billingBL.AddBilling(billing) > 0)
                {
                    MessageBox.Show("Thanh toán thành công !");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Thanh toán thất bại !");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
    }
}
