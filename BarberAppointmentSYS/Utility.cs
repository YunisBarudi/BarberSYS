using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Drawing.Printing;
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
        public static int getSelectedBarberId(ComboBox comboBox)
        {
            if (comboBox.SelectedItem == null)
            {
                // If no item is selected, return -1
                return -1;
            }

            // Get the selected item from the combo box
            string selectedBarber = comboBox.SelectedItem.ToString();


            // Find the index of the '-' character
            int separatorIndex = selectedBarber.IndexOf('-');

            if (separatorIndex == -1)
            {
                // If the separator '-' is not found, return -1
                return -1;
            }

            // Extract the barber ID substring
            string barberIdString = selectedBarber.Substring(0, separatorIndex).Trim();

            int barberId;
            if (int.TryParse(barberIdString, out barberId))
            {
                // Return the parsed barber ID
                return barberId;
            }
            else
            {
                // Return -1 if parsing fails
                return -1;
            }
        }
        public static int getSelectedServiceId(ComboBox comboBox)
        {
            if (comboBox.SelectedItem == null)
            {
                return -1;
            }

            string serviceName = comboBox.SelectedItem.ToString();

            string strSQL = "SELECT Service_ID FROM Services WHERE Name = :service";

            try
            {
                using (OracleConnection conn = new OracleConnection(DBConnectcs.oraDB))
                {
                    conn.Open();

                    using (OracleCommand cmd = new OracleCommand(strSQL, conn))
                    {
                        // Create OracleParameter and add it to the Parameters collection
                        OracleParameter parameter = new OracleParameter(":service", OracleDbType.Varchar2);
                        parameter.Value = serviceName;
                        cmd.Parameters.Add(parameter);

                        // Execute the command using ExecuteScalar to get single value
                        object result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            // If result is not null, service exists, return its ID
                            return Convert.ToInt32(result);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            // If service not found or error occurred, return -1
            return -1;
        }

        public static void loadBarberAppointments(ComboBox cboName, int barber_id, DateTime appointmentDate )
        {

            string appointmentDateString = appointmentDate.ToString("dd-MMM-yy");
            //Define SQL query to retrieve the last Id assigned
            String strSQL = "SELECT Appointment_ID,Forename,Surname,AppTime,Barber_Id FROM Appointments WHERE Barber_ID = :barber_id AND AppointmentDate = :appointmentDateString";
            //Connect to the database
            OracleConnection conn = new OracleConnection(DBConnectcs.oraDB);
            conn.Open();
            //define an Oracle command
            OracleCommand cmd = new OracleCommand(strSQL, conn);
            //execute the command using an Oracle DataReader
            cmd.Parameters.Add(":barber_id", OracleDbType.Int32).Value = barber_id;
            cmd.Parameters.Add(":appointmentDateString", OracleDbType.Varchar2).Value = appointmentDateString;
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cboName.Items.Add(dr.GetString(0).PadLeft(2, '0') + " - " + dr.GetString(1) + " " + dr.GetString(2) + " " + dr.GetString(3)+ " " +dr.GetString(4).PadLeft(2, '0'));
            }
            conn.Close();
        }








    }
}
