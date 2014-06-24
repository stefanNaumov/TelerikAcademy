using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Workingdays
{
    class Workingdays
    {
        static void Main()
        {
            //int day = int.Parse(Console.ReadLine());
            //int month = int.Parse(Console.ReadLine());
            //int year = int.Parse(Console.ReadLine());
            DateTime start = DateTime.Today;
            DateTime end = new DateTime(2013, 2, 1);
        }
        static void Holidays()
        {
            DateTime[] Holidays = {new DateTime(2013,12,24),new DateTime(2013,12,31),new DateTime(2013,5,1),new DateTime(2013,5,2),
                                      new DateTime(2013,5,3),new DateTime(2013,5,4),new DateTime(2013,5,5)};
        }
    }
}
