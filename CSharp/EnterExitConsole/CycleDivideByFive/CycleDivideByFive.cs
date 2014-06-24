using System;

class CycleDivideByFive
{
    static void Main()
    {
        Console.Write("Enter first digit:");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Enter second digit:");
        int b = int.Parse(Console.ReadLine());
        int count = 0;
        for ( int c = a; c<=b; c++)
        {
            if (c % 5 == 0)
            {
                count++;
            }
        }
        Console.WriteLine(count);
    }
}

