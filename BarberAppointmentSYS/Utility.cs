using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BarberAppointmentSYS
{
    internal class Utility
    {
        public static void loadRatesData(ComboBox cboName)
        {
            //Define SQL query to retrieve the last Id assigned
            String strSQL = "SELECT * FROM Rates";
            //Connect to the database
            OracleConnection conn = new OracleConnection(DBConnectcs.oraDB);
            conn.Open();
            //define an Oracle command
            OracleCommand cmd = new OracleCommand(strSQL, conn);
            //execute the command using an Oracle DataReader
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cboName.Items.Add(dr.GetString(0) + " - " + dr.GetString(1));
            }
            conn.Close();
        }
        public static void loadServicesData(ComboBox cboName)
        {
            //Define SQL query to retrieve the last Id assigned
            String strSQL = "SELECT Service_ID,Name FROM Services WHERE Status = 'A'";
            //Connect to the database
            OracleConnection conn = new OracleConnection(DBConnectcs.oraDB);
            conn.Open();
            //define an Oracle command
            OracleCommand cmd = new OracleCommand(strSQL, conn);
            //execute the command using an Oracle DataReader
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cboName.Items.Add(dr.GetString(0).PadLeft(2,'0') + " - " + dr.GetString(1));
            }
            conn.Close();
        }
        public static void loadBarbersData(ComboBox cboName)
        {
            //Define SQL query to retrieve the last Id assigned
            String strSQL = "SELECT Barber_ID,Forename,Surname FROM Barbers WHERE Status = 'A'";
            //Connect to the database
            OracleConnection conn = new OracleConnection(DBConnectcs.oraDB);
            conn.Open();
            //define an Oracle command
            OracleCommand cmd = new OracleCommand(strSQL, conn);
            //execute the command using an Oracle DataReader
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cboName.Items.Add(dr.GetString(0).PadLeft(2, '0') + " - " + dr.GetString(1) + " " + dr.GetString(2));
            }
            conn.Close();
        }



    }
}
