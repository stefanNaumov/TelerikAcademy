using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace LeastMajorityMultiple
{
    class LeastMajorityMultiple
    {
        static void Main()
        {
            
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            int e = int.Parse(Console.ReadLine());

            BigInteger result = 0;
            
            int counter = 0;
            for (int i = 1; i < int.MaxValue; i++)
            {
                if (i % a == 0)
                {
                    counter++;
                }
                if (i % b == 0)
                {
                    counter++;
                }
                if (i % c == 0)
                {
                    counter++;
                }
                if (i % d == 0)
                {
                    counter++;
                }
                if (i % e == 0)
                {
                    counter++;
                }
                if (counter >= 3)
                {
                    result = i;
                    break;
                }
                counter = 0;
            }
            Console.WriteLine(result);
        }
    }
}
