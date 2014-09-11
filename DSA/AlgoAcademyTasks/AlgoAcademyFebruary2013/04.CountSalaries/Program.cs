using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04.CountSalaries
{
    class Program
    {
        static int sumCount = 0;
        static bool[,] adjMatrix;
        static int numberOfEmployees;
        static bool[] usedEmployees;

        static void Main()
        {
            numberOfEmployees = int.Parse(Console.ReadLine());
            adjMatrix = new bool[numberOfEmployees, numberOfEmployees];

            for (int i = 0; i < numberOfEmployees; i++)
            {
                string currentUser = Console.ReadLine();
                bool hasFoundEmployee = false;

                for (int j = 0; j < numberOfEmployees; j++)
                {
                    if (currentUser[j] == 'Y')
                    {
                        hasFoundEmployee = true;
                        adjMatrix[i, j] = true;
                    }
                }
                //no slaves found
                if (!hasFoundEmployee)
                {
                    sumCount += 1;
                }
            }
            int sum = 0;
            for (int i = 0; i < numberOfEmployees; i++)
            {
                for (int j = 0; j < numberOfEmployees; j++)
                {
                    if (adjMatrix[i,j])
                    {
                        sum += CountSums(j);
                    }
                }
            }

            Console.WriteLine(sumCount);
        }

        int[] sums = new int[numberOfEmployees];

        static int CountSums(int employee)
        {
            int sum = 0;

            for (int i = 0; i < numberOfEmployees; i++)
            {
                
            }
            
        }
    }
}
