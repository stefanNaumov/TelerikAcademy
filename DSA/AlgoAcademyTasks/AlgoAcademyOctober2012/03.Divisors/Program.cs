using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Divisors
{
    class Program
    {
        static List<int> permutations = new List<int>();
        static int numberOfElements;

        static void Main()
        {
            numberOfElements = int.Parse(Console.ReadLine());

            int[] numbers = new int[numberOfElements];

            for (int i = 0; i < numberOfElements; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

        }

        static void GetPermutations()
        {
            
        }
    }
}
