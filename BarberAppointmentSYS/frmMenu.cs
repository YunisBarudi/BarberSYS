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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblMain2_Click(object sender, EventArgs e)
        {

        }

        private void setServiceTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void barberToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void yearlyRevenueToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void mnuSetServiceType_Click(object sender, EventArgs e)
        {
                 
                 frmSetServiceType newForm = new frmSetServiceType(this);
                 this.Hide();
                 newForm.Show();
            
        }

        private void mnuDiscontinueBarber_Click(object sender, EventArgs e)
        {

        }

        private void mnuAddService_Click(object sender, EventArgs e)
        {
            frmAddService newForm = new frmAddService();
            this.Hide();
            newForm.Show();
        }
    }
}
