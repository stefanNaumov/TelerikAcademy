using System;

//Write a program that finds the index of given element in a sorted array of integers by using the binary search algorithm 
//(find it in Wikipedia).
namespace _11.BinarySearch
{
    class BinarySearch
    {
        static void Main()
        {
            int[] array = GenerateRandomArray(400, 2000);
            //int[] arr = new int[] { 11,4, 3, 1, 4, 2, 5, 8, 3, 11 };
            Array.Sort(array);
            int searchKey = 150;
            Console.Write("Index using recursive Binary Search algorithm: ");
            Console.WriteLine(FindIndexRecursive(array, searchKey, 0, array.Length));
            Console.Write("Index using iterative Binary Search algorithm: ");
            Console.WriteLine(FindIndexIterative(array, searchKey, 0, array.Length));
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
        
        static int FindIndexRecursive(int[] sortedArray, int key, int minIndex, int maxIndex)
        {
            //No such element found
            if (maxIndex < minIndex)
            {
                return -1;
            }
            else
            {
                int middleIndex = (maxIndex + minIndex) / 2;

                if (sortedArray[middleIndex] > key)
                {
                    return FindIndexRecursive(sortedArray, key, minIndex, middleIndex - 1);
                }
                else if (sortedArray[middleIndex] < key)
                {
                    return FindIndexRecursive(sortedArray, key, middleIndex + 1, maxIndex);
                }
                else
                {
                    return middleIndex;
                }
            }
        }

        static int FindIndexIterative(int[] sortedArr, int key, int minIndex, int maxIndex)
        {
            
            while (true)
            {
                int middleIndex = (minIndex + maxIndex) / 2;

                if (minIndex > maxIndex)
                {
                    return -1;
                }

                if (sortedArr[middleIndex] < key)
                {
                    minIndex = middleIndex + 1;
                }
                else if (sortedArr[middleIndex] > key)
                {
                    maxIndex = middleIndex - 1;
                }
                else
                {
                    return middleIndex;
                }
            }
        }
    }
}
