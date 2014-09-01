using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01.PriorityQueue
{
    public class QueueLoader
    {
        static void Main()
        {
            PriorityQueue<int> queue = new PriorityQueue<int>();

            //queue.Enqueue(3);
            //queue.Enqueue(111);
            //queue.Enqueue(21);

            for (int i = 0; i < 6; i++)
            {
                 queue.Enqueue(i);
            }

            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());
         
            Console.WriteLine(queue.Dequeue());
        }
    }
}
