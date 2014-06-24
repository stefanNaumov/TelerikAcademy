using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAndEventExercise
{
    public delegate void SecondChangeHandler(object clock,TimeInfoEventArgs timeInfo);
    public class TimeInfoEventArgs: EventArgs
    {
        public int hour;
        public int minute;
        public int second;
        public TimeInfoEventArgs(int hour, int minute, int second)
        {
            this.hour = hour;
            this.minute = minute;
            this.second = second;
        }
    }
}
