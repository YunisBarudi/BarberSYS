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

            String[] Months = { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };
            decimal[] Amounts = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

            String strSQL = "SELECT SUM(Rate), EXTRACT(MONTH FROM AppDate) AS MONTH " +
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

           

            for (int i = 0; i < dt.Rows.Count; i++)
            {
               
                Amounts[i] = Convert.ToDecimal(dt.Rows[i][0]);
            }
            chtData.ChartAreas[0].AxisX.Interval = 1;
            chtData.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
            chtData.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;
            chtData.Series[0].LegendText = "Income in €";
            chtData.Series[0].Points.DataBindXY(Months, Amounts);
            chtData.ChartAreas["ChartArea1"].AxisX.LabelStyle.Format = "C";
            chtData.Series[0].Label = "#VALY";
            chtData.Titles.Add("Yearly Revenue");
            chtData.Visible = true;
        }
        public void BarberRevenue(int Year)
        {
            String strSql = "SELECT " +
                "a.barber_id, b.forename, b.surname,  SUM(a.RATE) AS total_rate " +
                "FROM Appointments a " +
                "JOIN barbers b ON a.barber_id = b.barber_id " +
                "WHERE EXTRACT(YEAR FROM a.appdate) = " + Year +
                " GROUP BY a.barber_id, b.forename, b.surname " +
                "ORDER BY total_rate DESC";
            OracleConnection myConn = new OracleConnection(DBConnectcs.oraDB);

            OracleCommand cmd = new OracleCommand(strSql, myConn);
        }

       


    }
}
