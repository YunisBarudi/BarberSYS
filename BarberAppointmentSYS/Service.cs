using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarberAppointmentSYS
{
     class Service
    {
        private String name;
        private String description;
        private double rate;
        private char status;
        private int service_id;
        private String service_type;
        public Service() {
            this.service_id = 0;
            this.name = "";
            this.description = "";
            this.status = 'A';
            this.rate = 0;
            this.service_type = "";

        }
        public Service(int service_id, string name, string description, double rate, char status, string service_type)
        {
            this.name = name;
            this.description = description;
            this.rate = rate;
            this.status = status;
            this.service_id = service_id;
            this.service_type = service_type;
        }
        /// Getters ///
        public String getService_type()
        {
            return service_type;
        }
        public String getName()
        {
            return name;
        }
        public double getRate()
        {
            return rate;
        }
        public char getStatus()
        {
            return status;
        }
        public int getService_id()
        {
            return service_id;
        }
        public String getDescription()
        {
            return description;
        }

        /// Setters ///

        public void setService_Type(String service_type)
        {
            this.service_type = service_type;
        }

        public void setName(String name)
        {
           this.name=name;
        }
        public void setDescription(String description) 
        { 
            this.description = description;
        }
        public void setRate(double rate)
        {
            this.rate = rate;
        }
        public void setStatus(char status)
        {
            this.status = 'A'; 
        }
        public void setServiceID(int service_id)
        {
            this.service_id = service_id;
        }
        public static int getNextServiceID()
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnectcs.oraDB);

            //Define the SQL query to be executed
            String sqlQuery = "SELECT MAX(Service_ID) FROM Services";

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            OracleDataReader dr = cmd.ExecuteReader();

            //Does dr contain a value or NULL?
            int nextId;
            dr.Read();

            if (dr.IsDBNull(0))
                nextId = 1;
            else
            {
                nextId = dr.GetInt32(0) + 1;
            }

            //Close db connection
            conn.Close();

            return nextId;
        }
        public void addService()
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnectcs.oraDB);

            //Define the SQL query to be executed
            String sqlQuery = "INSERT INTO Services Values (" +
                this.service_id + ",'" +
                this.name + "','" +
                this.description + "'," +
                this.rate + ",'" +
                this.status + "','" +
                this.service_type + "')";

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            cmd.ExecuteNonQuery();

            //Close db connection
            conn.Close();
        }
        public void changeService()
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnectcs.oraDB);

            //Define the SQL query to be executed
            String sqlQuery = "UPDATE Products SET " +
                "Service_Id = " + this.service_id + "," +
                "Name = '" + this.name + "'," +
                "Description = '" + this.description + "'," +
                "Rate = " + this.rate + "," +
                "Status = '" + this.status + "'," +
                "TypeCode = '" + this.service_type + "' " +
                "WHERE ProductId = " + this.service_id;

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            cmd.ExecuteNonQuery();

            //Close db connection
            conn.Close();
        }

    }
}
