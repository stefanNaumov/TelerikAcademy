using System;

// Write a program that reads two arrays from
// the console and compares them element by element.

namespace _02.CompareTwoArrays
{
    class CompareTwoArr
    {
        static void Main(string[] args)
        {
            Console.Write("Enter size of the first array:");
            int firstArrSize = int.Parse(Console.ReadLine());
            Console.Write("Enter size of the second array:");
            int secondArrSize = int.Parse(Console.ReadLine());
            int[] arr1 = new int[firstArrSize];
            int[] arr2 = new int[secondArrSize];
            bool areEqual = true;
            if (secondArrSize == firstArrSize)
            {
                for (int i = 0; i < firstArrSize; i++)
                {
                    Console.WriteLine("Enter value for first array element {0}", i + 1);
                    arr1[i] = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter value for second array element {0}", i + 1);
                    arr2[i] = int.Parse(Console.ReadLine());
                }
                
                for (int i = 0; i < firstArrSize; i++)
                {
                    if (arr1[i] != arr2[i])
                    {
                        areEqual = false; 
                        break;
                    }
                }
            }
            else
            {
                areEqual = false;
            }
            Console.WriteLine("The arrays are equal: {0}", areEqual);
        }
    }
}
