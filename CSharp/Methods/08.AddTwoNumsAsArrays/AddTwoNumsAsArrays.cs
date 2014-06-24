using System;
using System.Collections.Generic;

//Write a method that adds two positive integer numbers represented as arrays of digits 
//(each array element arr[i] contains a digit; the last digit is kept in arr[0]). 
//Each of the numbers that will be added could have up to 10 000 digits.




class AddTwoNumsAsArrays
{
    static void Main()
    {
        int[] a = new int[] { 1, 6, 3 };
        int[] b = new int[] { 5, 3, 7 };
        int[] res = AddTwoIntegers(a, b);
        for (int i = 0; i < res.Length; i++)
        {
            Console.Write(res[i]);
        }
        Console.WriteLine();
    }
    static int[] AddTwoIntegers(int[] first, int[] second)
    {
        if(first.Length > second.Length)
        {
            return AddTwoIntegers(second,first);
        }
        List<int> result = new List<int>();
        int reminder = 0;
        for (int i = 0; i < first.Length; i++)
        {
            result.Add(((first[i] + second[i]) + reminder) % 10);
            reminder = (((first[i] + second[i]) + reminder) / 10);
        }
        for (int i = first.Length; i < second.Length; i++)
        {
            result.Add((second[i] + reminder) % 10);
            reminder = ((second[i] + reminder) / 10);
        }
        if(reminder != 0)
        {
            result.Add(reminder);
        }
        return result.ToArray();
    }
}


