using System;
using System.Collections.Generic;


class LeapYear
{
    public static bool IsLeapYear(int year)
    {
        bool IsLeap = false;
        if (year % 4 == 0)
        {
            IsLeap = true;
        }
        return IsLeap;
    }
}


