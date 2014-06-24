using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Globalization;

//Write a program that extracts from a given text all dates that match the format DD.MM.YYYY. 
//Display them in the standard date format for Canada.


class MatchDateTime
{
    static void Main()
    {
        string text = "Some sample text and a date: 04.08.2013 and some other sample text but this is not a date: 25.54.23213";

        string dates = ExtractDates(text);
        Console.WriteLine(dates);

    }

    static string ExtractDates(string text)
    {
        Regex pattern = new Regex(@"[0-9]{2}\.[0-9]{2}\.[0-9]{4}\s");
        MatchCollection dates = pattern.Matches(text);
        StringBuilder builder = new StringBuilder();
        CultureInfo culture = new CultureInfo("en-CA");

        for (int i = 0; i < dates.Count; i++)
        {
            builder.AppendFormat(culture,dates[i].Value + "\n");
        }
        return builder.ToString();
    }
}

