using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarberAppointmentSYS.Appointments
{
    class Appointment
    {
        private int appointment_id;
        private string forename;
        private string surname;
        private string phone;
        private string email;
        private DateTime appointmentDate;
        private string appointmentTime;
        private int service_id;
        private int barber_id;


        public Appointment()
        {
            this.appointment_id = 0;
            this.forename = "";
            this.surname = "";
            this.phone = "";
            this.email = "";
            this.appointmentDate = DateTime.Now;
            this.appointmentTime = "";
            this.service_id = 0;
            this.barber_id = 0;

        }
        public Appointment(int appointment_id, string forename, string surname, string phone,
            string email, DateTime appointmentDate, string appointmentTime, int service_id, int barber_id)
        {
            this.appointment_id = appointment_id;
            this.forename = forename;
            this.surname = surname;
            this.phone = phone;
            this.email = email;
            this.appointmentDate = appointmentDate;
            this.appointmentTime = appointmentTime;
            this.service_id = service_id;
            this.barber_id = barber_id;
        }
        /////Getters

        public int getAppointmentId()
        {
            return this.appointment_id;
        }
        public string getForename()
        {
            return this.forename;
        }
        public string getSurname()
        {
            return this.surname;
        }
        public string getPhone()
        {
            return this.phone;
        }
        public string getEmail()
        {
            return this.email;
        }
        public DateTime getAppointmentDate()
        {
            return this.appointmentDate;
        }
        public int getServiceId()
        {
            return service_id;
        }
        public int getBarberId()
        {
            return this.barber_id;
        }
        ////Setters////

        public void setApointmentId(int appointment_id)
        {
            this.appointment_id = appointment_id;
        }
        public void setForename(String forename)
        {
            this.forename = forename;
        }
        public void setSurname(String surname)
        {
            this.surname = surname;
        }
        public void setPhone(String phone)
        {
            this.phone = phone;
        }
        public void setEmail(String email)
        {
            this.email = email;
        }
        public void setAppointmentDate(DateTime appointment_date)
        {
            this.appointmentDate = appointment_date;
        }
        public void setAppointmentTime(String appointment_time)
        {
            this.appointmentTime = appointment_time;
        }
        public void setServiceId(int service_id)
        {
            this.service_id = service_id;
        }
        public void setBarberId(int barber_id)
        {
            this.barber_id = barber_id;
        }

        ///////////////////////////////////////

        public static int getNextAppointment_ID()
        {
            OracleConnection conn = new OracleConnection(DBConnectcs.oraDB);

            String sqlQuery = "SELECT MAX(Appointment_Id) FROM Appointments";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            OracleDataReader dr = cmd.ExecuteReader();

            int nextId;
            dr.Read();

            if (dr.IsDBNull(0))
                nextId = 1;
            else
            {
                nextId = dr.GetInt32(0) + 1;
            }

            conn.Close();

            return nextId;
        }
        public void addAppointment()
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnectcs.oraDB);

            string appointmentDateString = this.appointmentDate.ToString("dd-MMM-yy");

            //Define the SQL query to be executed
            String sqlQuery = "INSERT INTO Appointments Values (" +

                  this.appointment_id + ", '" +
                  this.forename + "', '" +
                  this.surname + "', '" +
                  this.phone + "', '" +
                  this.email + "', " +
                  "TO_DATE(:appointmentDate, 'DD-MON-YY'), '" +
                  this.appointmentTime + "', " +
                  this.service_id + ", " +
                  this.barber_id + ")";

            conn.Open();

            // Create an OracleCommand object with the SQL query and connection
            using (OracleCommand cmd = new OracleCommand(sqlQuery, conn))
            {
                
                cmd.Parameters.Add(":appointmentDate", OracleDbType.Varchar2).Value = appointmentDateString;

                Console.WriteLine(this.appointmentDate);
                // Execute the command (insert data into the database)
                cmd.ExecuteNonQuery();
            }
            

            // Close the connection
            conn.Close();
        }
        public void cancelAppointment(ComboBox cboName)
        {
            OracleConnection conn = new OracleConnection(DBConnectcs.oraDB);
            if (cboName.SelectedItem != null)
            {
                // Get the selected item from the ComboBox
                string selectedItem = cboName.SelectedItem.ToString();

                // Extract the Appointment_ID from the selected item (assuming it's the first part before the dash)
                string[] parts = selectedItem.Split('-');
                if (parts.Length >= 1)
                {
                    string appointmentID = parts[0].Trim();

                    // Define the SQL query to delete the appointment
                    string strSQL = "DELETE FROM Appointments WHERE Appointment_ID = :appointmentID";

                    // Connect to the database
                   conn.Open();

                        // Define the Oracle command
                        using (OracleCommand cmd = new OracleCommand(strSQL, conn))
                        {
                            // Add parameter for appointmentID
                            cmd.Parameters.Add(":appointmentID", OracleDbType.Int32).Value = int.Parse(appointmentID);

                            // Execute the command
                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                // Appointment deleted successfully
                                MessageBox.Show("Appointment deleted successfully.");
                            }
                            else
                            {
                                // No rows affected, appointment might not exist
                                MessageBox.Show("No appointment found to delete.");
                            }
                        }
                    
                }
                else
                {
                    MessageBox.Show("Invalid selected item format.");
                }
            }
            else
            {
                MessageBox.Show("Please select an appointment to delete.");
            }

        }
        public void checkAvailableTimeSlots(string selectedDate, int selectedBarberId, ComboBox cmbTime)
        {
            try
            {
                using (OracleConnection conn = new OracleConnection(DBConnectcs.oraDB))
                {
                    string getAvailableTimeSlotsQuery = @"
                SELECT at.apptime
                FROM AppointmentTimes at
                LEFT JOIN Appointments a ON at.apptime = a.apptime AND TRUNC(TO_DATE(a.appointmentdate, 'DD-MON-YY')) = TRUNC(TO_DATE(:selectedDate, 'DD-MON-YY')) AND a.barber_id = :selectedBarberId
                WHERE a.appointment_id IS NULL
                ORDER BY at.apptime";

                    conn.Open();

                    using (OracleCommand getAvailableTimeSlotsCommand = new OracleCommand(getAvailableTimeSlotsQuery, conn))
                    {
                        getAvailableTimeSlotsCommand.Parameters.Add(":selectedDate", OracleDbType.Varchar2).Value = selectedDate;
                        getAvailableTimeSlotsCommand.Parameters.Add(":selectedBarberId", OracleDbType.Int32).Value = selectedBarberId;

                        using (OracleDataReader timeSlotsReader = getAvailableTimeSlotsCommand.ExecuteReader())
                        {
                            cmbTime.Items.Clear();

                            while (timeSlotsReader.Read())
                            {
                                cmbTime.Items.Add(timeSlotsReader["apptime"]);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }








    }
}
