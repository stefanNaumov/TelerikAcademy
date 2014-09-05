using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a recursive program for generating and printing all permutations of the numbers 1, 2, ..., n 
//for given integer number n. Example:
//    n=3  {1, 2, 3}, {1, 3, 2}, {2, 1, 3},{2, 3, 1}, {3, 1, 2},{3, 2, 1}

namespace GenerateAllPermutations
{
    class Program
    {
        private static int N;
        private static int[] permutations;
        private static bool[] used;
        static void Main()
        {
            N = 3;
            permutations = new int[N];
            used = new bool[N];
            GenAllPermutations(0);
        }

        private static void GenAllPermutations(int index)
        {
            if (index >= permutations.Length)
            {
                Console.WriteLine(String.Join(", ",permutations));
                return;
            }

            for (int i = 0; i < N; i++)
            {
                if (!used[i])
                {
                    used[i] = true;
                    permutations[index] = i + 1;
                    GenAllPermutations(index + 1);
                    used[i] = false;
                }
            }
        }
    }
}
