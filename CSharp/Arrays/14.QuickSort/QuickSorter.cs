using System;
using System.Diagnostics;


namespace _14.QuickSort
{
    class QuickSorter
    {
        static void Main()
        {
            int[] arr = new int[] { 11, 4, 3, 1, 4, 2, 5, 8, 3, 11 };
            int[] randomArr = GenerateRandomArray(1000000, 5000000);

            Stopwatch watch = new Stopwatch();

            watch.Start();
            QuickSort(randomArr, 0, randomArr.Length - 1);
            watch.Stop();

            Console.WriteLine("Sorted {0} elements for {1} seconds",randomArr.Length,watch.Elapsed);

            //for (int i = 0; i < randomArr.Length; i++)
            //{
            //    Console.Write(randomArr[i] + " ");
            //}
            //Console.WriteLine();
        }

        static int[] GenerateRandomArray(int minSize, int maxSize)
        {
            Random generator = new Random();

            int arraySize = generator.Next(minSize, maxSize);
            int[] array = new int[arraySize];

            for (int i = 0; i < arraySize; i++)
            {
                array[i] = generator.Next(1, 500);
            }

            return array;
        }

        static void QuickSort(int[] array, int left, int right)
        {
            int i = left;
            int j = right;
            int pivot = array[(left + right) / 2];
            int temp;
            while (i <= j)
            {
                while (array[i] < pivot)
                {
                    i++;
                }
                while (array[j] > pivot)
                {
                    j--;
                }

                if (i <= j)
                {
                    temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                    i++;
                    j--;
                }
            }

            if (left <= j)
            {
                QuickSort(array, left, j);
            }
            if (right >= i)
            {
                QuickSort(array, i, right);
            }
        }
    }
}
