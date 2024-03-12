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

    public partial class frmMakeAppointment : Form
    {
        Appointment anAppointment = new Appointment();
        frmMenu parent;
        public frmMakeAppointment()
        {
            InitializeComponent();
        }
        public frmMakeAppointment(frmMenu parent)
        {
            InitializeComponent();
            this.parent = parent;
        }



        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (cmbBoxBarber.SelectedIndex == -1)
            {
                MessageBox.Show("Barber must be selected ",
                        "Barber Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                anAppointment.checkAvailableTimeSlots(String.Format("{0:yyyy-MM-dd}",appDatePicker), cmbBoxTime);
                lblSelectTime.Visible = true;
                cmbBoxTime.Visible = true;
                cmbBoxBarber.Enabled = false;
                appDatePicker.Enabled = false;
            }
        }

        private void cmbBoxTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            grpBoxCustomerDetails.Visible = true;
        }

        private void btnMakeAppointment_Click(object sender, EventArgs e)
        {
            if (txtBoxForename.Text.All(t => char.IsLetter(t)) && txtBoxForename.Text.Length != 0)
            {
                if (txtBoxSurname.Text.All(t => char.IsLetter(t)) && txtBoxSurname.Text.Length != 0)
                {
                    if (cmbBoxService.SelectedIndex != -1)
                    {
                        if (txtBoxPhone.Text.All(t => char.IsNumber(t)) && txtBoxPhone.Text.Length == 10)
                        {
                            if(txtBoxEmail.Text.Length >= 10)
                            {
                                MessageBox.Show("Appointment Details:\n\n"+"\nBarber: "
                                    + cmbBoxBarber.Text +
                                    "\nDate: " + appDatePicker.Text + "\nTime: " + cmbBoxTime.Text + "\nService: " + cmbBoxService.Text +
                                    "\n\n\nCustomer Details:\n\nForename: " + txtBoxForename.Text + "\nSurname: " + txtBoxSurname.Text +
                                    "\nPhone: " + txtBoxPhone.Text + "\nE-mail: "+txtBoxEmail.Text,"Confirmation message",
                                    MessageBoxButtons.OK,MessageBoxIcon.Information);
                                txtBoxEmail.Text = string.Empty;
                                txtBoxForename.Text = string.Empty;
                                txtBoxPhone.Text = string.Empty;
                                txtBoxSurname.Text = string.Empty;
                                cmbBoxService.SelectedIndex = -1;
                                cmbBoxBarber.SelectedIndex = -1;
                                cmbBoxTime.SelectedIndex = -1;
                                appDatePicker.Value = System.DateTime.Now;
                                grpBoxCustomerDetails.Visible = false;
                                lblSelectTime.Visible = false;
                                cmbBoxTime.Visible = false;
                                cmbBoxBarber.Enabled = true;
                                appDatePicker.Enabled = true;
                                DialogResult dialogResult = MessageBox.Show("Do you wanna back to the main menu?", "Main menu", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                if (dialogResult == DialogResult.Yes)
                                {
                                    this.Close();
                                    parent.Visible = true;
                                }


                            }
                            else
                            {
                                MessageBox.Show("E-mail is not valid", "Invalid E-mail",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txtBoxEmail.Text = string.Empty;
                                txtBoxEmail.Focus();
                            }

                        }
                        else
                        {
                            MessageBox.Show("Phone number must be numeric", "Invalid Phone Number",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtBoxPhone.Text = string.Empty;
                            txtBoxPhone.Focus();

                        }
                    }
                    else
                    {
                        MessageBox.Show("Service must be selected ", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                        cmbBoxService.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Surname must contain letters only", "Invalid Surname",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtBoxSurname.Text = string.Empty;
                    txtBoxSurname.Focus();
                }
            }
            else
            {
                MessageBox.Show("Forename must contain letters only", "Invalid Forename",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBoxForename.Text = string.Empty;
                txtBoxForename.Focus();
            }
        }

        private void frmMakeAppointment_Load(object sender, EventArgs e)
        {
            Utility.loadBarbersData(cmbBoxBarber);
            appDatePicker.MinDate = DateTime.Today;
            appDatePicker.Value = DateTime.Today;
        }
    }
}
