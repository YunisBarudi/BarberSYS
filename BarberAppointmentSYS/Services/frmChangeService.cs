using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarberAppointmentSYS
{
    public partial class frmChangeService : Form
    {
        frmMenu parent;
        public frmChangeService()
        {
            InitializeComponent();
        }
        public frmChangeService(frmMenu parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void cmbBoxService_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBoxService.SelectedIndex == 0)
            {
                cmbBoxSetServiceType.SelectedIndex = 1;
                txtServiceName.Text = "Fade haircut";
                txtRate.Text = "30.00";
                txtDescriptionService.Text = "Gradual transition from longer to shorter hair.";
                groupBox1.Visible = true;
            }
            if (cmbBoxService.SelectedIndex == 1)
            {
                cmbBoxSetServiceType.SelectedIndex = 1;
                txtServiceName.Text = "Clipper Haircut";
                txtRate.Text = "35.00";
                txtDescriptionService.Text = "Efficient clipper haircuts for clean, precise styles.";
                groupBox1.Visible = true;
            }
            if (cmbBoxService.SelectedIndex == 2)
            {
                cmbBoxSetServiceType.SelectedIndex= 2;
                txtServiceName.Text = "Beard Fade";
                txtRate.Text = "20.00";
                txtDescriptionService.Text = "Gradual transition from a shorter to longer length at the chin.";
                groupBox1.Visible = true;
            }
            if(cmbBoxService.SelectedIndex == 3)
            {
                cmbBoxSetServiceType.SelectedIndex = 0;
                txtServiceName.Text = "Beard Shape-Up";
                txtRate.Text = "15.00";
                txtDescriptionService.Text = "Defining the edges of the beard for a clean look.";
                groupBox1.Visible = true;
            }
        }



        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void btnChangeService_Click(object sender, EventArgs e)
        {
            if (cmbBoxSetServiceType.SelectedIndex != -1)
            {
                if (txtServiceName.Text.All(c => char.IsLetter(c) || c == ' ') && txtServiceName.Text.Length >= 5)
                {

                    if (double.TryParse(txtRate.Text, out double rateValue) && rateValue >= 0)
                    {
                        if (txtDescriptionService.Text.Length <= 60 && txtDescriptionService.Text.Length >= 5)
                        {
                            MessageBox.Show("Service:\n" + cmbBoxSetServiceType.Text + "\n" + CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtServiceName.Text.ToLower()) +
                                " - " + txtDescriptionService.Text + "\nRate: " + txtRate.Text +
                       "\nWas changed successfully", "Confirmation message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            cmbBoxSetServiceType.Text = string.Empty;
                            txtServiceName.Text = string.Empty;
                            txtRate.Text = string.Empty;
                            txtDescriptionService.Text = string.Empty;
                            groupBox1.Visible = false;
                            cmbBoxService.SelectedIndex = -1;
                            DialogResult dialogResult = MessageBox.Show("Do you wanna back to the main menu?", "Main menu", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (dialogResult == DialogResult.Yes)
                            {
                                this.Close();
                                parent.Visible = true;
                            }
                        }
                        else
                        {
                            MessageBox.Show(" Decription must be not numeric and Length less than 30 ",
                   "Invalid Description", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            cmbBoxSetServiceType.Text = string.Empty;
                            txtServiceName.Text = string.Empty;
                            txtRate.Text = string.Empty;
                            txtDescriptionService.Text = string.Empty;
                        }
                    }
                    else
                    {
                        MessageBox.Show(" Rate must be double and greater than 0 ",
                        "Invalid Rate", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        cmbBoxSetServiceType.Text = string.Empty;
                        txtServiceName.Text = string.Empty;
                        txtRate.Text = string.Empty;
                        txtDescriptionService.Text = string.Empty;
                    }
                }
                else
                {
                    MessageBox.Show(" Service Name must be not numeric ",
                   "Invalid Service Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cmbBoxSetServiceType.Text = string.Empty;
                    txtServiceName.Text = string.Empty;
                    txtRate.Text = string.Empty;
                    txtDescriptionService.Text = string.Empty;
                }
            }
            else
            {
                MessageBox.Show(" Service Type must be entered ",
                   "Invalid Service Type", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtServiceName.Text = string.Empty;
                txtRate.Text = string.Empty;
                txtDescriptionService.Text = string.Empty;
            }
        }
    }
}
