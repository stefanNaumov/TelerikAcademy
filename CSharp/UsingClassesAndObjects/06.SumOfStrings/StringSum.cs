using System;
using System.Collections.Generic;
using System.Text;



class StringSum
{
    public static int SumOfStrings(string[] array)
    {
        int sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += int.Parse(array[i]);
        }
        return sum;
    }
}

