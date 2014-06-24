using System;
using System.Collections.Generic;


//Write a program that prints to the console which day of the week is today. Use System.DateTime.


class Program
{
    static void Main()
    {
        DateTime today = Day.now;
        Console.WriteLine(today);
    }
}

