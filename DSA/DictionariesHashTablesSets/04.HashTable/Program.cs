using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.ObjectModel;

namespace HashTable
{
    class Program
    {
        static void Main()
        {
           
        }
    }
    public class HashTable<K,T>
    {
        private const int defaultCapacity = 16;
        private int elementsCount;
        private int capacity;
        LinkedList<KeyValuePair<K, T>>[] list;
        //constructor
        public HashTable()
        {
            this.list = new LinkedList<KeyValuePair<K, T>>[defaultCapacity];
            this.capacity = defaultCapacity;
        }
        //properties
        public int Count 
        {
            get { return this.elementsCount; }
        }
        public int Capacity
        {
            get { return this.capacity; }
        }
        //methods
        public void Add(K key, T value)
        {
            KeyValuePair<K, T> currentPair = new KeyValuePair<K, T>(key, value);
            if (this.elementsCount >= this.capacity * 0.75)
            {
                //implement AutoGrow()
            }
            int index = Index(key);
        }
        //CHECK!!!
        private void AutoGrow()
        {
            int doubleCapacity = this.capacity * 2;
            LinkedList<KeyValuePair<K, T>>[] newList = new LinkedList<KeyValuePair<K, T>>[doubleCapacity];
            foreach (var pair in this.list)
            {
                foreach (KeyValuePair<K,T> item in pair)
                {
                    int index = this.Index(item.Key);
                    if (newList[index] != null)
                    {
                        newList[index].AddLast(item);
                    }
                    else
                    {
                        newList[index].AddFirst(item);
                    }
                }
            }
            this.list = newList;
        }
        // hash function
        private int Index(K key)
        {
            int index = key.GetHashCode() % this.list.Length;
            return index;
        }
    }
}
