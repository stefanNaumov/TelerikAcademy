using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    public class LinkedListQueue<T> where T: IComparable<T>
    {
        private int count;
        private QueueItem<T> head;
        private QueueItem<T> tail;

        public LinkedListQueue()
        {
            this.count = 0;
            this.head = null;
            this.tail = null;
        }

        public void Enqueue(T element)
        {
            QueueItem<T> newElement = new QueueItem<T>();
            newElement.Value = element;
            if (this.head == null)
            {
                this.head = newElement;
            }

            if (this.tail != null)
            {
                this.tail.NextItem = newElement;
            }

            this.tail = newElement;
            this.count++;
        }

        public T Dequeue()
        {
            if (this.head == null)
            {
                throw new ArgumentException("Cannot Dequeue from an empty queue!");
            }

            T dequeued = this.head.Value;
            this.head = this.head.NextItem;
            this.count--;

            return dequeued;
        }

        public T Peek()
        {
            if (this.head == null)
            {
                throw new ArgumentException("Cannot Peek from an empty queue!");
            }
            return this.head.Value;
        }

        public int Count
        {
            get { return this.count; }
        }
    }
}
