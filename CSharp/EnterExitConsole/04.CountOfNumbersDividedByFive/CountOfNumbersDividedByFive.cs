using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that reads two positive integer numbers and prints how many numbers p exist between
//them such that the reminder of the division by 5 is 0 (inclusive). Example: p(17,25) = 2.


namespace _04.CountOfNumbersDividedByFive
{
    class CountOfNumbersDividedByFive
    {
        static void Main()
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int counter = 0;

            for (int i = first; i <= second; i++)
            {
                if (i % 5 == 0)
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }
    }
}
