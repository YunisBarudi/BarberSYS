using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarberAppointmentSYS
{
    public partial class frmAddBarber : Form
    {
        int BarberID = 0;
        frmMenu parent;
        public frmAddBarber()
        {
            InitializeComponent();
        }
        public frmAddBarber(frmMenu parent)
        {
            InitializeComponent();
            this.parent = parent;
        }



        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void btnAddBarber_Click(object sender, EventArgs e)
        {
            if(txtForename.Text.All(t => char.IsLetter(t)) && txtForename.Text.Length != 0)
            {
                if(txtSurname.Text.All(t=> char.IsLetter(t)) && txtSurname.Text.Length != 0)
                {
                    bool isValid = true;

                    for (int i = 0; i < txtPostcode.Text.Length; i++)
                    {
                        if (i == 0 || i == 3 || i == 4)
                        {
                            if (!char.IsLetter(txtPostcode.Text[i]))
                            {
                                isValid = false;
                                break;
                            }
                        }
                        else
                        {
                            if (!char.IsDigit(txtPostcode.Text[i]))
                            {
                                isValid = false;
                                break;
                            }
                        }
                    }

                    if (isValid){
                        if (txtPhoneNumber.Text.All (t=> char.IsNumber(t)) && txtPhoneNumber.Text.Length == 10)
                        {
                            if (txtEmail.Text.Length>=10)
                            {
                                Barber aBarber = new Barber(Convert.ToInt32(Barber.getNextBarber_ID()),txtForename.Text,
                                    txtSurname.Text,txtPostcode.Text, txtEmail.Text, txtPhoneNumber.Text, 'A');
                                aBarber.addBarber();
                                MessageBox.Show("Barber:\n" + CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtForename.Text.ToLower())
                                     +" "+ CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtSurname.Text.ToLower()) +
                                      "\nPostcode: " + txtPostcode.Text+"\nPhone number: "+txtPhoneNumber.Text+"\nE-mail: "+txtEmail.Text+
                                     "\nWas added successfully", "Confirmation message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                txtForename.Text = string.Empty;
                                txtSurname.Text = string.Empty;
                                txtPhoneNumber.Text = string.Empty;
                                txtPostcode.Text = string.Empty; 
                                txtEmail.Text = string.Empty;
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
                                txtEmail.Text = string.Empty;
                                txtEmail.Focus();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Phone number must be numeric", "Invalid Phone Number",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtPhoneNumber.Text = string.Empty; 
                            txtPhoneNumber.Focus();
                        }

                    }
                    else
                    {
                        MessageBox.Show("Postcode is not valid", "Invalid Postcode",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtPostcode.Text = string.Empty;
                        txtPostcode.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Surname must contain letters only","Invalid Surname",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSurname.Text = string.Empty;
                    txtSurname.Focus();
                }
            }
            else
            {
                MessageBox.Show("Forename must contain letters only", "Invalid Forename",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtForename.Text = string.Empty;
                txtForename.Focus();

            }
        }
    }
}
