using BarberAppointmentSYS.Appointments;
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
    public partial class frmCancelAppointment : Form
    {
        Appointment anAppointment = new Appointment();
        frmMenu parent;
        
        public frmCancelAppointment()
        {
            InitializeComponent();
        }
        public frmCancelAppointment(frmMenu parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (cmbBoxBarber.SelectedIndex == -1)
            {
                MessageBox.Show("Barber must be selected ",
                        "Barber Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            int barberID = Utility.getSelectedBarberId(cmbBoxBarber);
            Utility.loadBarberAppointments(cmbBoxAppointments,barberID , DateTime.Parse(String.Format("{0:dd-MMM-yy}", appDatePicker.Value)));
            if (cmbBoxAppointments.Items == null)
            {
                MessageBox.Show("No Appointments on that date ",
                        "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                cmbBoxBarber.Enabled = false;
                appDatePicker.Enabled = false;
                grpBoxAppointments.Visible = true;
                pctrCancel.Visible = true;
            }
        }



        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void btnCancelAppointment_Click(object sender, EventArgs e)
        {
            if (cmbBoxAppointments.SelectedIndex == -1)
            {
                MessageBox.Show("Appointment must be selected","Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            else
            {
                anAppointment.cancelAppointment(cmbBoxAppointments);
                MessageBox.Show("Appointment:\n" + cmbBoxAppointments.Text + "\nHas been cancelled successfully",
                    "Confirmation message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbBoxBarber.SelectedIndex = -1;
                cmbBoxBarber.Enabled = true;
                appDatePicker.Value = System.DateTime.Now;
                appDatePicker.Enabled = true;
                grpBoxAppointments.Visible = false;
                pctrCancel.Visible = false;
                cmbBoxAppointments.SelectedIndex = -1;
            }
        }

        private void frmCancelAppointment_Load(object sender, EventArgs e)
        {
            Utility.loadBarbersData(cmbBoxBarber);
            appDatePicker.MinDate = DateTime.Today;
           

        }

        private void cmbBoxBarber_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
