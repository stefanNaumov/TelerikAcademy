using System;

class BiggestOfFiveIntegers
{
    static void Main()
    {
        Console.WriteLine("Please enter five integers");
        Console.WriteLine("First integer:");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Second integer:");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine("Third integer:");
        int c = int.Parse(Console.ReadLine());
        Console.WriteLine("Fourth integer:");
        int d = int.Parse(Console.ReadLine());
        Console.WriteLine("Fifth integer:");
        int e = int.Parse(Console.ReadLine());
        int Biggest = a;
        if (Biggest < b)
        {
            Biggest = b;
        }
        if (Biggest < c)
        {
            Biggest = c;
        }
        if (Biggest < d)
        {
            Biggest = d;
        }
        if (Biggest < e)
        {
            Biggest = e;
        }
        Console.WriteLine("The biggest number is {0}",Biggest);
    }
}

