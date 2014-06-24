using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.SubsetKStrings
{
    class Program
    {
        static void Main()
        {
            string[] array = new string[] { "test", "rock", "fun" };
            int k = 2;
            string[] subset = new string[k];
            GenerateSubsetStrings(array, k, subset, 0);
        }
        static void GenerateSubsetStrings(string[] array, int k,string[] subset,int index)
        {
            if (index >= k)
            {
                Console.WriteLine("(" + String.Join(" ",subset) + ")");
                return;
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (!(subset.Contains(array[i])))
                {
                    subset[index] = array[i];
                    GenerateSubsetStrings(array, k, subset, index + 1);
                }
            }
        }
    }
}
