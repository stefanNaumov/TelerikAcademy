using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.KSubsets
{
    class Program
    {
        static void Main()
        {
            string[] set = new string[] { "hi", "a", "b" };
            int k = 2;
            string[] subset = new string[k];
            GenerateSubsets(k, set, 0, subset);
        }
        static void GenerateSubsets(int k, string[] collection,int index,string[] subset)
        {
            if (index == k)
            {
                Console.WriteLine("(" + String.Join(",",subset) + ")");
                return;
            }
            for (int i = 0; i < collection.Length; i++)
            {
                subset[index] = collection[i];
                GenerateSubsets(k, collection, index + 1, subset);
            }
        }
    }
}
