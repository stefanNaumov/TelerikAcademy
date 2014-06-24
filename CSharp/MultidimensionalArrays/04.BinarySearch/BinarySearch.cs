using System;
using System.Collections.Generic;

//Write a program, that reads from the console an array of N integers and an integer K, 
//sorts the array and using the method Array.BinSearch() finds the largest number in the array which is ≤ K. 



class BinarySearch
{
    static void Main()
    {
        int[] arr = new int[] { 1, 4, 7, 11, 16, 23, 35, 38, 41, 50 };
        Console.WriteLine("Enter number to search for in the array");
        int k = int.Parse(Console.ReadLine());

        Array.Sort(arr);
        int result = 0;
        if (k < arr[0])
        {
            result = arr[0];
            Console.WriteLine(result);
        }
        else
        {
            int binaryS = Array.BinarySearch(arr, k);

            if (binaryS >= 0)
            {
                result = arr[binaryS];
            }
            else
            {
                result = arr[~binaryS];
            }
        }
        Console.WriteLine("The biggest number to which {0} is less or equal is {1}",k,result);
        
    }
}

