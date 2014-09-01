using System;
using System.Collections.Generic;
using System.Linq;
using Wintellect.PowerCollections;

namespace BiDictionary
{
    public class BiDictionary<K1, K2, V>
    {
        //TODO:Implement ContainsKey methods

        private MultiDictionary<K1,V> firstDict;
        private MultiDictionary<K2,V> secondDict;
        private MultiDictionary<Tuple<K1, K2>, V> biDict;
        private int count;

        public BiDictionary()
        {
            this.firstDict = new MultiDictionary<K1, V>(false);
            this.secondDict = new MultiDictionary<K2, V>(false);
            this.biDict = new MultiDictionary<Tuple<K1, K2>, V>(false);
            this.count = 0;
        }

        public int Count
        {
            get { return this.count; }
        }

        public void InsertInFirstDict(K1 key,V value)
        {
            this.firstDict.Add(key, value);
            this.count++;
        }

        public void InsertInSecondDict(K2 key, V value)
        {
            this.secondDict.Add(key, value);
            this.count++;
        }

        public void InsertInBiDict(K1 firstKey, K2 secondKey, V value)
        {
            Tuple<K1, K2> keysPair = new Tuple<K1, K2>(firstKey, secondKey);

            this.biDict.Add(keysPair, value);
            this.count++;
        }

        public void Clear()
        {
            this.firstDict = new MultiDictionary<K1, V>(false);
            this.secondDict = new MultiDictionary<K2, V>(false);
            this.biDict = new MultiDictionary<Tuple<K1, K2>, V>(false);
            this.count = 0;
        }

        public IEnumerable<V> GetElementsFromFirstDict(K1 key)
        {
            IEnumerable<V> valueElements = this.firstDict[key].ToList();

            return valueElements;
        }

        public IEnumerable<V> GetElementsFromSecondDict(K2 key)
        {
            IEnumerable<V> valueElements = this.secondDict[key].ToList();

            return valueElements;
        }

        public IEnumerable<V> GetElementsFromBiDict(K1 firstKey, K2 secondKey, V value)
        {
            Tuple<K1,K2> keyPar = new Tuple<K1,K2>(firstKey, secondKey);
            IEnumerable<V> valueElements = this.biDict[keyPar].ToList();

            return valueElements;
        }

        public void RemoveFromFirstDict(K1 key)
        {
            if (this.firstDict.Count < 1)
            {
                throw new ArgumentException("Cannot remove from an empty dictionary!");
            }
            this.firstDict.Remove(key);
            this.count--;
        }

        public void RemoveFromSecondDict(K2 key)
        {
            if (this.secondDict.Count < 1)
            {
                throw new ArgumentException("Cannot remove from an empty dictionary!");
            }

            this.secondDict.Remove(key);
            this.count--;
        }

        public void RemoveFromBiDict(K1 firstKey, K2 secondKey)
        {
            if (this.biDict.Count < 1)
            {
                throw new ArgumentException("Cannot remove from an empty dictionary!");
            }

            Tuple<K1, K2> keyPair = new Tuple<K1, K2>(firstKey, secondKey);
            this.biDict.Remove(keyPair);
            this.count--;
        }
    }
}
