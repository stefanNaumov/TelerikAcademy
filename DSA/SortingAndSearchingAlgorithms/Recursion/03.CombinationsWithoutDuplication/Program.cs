using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.CombinationsWithoutDuplication
{
    class Program
    {
        static int numbersLimit = 4;
        static void Main()
        {
            int arrSize = 2;
            int[] arr = new int[arrSize];
            GenerateNoDuplicatecombinations(0, 1, arr);
        }
        static void GenerateNoDuplicatecombinations(int index, int start, int[] arr)
        {
            if (index >= arr.Length)
            {
                Console.WriteLine(String.Join(" ",arr));
                return;
            }
            for (int i = start; i <= numbersLimit; i++)
            {
                arr[index] = i;
                GenerateNoDuplicatecombinations(index + 1, i + 1, arr);
            }

        }
    }
}
