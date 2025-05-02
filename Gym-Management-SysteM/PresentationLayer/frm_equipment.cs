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
using System.Data.SqlClient;

namespace Gym_Management_System
{
    public partial class frm_equipment : Form
    {
        private EquipmentBL equipmentBL;
        public frm_equipment()
        {
            InitializeComponent();
            equipmentBL = new EquipmentBL();
        }
        private void load_equipment()
        {
            try
            {
                dgvEquipment.DataSource = equipmentBL.GetAllEquipment();
                dgvEquipment.AutoGenerateColumns = false;
            }

            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void Equipment_Load(object sender, EventArgs e)
        {
            dtpLastMainTain.MaxDate = DateTime.Now;
            load_equipment();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string name, type, status;
            DateTime lastMaintain, nextMaintain;
            int amount;
            if (string.IsNullOrWhiteSpace(txtNameEquipment.Text) ||
                string.IsNullOrWhiteSpace(cbTypeEquipment.Text) ||
                cbAmount.SelectedIndex == -1 ||
                cbStatus.SelectedIndex == -1
                )
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin !");
                return;
            }

            name = txtNameEquipment.Text;
            type = cbTypeEquipment.Text;
            amount = int.Parse(cbAmount.Text);
            status = cbStatus.Text;
            lastMaintain = dtpLastMainTain.Value;
            nextMaintain = dtpNextMainTain.Value;
            if (lastMaintain > nextMaintain)
            {
                MessageBox.Show("Ngày bảo trì không hợp lệ !");
                return;
            }
            try
            {
                Equipment equipment = new Equipment(name, type, amount, status, lastMaintain, nextMaintain);
                equipmentBL.AddEquipment(equipment);
                MessageBox.Show("Thêm thiết bị thành công !");
                load_equipment();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi thêm thiết bị: " + ex.Message);
            }
            finally
            {
                txtNameEquipment.Clear();
                cbTypeEquipment.SelectedIndex = -1;
                cbAmount.SelectedIndex = -1;
                cbStatus.SelectedIndex = -1;
                dtpNextMainTain.Value = DateTime.Now;
            }

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (dgvEquipment.CurrentRow != null && !dgvEquipment.CurrentRow.IsNewRow)
            {
                int id = (int)dgvEquipment.CurrentRow.Cells["ID"].Value;

                try
                {
                    equipmentBL.DeleteEquipment(id);
                    MessageBox.Show("Xóa thiết bị thành công !");
                    load_equipment();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa: " + ex.Message);
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvEquipment.CurrentRow != null && !dgvEquipment.CurrentRow.IsNewRow)
            {
                int id = (int)dgvEquipment.CurrentRow.Cells["ID"].Value;
                string name = (string)dgvEquipment.CurrentRow.Cells["nameEquipment"].Value;
                string type = (string)dgvEquipment.CurrentRow.Cells["type"].Value;
                int amount = (int)(dgvEquipment.CurrentRow.Cells["amount"].Value);
                string status = (string)dgvEquipment.CurrentRow.Cells["statusEquipment"].Value;
                DateTime lastMainTain = (DateTime)dgvEquipment.CurrentRow.Cells["lastMaintain"].Value;
                DateTime nextMainTain = (DateTime)dgvEquipment.CurrentRow.Cells["nextMaintain"].Value;

                frm_EditEquipment frm_editEquipment = new frm_EditEquipment(id, name, type, amount, status, lastMainTain, nextMainTain);
                frm_editEquipment.ShowDialog();
                if (frm_editEquipment.DialogResult == DialogResult.OK)
                {
                    load_equipment();
                }
            }
        }
    }
}
