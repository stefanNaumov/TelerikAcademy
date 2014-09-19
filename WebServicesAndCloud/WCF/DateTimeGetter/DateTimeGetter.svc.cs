using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace DateTimeGetter
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "DateTimeGetter" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select DateTimeGetter.svc or DateTimeGetter.svc.cs at the Solution Explorer and start debugging.
    public class DateTimeGetter : IDateTimeGetter
    {

        public string GetDateGetDayOfWeek(DateTime date)
        {
            string dateName = date.Date.DayOfWeek.ToString();
            string nameInBulgarian = String.Empty;

            switch (dateName)
            {
                case "Monday":
                    nameInBulgarian = "Понеделник";
                        break;
                case "Tuesday":
                        nameInBulgarian = "Вторник";
                        break;
                case "Wednesday":
                        nameInBulgarian = "Сряда";
                        break;
                case "Thursday":
                        nameInBulgarian = "Четвъртък";
                        break;
                case "Friday":
                        nameInBulgarian = "Петък";
                        break;
                case "Saturday":
                        nameInBulgarian = "Събота";
                        break;
                case "Sunday":
                        nameInBulgarian = "Неделя";
                        break;
                default:
                    break;
            }
            return nameInBulgarian;
        }
    }
}
