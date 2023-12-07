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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            mnuStrip.BringToFront();
        }

       

        private void mnuSetServiceType_Click(object sender, EventArgs e)
        {
                 
                 frmSetServiceType newForm = new frmSetServiceType(this);
                 this.Hide();
                 newForm.Show();
            
        }

        private void mnuDiscontinueBarber_Click(object sender, EventArgs e)
        {
            frmRemoveBarber newForm = new frmRemoveBarber(this);
            this.Hide();
            newForm.Show();
        }

        private void mnuAddService_Click(object sender, EventArgs e)
        {
            frmAddService newForm = new frmAddService(this);
            this.Hide();
            newForm.Show();
        }

        private void mnuServices_Click(object sender, EventArgs e)
        {

        }

        private void mnuChangeService_Click(object sender, EventArgs e)
        {
            frmChangeService newForm = new frmChangeService(this);
            this.Hide();
            newForm.Show();
        }

        private void mnuDiscontinueService_Click(object sender, EventArgs e)
        {
            frmDiscontinueService newForm = new frmDiscontinueService(this);
            this.Hide();
            newForm.Show();
        }

        private void mnuAddBarber_Click(object sender, EventArgs e)
        {
            frmAddBarber newForm = new frmAddBarber(this);
            this.Hide();
            newForm.Show();
        }

        private void mnuChangeBarber_Click(object sender, EventArgs e)
        {
            frmChangeBarber newForm = new frmChangeBarber(this);
            this.Hide();
            newForm.Show();
        }

        private void mnuListBarbers_Click(object sender, EventArgs e)
        {
            frmListBarbers newForm = new frmListBarbers(this);
            this.Hide();
            newForm.Show();
        }

        private void mnuMakeAppointment_Click(object sender, EventArgs e)
        {
            frmMakeAppointment newForm = new frmMakeAppointment(this);
            this.Hide();
            newForm.Show();
        }

        private void mnuCancelAppointment_Click(object sender, EventArgs e)
        {
            frmCancelAppointment newForm = new frmCancelAppointment(this);
            this.Hide();
            newForm.Show();
        }

        private void mnuYearlyRevenueAnalyse_Click(object sender, EventArgs e)
        {
            frmYearlyRevenueAnalysis newForm = new frmYearlyRevenueAnalysis(this);
            this.Hide();
            newForm.Show();
        }

        private void mnuYearlyBarberStatisctics_Click(object sender, EventArgs e)
        {
            frmYearlyBarberStatistics newForm = new frmYearlyBarberStatistics(this);
            this.Hide();
            newForm.Show();
        }
    }
}
