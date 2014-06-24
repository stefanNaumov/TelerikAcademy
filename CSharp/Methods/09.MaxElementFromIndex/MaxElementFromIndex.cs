using System;
using System.Collections.Generic;

//Write a method that return the maximal element in a portion of array of integers starting at given index. 
//Using it write another method that sorts an array in ascending / descending order.



class MaxElementFromIndex
{
    static void Main()
    {
        int[] array = new int[] { 1, 22, 32, 2, 24, 2, 42, 2, 2, 4 };
        Console.Write("Enter index:");
        int index = int.Parse(Console.ReadLine());
        Console.Write("The max element from index {0} is {1}",index,MaxElement(array,index));
        Console.WriteLine();
        Console.Write("The array in ascending order: ");
        AscendingArray(array);
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
        Console.Write("The array in descending order: ");
        DescendingArray(array);
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
    }
    static int MaxElement(int[] array, int index)
    {
        int maxEl = array[index];
        for (int i = index; i < array.Length; i++)
        {
            if(array[i] > maxEl)
            {
                maxEl = array[i];
            }
        }
        return maxEl;
    }
    static int[] AscendingArray(int[] array)
    {
        Array.Sort(array);
        return array;
        
    }
    static int[] DescendingArray(int[] array)
    {
        Array.Sort(array);
        Array.Reverse(array);
        return array;
    }

}

