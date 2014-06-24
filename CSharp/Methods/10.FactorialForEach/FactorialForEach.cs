using System;
using System.Collections.Generic;
using System.Numerics;

//Write a program to calculate n! for each n in the range [1..100]. 
//Hint: Implement first a method that multiplies a number represented as array of digits by given integer number. 



class FactorialForEach
{
    static void Main()
    {
        Console.Write("Enter number:");
        int num = int.Parse(Console.ReadLine());
        Console.WriteLine(Factorial(num));
    }
    static BigInteger Factorial(int number)
    {
        BigInteger result = 1;
        for (int i = 1; i <= number; i++)
        {
            result *= i;
        }
        return result;
    }
}

