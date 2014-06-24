using System;
using System.Collections.Generic;

//Write a method that checks if the element at given position in given array of integers is bigger than its two neighbors (when such exist).


class NeighboursOfGivenPosition
{
    static void Main()
    {
        Console.Write("Enter size of the array: ");
        int size = int.Parse(Console.ReadLine());
        int[] arr = new int[size];
        //fill the array
        for (int i = 0; i < size; i++)
        {
            Console.Write("Enter number {0}: ", i + 1);
            arr[i] = int.Parse(Console.ReadLine());
        }
        Console.Write("Enter position in the array which neighbors you would like to check:");
        int position = int.Parse(Console.ReadLine());
        CompareToNeighbours(arr, position);
    }
    static void CompareToNeighbours(int[] array,int position)
    {
        if(position - 1 < 0 || position + 1 >= array.Length)
        {
            Console.WriteLine("Neighbours don't exist!");
            return;
        }
        if (array[position] > array[position - 1] && array[position] > array[position + 1])
        {
            Console.WriteLine("Array at position {0} is bigger than it's neighbours!",position);
            return;
        }

        if (array[position] < array[position - 1] || array[position] < array[position + 1])
        {
            Console.WriteLine("Array at position {0} is not bigger than it's neighbours!",position);
            return;
        }
    }
}

