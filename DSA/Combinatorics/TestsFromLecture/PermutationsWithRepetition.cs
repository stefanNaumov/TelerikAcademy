using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestsFromLecture
{
    public class PermutationsWithRepetition
    {
        public List<int[]> Generate(int minVal, int maxVal)
        {
            List<int[]> allPermutations = new List<int[]>();

            for (int i = minVal; i <= maxVal; i++)
            {
                int firstEl = i;
                for (int j = minVal; j <= maxVal; j++)
                {
                    int secVal = j;
                    for (int k = minVal; k <= maxVal; k++)
                    {
                        int thirdVal = k;
                        int[] permutationArr = new int[] { firstEl, secVal, thirdVal };
                        allPermutations.Add(permutationArr);
                    }
                }
            }

            return allPermutations;
        }
    }
}
