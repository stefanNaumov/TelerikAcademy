using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Transactions;

//Create a method that places a new order in the Northwind database. 
//The order should contain several order items. Use transaction to ensure the data consistency.

namespace _09.PlaceOrderWithTRAN
{
    class Program
    {
        static void Main()
        {
            NorthwindEntities entities = new NorthwindEntities();
            
            using (entities)
            {
                using (var tranScope = new TransactionScope())
                {
                    try
                    {
                        Order order = new Order
                                    {
                                        ShipName = "SomeOrder",
                                        ShipCity = "Sofia"
                                    };

                        for (short i = 0; i < 3; i++)
                        {
                            Order_Detail orderItem = new Order_Detail
                            {
                                UnitPrice = 20 + i,
                                Quantity = (short)(5 + i)
                            };
                            order.Order_Details.Add(orderItem);
                        }
                        tranScope.Complete();
                        Console.WriteLine("Order added!");
                    }
                    catch (Exception ex)
                    {
                        tranScope.Dispose();
                    }
                }
            }
        }
    }
}
