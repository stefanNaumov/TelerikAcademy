using System;

//Sorting an array means to arrange its elements in increasing order. 
//Write a program to sort an array. 
//Use the "selection sort" algorithm: Find the smallest element, move it at the first position, 
//find the smallest from the rest, move it at the second position, etc.

namespace _07.SelectionSort
{
    class SelectionSorter
    {
        static void Main()
        {
            int[] randomArr = GenerateRandomArray(1,20);
            SelectionSort(randomArr);

            for (int i = 0; i < randomArr.Length; i++)
            {
                Console.Write(randomArr[i] + " ");
            }
            Console.WriteLine();
        }

        static void SelectionSort(int[] array)
        {
            int i, k;
            int kMin;

            for (i = 0; i < array.Length - 1; i++)
            {
                //assume that the first element is the minimun
                kMin = i;
                for (k = i + 1; k < array.Length; k++)
                {
                    //if we find an element which is less than the assumued minimum value
                    //we keep it's index
                    if (array[k] < array[kMin])
                    {
                        kMin = k;
                    }
                }
                //swap the initialy assumed value with the new found minimum value
                if (kMin != i)
                {
                    int temp = array[i];
                    array[i] = array[kMin];
                    array[kMin] = temp;
                }
            }
        }

        static int[] GenerateRandomArray(int minSize, int maxSize)
        {
            Random generator = new Random();

            int arraySize = generator.Next(minSize, maxSize);
            int[] array = new int[arraySize];

            for (int i = 0; i < arraySize; i++)
            {
                array[i] = generator.Next(1, 5000);
            }

            return array;
        }
    }
}
