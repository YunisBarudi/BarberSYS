using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarberAppointmentSYS
{
    public partial class frmAddBarber : Form
    {
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
            if(txtForename.Text.All(t => char.IsLetter(t)))
            {
                if(txtSurname.Text.All(t=> char.IsLetter(t)))
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
                            string pattern = @"^[a-zA-Z0-9]+(\.[a-zA-Z0-9]+)*@[a-zA-Z0-9]+\.[a-zA-Z]+$";
                            if (Regex.IsMatch(pattern, txtEmail.Text))
                            {

                            }
                            else
                            {

                            }
                        }
                        else
                        {
                            MessageBox.Show("E-mail is note valid", "Invalid E-mail",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtEmail.Text = string.Empty;
                            txtForename.Text = string.Empty;
                            txtSurname.Text = string.Empty;
                            txtPhoneNumber.Text = string.Empty; 
                            txtPostcode.Text = string.Empty;
                        }

                    }
                    else
                    {
                        MessageBox.Show("Postcode is not valid", "Invalid Postcode",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtEmail.Text = string.Empty;
                        txtForename.Text = string.Empty;
                        txtSurname.Text = string.Empty;
                        txtPhoneNumber.Text = string.Empty;
                        txtPostcode.Text = string.Empty;
                    }
                }
                else
                {
                    MessageBox.Show("Surname must contain letters only","Invalid Surname",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtEmail.Text = string.Empty;
                    txtForename.Text = string.Empty;
                    txtSurname.Text = string.Empty;
                    txtPhoneNumber.Text = string.Empty;
                    txtPostcode.Text = string.Empty;
                }
            }
            else
            {
                MessageBox.Show("Forename must contain letters only", "Invalid Forename",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Text = string.Empty;
                txtForename.Text = string.Empty;
                txtSurname.Text = string.Empty;
                txtPhoneNumber.Text = string.Empty;
                txtPostcode.Text = string.Empty;

            }
        }
    }
}
