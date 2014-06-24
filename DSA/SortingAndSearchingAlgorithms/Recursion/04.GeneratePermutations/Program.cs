using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.GeneratePermutations
{
    class Program
    {
        static void Main()
        {
            int n = 3;
            int[] array = new int[n];
            GeneratePermutations(array, 0, n);
        }
        static void GeneratePermutations(int[] array, int index, int n)
        {
            if (index >= array.Length)
            {
                Console.WriteLine("{" + String.Join(",",array) + "}");
                return;
            }
            
            for (int i = 1; i <= n; i++)
            {
                bool canAddNumber = true;
                for (int k = 0; k < index; k++)
                {
                    if (array[k] == i)
                    {
                        canAddNumber = false;
                    }
                }
                if (canAddNumber)
                {
                    array[index] = i;
                    GeneratePermutations(array, index + 1, n);
                }
            }
        }
    }
}
