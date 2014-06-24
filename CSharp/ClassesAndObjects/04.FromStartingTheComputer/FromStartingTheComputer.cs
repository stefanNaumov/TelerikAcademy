using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.FromStartingTheComputer
{
    class FromStartingTheComputer
    {
        static void Main()
        {
            int FromStart = Environment.TickCount;
            var time = TimeSpan.FromMilliseconds(FromStart);
            Console.WriteLine(time.Days + ":" + time.Hours + ":" + time.Minutes + ":" + time.Seconds);
        }
    }
}
