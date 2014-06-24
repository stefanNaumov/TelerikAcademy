using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Tribonacci
{
    class Tribonacci
    {
        static void Main()
        {
            BigInteger first = BigInteger.Parse(Console.ReadLine());
            BigInteger second = BigInteger.Parse(Console.ReadLine());
            BigInteger third = BigInteger.Parse(Console.ReadLine());
            BigInteger elementIndex = BigInteger.Parse(Console.ReadLine());
            BigInteger sum = 0;
            if (elementIndex == 1)
            {
                Console.WriteLine(first);
            }
            else if (elementIndex == 2)
            {
                Console.WriteLine(second);
            }
            else if (elementIndex == 3)
            {
                Console.WriteLine(third);
            }
            else
            {

                for (int i = 3; i < elementIndex; i++)
                {
                    sum = first + second + third;
                    first = second;
                    second = third;
                    third = sum;

                }
                Console.WriteLine(sum);
            }
        }
    }
}
