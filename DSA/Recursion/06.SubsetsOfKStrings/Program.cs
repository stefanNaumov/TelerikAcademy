using System;
using System.Collections.Generic;
//Write a program for generating and printing all subsets of k strings from given set of strings.
//    Example: s = {test, rock, fun}, k=2
//    (test rock),  (test fun),  (rock fun)


namespace _06.SubsetsOfKStrings
{
    class Program
    {
        static string[] set;
        static int K;
        static string[] subsets;

        static void Main()
        {
            set = new string[] { "test", "rock", "fun" };
            K = 2;
            subsets = new string[K];
            GenerateSubsets(0, 0);
        }

        static void GenerateSubsets(int index, int lastIndex)
        {
            if (lastIndex >= K)
            {
                Console.WriteLine(String.Join(", ",subsets));
                return;
            }
            for (int i = index; i < set.Length; i++)
            {
                subsets[lastIndex] = set[i];
                GenerateSubsets(i + 1, lastIndex + 1);
            }
           
        }
    }
}
