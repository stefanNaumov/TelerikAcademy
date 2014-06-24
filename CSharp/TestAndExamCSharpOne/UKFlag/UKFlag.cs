using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UKFlag
{
    class UKFlag
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int leftDots = 1;
            int rightDots = (N-3)/2;

            Console.Write("\\");
            Console.Write(new string('.',rightDots));
            Console.Write('|');
            Console.Write(new string('.',rightDots));
            Console.Write('/');
            Console.WriteLine();
            
            rightDots--;

            for (int i = 0; i < (N-3)/2; i++)
            {
                Console.Write(new string('.',leftDots));
                Console.Write('\\');
                Console.Write(new string('.',rightDots));
                Console.Write('|');
                Console.Write(new string('.',rightDots));
                Console.Write('/');
                Console.Write(new string('.',leftDots));
                leftDots++;
                rightDots--;
                Console.WriteLine();
            }
            Console.Write(new string('-',N/2));
            Console.Write('*');
            Console.Write(new string('-',N/2));
            Console.WriteLine();
            leftDots = (N - 3) / 2;
            rightDots = 0;

            for (int i = 0; i < N/2; i++)
            {
                Console.Write(new string('.',leftDots));
                Console.Write('/');
                Console.Write(new string('.',rightDots));
                Console.Write('|');
                Console.Write(new string('.',rightDots));
                Console.Write('\\');
                Console.Write(new string('.',leftDots));
                Console.WriteLine();
                leftDots--;
                rightDots++;
            }

        }
    }
}
