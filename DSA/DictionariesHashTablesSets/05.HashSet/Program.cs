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
            CustomHashSet<int> firstSet = new CustomHashSet<int>();
            CustomHashSet<int> secondSet = new CustomHashSet<int>();

            for (int i = 1; i < 5; i++)
            {
                firstSet.Add(i);
            }

            for (int i = 2; i < 7; i++)
            {
                secondSet.Add(i);
            }

            CustomHashSet<int> newSet = firstSet.Union(secondSet);

            foreach (var item in newSet)
            {
                Console.WriteLine(item);
            }
        }
    }

    public class CustomHashSet<T> : IEnumerable
    {
        private HashTable<T, int> hashTable;

        public CustomHashSet()
        {
            this.hashTable = new HashTable<T, int>();
        }

        public void Add(T key)
        {
            //if (!this.ContainsKey(key))
            //{
                this.hashTable.Add(key, key.GetHashCode());
            //}
        }

        public void Remove(T key)
        {
            this.hashTable.Remove(key);
        }

        public void Clear()
        {
            this.hashTable.Clear();
        }

        public int Count
        {
            get
            {
                return this.hashTable.Count;
            }
        }

        public bool ContainsKey(T key)
        {
            //if (this.hashTable.FindValue(key).Equals(null))
            //{
            //    return false;
            //}

            return true;
             
        }

        public IEnumerable<T> Items
        {
            get
            {
                return this.hashTable.Keys;
            }
        }

        public IEnumerator GetEnumerator()
        {
            foreach (var item in this.hashTable)
            {
                yield return item.Value;
            }
        }

        public CustomHashSet<T> Union(CustomHashSet<T> hashSet)
        {
            IEnumerable<T> unionSet = this.Items.Union(hashSet.Items);
            CustomHashSet<T> newHashSet = new CustomHashSet<T>();

            foreach (var item in unionSet)
            {
                newHashSet.Add(item);
            }

            return newHashSet;
        }

        public CustomHashSet<T> Intersect(CustomHashSet<T> hashSet)
        {
            IEnumerable<T> intersectionSet = this.Items.Intersect(hashSet.Items);
            CustomHashSet<T> newHashSet = new CustomHashSet<T>();

            foreach (var item in intersectionSet)
            {
                newHashSet.Add(item);
            }

            return newHashSet;
        }

    }
}
