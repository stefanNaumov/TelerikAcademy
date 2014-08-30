using System;
using System.Collections.Generic;
using System.Linq;
using _01.DbContext;
using DbContext;
//Create a DAO class with static methods which provide functionality for inserting, 
//modifying and deleting customers. Write a testing class.

namespace _02.InsertModifyDeleteNorthwind
{
    class Program
    {
        static void Main()
        {
            DAO.AddCustomer("3345", "Vafla barkoch Ltd", "Gruiovo");

            NorthwindEntities entities = new NorthwindEntities();

            Customer addedCustomer = entities.Customers.FirstOrDefault(c => c.CustomerID == "3345");
            Console.WriteLine(addedCustomer.CompanyName);
        }
    }
}
