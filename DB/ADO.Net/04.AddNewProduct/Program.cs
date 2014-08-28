using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

//Write a method that adds a new product in the products table in the Northwind database. 
//Use a parameterized SQL command.

namespace AddNewProduct
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
                string prodName = "@ColdBeer";
                decimal value = 1.5m;

                SqlParameter nameParam = new SqlParameter("@Added", prodName);
               
                SqlParameter priceParam = new SqlParameter("@Price",value);

                SqlCommand sqlCmd = new SqlCommand("INSERT INTO Products(ProductName,UnitPrice) VALUES(@Added,@Price)", dbConn);

                sqlCmd.Parameters.Add(nameParam);
                sqlCmd.Parameters.Add(priceParam);

                int rows = sqlCmd.ExecuteNonQuery();
                if (rows == 1)
                {
                    Console.WriteLine("Product added!");
                }
                else
                {
                    Console.WriteLine("Error");
                }
            }
        }
    }
}
