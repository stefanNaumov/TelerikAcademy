using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a method that finds all customers who have orders made in 1997 and shipped to Canada.

namespace _03.SelectOrders
{
    class Program
    {
        static void Main()
        {
            ICollection<string> customers = FindCustomers(1997, "Canada");

            foreach (var order in customers)
            {
                Console.WriteLine("Customer order: {0}", order);
            }
        }

        private static ICollection<string> FindCustomers(int orderYear, string destination)
        {
            NorthwindEntities entities = new NorthwindEntities();
            ICollection<string> customersList = new List<string>();

            using (entities)
            {
                var query = from order in entities.Orders
                            where order.OrderDate.Value.Year == orderYear && order.ShipCountry == destination
                            select order;

                foreach (var order in query)
                {
                    customersList.Add(order.ShipName);
                }
            }

            return customersList;
        }
    }
}
