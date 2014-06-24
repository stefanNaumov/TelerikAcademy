using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForestRoad
{
    class ForestRoad
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int rightdots = N - 1;
            int Leftdots = 0;

            for (int i = 0; i < N - 1; i++)
            {
                Console.Write(new string('.',Leftdots));
                Console.Write('*');
                Console.Write(new string('.',rightdots));
                Console.WriteLine();
                Leftdots++;
                rightdots--;
            }
            for (int i = N; i > 0; i--)
            {
                Console.Write(new string('.',Leftdots));
                Console.Write('*');
                Console.Write(new string('.',rightdots));
                Console.WriteLine();
                Leftdots--;
                rightdots++;
            }

        }
    }
}
