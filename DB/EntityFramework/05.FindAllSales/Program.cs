using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Write a method that finds all the sales by specified region and period (start / end dates).

namespace _05.FindAllSales
{
    class Program
    {
        static void Main()
        {
            FindSales("Western", 1997, 2012);
        }

        private static void FindSales(string region, int startDate, int endDate)
        {
            NorthwindEntities entities = new NorthwindEntities();

            var queryResult = from order in entities.Orders
                        where order.ShipRegion == region
                        && order.OrderDate.Value.Year > startDate
                        && order.OrderDate.Value.Year < endDate
                        select order;
            if (queryResult.Count() == 0)
            {
                Console.WriteLine("No such element");
            }

            foreach (var order in queryResult)
            {
                Console.WriteLine("Region: " + order.ShipRegion + "Date: " + order.OrderDate);
            }
        }
    }
}
