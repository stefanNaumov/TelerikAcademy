using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//By inheriting the Employee entity class create a class 
//which allows employees to access their corresponding territories as property of type EntitySet<T>.

namespace _08.EntityClassInheritance
{
    class Program
    {
        static void Main()
        {
            NorthwindEntities entities = new NorthwindEntities();

            Employees employee = new Employees();

            employee = entities.Employees.Find(1);

            foreach (var territory in employee.Territories)
            {
                Console.WriteLine(territory.TerritoryDescription);
            }
        }
    }
}
