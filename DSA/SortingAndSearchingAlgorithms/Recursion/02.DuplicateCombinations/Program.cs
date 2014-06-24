using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.DuplicateCombinations
{
    class Program
    {
        static int n = 3;
        static void Main()
        {
            int k = 2;
            
            int[] arr = new int[k];
            GenerateCombinations(0, 1, arr);
        }
        static void GenerateCombinations(int index, int start,int[] arr)
        {
            if (index >= arr.Length)
            {
                Console.WriteLine(String.Join(" ",arr));
                return;
            }
            for (int i = start; i <= n; i++)
            {
                arr[index] = i;
                GenerateCombinations(index + 1, i, arr);
            }
        }
    }
}
