using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

//All classes are in one file in order to be easier for me to understand the concepts of the events
namespace TimerWithEvent
{
    public delegate void TimerEventHandler(object sender);
    
    class Program
    {
        static void Main()
        {
            Timer timer = new Timer(1.0, 5.0);
            timer.eventHandler += EventTestingMethod;
            timer.Execute();
        }

        static void EventTestingMethod(object sender)
        {
            Console.WriteLine("Testing the event!");
        }
    }
    //public class EventPublisher : EventArgs
    //{
    //    public int interval{ get; set; }

    //    public EventPublisher(int interval)
    //    {
    //        this.interval = interval;
    //    }
    //}
    public class Timer
    {
        public event TimerEventHandler eventHandler;

        private int secondsInterval;
        private double overallSeconds;

        public Timer(double interval,double overallTime)
        {
            this.secondsInterval = ConvertDoubleToMilliseconds(interval);
            this.overallSeconds = overallTime;
        }
        public void Execute()
        {
            TimerEventHandler handler = eventHandler;
            DateTime start = DateTime.Now;
            DateTime end = start.AddSeconds(overallSeconds);
           
            if (handler != null)
            {
                handler(this);
                while (start <= end)
                {
                    handler(this);
                    Thread.Sleep(secondsInterval);
                    start = DateTime.Now;
                }
            } 
        }
        private static int ConvertDoubleToMilliseconds(double seconds)
        {
            return (int)TimeSpan.FromSeconds(seconds).TotalMilliseconds;
        }
    }
}
