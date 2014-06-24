using System;


//Write a program that calculates N!/K! for given N and K (1<K<N).



class NFaktKFaktoriel
{
    static void Main()
    {
        
        Console.WriteLine("Enter N!:");
        double N = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter K!:");
        double K = double.Parse(Console.ReadLine());
        double factorialA = 1;
        double factorialB = 1;
        double result;
        if (N > K && K > 1)
        {
            for (double i = N; i > 1; i--)
            {
                factorialA *= i;
            }
            for (double i2 = K; i2 > 1; i2--)
            {
                factorialB *= i2;
            }
            result = (factorialA / factorialB);
            Console.WriteLine("N!/K! = {0}",result);
        }
        else if (N < K || K < 1)
        {
            Console.WriteLine("N must be greater than K and K must be greater than 1!");
        }
    }
}

