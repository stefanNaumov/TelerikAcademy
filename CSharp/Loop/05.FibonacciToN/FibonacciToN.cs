using System;

//Write a program that reads a number N and calculates the sum of the first N members of the sequence of Fibonacci: 
//0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …



class FibonacciToN
{
    static void Main()
    {

        double a = 0;
        double b = 1;
        double sum = 0;
        double result = 1;
        double firstN = 0;
        double secondN = 1;
        double temp = 0;
        Console.WriteLine("enter a number:");
        double n = double.Parse(Console.ReadLine());
        for (double i = 0; i < n; i++)
        {
            sum = a + b;
            a = b;
            b = sum;
            if (sum < n)
            {
                Console.WriteLine(sum);
            }
        }
        Console.WriteLine("Enter until which number to calculate Fibonacci sequence:");
        double nPos = double.Parse(Console.ReadLine());
        for (double i2 = 0; i2 < nPos+(firstN/2); i2 = result)
        {
            temp = firstN;
            firstN = secondN;
            secondN += temp;

            result += temp;
            Console.WriteLine(result);
        }
        Console.WriteLine("The sum of Fibonacci sequence until {0} is:",nPos);
        Console.WriteLine(result+firstN);
    }
}

