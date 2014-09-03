using System;
using System.Collections.Generic;
using System.Data.Objects;
using System.Diagnostics;
using System.Linq;

//Using Entity Framework write a SQL query to 
//select all employees from the Telerik Academy database 
//and later print their name, department and town. 
//Try the both variants: with and without .Include(…). 
//Compare the number of executed SQL statements and the performance.


namespace _01.SelectEmployees
{
    class MainLoader
    {
        static void Main()
        {
            TelerikAcademyEntities entities = new TelerikAcademyEntities();

            using (entities)
            {
                var employees = entities.Employees;
                Stopwatch stopWatch = new Stopwatch();
                stopWatch.Start();
                foreach (var employee in employees)
                {
                   // Console.WriteLine(employee.FirstName + " " + employee.DepartmentID + " " + employee.Addresses.Towns.Name);
                }
                stopWatch.Stop();
                Console.Write("Number of items " + employees.Count() + ": ");
                Console.WriteLine(stopWatch.Elapsed);
                stopWatch.Reset();

                stopWatch.Start();
                foreach (var employee in entities.Employees.Include("Departments").Include("Addresses").Include("Addresses.Towns"))
                {
                    //Console.WriteLine(employee.FirstName + " " + employee.DepartmentID + " " + employee.Addresses.Towns.Name);
                }
                stopWatch.Stop();
                Console.Write("Number of items " + entities.Employees.Count() + ": ");
                Console.WriteLine(stopWatch.Elapsed);
            }
        }
    }
}
