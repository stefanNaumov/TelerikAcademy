using System;
using System.Collections.Generic;

//Write a program that creates an array containing all letters from the alphabet (A-Z). 
//Read a word from the console and print the index of each of its letters in the array.

namespace _12.CharIndex
{
    class CharIndex
    {
        static void Main()
        {
            char[] alphabet = GenerateAlphabet();
            string word = "moisei";
            List<int> indeces = FindStringIndeces(word,alphabet);

            for (int i = 0; i < indeces.Count; i++)
            {
                Console.Write(indeces[i] + " ");    
            }
            Console.WriteLine();
        }
        //A smarter way is to keep chars and their indeces in a Dictionary<char,int>
        //but that is not the purpose of this HW 
        static char[] GenerateAlphabet()
        {
            char[] alphabet = new char[26];

            for (int i = 0; i < 26; i++)
            {
                alphabet[i] = (char)(i + 97);
            }

            return alphabet;
        }

        //could be done using the value of each char from the ASCII Table
        //static List<int> FindStringIndeces(string word)
        //{
        //    List<int> indeces = new List<int>(word.Length);
        //    word = word.ToLower();

        //    for (int i = 0; i < word.Length; i++)
        //    {
        //        indeces.Add((int)word[i] - 97);
        //    }

        //    return indeces;
        //}

        static List<int> FindStringIndeces(string word, char[] alphabet)
        {
            List<int> indeces = new List<int>(word.Length);
            word = word.ToLower();

            for (int i = 0; i < word.Length; i++)
            {
                char currentChar = word[i];

                for (int j = 0; j < alphabet.Length; j++)
                {
                    if (currentChar == alphabet[j])
                    {
                        indeces.Add(j);
                        break;
                    }
                }
            }

            return indeces;
        }
    }
}
