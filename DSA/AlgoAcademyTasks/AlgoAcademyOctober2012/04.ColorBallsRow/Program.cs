using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorBallsRow
{
    class Program
    {
        static void Main()
        {
            char[] ballsInput = Console.ReadLine().ToArray();

            long permCount = GetPermutationsCount(ballsInput);

            Console.WriteLine(permCount);


        }

        static long GetPermutationsCount(char[] balls)
        {
            int[] ballCounter = new int[26];
            long result = GetFactorial(balls.Length);

            for (int i = 0; i < balls.Length; i++)
            {
                ballCounter[(int)balls[i] - 65]++;
            }

            for (int i = 0; i < ballCounter.Length; i++)
            {
                int currBall = ballCounter[i];

                long factorial = GetFactorial(currBall);

                result = result / factorial;
            }

            return result;
        }

        static long GetFactorial(int num)
        {
            long result = 1;

            for (int i = 2; i <= num; i++)
            {
                result *= i;
            }

            return result;
        }
    }
}
