using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    class Program
    {
        static void Main()
        {
            Person a = new Person("Ivan", 20);
            Person b = new Person("Gosho");
            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}
