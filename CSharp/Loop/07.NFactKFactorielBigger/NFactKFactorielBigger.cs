using System;

//Write a program that calculates N!*K! / (K-N)! for given N and K (1<N<K).



class NFactKFactorielBigger
{
    static void Main()
    {
        Console.WriteLine("Enter number N for N!:");
        double N = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter number K for K!:");
        double K = double.Parse(Console.ReadLine());
        double NFactorial = 1;
        double KFactorial = 1;
        double result = 1;
        double sum = (N-K);
        if (N > K && K > 1)
        {
            for (double i = N; i >= 1; i--)
            {
                NFactorial *= i;
            }
            for (double i2 = K; i2 >= 1; i2--)
            {
                KFactorial *= i2;
            }
            for (double i3 = sum; i3 >= 1; i3--)
            {
                result *= i3;
            }
            Console.Write("N!*K!/(N-K)! = ");
            Console.WriteLine((NFactorial * KFactorial) / (result));
        }
        else if (N > K && K <= 1)
        {
            Console.WriteLine("K must be greater than 1!");
        }
        else if (N < K && K > 1)
        {
            Console.WriteLine("N must be greater than K!");
        }
        else if (N < K && K <= 1)
        {
            Console.WriteLine("Error!");
        }
    }
}

