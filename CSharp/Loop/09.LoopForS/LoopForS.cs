using System;

//Write a program that, for a given two integer numbers N and X, calculates the sumS = 1 + 1!/X + 2!/X2 + … + N!/XN



class LoopForS
{
    static void Main()
    {
        Console.WriteLine("Enter N:");
        double N = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter X:");
        double X = double.Parse(Console.ReadLine());
        double sum = 1;
        double power;
        double factorial;
        for (double k = 1; k <= N; k++)
        {
            factorial = 1;
            power = 1;
            for (double i = 1; i <= k; i++)
            {
                factorial *= i;
                power *= X;
            }
            sum += (factorial / power);
        }
        Console.WriteLine("The result is = {0}",sum);
    }
}

