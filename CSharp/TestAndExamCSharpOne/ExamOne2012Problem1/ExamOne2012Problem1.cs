using System;

class ExamOne2012Problem1
{
    static void Main()
    {
        Console.WriteLine("Enter day 1....31:");
        int day = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter month:");
        int month = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter year:");
        int year = int.Parse(Console.ReadLine());
        day++;
        month++;
        year++;
        if (day > 31)
        {
            day = 1;
        }
        if (month > 12)
        {
            month = 1;
        }
        if (year > 2013)
        {
            year = 2000;
        }
        Console.WriteLine("{0}.{1}.{2}", day, month, year);
    }
}

