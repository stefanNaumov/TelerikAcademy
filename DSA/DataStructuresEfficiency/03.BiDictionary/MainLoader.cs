﻿using System;
using System.Collections.Generic;
using System.Linq;

//Implement a class BiDictionary<K1,K2,T> that allows adding triples {key1, key2, value} 
//and fast search by key1, key2 or by both key1 and key2. Note: multiple values can be stored for given key.

namespace BiDictionary
{
    class Program
    {
        static void Main()
        {
            BiDictionary<int, int, string> biDict = new BiDictionary<int, int, string>();
            biDict.InsertInFirstDict(1, "a");
            var items = biDict.GetElementsFromFirstDict(1);

            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
            biDict.RemoveFromFirstDict(1);
            items = biDict.GetElementsFromFirstDict(1);
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
        }
    }
}
