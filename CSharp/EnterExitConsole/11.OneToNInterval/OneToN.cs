using System;
using System.Threading;


class OneToN
{
    static void Main()
    {
        Console.WriteLine("Please enter a number:");
        
        int n = int.Parse(Console.ReadLine());
        int sum=1;
        for (int i = 1; i <= n; i++)
        {
            sum = i;
            Console.WriteLine(sum);
            Thread.Sleep(500);
        }
        
    }
}

