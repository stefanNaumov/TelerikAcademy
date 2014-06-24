using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivisibleBy7And3
{
    class Program
    {
        static void Main()
        {
            int[] array = new int[200];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i;
            }
            Console.WriteLine("Numbers divisible by 7 and 3 using lambda expression:");
            PrintNumsUsingLambda(array);
            Console.WriteLine("Numbers divisible by 7 and 3 using LINQ:");
            PrintNumsUsingLINQ(array);
        }
        static void PrintNumsUsingLambda(int[] numbers)
        {
            var divisible = numbers.Where(x => x % 21 == 0);
            foreach (var number in divisible)
            {
                Console.WriteLine(number);
            }
        }
        static void PrintNumsUsingLINQ(int[] numbers)
        {
            var divisible = from num in numbers
                            where num % 21 == 0
                            select num;
            foreach (var number in divisible)
            {
                Console.WriteLine(number);
            }
        }
    }
}
