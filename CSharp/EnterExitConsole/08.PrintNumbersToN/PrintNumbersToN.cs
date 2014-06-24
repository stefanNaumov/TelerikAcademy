using System;
using System.Threading;


namespace _08.PrintNumbersToN
{
    class PrintNumbersToN
    {
        static void Main()
        {
            Console.WriteLine("Enter number N:");
            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(400);
            }
        }
    }
}
