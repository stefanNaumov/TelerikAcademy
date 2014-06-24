using System;

//Write a program that gets a number n and after that gets more n numbers and calculates and prints their sum. 


class SumOfNIntegers
{
    static void Main()
    {
        Console.WriteLine("Enter number of values:");
        uint number = uint.Parse(Console.ReadLine());
        double sum = 0;
        for (uint i = 1; i <= number; i++)
        {
            Console.WriteLine("Enter a number:");
            double n = double.Parse(Console.ReadLine());
            sum += n;
        }
        Console.WriteLine("The sum of the numbers is {0}",sum);
    }
}

