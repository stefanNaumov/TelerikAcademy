using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Write a program that reads two dates in the format: day.month.year and calculates the number of days between them. Example:
//Enter the first date: 27.02.2006
//Enter the second date: 3.03.2004 !this must be an error -> the distance is not 4 days unless the second date's year is 2006 too.
//Distance: 4 days


class PeriodBetweenDates
{
    static void Main()
    {
        int firstDay = 27;
        int firstMonth = 02;
        int firstYear = 2006;
        DateTime firstDate = new DateTime(firstYear, firstMonth, firstDay);
        int secDay = 3;
        int secMonth = 03;
        int secYear = 2006;
        DateTime secDate = new DateTime(secYear,secMonth,secDay);
        TimeSpan timespan = secDate - firstDate;
        Console.WriteLine("Total days {0}",timespan.TotalDays);
    }

}

