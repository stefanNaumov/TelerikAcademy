using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{

    public class LinkedList<T> where T:IComparable<T>
    {
        private ListItem<T> head;
        private ListItem<T> current;

        public LinkedList()
        {
            
        }

        public void Add(T value)
        {
            var node = new ListItem<T>();
            node.Value = value;

            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                current.NextItem = node;
            }

            current = node;
        }

        public void Remove(T value)
        {

        }

        public ListItem<T> Find(T value)
        {
            ListItem<T> tempNode = this.head;
            ListItem<T> result = null;

            while (tempNode.CompareTo(value) != 0)
            {
                tempNode = tempNode.NextItem;
                if (tempNode == null)
                {
                    break;
                }
                if (tempNode.CompareTo(value) == 0)
                {
                    result = tempNode;
                }
            }
            return result;
        }
    }
}
