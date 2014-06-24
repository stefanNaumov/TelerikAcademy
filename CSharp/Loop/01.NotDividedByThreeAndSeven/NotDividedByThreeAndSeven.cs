using System;

//Write a program that prints all the numbers from 1 to N, that are not divisible by 3 and 7 at the same time.




class NotDividedByThreeAndSeven
{
    static void Main()
    {
        int a = 1;
        Console.WriteLine("Enter N:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("The numbers which cannot be divided by 3 or 7 until {0}, are:",n);
        for (int i = a; i < n; i++)
        {
            if (!((i % 3 == 0) || (i % 7 == 0)))
            {
                Console.WriteLine(i);
            }
        }
    }
}

