using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;


namespace _ProductsFromString
{
    class Program
    {
        static void Main()
        {
            SqlConnection dbConn = new SqlConnection(
                "Server=.\\SQLSERVER2012; Database=Northwind; Integrated Security = true");

            string strInput = Console.ReadLine();

            if (strInput.Contains('%'))
            {
                strInput.Replace('%',' ');
            }

            if (strInput.Contains('\\'))
            {
                strInput.Replace('\\',' ');
            }

            if (strInput.Contains('\''))
            {
                strInput.Replace('\'', ' ');
            }

            if (strInput.Contains('\"'))
            {
                strInput.Replace('\"', ' ');
            }

            if (strInput.Contains('_'))
            {
                strInput.Replace('_', ' ');
            }

            dbConn.Open();

            using (dbConn)
            {
                SqlParameter inputParam = new SqlParameter();
                inputParam.ParameterName = "@inputParam";
                inputParam.Value = strInput;

                SqlCommand sqlCmd = new SqlCommand("SELECT p.ProductName FROM Products p WHERE p.ProductName LIKE @inputParam", dbConn);
                sqlCmd.Parameters.Add(inputParam);
                SqlDataReader reader = sqlCmd.ExecuteReader();

                using (reader)
                {
                    while (reader.Read())
                    {
                        Console.WriteLine("Name - {0}",reader["ProductName"]);
                    }
                }
            }
        }
    }
}
