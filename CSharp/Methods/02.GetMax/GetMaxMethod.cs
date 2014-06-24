using System;
using System.Collections.Generic;

//Write a method GetMax() with two parameters that returns the bigger of two integers. 
//Write a program that reads 3 integers from the console and prints the biggest of them using the method GetMax().


class GetMaxMethod
{
    static void Main()
    {
        Console.Write("Enter first number:");
        int first = int.Parse(Console.ReadLine());
        Console.Write("Enter second number:");
        int second = int.Parse(Console.ReadLine());
        Console.Write("Enter third number:");
        int third = int.Parse(Console.ReadLine());
        int maxFRomFirstSecond = GetMax(first, second);
        int result = Math.Max(maxFRomFirstSecond, third);
        Console.WriteLine("The biggest number is: {0}",result);
        
    }
    static int GetMax(int first, int second)
    {
        if (first >= second)
        {
            return first;
        }
        else
        {
            return second;
        }
    }
}

