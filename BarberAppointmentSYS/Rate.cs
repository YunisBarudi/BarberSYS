using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace BarberAppointmentSYS
{

    class Rate
    {
        private String service_type;
        private String description;

        public Rate()
        {
            this.service_type = "";
            this.description = "";
        }
        public Rate(String service_type, String description)
        {
            this.service_type = service_type;
            this.description = description;
        }
        // Getters and Setters //
        public String getService_type()
        {
            return this.service_type;
        }
        public String getDescription()
        {
            return this.description;
        }
        public void setService_type(String Service_type)
        {
            service_type = Service_type;
        }
        public void setDescription(String Description)
        {
            this.description = Description;
        }
        public void  addRate() {

            OracleConnection conn = new OracleConnection(DBConnectcs.oraDB);

            //Define the SQL query to be executed
            String sqlQuery = "INSERT INTO Rates Values ('" +
               this.service_type + "','" +
               this.description + "')";

            OracleCommand cmd = new OracleCommand(sqlQuery,conn);
            conn.Open();

            cmd.ExecuteNonQuery();

            conn.Close();
        }
    }

}
