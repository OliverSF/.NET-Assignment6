using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SuperMarketAssignment
{
    class Customer
    {
        
        private string connectionString = "Data Source = lugh4.it.nuigalway.ie; Initial Catalog = msdb2431; Persist Security Info=True;User ID = msdb2431; Password=msdb2431OL";

        public void createCustomerTable(String query)
        {
            //instatiating the connection
            SqlConnection conn = new SqlConnection(connectionString);

            SqlDataReader rdr = null;

            try
            {
                //Open the connection
                conn.Open();

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.ExecuteNonQuery();
            }
            finally
            {
                //close the reader
                if (rdr != null)
                {
                    rdr.Close();
                }

                //Close the connection
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }

        public void insertCustomerValues(String query)
        {
            //instatiating the connection
            SqlConnection conn = new SqlConnection(connectionString);

            SqlDataReader rdr = null;

            try
            {
                //Open the connection
                conn.Open();

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.ExecuteNonQuery();
            }
            finally
            {
                //close the reader
                if (rdr != null)
                {
                    rdr.Close();
                }

                //Close the connection
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }

        public void updateCustomerTable(String query)
        {
            //instatiating the connection
            SqlConnection conn = new SqlConnection(connectionString);

            SqlDataReader rdr = null;

            try
            {
                //Open the connection
                conn.Open();

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.ExecuteNonQuery();
            }
            finally
            {
                //close the reader
                if (rdr != null)
                {
                    rdr.Close();
                }

                //Close the connection
                if (conn != null)
                {
                    conn.Close();
                }
            }

        }

        public void deleteQueryCustomer(String query)
        {
            //instatiating the connection
            SqlConnection conn = new SqlConnection(connectionString);

            SqlDataReader rdr = null;

            try
            {
                //Open the connection
                conn.Open();

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.ExecuteNonQuery();
            }
            finally
            {
                //close the reader
                if (rdr != null)
                {
                    rdr.Close();
                }

                //Close the connection
                if (conn != null)
                {
                    conn.Close();
                }
            }

        }

        public void readCustomerTable(String query)
        {
            //instatiating the connection
            SqlConnection conn = new SqlConnection(connectionString);

            SqlDataReader rdr = null;

            try
            {
                //Open the connection
                conn.Open();

                SqlCommand cmd = new SqlCommand(query, conn);

                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    Console.WriteLine(rdr[0] + ": " + "Customer: " + rdr[1] + " Product: " + rdr[2]);

                }
            }
            finally
            {
                //close the reader
                if (rdr != null)
                {
                    rdr.Close();
                }

                //Close the connection
                if (conn != null)
                {
                    conn.Close();
                }

            }
        }

        public void createCustomerQuery(String query)
        {
            //instatiating the connection
            SqlConnection conn = new SqlConnection(connectionString);

            SqlDataReader rdr = null;

            try
            {
                //Open the connection
                conn.Open();

                SqlCommand cmd = new SqlCommand(query, conn);

                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    Console.WriteLine(rdr[0] + ": " + rdr[1] + ", " + rdr[2] + ", " + rdr[3]);

                }
            }
            finally
            {
                //close the reader
                if (rdr != null)
                {
                    rdr.Close();
                }

                //Close the connection
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }        
    }
}
