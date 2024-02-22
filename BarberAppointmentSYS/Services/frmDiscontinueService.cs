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
    public partial class frmDiscontinueService : Form
    {
        frmMenu parent;

        Service aService = new Service();
        public frmDiscontinueService()
        {
            InitializeComponent();
        }
        public frmDiscontinueService(frmMenu parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
                this.Close();
                parent.Visible = true;
        }

        private void btnDiscontinueService_Click(object sender, EventArgs e)
        {
            if (cmbBoxService.SelectedIndex != -1) {

                aService.getService(Convert.ToInt32(cmbBoxService.Text.Substring(0, 2)));

                aService.discontinueService();

                MessageBox.Show("Service was discontinued successfully", "Confirmation message",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbBoxService.Items.Clear();
                Utility.loadServicesData(cmbBoxService);
                DialogResult dialogResult = MessageBox.Show("Do you wanna back to the main menu?", "Main menu", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    this.Close();
                    parent.Visible = true;
                }
            }
            else
            {
                MessageBox.Show("Service must be selected", "Service Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmDiscontinueService_Load(object sender, EventArgs e)
        {
            Utility.loadServicesData(cmbBoxService);
        }
    }
}
