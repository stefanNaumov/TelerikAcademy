using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace _01.SortableCollection
{
    class MainLoader
    {
        static void Main()
        {
            Random generator = new Random();
            Stopwatch watch = new Stopwatch();
            int count = 5000;
            List<int> testList = GenerateRandomNumbers(count);
            SortableCollection sortableCollection = new SortableCollection(testList);

            watch.Start();
            sortableCollection.BubbleSort();
            watch.Stop();
            Console.WriteLine("Bubble sort time for {0} elements: {1}",count, watch.Elapsed);
            watch.Reset();

            testList = GenerateRandomNumbers(count);
            watch.Start();
            sortableCollection.SelectionSort();
            watch.Stop();
            Console.WriteLine("Selection sort time for {0} elements: {1}",count, watch.Elapsed);
            watch.Reset();

            testList = GenerateRandomNumbers(count);
            watch.Start();
            sortableCollection.InsertionSort();
            watch.Stop();
            Console.WriteLine("Insertion sort time for {0} elements: {1}",count, watch.Elapsed);
            watch.Reset();

        }
        
        static List<int> GenerateRandomNumbers(int count)
        {
            List<int> testList = new List<int>();
            Random generator = new Random();
            for (int i = 0; i < count; i++)
            {
                testList.Add(generator.Next(1, 10000));
            }

            return testList;
        }
        
    }
}
