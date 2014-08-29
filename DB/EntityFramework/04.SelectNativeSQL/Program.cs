using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04.SelectNativeSQL
{
    class Program
    {
        static void Main(string[] args)
        {
            NorthwindEntities entities = new NorthwindEntities();

            using (entities)
            {
                int orderDate = 1997;
                string shipCountry = "Canada";
                object[] parameters = {orderDate, shipCountry};

                string query = @"SELECT c.CompanyName FROM Customers c " +
                        "INNER JOIN Orders o ON o.CustomerID = c.CustomerID " +
                        "WHERE (YEAR(o.OrderDate) = {0} AND o.ShipCountry = {1});";
                
                var queryResult = entities.Database.SqlQuery<string>(query, parameters);

                foreach (var result in queryResult)
                {
                    Console.WriteLine(result);
                }
            }
        }
    }
}
