using System;
using System.Collections.Generic;
//Write a recursive program for generating and printing all ordered k-element subsets from n-element set (variations Vkn).
    //Example: n=3, k=2, set = {hi, a, b} =>
    //(hi hi), (hi a), (hi b), (a hi), (a a), (a b), (b hi), (b a), (b b)

namespace _05.OrderedKSubsets
{
    class MainLoader
    {
        static int K;
        static int N;
        static string[] set;
        static string[] variations;

        static void Main()
        {
            K = 2;
            N = 3;
            set = new string[] { "hi", "a", "b" };
            variations = new string[K];

            GenerateVariations(0);
        }

        static void GenerateVariations(int index)
        {
            if (index >= K)
            {
                Console.WriteLine(String.Join(", ",variations));
                return;
            }

            for (int i = 0; i < set.Length; i++)
            {
                variations[index] = set[i];
                GenerateVariations(index + 1);
            }
        }
    }
}
