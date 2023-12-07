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
    public partial class frmChangeBarber : Form
    {
        int BarberID;
        frmMenu parent;
        public frmChangeBarber()
        {
            InitializeComponent();
        }
        public frmChangeBarber(frmMenu parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void btnChangeBarber_Click(object sender, EventArgs e)
        {
            if(txtForename.Text.All(t => char.IsLetter(t)) && txtForename.Text.Length != 0)
            {
                if (txtSurname.Text.All(t => char.IsLetter(t)) && txtSurname.Text.Length != 0)
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

                    if (isValid)
                    {
                        if (txtPhoneNumber.Text.All(t => char.IsNumber(t)) && txtPhoneNumber.Text.Length == 10)
                        {
                            if (txtEmail.Text.Length >= 10)
                            {
                                MessageBox.Show("Barber:\n" + CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtForename.Text.ToLower())
                                     + " " + CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtSurname.Text.ToLower()) +
                                     "\nBarber ID: " + BarberID + "\nPostcode: " + txtPostcode.Text + "\nPhone number: " + txtPhoneNumber.Text + "\nE-mail: " + txtEmail.Text +
                                     "\nWas changed successfully", "Confirmation message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                txtForename.Text = string.Empty;
                                txtSurname.Text = string.Empty;
                                txtPhoneNumber.Text = string.Empty;
                                txtPostcode.Text = string.Empty;
                                txtEmail.Text = string.Empty;
                                cmbBoxBarber.SelectedIndex = -1;
                                grpBoxChangeBarber.Visible = false;
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
                    MessageBox.Show("Surname must contain letters only", "Invalid Surname",
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void cmbBoxService_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBoxBarber.SelectedIndex == 0)
            {
                txtForename.Text = "Joe";
                txtSurname.Text = "Bloggs";
                txtPostcode.Text = "V92CX88";
                txtPhoneNumber.Text = "0877932274";
                txtEmail.Text = "joe.bloggs@students.ittralee.ie";
                BarberID = 1;
               
            }
            if (cmbBoxBarber.SelectedIndex == 1)
            {
                txtForename.Text = "Yunis";
                txtSurname.Text = "Barudi";
                txtPostcode.Text = "V92FC79";
                txtPhoneNumber.Text = "0877932874";
                txtEmail.Text = "unis1barudi@gmail.com";
                BarberID = 2;
            }
            if(cmbBoxBarber.SelectedIndex == 2)
            {
                txtForename.Text = "Roman";
                txtSurname.Text = "Hnat";
                txtPostcode.Text = "V92FC79";
                txtPhoneNumber.Text = "0879076212";
                txtEmail.Text = "roman.hnatyshyn@students.ittralee.ie";
                BarberID = 3;

            }
            if(cmbBoxBarber.SelectedIndex == 3)
            {
                txtForename.Text = "Lionel";
                txtSurname.Text = "Messi";
                txtPostcode.Text = "V91FC78";
                txtPhoneNumber.Text = "0871234569";
                txtEmail.Text = "lionel.messi@students.ittralee.ie";
                BarberID = 4;
            }
            grpBoxChangeBarber.Visible = true;
            btnChangeBarber.Visible = true;
        }
    }
}
