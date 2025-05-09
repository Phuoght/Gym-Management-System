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

        private void searchMember()
        {
            string name = txtMemberName.Text.Trim();

            try
            {
                dgvCheckin.AutoGenerateColumns = false;
                List<Member>data = checkinBL.SearchCheckin(name);

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

                bool isChecked = (bool)dgvCheckin.Rows[e.RowIndex].Cells[e.ColumnIndex].EditedFormattedValue;

                if (isChecked)
                {
                    int memberId = (int)(dgvCheckin.Rows[e.RowIndex].Cells["ID"].Value);
                    Checkin checkin = new Checkin(memberId, DateTime.Now);
                    if (checkinBL.SaveCheckin(checkin) > 0)
                    {
                        MessageBox.Show("Check-in thành công !");
                        dgvCheckin.DataSource = null;
                    }
                    else
                    {
                        MessageBox.Show("Check-in không thành công !");
                    }
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
