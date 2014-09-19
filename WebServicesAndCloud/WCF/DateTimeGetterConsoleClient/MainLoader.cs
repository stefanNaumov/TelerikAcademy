using DateTimeGetterConsoleClient.DateTimeGetterConsumer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//01.Create a simple WCF service. 
//It should have a method that accepts a DateTime parameter and returns the day of week (in Bulgarian) as string. 
//Test it with the integrated WCF client.
//02.Create a console-based client for the WCF service above. Use the "Add Service Reference" in Visual Studio.

namespace DateTimeGetterConsoleClient
{
    class MainLoader
    {
        static void Main()
        {
            DateTimeGetterClient dateTimeGetter = new DateTimeGetterClient();

            var dayName = dateTimeGetter.GetDateGetDayOfWeek(DateTime.Now);

            Console.WriteLine(dayName);
        }
    }
}
