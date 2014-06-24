using System;
using System.Collections.Generic;


class WorkingDaysCalculator
{
    public static int WorkDaysCounter(DateTime today, DateTime futureDate)
    {
        int dayCounter = 0;
        DateTime[] holidays = new DateTime[] { new DateTime(2013, 12, 24), new DateTime(2013, 12, 31), new DateTime(2013, 12, 25)
        , new DateTime(2013, 12, 28), new DateTime(2013, 12, 29), new DateTime(2013, 12, 30)};

        int workingDays = 0;

        for (DateTime day = today; day < futureDate; day = day.AddDays(1))
        {
            string currentDay = day.DayOfWeek.ToString();
            workingDays++;
            if (currentDay != "Saturday" && currentDay != "Sunday")
            {
                for (int i = 0; i < holidays.Length; i++)
                {
                    if (day == holidays[i])
                    {
                        workingDays--;
                    }
                }
            }
            else if(currentDay == "Saturday" || currentDay == "Sunday")
            {
                workingDays--;
            }
        }
        return workingDays;
    }
}

