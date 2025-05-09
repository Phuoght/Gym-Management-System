using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym_Management_System
{
    public partial class frm_loading : Form
    {
        public frm_loading()
        {
            InitializeComponent();
        }
        int startPoint = 0;

        private async void timer1_Tick(object sender, EventArgs e)
        {
            startPoint += 20;
            pbLoading.Value = startPoint;
            if (pbLoading.Value == 100)
            {
                pbLoading.Value = 100;
                timer1.Stop();

                await Task.Delay(1000);

                frm_Main formMain = new frm_Main();
                this.Hide();
                formMain.ShowDialog();
                this.Close();
            }
        }
    }
}
