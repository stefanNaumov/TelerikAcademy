using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salaries
{
    class Program
    {
        static bool[,] adjMatrix;
        static long[] cache;
        static int numOfEmployees;

        static void Main()
        {
            numOfEmployees = int.Parse(Console.ReadLine());

            adjMatrix = new bool[numOfEmployees, numOfEmployees];

            cache = new long[numOfEmployees];

            for (int i = 0; i < numOfEmployees; i++)
            {
                string currEmployee = Console.ReadLine();

                for (int j = 0; j < currEmployee.Length; j++)
                {
                    if (currEmployee[j] == 'Y')
                    {
                        adjMatrix[i, j] = true;
                    }
                }
            }

            long salaries = 0;

            for (int i = 0; i < numOfEmployees; i++)
            {
                salaries += FindSum(i);
            }

            Console.WriteLine(salaries);
        }

        static long FindSum(int employee)
        {
            if (cache[employee] > 0)
            {
                return cache[employee];
            }

            long sum = 0;

            for (int i = 0; i < numOfEmployees; i++)
            {
                if (adjMatrix[employee,i] == true)
                {
                    sum += FindSum(i);
                }
            }

            if (sum == 0)
            {
                sum = 1;    
            }
            cache[employee] = sum;

            return sum;
        }
    }
}
