using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestsFromLecture
{
    class MainLoader
    {
        static void Main()
        {
            PermWithoutRepRecursive nonRepPermutations = new PermWithoutRepRecursive(3);
            //nonRepPermutations.GeneratePerm(0);

            PermWithRepRecursive permWithRep = new PermWithRepRecursive(3);
            //permWithRep.GeneratePerm(0);

            CombinationsWithoutRep nonRepCombinations = new CombinationsWithoutRep(2, 4);
            nonRepCombinations.GenerateComb(4, 2);
            
            //CombinationsWithRep combWithRep = new CombinationsWithRep(3, 3);
            //combWithRep.GenerateComb(0);
        }

        static void Print(List<int[]> collection)
        {
            for (int i = 0; i < collection.Count; i++)
            {
                int[] currPermutation = collection[i];

                for (int j = 0; j < currPermutation.Length; j++)
                {
                    Console.Write(currPermutation[j] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
