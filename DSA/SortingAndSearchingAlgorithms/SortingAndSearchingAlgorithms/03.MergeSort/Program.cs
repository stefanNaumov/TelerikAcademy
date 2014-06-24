using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.MergeSort
{
    class Program
    {
        static void Main()
        {
            List<int> testList = GenerateRandomNumbers();
            Stopwatch watch = new Stopwatch();
            watch.Start();
            MergeSorter<int> sorter = new MergeSorter<int>(testList);
            watch.Stop();
            Console.WriteLine("Merge Sort time: {0}", watch.Elapsed);
            //for (int i = 0; i < sorter.Count; i++)
            //{
            //    Console.Write(sorter[i] + " ");
            //}
            Console.WriteLine();
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
    }
}
