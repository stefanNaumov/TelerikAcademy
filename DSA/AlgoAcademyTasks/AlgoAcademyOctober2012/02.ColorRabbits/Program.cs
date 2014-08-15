using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorRabbits
{
    class Program
    {
        const int MAXN = 1000000;
        static int[] rabbitGroups = new int[MAXN + 2];

        static void Main()
        {
            int numberOfRabbits = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfRabbits; i++)
            {
                int currGroup = int.Parse(Console.ReadLine());

                rabbitGroups[currGroup + 1]++;
            }

            int minSumRabbits = 0;

            for (int i = 0; i < rabbitGroups.Length; i++)
            {
                if (rabbitGroups[i] > 0)
                {
                    int currSum = (int)Math.Ceiling((double)rabbitGroups[i] / i) * i;
                    minSumRabbits += currSum;
                }
            }

            Console.WriteLine(minSumRabbits);
        }
    }
}
