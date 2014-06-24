using System;
using System.Collections.Generic;

//You are given a sequence of positive integer values written into a string, separated by spaces.
//Write a function that reads these values from given string and calculates their sum. 
//Example: string = "43 68 9 23 318"  result = 461


class SumOfStrings
{
    static void Main()
    {
        string numbers = "43 68 9 23 318";

        string[] arrayofStrings = numbers.Split(' ');
        int sum = StringSum.SumOfStrings(arrayofStrings);
        Console.WriteLine(sum);
        
    }
}

