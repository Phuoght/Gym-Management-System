using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using TransferObject;
using BusinessLayer;
namespace Gym_Management_System
{
    public partial class frm_coach : Form
    {
        private ptBL ptBL;
        public frm_coach()
        {
            InitializeComponent();
            ptBL = new ptBL();
        }

        private void load_pt()
        {
            try
            {
                dgvPT.DataSource = new ptBL().GetPTs();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void frm_coach_Load(object sender, EventArgs e)
        {
            dtpDateOfBirth.MaxDate = DateTime.Now;
            load_pt();
        }

    }
}
