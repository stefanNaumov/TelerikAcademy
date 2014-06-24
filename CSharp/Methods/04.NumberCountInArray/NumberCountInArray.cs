using System;
using System.Collections.Generic;

//Write a method that counts how many times given number appears in given array. 
//Write a test program to check if the method is working correctly.


class NumberCountInArray
{
    static void Main()
    {
        Console.Write("Enter size of the array: ");
        int size = int.Parse(Console.ReadLine());
        int[] arr = new int[size];
        //fill the array
        for (int i = 0; i < size; i++)
        {
            Console.Write("Enter number {0}: ",i+1);
            arr[i] = int.Parse(Console.ReadLine());
        }
        Console.Write("Enter number to check how many times it appears in the array:");
        int number = int.Parse(Console.ReadLine());
        int result = NumberinArray(arr, number);
        Console.WriteLine("The number {0} appears {1} times in the array",number,result);
    }
    static int NumberinArray(int[] array,int number)
    {
        int counter = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if(array[i] == number)
            {
                counter++;
            }
        }
        return counter;
    }
}

