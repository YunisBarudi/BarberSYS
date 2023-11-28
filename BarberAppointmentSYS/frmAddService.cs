using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarberAppointmentSYS
{
    public partial class frmAddService : Form
    {
        frmMenu parent;
        public frmAddService()
        {
            InitializeComponent();
        }
        public frmAddService(frmMenu parent)
        {
            InitializeComponent();
            this.parent = parent;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbBoxSetServiceType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void btnAddService_Click(object sender, EventArgs e)
        {
            if (cmbBoxSetServiceType.SelectedIndex != -1)
            {
                if (txtServiceName.Text.All(t => char.IsLetter(t)) && txtServiceName.Text.Length>=5)
                {

                    if (double.TryParse(txtRate.Text, out double rateValue) && rateValue >= 0)
                    { 
                        if (txtDescriptionService.Text.Length <= 30 && txtDescriptionService.Text.Length >= 5 
                            && txtDescriptionService.Text.All(t=> char.IsLetter(t)))
                        {
                            MessageBox.Show("Service:\n"+cmbBoxSetServiceType.Text+ "\n" + CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtServiceName.Text.ToLower())+ 
                                " - " + txtDescriptionService.Text + "\nRate: "+ txtRate.Text+
                       "\nWas added successfully", "Confirmation message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            cmbBoxSetServiceType.Text = string.Empty;
                            txtServiceName.Text = string.Empty;
                            txtRate.Text = string.Empty;
                            txtDescriptionService.Text = string.Empty;
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void frmAddService_Load(object sender, EventArgs e)
        {

        }
    }
}
