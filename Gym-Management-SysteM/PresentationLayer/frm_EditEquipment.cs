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
    public partial class frm_EditEquipment : Form
    {
        private EquipmentBL equipmentBL;
        private int id;
        public frm_EditEquipment(int id, string name, string type, int amount, string status, DateTime lastMaintain, DateTime nextMaintain)
        {
            InitializeComponent();
            this.id = id;
            this.txtNameEquipment.Text = name;
            this.cbTypeEquipment.Text = type;
            this.cbAmount.Text = amount.ToString();
            this.cbStatus.Text = status;
            this.dtpLastMainTain.Value = lastMaintain;
            this.dtpNextMainTain.Value = nextMaintain;
            equipmentBL = new EquipmentBL();
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
            Equipment equipment = new Equipment(this.id, name, type, amount, status, lastMaintain, nextMaintain);
            try
            {
                equipmentBL.EditEquipment(equipment);
                MessageBox.Show("Cập nhật thiết bị thành công !");
                this.DialogResult = DialogResult.OK;
                this.Close();

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi cập nhật thiết bị: " + ex.Message);
            }
        }
    }
}
