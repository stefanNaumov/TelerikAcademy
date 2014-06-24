using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trapeziod
{
    class Trapezoid
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            if (!(N < 3 || N > 39))
            {
                for (int i = 0; i < 1; i++)
                {
                    int dots = N;
                    int asteriks = N;
                    Console.Write(new string('.', dots));
                    Console.Write(new string('*', asteriks));
                    Console.WriteLine();
                }
                for (int i2 = 0; i2 < N - 1; i2++)
                {
                    int asterix = 2;
                    int rightDots = i2 + ((N - asterix) + 1);
                    int leftDots = (2 * N - rightDots) - 2;
                    Console.Write(new string('.', leftDots));
                    Console.Write(new string('*', asterix / 2));
                    Console.Write(new string('.', rightDots));
                    Console.Write(new string('*', asterix / 2));
                    Console.WriteLine();
                }
                for (int i = N - 1; i < N; i++)
                {
                    int asterix = 2 * N;
                    Console.Write(new string('*', asterix));
                    Console.WriteLine();
                }
            }
        }
    }
}
