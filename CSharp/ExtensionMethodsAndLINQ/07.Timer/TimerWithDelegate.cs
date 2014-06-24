using System;
using System.Threading;

namespace Timer
{
    class TimerWithDelegate
    {
        public delegate void TimerDelegate();
        //int for the interval because Thread.Sleep uses int milliseconds as parameter
        private int secondsInterval;
        //double for the overallSeconds because DateTime.AddSeconds uses double as parameter
        private double overallSeconds;
        TimerDelegate methodDelegate;

        public TimerWithDelegate(double interval, double overallSeconds)
        {
            //Thread.Sleep takes parameter in milliseconds and we need to convert the user's input to milliseconds
            this.secondsInterval = ConvertDoubleToMilliseconds(interval);
            //the overall seconds don't need to be converted because DateTime.AddSeconds takse double value directly
            this.overallSeconds = overallSeconds;
        }
        public TimerDelegate SetMethod
        {
            get { return this.methodDelegate; }
            set { this.methodDelegate = value; }
        }
        //convert user input to milliseconds
        private static int ConvertDoubleToMilliseconds(double seconds)
        {
            return (int)TimeSpan.FromSeconds(seconds).TotalMilliseconds;
        }
        public void StartExecuting()
        {
            DateTime start = DateTime.Now;
            DateTime end = start.AddSeconds(overallSeconds);
            
            while (start <= end)
            {
                methodDelegate();
                Thread.Sleep(secondsInterval);
                start = DateTime.Now;
            }
        }
    }

}