using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.ObjectModel;

//Implement the data structure "hash table" in a class HashTable<K,T>. 
//Keep the data in array of lists of key-value pairs (LinkedList<KeyValuePair<K,T>>[]) 
//with initial capacity of 16. 
//When the hash table load runs over 75%, perform resizing to 2 times larger capacity. 
//Implement the following methods and properties: Add(key, value), 
//Find(key)value, Remove( key), Count, Clear(), this[], Keys.
//Try to make the hash table to support iterating over its elements with foreach.

namespace HashTable
{
    public class Program
    {
        static void Main()
        {
            HashTable<int, int> hashTable = new HashTable<int, int>();

            for (int i = 0; i < 200000; i++)
            {
                hashTable.Add(i, (i + 1) * i);
            }

            Console.WriteLine(hashTable.FindValue(250));
            hashTable.Clear();
            Console.WriteLine(hashTable.FindValue(250));
        }
    }

    public class HashTable<K,T> : IEnumerable
    {
        private const int defaultCapacity = 16;
        private int elementsCount;
        private int capacity;
        LinkedList<KeyValuePair<K, T>>[] list;
       
        public HashTable()
        {
            this.list = new LinkedList<KeyValuePair<K, T>>[defaultCapacity];
            this.capacity = defaultCapacity;
        }
        
        public int Count 
        {
            get { return this.elementsCount; }
        }
        public int Capacity
        {
            get { return this.capacity; }
        }

        public T this[K indexKey]
        {
            get 
            {
                return this.FindValue(indexKey);
            }
            set
            {
                this.Add(indexKey, value);
            }
        }

        public List<K> Keys
        {
            get
            {
                if (this.list.Length < 1)
                {
                    throw new ArgumentException("Cannot get keys from an empty HashTable<K,T>!");
                }

                List<K> keysList = new List<K>();
                for (int i = 0; i < this.list.Length; i++)
                {
                    if (this.list[i] != null)
                    {
                        var next = this.list[i].First;
                        while (next != null)
                        {
                            keysList.Add(next.Value.Key);
                            next = next.Next;
                        }
                    }
                }

                return keysList;
            }
        }
        
        //TODO:Implement
        public void Remove(K key)
        {
            int index = this.GetIndex(key);
            LinkedList<KeyValuePair<K, T>> linkedList = this.GetLinkedList(index);
            KeyValuePair<K, T> pair = default(KeyValuePair<K, T>);

            foreach (var item in linkedList)
            {
                if (item.Key.Equals(key))
                {
                    pair = item;
                    break;
                }
            }

            linkedList.Remove(pair);
        }

        public void Clear()
        {
            this.list = new LinkedList<KeyValuePair<K, T>>[defaultCapacity];
        }

        public T FindValue(K key)
        {
            int index = this.GetIndex(key);
            LinkedList<KeyValuePair<K, T>> linkedList = this.GetLinkedList(index);

            foreach (var pair in linkedList)
            {
                if (pair.Key.Equals(key))
                {
                    return pair.Value;
                }
            }

            return default(T);
        }

        public void Add(K key, T value)
        {
            
            if (this.elementsCount >= this.capacity * 0.75)
            {
                this.AutoGrow();
            }
            int index = GetIndex(key);
            KeyValuePair<K, T> currentPair = new KeyValuePair<K, T>(key, value);
            
            LinkedList<KeyValuePair<K, T>> linkedList = this.GetLinkedList(index);
            
            linkedList.AddLast(currentPair);

            this.elementsCount++;
        }
        
        private void AutoGrow()
        {
            int doubleCapacity = this.capacity * 2;
            LinkedList<KeyValuePair<K, T>>[] newList = new LinkedList<KeyValuePair<K, T>>[doubleCapacity];

            for (int i = 0; i < this.Count; i++)
            {
                newList[i] = this.list[i];
            }
            this.capacity = doubleCapacity;
            this.list = newList;
        }

        private LinkedList<KeyValuePair<K, T>> GetLinkedList(int index)
        {
            LinkedList<KeyValuePair<K, T>> linkedList = this.list[index];

            if (linkedList == null)
            {
                linkedList = new LinkedList<KeyValuePair<K, T>>();
                this.list[index] = linkedList;
            }

            return linkedList;
        }

        private int GetIndex(K key)
        {
            int index = Math.Abs(key.GetHashCode() % this.list.Length);
            return index;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public IEnumerator<KeyValuePair<K, T>> GetEnumerator()
        {
            for (int i = 0; i < this.list.Length; i++)
            {
                if (this.list[i] != null)
                {
                    var next = this.list[i].First;
                    while (next != null)
                    {
                        yield return next.Value;
                        next = next.Next;
                    }
                }
            }
        }
    }
}
