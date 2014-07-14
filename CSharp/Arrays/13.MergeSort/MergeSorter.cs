using System;
using System.Collections.Generic;
using System.Diagnostics;

//* Write a program that sorts an array of integers using the merge sort algorithm (find it in Wikipedia).
namespace _13.MergeSort
{
    class MergeSorter
    {
        static void Main()
        {
            //int[] arr = new int[] { 11, 4, 3, 1, 4, 2, 5, 8, 3, 11 };
            int[] randomArr = GenerateRandomArray(100000, 500000);

            Stopwatch watch = new Stopwatch();
            watch.Start();
            int[] sorted = Split(randomArr);
            watch.Stop();

            Console.WriteLine("Sorted {0} elements for: {1} seconds",randomArr.Length,watch.Elapsed);

            //for (int i = 0; i < sorted.Length; i++)
            //{
            //    Console.Write(sorted[i] + " ");
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

        static int[] Split(int[] array)
        {
            if (array.Length == 1)
            {
                return array;
            }

            int middle = array.Length / 2;
            int[] leftArray = new int[middle];
            int[] rigthArray = new int[array.Length - middle];

            for (int i = 0; i < middle; i++)
            {
                leftArray[i] = array[i];
            }

            for (int i = middle, j = 0; i < array.Length;j++, i++)
            {
                rigthArray[j] = array[i];
            }

            leftArray = Split(leftArray);
            rigthArray = Split(rigthArray);

            return Merge(leftArray, rigthArray);
        }

        static int[] Merge(int[] leftArr, int[] rightArr)
        {
            int leftSide = 0;
            int rightSide = 0;

            int[] concatenatedArr = new int[leftArr.Length + rightArr.Length];

            for (int i = 0; i < concatenatedArr.Length; i++)
			{
                if (rightSide == rightArr.Length || (leftSide < leftArr.Length) && (leftArr[leftSide] <= rightArr[rightSide]))
                {
                    concatenatedArr[i] = leftArr[leftSide];
                    leftSide++;
                }
                else if (leftSide == leftArr.Length || ((rightSide < rightArr.Length) && rightArr[rightSide] <= leftArr[leftSide]))
                {
                    concatenatedArr[i] = rightArr[rightSide];
                    rightSide++;
                }
			}

            return concatenatedArr;
        }
    }
}
