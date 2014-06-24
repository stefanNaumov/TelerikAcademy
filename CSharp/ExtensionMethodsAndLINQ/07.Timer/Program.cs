using System;

namespace Timer
{
    public delegate void EventHandler();
    class MainClass
    {
        public static void Main()
        {
            TimerWithDelegate timer = new TimerWithDelegate(1.0, 5.0);
            timer.SetMethod = MethodToExecute;
            timer.StartExecuting();
        }
        public static void MethodToExecute()
        {
            Console.WriteLine("Generating method!");
        }
    }
}