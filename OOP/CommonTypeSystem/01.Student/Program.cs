using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    class Program
    {
        static void Main()
        {
            Student one = new Student();
            Student two = new Student();
            one.FirstName = "a";
            two.FirstName = "a";
            Console.WriteLine(one.CompareTo(two));
            two.FirstName = "b";
            Console.WriteLine(one.CompareTo(two));
        }
    }
}
