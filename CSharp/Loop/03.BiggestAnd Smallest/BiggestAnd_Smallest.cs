using System;

//Write a program that reads from the console a sequence of N integer numbers and returns the minimal and maximal of them.



class BiggestAnd_Smallest
{
    static void Main()
    {
        Console.WriteLine("How many numbers would you like to compare:");
        int numbers = int.Parse(Console.ReadLine());
        int MaxNum, MinNum, N;
        Console.WriteLine("Enter a number:");
        N = int.Parse(Console.ReadLine());
        MaxNum = MinNum = N;
        for (int i = 1; i < numbers; i++)
        {
            Console.WriteLine("Enter next number:");
            N = int.Parse(Console.ReadLine());
            if (MaxNum < N)
            {
                MaxNum = N;
            }
            if (MinNum > N)
            {
                MinNum = N;
            }
        }
        Console.WriteLine("The biggest number is {0} ",MaxNum);
        Console.WriteLine("The smallest number is {0} ",MinNum);
    }
}

