using System;
using System.Linq;
using System.Data.SqlClient;

//Write a program that retrieves from the Northwind sample database in MS SQL Server the number of  rows in the Categories table.

namespace RetrieveNumOfRows
{
    class Program
    {
        static void Main()
        {
            SqlConnection dbConn = new SqlConnection(
                "Server=.\\SQLSERVER2012; Database=Northwind; Integrated Security = true");

            dbConn.Open();

            using (dbConn)
            {
                SqlCommand sqlCmd = new SqlCommand(@"SELECT COUNT(*) FROM Categories", dbConn);
                int count = (int)sqlCmd.ExecuteScalar();

                Console.WriteLine("the count of rows in dbo.Categories is {0}",count);
            }
        }
    }
}
