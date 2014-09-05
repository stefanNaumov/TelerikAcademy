using System;
using System.Collections.Generic;

//Modify the previous program to skip duplicates:
//n=4, k=2  (1 2), (1 3), (1 4), (2 3), (2 4), (3 4)

namespace CombsWithoutDuplicates
{
    class Program
    {
        private static int numberOfElements;
        private static int combinationsCount;
        private static int[] combs;

        static void Main()
        {
            int n = 4;
            int k = 2;
            combs = new int[k];
            numberOfElements = n;
            combinationsCount = k;
            GenComsWithoutDuplication(0, 1);
        }

        private static void GenComsWithoutDuplication(int index, int number)
        {
            if (index >= combinationsCount)
            {
                Console.WriteLine(String.Join(", ",combs));
                return;
            }

            for (int i = number; i <= numberOfElements; i++)
            {
                combs[index] = i;
                GenComsWithoutDuplication(index + 1, i + 1);
            }
        }
    }
}
