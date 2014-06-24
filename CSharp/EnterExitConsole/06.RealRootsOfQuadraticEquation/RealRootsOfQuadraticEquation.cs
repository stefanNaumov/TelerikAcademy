using System;


//Write a program that reads the coefficients a, b and c of a quadratic equation ax2+bx+c=0 and solves it 
//(prints its real roots).

namespace _06.RealRootsOfQuadraticEquation
{
    class RealRootsOfQuadraticEquation
    {
        static void Main()
        {
            Console.WriteLine("Enter value for A");
            double A = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter value for B");
            double B = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter value for C");
            double C = double.Parse(Console.ReadLine());
            
            double dis = (B * B) - (4 * A * C);
            if (dis < 0)
            {
                Console.WriteLine("Equation do not have real roots");
            }
            else if (dis == 0)
            {
                dis = Math.Sqrt(dis);
                double root = (-B + dis) / (2 * A);
                Console.WriteLine("Equation have 1 real root X = " + root);
            }
            else
            {
                dis = Math.Sqrt(dis);
                double rootOne = (-B + dis) / (2 * A);
                double rootTwo = (-B - dis) / (2 * A);
                Console.WriteLine("Equation have 2 real roots \nX1 = {0:0.000} and X2 = {1:0.000}", rootOne, rootTwo);
            }

        }
    }
}
