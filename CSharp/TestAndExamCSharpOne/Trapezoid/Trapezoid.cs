using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trapezoid
{
    class Trapezoid
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());

            int dots = N;
            int asteriks = N;

            Console.Write(new string('.',dots));
            Console.Write(new string('*',asteriks));
            Console.WriteLine();
            int dotsLeft = N - 1;
            int dotsRight = N - 1;

            for (int i = 1; i < N; i++)
            {
                
                Console.Write(new string('.',dotsLeft));
                Console.Write('*');
                Console.Write(new string('.',dotsRight));
                Console.Write('*');
                dotsLeft--;
                dotsRight++;
                Console.WriteLine();
            }
            Console.WriteLine(new string('*',N*2));
        }
    }
}
