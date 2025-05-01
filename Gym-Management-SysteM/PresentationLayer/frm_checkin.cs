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

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Vui lòng điền tên bạn muốn tìm kiếm");
                return;
            }

            try
            {
                dgvCheckin.AutoGenerateColumns = false;
                if (checkinBL.SearchCheckin(name).Count == 0)
                {
                    MessageBox.Show("Không tìm thấy tên thành viên !");
                    return;
                }
                else
                {
                    dgvCheckin.DataSource = checkinBL.SearchCheckin(name);
                    dgvCheckin.DefaultCellStyle.ForeColor = Color.Black;
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                txtMemberName.Clear();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            searchMember();
        }

        private void frm_checkin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                searchMember();
                e.SuppressKeyPress = true;
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
    }
}
