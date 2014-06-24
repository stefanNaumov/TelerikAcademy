using System;



//Write a program that reads 3 integer numbers from the console and prints their sum.


namespace _01.SumOfThreeIntegers
{
    class SumOfThreeIntegers
    {
        static void Main()
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());
            int sum = first + second + third;
            Console.WriteLine(sum);
        }
    }
}
