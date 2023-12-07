using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarberAppointmentSYS
{
    public partial class frmYearlyBarberStatistics : Form
    {
        frmMenu parent;
        public frmYearlyBarberStatistics()
        {
            InitializeComponent();
        }
        public frmYearlyBarberStatistics(frmMenu parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void cmbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbYear.SelectedIndex != -1)
            {
                grpBoxStatictics.Visible = true;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            grpBoxStatictics.Visible = false;
            cmbYear.SelectedIndex = -1;
            cmbYear.Enabled = true;
        }
    }
}
