using System;

class Fibonacci
{
    static void Main()
    {
        decimal a = 0;
        decimal b = 1;
        decimal sum = 0;
        for (decimal i = 0; i < 100; i++)
        {
            sum = a + b;
            a = b;
            b = sum;
            Console.WriteLine(sum);
        }
    }
}

