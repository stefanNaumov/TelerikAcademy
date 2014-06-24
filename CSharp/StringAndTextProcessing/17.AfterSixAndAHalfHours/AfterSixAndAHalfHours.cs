using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

//Write a program that reads a date and time given in the format: day.month.year hour:minute:second 
//and prints the date and time after 6 hours and 30 minutes (in the same format) along with the day of week in Bulgarian.


class AfterSixAndAHalfHours
{
    static void Main()
    {
        CultureInfo culture = CultureInfo.CreateSpecificCulture("BG-bg");

        string date = "02.08.2013.15.35.30";

        DateTime today = DateTime.ParseExact(date, "d.M.yyyy.HH.mm.ss",culture);
        double hours = 6.30;
        DateTime afterSixHours = today.AddHours(hours);
        Console.WriteLine("After six and a half hours: {0},day of week: {1}",afterSixHours,afterSixHours.ToString("dddd",new CultureInfo("bg-BG")));
    }
}

