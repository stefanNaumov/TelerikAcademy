using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.InsertModifyDeleteNorthwind
{
    public static class DAO
    {
        private static NorthwindEntities entities = new NorthwindEntities();

       

        public static void AddCustomer(string customerID, string companyName, string city)
        {
            Customer customer = new Customer
                {
                    CustomerID = customerID,
                    CompanyName = companyName,
                    City = city
                };

            entities.Customers.Add(customer);
            entities.SaveChanges();
        }

        public static void UpdateCustomer(string customerID, string companyName)
        {
            Customer customer = GetCustomer(customerID);
            customer.CompanyName = companyName;

            entities.SaveChanges();
        }

        public static void DeleteCustomer(string customerID)
        {
            Customer customer = GetCustomer(customerID);
            entities.Customers.Remove(customer);

            entities.SaveChanges();
        }

        private static Customer GetCustomer(string customerID)
        {
            Customer customer = entities.Customers.FirstOrDefault(c => c.CustomerID == customerID);

            return customer;
        }
        
    }
}
