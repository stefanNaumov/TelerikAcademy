using System;
//Write a program that calculates the greatest common divisor (GCD) of given two numbers. 
//Use the Euclidean algorithm (find it in Internet).


namespace _08.GreatestCommonDivisor
{
    class GreatestCommonDivisor
    {
        static void Main()
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());

            int biggestNumber = Math.Max(first, second);
            int gcd = 0;

            for (int i = 1; i <= biggestNumber; i++)
            {
                if (first % i == 0 && second % i == 0)
                {
                    gcd = i;
                }
            }
            Console.WriteLine(gcd);
        }
    }
}
