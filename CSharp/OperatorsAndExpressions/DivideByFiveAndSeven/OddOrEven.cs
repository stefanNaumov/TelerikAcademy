using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Please enter a number");
        int myNumber = int.Parse(Console.ReadLine());
        int a = myNumber % 5;
        int b = myNumber % 7;
        Console.WriteLine((a == 0) && (b == 0) ? "The number can be divided by 5 and 7" : "The number cannot be divided by 5 and 7");
    }
}

