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
    public partial class frmListBarbers : Form
    {
        frmMenu parent;
        public frmListBarbers()
        {
            InitializeComponent();
        }
        public frmListBarbers(frmMenu parent)
        {
            InitializeComponent();
            this.parent = parent;
        }


       /*
         
            That was my Harcode for prototype in 1st semester 
         
        private void btnListBarbers_Click(object sender, EventArgs e)
        {
            
            if (chkBoxEmail.Checked ||chkBoxForename.Checked || chkBoxSurname.Checked ||
                 chkBoxPhoneNumber.Checked || chkBoxPostcode.Checked)
            {


                tblListBarbers.Controls.Clear();
                tblListBarbers.ColumnStyles.Clear();


                String[][] barbers = new String[][]
                {
        new String[] { "001", "Joe", "Bloggs", "V92FC78", "0877932794", "joe.bloggs@students.ittralee.ie", "A" },
        new String[] { "002", "Yunis", "Barudi", "V92FC79", "0877932874", "yunis.barudi@students.ittralee.ie", "A" },
        new String[] { "003", "Roman", "Hnat", "V92FC79", "0877932724", "roman.hnatyshyn@students.ittralee.ie", "A" },
        new String[] { "004", "Lionel", "Messi", "V92FC58", "0871932794", "lionel.messi@students.ittralee.ie", "A" }
                };

                tblListBarbers.ColumnCount = 7;
                tblListBarbers.RowCount = 1;
                for (int i = 0; i < tblListBarbers.ColumnCount; i++)
                {
                    tblListBarbers.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
                }
                string[] headers = { "BarberId", "Forename", "Surname", "Postcode", "Phone Number", "Email", "Status" };
                for (int i = 0; i < tblListBarbers.ColumnCount; i++)
                {
                    tblListBarbers.Controls.Add(new Label() { Text = headers[i] }, i, 0);
                }
                int count = 0;
                if (count == 0)
                {
                    tblListBarbers.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));

                }
                else
                {
                    tblListBarbers.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
                }
                count = 1;
                foreach (var barber in barbers)
                {

                    AddRowToTable(tblListBarbers, barber);
                }
                if (!chkBoxEmail.Checked)
                {
                    tblListBarbers.ColumnStyles[5].SizeType = SizeType.Absolute;
                    tblListBarbers.ColumnStyles[5].Width = 0;
                }
                if (!chkBoxForename.Checked)
                {
                    tblListBarbers.ColumnStyles[1].SizeType = SizeType.Absolute;
                    tblListBarbers.ColumnStyles[1].Width = 0;
                }
                if (!chkBoxSurname.Checked)
                {
                    tblListBarbers.ColumnStyles[2].SizeType = SizeType.Absolute;
                    tblListBarbers.ColumnStyles[2].Width = 0;
                }
                if (!chkBoxPhoneNumber.Checked)
                {
                    tblListBarbers.ColumnStyles[4].SizeType = SizeType.Absolute;
                    tblListBarbers.ColumnStyles[4].Width = 0;
                }
                if (!chkBoxPostcode.Checked)
                {
                    tblListBarbers.ColumnStyles[3].SizeType = SizeType.Absolute;
                    tblListBarbers.ColumnStyles[3].Width = 0;
                }
                tblListBarbers.Visible = true;
            }
            else
            {
                MessageBox.Show("Please check at least one checkbox ","Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddRowToTable(TableLayoutPanel table, string[] rowData)
        {
            table.RowCount = table.RowCount + 1;
            table.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));


            for (int i = 0; i < rowData.Length; i++)
            {
                table.Controls.Add(new Label() { Text = rowData[i] }, i, table.RowCount - 1);
            }
        }
        */

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void btnListBarbers_Click(object sender, EventArgs e)
        {
            
        }

        private void frmListBarbers_Load(object sender, EventArgs e)
        {
            txtListBarbers.Enabled = false;
            txtListBarbers.Visible = false;
        }
    }
}
