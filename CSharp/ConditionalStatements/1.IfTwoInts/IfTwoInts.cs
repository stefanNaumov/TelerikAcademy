using System;

class IfTwoInts
{
    static void Main()
    {
        Console.WriteLine("Enter first number:");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter second number:");
        int b = int.Parse(Console.ReadLine());
        if (a > b)
        {
            Console.WriteLine(a);
        }
        else
        {
            Console.WriteLine(b);
        }
    }
}

