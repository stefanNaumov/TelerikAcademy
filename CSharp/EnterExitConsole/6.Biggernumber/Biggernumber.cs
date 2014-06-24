using System;

//Write a program that gets two numbers from the console and prints the greater of them. Don’t use if statements.


class Biggernumber
{
    static void Main()
    {
        Console.Write("Please enter the first number:");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Please enter the second number:");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine(Math.Max(a,b));
    }
}

