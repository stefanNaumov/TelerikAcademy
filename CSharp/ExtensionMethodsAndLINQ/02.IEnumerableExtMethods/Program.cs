using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerableExtMethods
{
    class Program
    {
        static void Main()
        {
            List<int> l = new List<int>();
            for (int i = 1; i <= 5; i++)
            {
                l.Add(i);
            }
            int product = l.Product();
            int average = l.Average();
            int sum = l.Sum();
            int min = l.Min();
            int max = l.Max();
            Console.WriteLine("Product of list numbers: {0}",product);
            Console.WriteLine("Average value of list numbers: {0}",average);
            Console.WriteLine("Sum of list numbers: {0}",sum);
            Console.WriteLine("The minimal element is: {0}",min);
            Console.WriteLine("The max element is: {0}",max);
        }
    }
}
