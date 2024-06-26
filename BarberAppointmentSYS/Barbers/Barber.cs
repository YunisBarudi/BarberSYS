﻿using BarberAppointmentSYS.Appointments;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarberAppointmentSYS
{
    class Barber
    {
        private String forename;
        private String surname;
        private String postcode;
        private String email;
        private String phone;
        private char status;
        private int barber_id;
    
        public Barber() { 
        
            this.barber_id = 0;
            this.forename = "";
            this.surname = "";
            this.postcode = "";
            this.phone = "";
            this.email = "";
            this.status = 'A';

        }
        public Barber(int barber_id, string forename, string surname, string postcode, string email,
            string phone, char status)
        {
            this.barber_id = barber_id;
            this.forename = forename;
            this.surname = surname;
            this.postcode = postcode;
            this.email = email;
            this.phone = phone;
            this.status = status;
            
        }
        ///Getters///
        public String getForename()
        {
            return forename;
        }
        public String getSurname()
        {
            return surname;
        }
        public String getPostcode()
        {
            return postcode;
        }
        public String getEmail()
        {
            return email;
        }
        public int getBarber_id()
        {
            return barber_id;
        }
        public String getPhone()
        {
            return phone;
        }
        public char getStatus()
        {
            return status;
        }

        ///Setters///
        
        public void setForename(String forename)
        {
            this.forename = forename;
        }
        public void setSurname(String surname)
        {
            this.surname = surname;
        }
        public void setPostcode(String postcode)
        {
            this.postcode = postcode;
        }
        public void setEmail(String email)
        {
            this.email = email;
        }
        public void setPhone(String phone)
        {
            this.phone = phone;

        }
        public void setStatus(char status) 
        { 
            this.status = status;

        }
        public void setBarber_Id(int barber_id)
        {
            this.barber_id = barber_id;
        }

        public static int getNextBarber_ID()
        {
            OracleConnection conn = new OracleConnection(DBConnectcs.oraDB);

            String sqlQuery = "SELECT MAX(Barber_Id) FROM Barbers";

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
        public void addBarber()
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnectcs.oraDB);

            //Define the SQL query to be executed
            String sqlQuery = "INSERT INTO Barbers Values (" +
                this.barber_id + ",'" +
                this.forename + "','" +
                this.surname + "','" +
                this.postcode + "','" +
                this.phone + "','" +
                this.email + "','" +
                this.status + "')";

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            cmd.ExecuteNonQuery();

            //Close db connection
            conn.Close();
        }
        public void getBarber(int barber_id)
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnectcs.oraDB);

            //Define the SQL query to be executed
            String sqlQuery = "SELECT * FROM Barbers WHERE Barber_ID = " + barber_id;

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            OracleDataReader dr = cmd.ExecuteReader();
            dr.Read();

            //set the instance variables with values from data reader
            setBarber_Id(dr.GetInt32(0));
            setForename(dr.GetString(1));
            setSurname(dr.GetString(2));
            setPostcode(dr.GetString(3));
            setPhone(dr.GetString(4));
            setEmail(dr.GetString(5));
            setStatus(Convert.ToChar(dr.GetString(6)));
            

            //close DB
            conn.Close();
        }
        public void listBarbers(RichTextBox listBarbers,string orderBy)
        {
            OracleConnection conn = new OracleConnection(DBConnectcs.oraDB);

            String sqlQuery = "SELECT * FROM Barbers " +
                  "ORDER BY " + orderBy;

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();
            OracleDataReader reader = cmd.ExecuteReader();


            listBarbers.Clear();

            while (reader.Read())
            {
                string barberInfo = string.Format("Name: {0} {1}, Postcode: {2}, Phone: {3}, Email: {4}, Status: {5}",
                                         reader["FORENAME"], reader["SURNAME"],reader["POSTCODE"],
                                         reader["PHONE"], reader["EMAIL"], reader["STATUS"]);
                listBarbers.AppendText(barberInfo + "\n\n");
            }

            reader.Close();
        }

    
        
        public void changeBarber()
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnectcs.oraDB);

            //Define the SQL query to be executed
            String sqlQuery = "UPDATE Barbers SET " +
                "Forename = '" + this.forename + "'," +
                "Surname = '" + this.surname + "'," +
                "Postcode = '" + this.postcode + "'," +
                "Phone = '" + this.phone + "'," +
                "Email = '" + this.email + "'," +
                "Status = '" + this.status + "' " +
                "WHERE Barber_Id = " + this.barber_id;

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            cmd.ExecuteNonQuery();

            //Close db connection
            conn.Close();
        }
        public void removeBarber()
        {
            OracleConnection conn = new OracleConnection(DBConnectcs.oraDB);

            String sqlQuery = "UPDATE Barbers SET " +
                "Status = 'D' " +
                "WHERE Barber_Id = " + this.barber_id;
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            cmd.ExecuteNonQuery();

            conn.Close();
        }
        
    }
}
