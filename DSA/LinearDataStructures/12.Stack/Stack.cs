using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    public class Stack<T>
    {
        private int index;
        private T[] elements;
        private int capacity;

        public Stack()
        {
            this.index = -1;
            this.capacity = 10;
            this.elements = new T[capacity];
        }
        public Stack(int capacity)
            :base()
        {
            this.capacity = capacity;
            this.elements = new T[capacity];
        }

        public int GetLength
        {
            get { return this.index + 1; }
        }

        public T Pop()
        {
            if (this.GetLength < 1)
            {
                throw new ArgumentException("Cannot pop from an empty stack!");
            }
            T popped = this.elements[index];
            this.elements[index] = default (T);
            this.index--;

            return popped;
        }

        public void Push(T element)
        {
            if (this.index >= this.capacity -1)
            {
                this.ResizeStack();
            }
            this.index++;
            this.elements[index] = element;
        }

        public T Peek()
        {
            if (this.GetLength < 1)
            {
                throw new ArgumentException("Cannot peek from an empty stack!");
            }

            return this.elements[index];
        }

        private void ResizeStack()
        {
            this.capacity = (this.capacity + 1) * 2;
            T[] resized = new T[this.capacity];
            Array.Copy(this.elements, resized,this.elements.Length);
            this.elements = resized;
        }
    }
}
