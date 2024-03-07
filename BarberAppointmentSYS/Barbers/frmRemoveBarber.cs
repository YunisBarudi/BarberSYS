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
    public partial class frmRemoveBarber : Form
    {
        frmMenu parent;

        Barber aBarber = new Barber();

        public frmRemoveBarber()
        {
            InitializeComponent();
        }
        public frmRemoveBarber(frmMenu parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void btnChangeBarber_Click(object sender, EventArgs e)
        {
            if (cmbBoxBarber.SelectedIndex!=-1)
            {
                aBarber.getBarber(Convert.ToInt32(cmbBoxBarber.Text.Substring(0, 2)));

                aBarber.removeBarber();
                MessageBox.Show("Barber was discontinued successfully", "Confirmation message",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbBoxBarber.Items.Clear();
                Utility.loadBarbersData(cmbBoxBarber);
                DialogResult dialogResult = MessageBox.Show("Do you wanna back to the main menu?", "Main menu", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    this.Close();
                    parent.Visible = true;
                }
            }
            else
            {
                MessageBox.Show("Barber must be selected", "Barber Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void frmRemoveBarber_Load(object sender, EventArgs e)
        {
            Utility.loadBarbersData(cmbBoxBarber);
        }

      
    }
}
