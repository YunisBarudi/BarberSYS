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
        private string appointmentDate;
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
            this.appointmentDate = "";
            this.appointmentTime = "";
            this.service_id = 0;
            this.barber_id = 0;

        }
        public Appointment(int appointment_id, string forename, string surname, string phone,
            string email, string appointmentDate, string appointmentTime, int service_id, int barber_id)
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
        public string getAppointmentDate()
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
        public void setAppointmentDate(String appointment_date)
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

            //Define the SQL query to be executed
            String sqlQuery = "INSERT INTO Appointments Values (" +
                this.appointment_id + ",'" +
                this.forename + "','" +
                this.surname + "','" +
                this.phone + "','" +
                this.email + "','" +
                this.appointmentDate + "','" +
                this.appointmentTime + "'," +
                this.service_id + "," +
                this.barber_id + ")";

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            cmd.ExecuteNonQuery();

            //Close db connection
            conn.Close();
        }
        public void checkAvailableTimeSlots(string selectedDate, ComboBox cmbTime)
        {
            try
            {
                OracleConnection conn = new OracleConnection(DBConnectcs.oraDB);

                // Debugging: Print the selectedDate and connection string
                Console.WriteLine("Selected Date: " + selectedDate);
                Console.WriteLine("Connection String: " + DBConnectcs.oraDB);

                string getAvailableTimeSlotsQuery = "SELECT apptime " +
                                                     "FROM AppointmentTimes " +
                                                     "WHERE apptime NOT IN (" +
                                                     "    SELECT apptime " +
                                                     "    FROM Appointments " +
                                                     "    WHERE TRUNC(appointmentdate) = TO_DATE(:selectedDate, 'YYYY-MM-DD')" +
                                                     ")";

                conn.Open();

                using (OracleCommand getAvailableTimeSlotsCommand = new OracleCommand(getAvailableTimeSlotsQuery, conn))
                {
                    getAvailableTimeSlotsCommand.Parameters.Add(":selectedDate", selectedDate);

                    OracleDataReader timeSlotsReader = getAvailableTimeSlotsCommand.ExecuteReader();
                    cmbTime.Items.Clear();

                    while (timeSlotsReader.Read())
                    {
                        cmbTime.Items.Add(timeSlotsReader["apptime"]);
                    }
                    timeSlotsReader.Close();
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                // Log or display the error message
                MessageBox.Show("Error: " + ex.Message);
            }
        }


    }
}
