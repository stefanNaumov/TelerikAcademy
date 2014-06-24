using System;
using System.Collections.Generic;


//Write a method that calculates the number of workdays between today and given date, passed as parameter. 
//Consider that workdays are all days from Monday to Friday except a fixed list of public holidays specified preliminary as array.



class WorkingDays
{
    static void Main()
    {
        DateTime today = DateTime.Today;
        Console.Write("Enter year: ");
        int year = int.Parse(Console.ReadLine());
        Console.Write("Enter month: ");
        int month = int.Parse(Console.ReadLine());
        Console.Write("Enter date: ");
        int date = int.Parse(Console.ReadLine());
        DateTime futureDate = new DateTime(year, month, date);
        int working = WorkingDaysCalculator.WorkDaysCounter(today, futureDate);
        Console.WriteLine("The working days between today and {0} are: {1}",futureDate,working);
    }
}

