using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Implement the ADT queue as dynamic linked list. 
//Use generics (LinkedQueue<T>) to allow storing different data types in the queue.

namespace Queue
{
    class QueueLoader
    {
        static void Main()
        {
            LinkedListQueue<int> queue = new LinkedListQueue<int>();

            for (int i = 0; i < 100; i++)
            {
                queue.Enqueue(i);
            }
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(queue.Dequeue());
            }
        }
    }
}
