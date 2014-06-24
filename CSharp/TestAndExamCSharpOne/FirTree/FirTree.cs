using System;

namespace FirTree
{
    class FirTree
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());

            int leftDots = N - 2;
            int rightDots = N - 2;
            int asteriks = 1;

            for (int i = 0; i < N - 1; i++)
            {
                Console.Write(new string('.',leftDots) + new string('*',asteriks) + new string('.',rightDots));
                leftDots--;
                rightDots--;
                asteriks += 2;
                Console.WriteLine();
            }
            Console.Write(new string('.',N - 2) + '*' + new string('.',N - 2));
            Console.WriteLine();

        }
    }
}
