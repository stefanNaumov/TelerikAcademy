using System;
using System.Collections.Generic;

//You are given an array of strings. 
//Write a method that sorts the array by the length of its elements (the number of characters composing them).


class StringLengthArray
{
    static void Main()
    {
        string[] names = new string[] { "Pesho", "Gosho", "Ivancho", "Miumiun", "Ganio", "Patriciiiiiiiii" };

        SortByStringLength(names);
        for (int i = 0; i < names.Length; i++)
        {
            Console.Write(names[i] + " ");
        }
        Console.WriteLine();
    }
    static string[] SortByStringLength(string[] array)
    {
        string[] sortedArray = new string[array.Length];

        for (int i = 0; i < array.Length; i++)
        {
            string curr = array[i];
            for (int j = 0; j < array.Length; j++)
            {
                if (curr.Length <= array[j].Length)
                {
                    curr = array[j];
                    array[j] = array[i];
                    array[i] = curr;
                }
            }
        }
        return array;
    }
}

