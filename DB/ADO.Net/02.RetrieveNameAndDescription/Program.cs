using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

//Write a program that retrieves the name and description of all categories in the Northwind DB.

namespace RetrieveNameAndDescription
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection dbConn = new SqlConnection(
                "Server=.\\SQLSERVER2012; Database=Northwind; Integrated Security = true");

            dbConn.Open();

            using (dbConn)
            {
                SqlCommand sqlCmd = new SqlCommand("SELECT CategoryName, Description FROM Categories", dbConn);

                SqlDataReader reader = sqlCmd.ExecuteReader();

                using (reader)
                {
                    while (reader.Read())
                    {
                        Console.WriteLine("Name: {0} - Description {1}", (string)reader["CategoryName"], (string)reader["Description"]);
                    }
                }
            }
        }
    }
}
