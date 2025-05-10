using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using TransferObject;
using BusinessLayer;
namespace Gym_Management_System
{
    public partial class frm_dashboard : Form
    {
        private DashBoardBL dashBoardBL;
        public frm_dashboard()
        {
            InitializeComponent();
            dashBoardBL = new DashBoardBL();
        }

        private void frm_dashboard_Load(object sender, EventArgs e)
        {
            lbPT.Text = dashBoardBL.GetQuantityPTs().ToString();
            lbMember.Text = dashBoardBL.GetQuantityMembers().ToString();
            lbReceptionist.Text = dashBoardBL.GetQuantityReceptionists().ToString();
            lbMemberShip.Text = dashBoardBL.GetQuantityMemberShips().ToString();
            lbEquipment.Text = dashBoardBL.GetQuantityEquipments().ToString();
            lbPromote.Text = dashBoardBL.GetQuantityPromotes().ToString();
            lbRevenue.Text = dashBoardBL.GetAllRevenue().ToString("C0", System.Globalization.CultureInfo.GetCultureInfo("vi-VN"));
        }
    }
}
