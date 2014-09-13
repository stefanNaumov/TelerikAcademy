using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04.CountSalaries
{
    class Program
    {
        static bool[,] adjMatrix;
        static int numberOfEmployees;
        static bool[] usedEmployees;
        static long[] sums;
            
        static void Main()
        {
            numberOfEmployees = int.Parse(Console.ReadLine());
            adjMatrix = new bool[numberOfEmployees, numberOfEmployees];
            sums = new long[numberOfEmployees];

            for (int i = 0; i < numberOfEmployees; i++)
            {
                string currentUser = Console.ReadLine();

                for (int j = 0; j < numberOfEmployees; j++)
                {
                    if (currentUser[j] == 'Y')
                    {
                        adjMatrix[i, j] = true;
                    }
                }
            }

            long sum = 0;
            for (int i = 0; i < numberOfEmployees; i++)
            {
                sum += CountSums(i);
            }

            Console.WriteLine(sum);
        }

        static long CountSums(int employee)
        {
            if (sums[employee] > 0)
            {
                return sums[employee];
            }
            long sum = 0;

            for (int i = 0; i < numberOfEmployees; i++)
            {
                if (adjMatrix[employee, i])
                {
                    sum += CountSums(i);
                }
            }

            if (sum == 0)
            {
                sum = 1;
            }

            sums[employee] = sum;

            return sum;
        }
    }
}
