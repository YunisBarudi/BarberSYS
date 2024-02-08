using Oracle.ManagedDataAccess.Client;
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
 
    public partial class frmSetServiceType : Form
    {

         frmMenu parent;
      
        public frmSetServiceType()
        {
            InitializeComponent();
        }
        public frmSetServiceType(frmMenu parent)
        {
            InitializeComponent();
            this.parent = parent;
   
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtServiceType_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnSetServiceType_Click(object sender, EventArgs e)
        {
            
            if (txtServiceType.Text.All(t=>char.IsLetter(t)) && 
                txtServiceType.Text.Length == 2)

            {   
                if (txtDescriptionType.Text.Length <= 30 && txtDescriptionType.Text.Length>=5)
                {
                    try
                    {
                        Rate rate = new Rate(txtServiceType.Text, txtDescriptionType.Text);

                        rate.addRate();

                        MessageBox.Show("Service Type:\n" + txtServiceType.Text.ToUpper() + " - " + txtDescriptionType.Text +
                             "\nWas added successfully", "Confirmation message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtDescriptionType.Text = string.Empty;
                        txtServiceType.Text = string.Empty;
                        DialogResult dialogResult = MessageBox.Show("Do you wanna back to the main menu?", "Main menu", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dialogResult == DialogResult.Yes)
                        {
                            this.Close();
                            parent.Visible = true;
                        }
                    }
                    catch (OracleException ex){ 
                        if(ex.Number == 1)
                        {
                            MessageBox.Show("Service Type must be unique", "Invalid Service Type!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtServiceType.Focus();
                        }
                            
                    }
                }
                else
                {

                    MessageBox.Show(" Decription must be not numeric and Length less than 30 ",
                   "Invalid Description", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtDescriptionType.Text = string.Empty;
                    txtServiceType.Text = string.Empty;
                }
             
            }
            else
            {
                
                    
                MessageBox.Show(" Service Type Must be not numeric and Length = 2 ",
                    "Invalid Service Type",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    txtDescriptionType.Text = string.Empty;
                    txtServiceType.Text = string.Empty;
            }
        }

        private void txtDescriptionType_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;

        }
    }
}
