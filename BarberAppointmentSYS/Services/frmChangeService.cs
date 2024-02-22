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
        Service aService = new Service();

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
            if(cmbBoxService.SelectedIndex != -1)


    {
                aService.getService(Convert.ToInt32(cmbBoxService.Text.Substring(0,2)));

                txtServiceName.Text = aService.getName();
                txtDescriptionService.Text = aService.getDescription();
                cmbBoxSetServiceType.SelectedItem = aService.getService_type();
                txtRate.Text = aService.getRate().ToString();
                

                Utility.loadRatesData(cmbBoxSetServiceType);

                cmbBoxService.Enabled = false;
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

                            aService.setName(txtServiceName.Text);
                            aService.setDescription(txtDescriptionService.Text);
                            aService.setRate(int.Parse(txtRate.Text));
                            aService.setService_Type(cmbBoxSetServiceType.SelectedItem.ToString().Substring(0,2));
                            aService.changeService();
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
                            cmbBoxService.Items.Clear();
                            cmbBoxSetServiceType.Items.Clear();
                            cmbBoxService.Enabled = true;
                            Utility.loadServicesData(cmbBoxService);
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

        private void frmChangeService_Load(object sender, EventArgs e)
        {
            Utility.loadServicesData(cmbBoxService);
        }
    }
}
