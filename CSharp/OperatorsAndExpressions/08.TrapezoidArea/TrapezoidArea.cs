using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.TrapezoidArea
{
    class TrapezoidArea
    {
        static void Main()
        {
            //int trapezoidSideA = int.Parse(Console.ReadLine());
            //int trapezoidSideB = int.Parse(Console.ReadLine());
            //int trapezoidHeight = int.Parse(Console.ReadLine());

            //int trapezoidArea = ((trapezoidSideA + trapezoidSideB) / 2) * trapezoidHeight;
            //Console.WriteLine(trapezoidArea);
            string A;
            int N = 0;
            int mask = 1;
            mask = mask << 3;
            do
            {
                Console.Write("Input an int:");
                A = Console.ReadLine();
            }
            while (!int.TryParse(A, out N));
            N = N & mask;// 00001000
            if (N != 0)
            {
                Console.WriteLine("1");
            }
            else
            {
                Console.WriteLine("0");
            }
        }
    }
}
