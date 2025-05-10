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
using DataLayer;
using TransferObject;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Gym_Management_System
{
    public partial class frm_checkin : Form
    {
        private CheckinBL checkinBL;
        public frm_checkin()
        {
            InitializeComponent();
            checkinBL = new CheckinBL();
            this.KeyPreview = true;
        }
        private void GetMemberShips()
        {
            MembershipBL membershipBL = new MembershipBL();
            List<Membership> listMemberships = membershipBL.GetMemberships();
            membership.DataSource = listMemberships;
            membership.DisplayMember = "Name";
            membership.ValueMember = "ID";
        }

        private void GetPTs()
        {
            ptBL PtBL = new ptBL();
            List<PT> listPTs = PtBL.GetPTs();
            pt.DataSource = listPTs;
            pt.DisplayMember = "Name";
            pt.ValueMember = "ID";

        }

        private void searchMember()
        {
            string name = txtMemberName.Text;

            try
            {
                dgvCheckin.AutoGenerateColumns = false;
                List<Member>data = checkinBL.SearchCheckin(name);
                GetMemberShips();
                GetPTs();
                dgvCheckin.DataSource = checkinBL.SearchCheckin(name);
                dgvCheckin.DefaultCellStyle.ForeColor = Color.Black;
                dgvCheckin.Columns["checkin"].Visible = data.Count > 0;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void dgvCheckin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCheckin.Columns[e.ColumnIndex].Name == "checkin" && e.RowIndex >= 0)
            {
                int id = (int)dgvCheckin.CurrentRow.Cells["ID"].Value;

                var (duration, startDate) = checkinBL.GetTimeMemberShip(id);

                DateTime dateMembership = Convert.ToDateTime(startDate.AddMonths(duration));
                DateTime dateNow = DateTime.Now;
                //DateTime dateNow = new DateTime(2025, 10, 10);
                bool isActiveMemberships = checkinBL.IsActiveMembership(dateNow, dateMembership);

                if (isActiveMemberships)
                {
                    bool isChecked = (bool)dgvCheckin.Rows[e.RowIndex].Cells[e.ColumnIndex].EditedFormattedValue;

                    if (isChecked)
                    {
                        int memberId = (int)(dgvCheckin.Rows[e.RowIndex].Cells["ID"].Value);
                        Checkin checkin = new Checkin(memberId, DateTime.Now);
                        if (checkinBL.SaveCheckin(checkin) > 0)
                        {
                            MessageBox.Show("Check-in thành công !");
                            txtMemberName.Text = "";
                            dgvCheckin.DataSource = null;
                        }
                        else
                        {
                            MessageBox.Show("Check-in không thành công !");
                            
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Gói tập đã hết hạn !");
                    dgvCheckin.CurrentRow.Cells["checkin"].Value = false;
                    dgvCheckin.RefreshEdit();
                    return;
                }
                
            }
        }

        private void txtMemberName_TextChanged(object sender, EventArgs e)
        {
            if (txtMemberName.Text == "")
            {
                dgvCheckin.DataSource = null;
                dgvCheckin.Columns["checkin"].Visible = false;
            }
            else
            {
                searchMember();
            }

        }

        private void frm_checkin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Space)
            {
                searchMember();
                e.SuppressKeyPress = true;
            }
        }

        private void frm_checkin_Load(object sender, EventArgs e)
        {
            dgvCheckin.Columns["checkin"].Visible = false;
        }
    }
}
