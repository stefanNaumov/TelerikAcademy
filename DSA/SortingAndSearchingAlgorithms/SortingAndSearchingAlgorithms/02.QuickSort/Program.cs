using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace _02.QuickSort
{
    class Program
    {
        static void Main()
        {
            List<int> testList = GenerateRandomNumbers();
            Stopwatch watch = new Stopwatch();
            watch.Start();
            QuickSorter<int> sorter = new QuickSorter<int>(testList);
            watch.Stop();
            Console.WriteLine("Quick Sort time: {0}",watch.Elapsed);
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
            for (int i = 0; i < 10; i++)
            {
                testList.Add(generator.Next(1, 100000000));
            }

            return testList;
        }
    }
}
