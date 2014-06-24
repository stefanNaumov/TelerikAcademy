using System;
using System.Collections.Generic;

//Write a method that returns the index of the first element in array that is bigger than its neighbors, 
//or -1, if there’s no such element.Use the method from the previous exercise.


class IndexOfNumber
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
        int result = CompareNumberAndNeighbours(arr);
        if (result != -1)
        {
            Console.WriteLine("The index of the number which is bigger than it's neighbours is {0}", result);
        }
        else
        {
            Console.WriteLine("No such number!");
        }
    }
    static int CompareNumberAndNeighbours(int[] array)
    {
        int index = -1;
        for (int i = 0; i < array.Length; i++)
		{
			 if(i > 0 && i < array.Length-1)
             {
                 if(array[i] > array[i-1] && array[i] > array[i+1])
                 {
                     index = i;
                 }
             }
		}
        return index;
    }
}

