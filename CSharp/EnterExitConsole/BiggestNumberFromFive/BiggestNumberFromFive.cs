using System;

class BiggestNumberFromFive
{
    static void Main()
    {
        Console.WriteLine("First number:");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Second number:");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine("Third number:");
        int c = int.Parse(Console.ReadLine());
        Console.WriteLine("Fourth number:");
        int d = int.Parse(Console.ReadLine());
        Console.WriteLine("Fifth number:");
        int e = int.Parse(Console.ReadLine());
        if ((a > b) && (a > c) && (a > d) && (a > e))
        {
            Console.WriteLine("The biggest number is {0}", a);
        }
        else if ((b > a) && (b > c) && (b > d) && (b > e))
        {
            Console.WriteLine("The biggest number is {0}", b);
        }
        else if ((c > a) && (c > b) && (c > d) && (c > e))
        {
            Console.WriteLine("The biggeset number is {0}", c);
        }
        else if ((d > a) && (d > b) && (d > c) && (d > e))
        {
            Console.WriteLine("The biggeset number is {0}", d);
        }
        else if ((e > a) && (e > b) && (e > c) && (e > d)) 
        {
            Console.WriteLine("The biggest number is {0}", e);
        }
    }
}

