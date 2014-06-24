using System;
using System.Collections.Generic;
using System.Linq;


namespace ForestRoad
{
    class ForestRoad
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            for (int i = 0; i < N; i++)
            {
                int dotsLeft = i;
                int dotsRigth = (N- dotsLeft) - 1;
                int asterix = 1;
                Console.Write(new string('.',dotsLeft));
                Console.Write(new string('*', asterix));
                Console.Write(new string('.', dotsRigth));
                Console.WriteLine();
            }
            for (int i = 1; i < N;i++)
            {
                int dotsRigth = i;
                int dotsLeft = (N - dotsRigth) - 1;
                int asterix = 1;
                Console.Write(new string('.',dotsLeft));
                Console.Write(new string('*',asterix));
                Console.Write(new string('.',dotsRigth));
                Console.WriteLine();
            }
        }
    }
}
