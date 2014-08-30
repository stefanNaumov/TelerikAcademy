using System;
using System.Collections.Generic;
using DbContext;

//STORED PROCEDURE IN SQL SERVER

//ALTER PROC [dbo].[usp_GetIncome](@supplierName varchar(50), @startDate date, @endDate date)
//AS
//SELECT s.CompanyName, ordDet.UnitPrice * ordDet.Quantity AS Income
//FROM Suppliers s
//INNER JOIN Products p
//ON p.SupplierID = s.SupplierID
//INNER JOIN [Order Details] ordDet
//ON ordDet.ProductID = p.ProductID
//INNER JOIN Orders o
//ON o.OrderID = ordDet.OrderID
//WHERE o.OrderDate BETWEEN @startDate AND @endDate
//AND s.CompanyName = @supplierName
//ORDER BY Income
namespace _10.GetIncome
{
    class Program
    {
        static void Main()
        {
            NorthwindEntities entities = new NorthwindEntities();

            using (entities)
            {
                var findIncomes = entities.usp_GetIncome("Leka Trading", DateTime.Parse("1995-01-01"), DateTime.Parse("2012-12-21"));

                foreach (var income in findIncomes)
                {
                    Console.WriteLine("Company: " + income.CompanyName + " Income: " + income.Income);
                }
            }
        }
    }
}
