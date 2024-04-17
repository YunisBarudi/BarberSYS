using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace BarberAppointmentSYS
{
     internal class Admin
       
    {
        public Admin() { }
        public void frmYearlyRevenueAnalysis_Load(int Year, Chart chtData)
        {
            String strSQL = "SELECT SUM(Rate) AS TotalRate, EXTRACT(MONTH FROM AppDate) AS MonthNumber " +
                            "FROM Appointments " +
                            "WHERE EXTRACT(YEAR FROM AppDate) = :Year " +
                            "GROUP BY EXTRACT(MONTH FROM AppDate)";

            DataTable dt = new DataTable();
            OracleConnection myConn = new OracleConnection(DBConnectcs.oraDB);

            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            cmd.Parameters.Add(new OracleParameter(":Year", Year));

            OracleDataAdapter da = new OracleDataAdapter(cmd);
            da.Fill(dt);
            myConn.Close();
            if (dt.Rows.Count == 0)
            {
                chtData.Visible = false;
                MessageBox.Show("No data found for the selected year.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Dictionary<int, string> monthNames = new Dictionary<int, string>()
    {
        {1, "JAN"}, {2, "FEB"}, {3, "MAR"}, {4, "APR"}, {5, "MAY"}, {6, "JUN"},
        {7, "JUL"}, {8, "AUG"}, {9, "SEP"}, {10, "OCT"}, {11, "NOV"}, {12, "DEC"}
    };

            List<string> MonthsList = new List<string>();
            List<decimal> AmountsList = new List<decimal>();

            foreach (DataRow row in dt.Rows)
            {
                int monthNumber = Convert.ToInt32(row["MonthNumber"]);
                string monthName = monthNames.ContainsKey(monthNumber) ? monthNames[monthNumber] : "Unknown";
                MonthsList.Add(monthName);
                AmountsList.Add(Convert.ToDecimal(row["TotalRate"]));
            }

            // Convert lists to arrays
            string[] Months = MonthsList.ToArray();
            decimal[] Amounts = AmountsList.ToArray();

            chtData.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
            chtData.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;
            chtData.Series[0].LegendText = "Income in €";
            chtData.Series[0].Points.DataBindXY(Months, Amounts);
            chtData.ChartAreas["ChartArea1"].AxisX.LabelStyle.Format = "C";
            chtData.Series[0].Label = "#VALY";
            chtData.Titles.Add("Yearly Revenue");
            chtData.Visible = true;
        }


    }
}
