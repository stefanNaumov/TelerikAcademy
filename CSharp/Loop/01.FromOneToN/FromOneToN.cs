using System;


//Write a program that prints all the numbers from 1 to N.


namespace _01.FromOneToN
{
    class FromOneToN
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
