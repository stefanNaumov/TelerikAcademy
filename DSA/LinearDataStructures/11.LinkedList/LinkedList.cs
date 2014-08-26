using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Implement the data structure linked list. 
//Define a class ListItem<T> that has two fields: value (of type T) and NextItem (of type ListItem<T>). 
//Define additionally a class LinkedList<T> with a single field FirstElement (of type ListItem<T>).

namespace LinkedList
{

    public class LinkedList<T> where T: IComparable<T>
    {
        private ListItem<T> head;
        private ListItem<T> current;
        private int size;

        public LinkedList()
        {
            this.size = 0;
        }

        public int Count 
        {
            get { return this.size; }
        }

        public void Add(T value)
        {
            this.size++;

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
        //Must implement getting the previous element in order to have correct removal of element
        public void Remove(T value)
        {
            ListItem<T> tempPreviousNode = this.head;
            ListItem<T> tempCurrentNode = this.head;

            while (tempCurrentNode.CompareTo(value) != 0)
            {
                tempPreviousNode = tempCurrentNode;
                tempCurrentNode = tempCurrentNode.NextItem;

                if (tempCurrentNode == null)
                {
                    throw new ArgumentException("No such element in the list!");
                }

                if (tempPreviousNode.CompareTo(value) == 0)
                {
                    tempPreviousNode = tempPreviousNode.NextItem;
                    tempCurrentNode = tempCurrentNode.NextItem;
                    this.size--;
                    break;
                }
            }
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
                    throw new ArgumentException("Cannot find such element in the list!");
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
