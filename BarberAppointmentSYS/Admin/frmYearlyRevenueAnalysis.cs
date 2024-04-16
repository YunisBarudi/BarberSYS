using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace BarberAppointmentSYS
{
    public partial class frmYearlyRevenueAnalysis : Form
    {
        frmMenu parent;
        public frmYearlyRevenueAnalysis()
        {
            InitializeComponent();
        }
        public frmYearlyRevenueAnalysis(frmMenu parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void cmbBoxService_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbYear.SelectedIndex != -1)
            {
                cmbYear.Enabled = false;
            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            cmbYear.SelectedIndex = -1;
            cmbYear.Enabled = true;

        }



        private void frmYearlyRevenueAnalysis_Load(object sender, EventArgs e)
        {
            String strSQL = "SELECT SUM(Sale_Value), to_Char(Sale_Date,'MM') FROMSales GROUP BY to_Char(Sale_Date,'MM') ORDER char(Sale_Date, 'MM')";
            DataTable dt = new DataTable();
            OracleConnection myConn = new OracleConnection(DBConnectcs.oraDB);

            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            da.Fill(dt);
            myConn.Close();
            string[] Months = new string[12];
            decimal[] Amounts = new decimal[12];
            for (int i = 0; i < 12; i++)
            {
                Months[i] = getMonth(Convert.ToInt32(dt.Rows[i][0]));
                Amounts[i] = Convert.ToDecimal(dt.Rows[i][1]);
            }
      
               for (int i = 0; i < dt.Rows.Count; i++)
            {
                Amounts[Convert.ToInt32(dt.Rows[i][0]) - 1] = Convert.ToDecimal(dt.Rows[i][1]);
            }
            chtData.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
            chtData.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;
            chtData.Series[0].LegendText = "Income in €";
            chtData.Series[0].Points.DataBindXY(Months, Amounts);
            chtData.ChartAreas["ChartArea1"].AxisX.LabelStyle.Format = "C";
            //chtSales.Series[0].Points[0] = "XXX";
            chtData.Series[0].Label = "#VALY";
            chtData.Titles.Add("Yearly Revenue");
            chtData.Visible = true;
        }
        public String getMonth(int month)
        {
            switch (month)
            {
                case 1:
                    {
                        return "JAN";
                    }
                case 2:
                    {
                        return "FEB";
                    }
                case 3:
                    {
                        return "MAR";
                    }
                case 4:
                    {
                        return "APR";
                    }
                case 5:
                    {
                        return "MAY";
                    }
                case 6:
                    {
                        return "JUN";
                    }
                case 7:
                    {
                        return "JUL";
                    }
                case 8:
                    {
                        return "AUG";
                    }
                case 9:
                    {
                        return "SEP";
                    }
                case 10:
                    {
                        return "OCT";
                    }
                case 11:
                    {
                        return "NOV";
                    }
                case 12:
                    {
                        return "DEC";
                    }
                default:
                    {
                        return null;
                    }
            }
        }

    }
}
