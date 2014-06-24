using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace _01.SelectionSort
{
    class Program
    {
        static void Main()
        {
            Random generator = new Random();
            Stopwatch watch = new Stopwatch();
            List<int> testList = GenerateRandomNumbers();
            testList = GenerateRandomNumbers();

            watch.Start();
            BubbleSort(testList);
            watch.Stop();
            Console.WriteLine("Bubble sort time: {0}",watch.Elapsed);
            watch.Reset();

            testList = GenerateRandomNumbers();
            watch.Start();
            SelectionSort(testList);
            watch.Stop();
            Console.WriteLine("Selection sort time: {0}",watch.Elapsed);
            watch.Reset();

            testList = GenerateRandomNumbers();
            watch.Start();
            InsertionSort(testList);
            watch.Stop();
            Console.WriteLine("Insertion sort time: {0}",watch.Elapsed);
            watch.Reset();

        }
        static void SelectionSort(IList<int> collection)
        {
            for (int i = 0; i < collection.Count -1; i++)
			{
                int min = i;
                for (int j = 0; j < collection.Count; j++)
                {
                    if (collection[j] < collection[min])
                    {
                        min = j;
                    }
                }
                if (min != i)
                {
                    int temp = collection[i];
                    collection[i] = collection[min];
                    collection[min] = temp;
                }
			}
        }
        static void BubbleSort(IList<int> collection)
        {
            bool swapped = false;
            do
            {
                swapped = false;
                for (int i = 1; i < collection.Count; i++)
                {
                    if (collection[i - 1] > collection[i])
                    {
                        int temp = collection[i - 1];
                        collection[i - 1] = collection[i];
                        collection[i] = temp;
                        swapped = true;
                    }
                } 
            }
            while(swapped == true);
        }
        static void InsertionSort(IList<int> collection)
        {
            for (int i = 1; i < collection.Count; i++)
            {
                int movingPos = i;
                while (movingPos > 0 && collection[movingPos - 1] > collection[movingPos])
                {
                    int temp = collection[movingPos - 1];
                    collection[movingPos - 1] = collection[movingPos];
                    collection[movingPos] = temp;
                    movingPos--;
                }
            }
        }
        static List<int> GenerateRandomNumbers()
        {
            List<int> testList = new List<int>();
            Random generator = new Random();
            for (int i = 0; i < 50000; i++)
            {
                testList.Add(generator.Next(1, 1000000));
            }

            return testList;
        }
        
    }
}
