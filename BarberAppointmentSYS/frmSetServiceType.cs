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
        public frmSetServiceType()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtServiceType_TextChanged(object sender, EventArgs e)
        {

        }
        int count = 0;
        private void btnSetServiceType_Click(object sender, EventArgs e)
        {
            
            if (txtServiceType.Text.All(t=>char.IsLetter(t)) && 
                txtServiceType.Text.Length == 2)
            {
                if (txtDescriptionType.Text.Length <= 30 && txtDescriptionType.Text.Length>=5)
                {
                     MessageBox.Show("Service Type was added successfully","Comfirmation message",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    txtDescriptionType.Text = string.Empty;
                    txtServiceType.Text = string.Empty;
                }
                else
                {
                    MessageBox.Show(" Secription must be not numeric and Length less than 30 ",
                   "Invalid Description", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
             
            }
            else
            {
                
                    
                MessageBox.Show(" Service Type Must be not numeric and Length = 2 ",
                    "Invalid Service Type",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void txtDescriptionType_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
