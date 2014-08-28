using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;

//Write a program that retrieves from the Northwind database all product categories 
//and the names of the products in each category. 
//Can you do this with a single SQL query (with table join)?

namespace CategoriesAndNames
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
                SqlCommand sqlCmd = new SqlCommand("SELECT c.CategoryName, p.ProductName FROM Categories c " +
                                                    "INNER JOIN Products p ON c.CategoryID = p.CategoryID " +
                                                    "GROUP BY c.CategoryName,p.ProductName",dbConn);

                SqlDataReader reader = sqlCmd.ExecuteReader();

                using (reader)
                {
                    while (reader.Read())
                    {
                        Console.WriteLine("Category Name {0} - Product Name {1}",reader["CategoryName"],reader["ProductName"]);
                    }
                }
            }
        }
    }
}
