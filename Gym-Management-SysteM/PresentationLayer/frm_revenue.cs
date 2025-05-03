using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
using TransferObject;

namespace Gym_Management_System
{
    public partial class frm_revenue : Form
    {
        private RevenueBL revenueBL;
        public frm_revenue()
        {
            InitializeComponent();
            revenueBL = new RevenueBL();
        }
        private void GetReceptionists()
        {
            ReceptionistsBL receptionistBL = new ReceptionistsBL();
            List<Receptionist> listReceptionist = receptionistBL.GetReceptionists();
            receptionist.DataSource = listReceptionist;
            receptionist.DisplayMember = "Name";// Thuộc tính hiển thị
            receptionist.ValueMember = "ID";// Giá trị thực (dùng để lưu hoặc xử lý)
        }

        private void GetMembers()
        {
            MemberBL memberBL = new MemberBL();
            List<Member> listMembers = memberBL.GetMember();
            member.DataSource = listMembers;
            member.DisplayMember = "Name";// Thuộc tính hiển thị
            member.ValueMember = "ID";// Giá trị thực (dùng để lưu hoặc xử lý)

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            DateTime startDate, endDate;
            if (dtpStartDate.Value > dtpEndDate.Value)
            {
                MessageBox.Show("Ngày bắt đầu phải nhỏ hơn ngày kết thúc");
                return;
            }
            startDate = dtpStartDate.Value;
            endDate = dtpEndDate.Value;
            try
            {
                List<Billing> billings = revenueBL.GetBillings(startDate, endDate);
                if (billings.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu trong khoảng thời gian này !");
                    return;
                }
                GetMembers();
                GetReceptionists();
                dgvReport.DataSource = billings;
                dgvReport.AutoGenerateColumns = false;

                

                double totalRevenue = 0;
                foreach (var billing in billings)
                {
                    totalRevenue += billing.total;
                }
                lbTotalRevenue.Text = "Tổng Doanh Thu: " + totalRevenue.ToString("C0", System.Globalization.CultureInfo.GetCultureInfo("vi-VN"));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
                return;
            }
        }
    }
}
