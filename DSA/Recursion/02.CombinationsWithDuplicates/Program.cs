using System;
using System.Collections.Generic;

//Write a recursive program for generating and printing all the combinations with duplicates of k elements from n-element set. Example:
//    n=3, k=2  (1 1), (1 2), (1 3), (2 2), (2 3), (3 3)

namespace CombinationsWithDuplicates
{
    class Program
    {
        private static int numberOfElements;
        private static int combinationsCount;
        private static int[] combs;

        static void Main()
        {
            int n = 3;
            int k = 2;
            combs = new int[k];
            numberOfElements = n;
            combinationsCount = k;
            GenerateCombinationsWithDuplicates(0, 1);
        }

        private static void GenerateCombinationsWithDuplicates(int index, int number)
        {
            if (index >= combs.Length)
            {
                Console.WriteLine(String.Join(", ",combs));
                return;
            }

            for (int i = number; i <= numberOfElements; i++)
            {
                combs[index] = i;
                GenerateCombinationsWithDuplicates(index + 1, i);
            }
        }
    }
}
