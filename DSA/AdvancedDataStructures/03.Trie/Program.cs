﻿using System;
using System.Linq;


//Write a program that finds a set of words (e.g. 1000 words) in a large text (e.g. 100 MB text file). 
//Print how many times each word occurs in the text.
//Hint: you may find a C# trie in Internet.

namespace Trie
{
    class Program
    {
        static void Main()
        {
            Trie<bool> trie = new Trie<bool>();

            trie.AddRange(Enumerable.Range(0, 100).Select(i => new TrieEntry<bool>(i.ToString(), false)));

        }
    }
}
