using System;

class BiggestOfThree
{
    static void Main()
    {
        Console.WriteLine("Enter first number:");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter second number:");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter third number:");
        int c = int.Parse(Console.ReadLine());
        if (a >= b && a >= c && (a+b+c)>0 )
        {
            Console.WriteLine("The biggest number is {0}", a);
        }
        if (b >= a && b >= c && (a+b+c)>0)
        {
            Console.WriteLine("The biggest number is {0}", b);
        }
        else if ( c >= b && c >= a && (a+b+c)>0)
        {
            Console.WriteLine("The biggest number is {0}", c);
        }
        else 
        {
            Console.WriteLine("Fuck You!");
        }
    }
}

