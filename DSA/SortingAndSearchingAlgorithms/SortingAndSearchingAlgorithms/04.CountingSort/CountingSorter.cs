using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Diagnostics;

namespace _04.CountingSort
{
    public class CountingSorter
    {
        static void Main()
        {
            List<int> collection = GenerateRandomNumbers();
            Stopwatch watch = new Stopwatch();
            watch.Start();
            int[] sortedArray = CountingSort(collection, 0, 1000);
            watch.Stop();
            Console.WriteLine("Counting sort time: {0}",watch.Elapsed);
        }

        static List<int> GenerateRandomNumbers()
        {
            List<int> testList = new List<int>();
            Random generator = new Random();
            for (int i = 0; i < 1000000; i++)
            {
                testList.Add(generator.Next(1, 1000));
            }

            return testList;
        }

        static int[] CountingSort(List<int> collection, int minValue, int maxValue)
        {
            int[] sortedCollection = new int[maxValue];
            for (int i = 0; i < collection.Count; i++)
            {
                sortedCollection[collection[i]]++;
            }
            return sortedCollection;
        }
    }
}
