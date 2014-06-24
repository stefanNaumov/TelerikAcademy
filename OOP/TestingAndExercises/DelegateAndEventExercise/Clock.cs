using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace DelegateAndEventExercise
{
    public class Clock
    {
        SecondChangeHandler secondChange;
        public int hour;
        public int minute;
        public int second;

        public void Run()
        {
            for (; ; )
            {
                Thread.Sleep(100);
                DateTime dt = DateTime.Now;
                if (dt.Second != second)
                {
                    TimeInfoEventArgs timeInfo = new TimeInfoEventArgs(dt.Hour, dt.Minute, dt.Second);

                    if (secondChange != null)
                    {
                        secondChange(this, timeInfo);
                    }
                }
                this.hour = dt.Hour;
                this.minute = dt.Minute;
                this.second = dt.Second;
            }
        }
    }
}
