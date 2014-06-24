using System;
using System.Collections.Generic;

//Write a program that reads a year from the console and checks whether it is a leap.


class IsLeapYear
{
    static void Main()
    {
        Console.Write("Enter year:");
        int year = int.Parse(Console.ReadLine());
        bool result = LeapYear.IsLeapYear(year);
        Console.WriteLine("The year {0} is leap: {1}", year, result);
    }
}

