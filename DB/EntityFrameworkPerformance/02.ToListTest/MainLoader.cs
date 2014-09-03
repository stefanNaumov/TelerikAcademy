using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

//Using Entity Framework write a query that selects all employees from the Telerik Academy database, 
//then invokes ToList(), then selects their addresses, then invokes ToList(), 
//then selects their towns, then invokes ToList() and finally checks whether the town is "Sofia". 
//Rewrite the same in more optimized way and compare the performance.

namespace _02.ToListTest
{
    class MainLoader
    {
        static void Main()
        {
            TelerikAcademyEntities entities = new TelerikAcademyEntities();
            Stopwatch watch = new Stopwatch();
            watch.Start();

            SlowSelection(entities);

            watch.Stop();
            Console.WriteLine("Slow selection: " + watch.Elapsed);

            watch.Reset();
            watch.Start();

            OptimizedConnection(entities);

            watch.Stop();
            Console.WriteLine("Optimized selection: " + watch.Elapsed);
        }

        static void SlowSelection(TelerikAcademyEntities entities)
        {
            List<Employees> allEmployees = entities.Employees.ToList();
            List<Addresses> employeesAddresses = (from employee in allEmployees
                                                  select employee.Addresses).ToList();
            List<Towns> employeesTowns = (from town in employeesAddresses
                                          select town.Towns).ToList();
            var sofiaSelect = from town in employeesTowns
                              where town.Name == "Sofia"
                              select town;
        }

        static void OptimizedConnection(TelerikAcademyEntities entities)
        {
            var optimizedSelection = from town in entities.Towns
                                     where town.Name == "Sofia"
                                     select town;
        }
    }
}
