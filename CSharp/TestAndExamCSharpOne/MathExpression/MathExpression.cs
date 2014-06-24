using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathExpression
{
    class MathExpression
    {
        static void Main()
        {
            double N = double.Parse(Console.ReadLine());
            double M = double.Parse(Console.ReadLine());
            double P = double.Parse(Console.ReadLine());

            double upperResult = (N * N) + (1 / (M * P)) + 1337;
            double lowerResult = N - (128.523123123 * P);

            double leftSide = upperResult / lowerResult;
            double rightSide = Math.Sin((int)M % 180);
            double finalResult = leftSide + rightSide;
            Console.WriteLine("{0:0.000000}",finalResult);
        }
    }
}
