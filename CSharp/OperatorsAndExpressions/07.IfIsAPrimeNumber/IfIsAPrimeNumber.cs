using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.IfIsAPrimeNumber
{
    class IfIsAPrimeNumber
    {
        static void Main()
        {
            //int number = int.Parse(Console.ReadLine()); ;
            //bool isPrime = true;

            //for (int i = 2; i < number/2; i++)
            //{
            //    if (number % i == 0)
            //    {
            //        isPrime =  false;
            //    }
                
            //}
            //Console.WriteLine("Is your number prime - {0}",isPrime);
            uint n;
            uint mask = 7;
            uint FirstThree;
            uint SecondThree;
            do
            {
                Console.Write("Input an Unsigned Int=");
            } while (!uint.TryParse(Console.ReadLine(), out n));
            Console.WriteLine(Convert.ToString(n, 2).PadLeft(32, '0'));
            FirstThree = n & (mask << 3);
            SecondThree = n & (mask << 23);
            mask = n & (~(mask << 3) | (mask << 23));
            n = mask | (FirstThree << 21);
            n = n | (SecondThree >> 21);
            Console.WriteLine(Convert.ToString(n, 2).PadLeft(32, '0'));

        }
    }
}
