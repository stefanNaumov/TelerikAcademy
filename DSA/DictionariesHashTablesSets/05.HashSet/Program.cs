using System;
using System.Collections.Generic;
using System.Linq;
using HashTable;
using System.Collections;

//Implement the data structure "set" in a class HashedSet<T> using your class HashTable<K,T> to hold the elements. 
//Implement all standard set operations like Add(T), Find(T), Remove(T), Count, Clear(), union and intersect.
namespace HashSet
{
    class Program
    {
        static void Main()
        {

        }
    }

    public class CustomHashSet<T> : IEnumerable
    {
        private HashTable<T, int> hashTable;

        public CustomHashSet()
        {
            this.hashTable = new HashTable<T, int>();
        }

        public int Count
        {
            get
            {
                return this.hashTable.Count;
            }
        }

        public IEnumerable<T> Items
        {
            get
            {
                return this.hashTable.GetKeys();
            }
        }

       

    }
}
