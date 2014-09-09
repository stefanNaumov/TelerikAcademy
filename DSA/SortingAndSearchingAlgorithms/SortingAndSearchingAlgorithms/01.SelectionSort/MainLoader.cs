using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace SortableCollection
{
    class MainLoader
    {
        static void Main()
        {
            Random generator = new Random();
            Stopwatch watch = new Stopwatch();
            List<int> testList = GenerateRandomNumbers();
            testList = GenerateRandomNumbers();
            SortableCollection sortableCollection = new SortableCollection(testList);

            watch.Start();
            sortableCollection.BubbleSort();
            watch.Stop();
            Console.WriteLine("Bubble sort time: {0}",watch.Elapsed);
            watch.Reset();

            testList = GenerateRandomNumbers();
            watch.Start();
            sortableCollection.SelectionSort();
            watch.Stop();
            Console.WriteLine("Selection sort time: {0}",watch.Elapsed);
            watch.Reset();

            testList = GenerateRandomNumbers();
            watch.Start();
            sortableCollection.InsertionSort();
            watch.Stop();
            Console.WriteLine("Insertion sort time: {0}",watch.Elapsed);
            watch.Reset();

        }
        
        static List<int> GenerateRandomNumbers()
        {
            List<int> testList = new List<int>();
            Random generator = new Random();
            for (int i = 0; i < 10000; i++)
            {
                testList.Add(generator.Next(1, 1000));
            }

            return testList;
        }
        
    }
}
