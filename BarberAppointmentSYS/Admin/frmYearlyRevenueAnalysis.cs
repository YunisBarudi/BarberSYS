using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace BarberAppointmentSYS
{
    public partial class frmYearlyRevenueAnalysis : Form
    {
        frmMenu parent;
        public frmYearlyRevenueAnalysis()
        {
            InitializeComponent();
        }
        public frmYearlyRevenueAnalysis(frmMenu parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void cmbBoxService_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbYear.SelectedIndex != -1)
            {
                Admin anAdmin = new Admin();
                chtData.Series[0].Points.Clear();
                chtData.Titles.Clear();
                anAdmin.frmYearlyRevenueAnalysis_Load(int.Parse(cmbYear.Text), chtData);
                

                
            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            cmbYear.SelectedIndex = -1;
            cmbYear.Enabled = true;

        }

        private void frmYearlyRevenueAnalysis_Load(object sender, EventArgs e)
        {
            chtData.Visible = false;
            Utility.loadAppointmentsYear(cmbYear);
        }
    }
}
