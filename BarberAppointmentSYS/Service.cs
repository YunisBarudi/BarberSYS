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
        private String service_id;
        private String service_type;
        public Service() { 
        }
        public static int getNextProdID()
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
    }
}
