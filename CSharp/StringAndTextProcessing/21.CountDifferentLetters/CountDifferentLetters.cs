using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that reads a string from the console and prints all different letters in the string 
//along with information how many times each letter is found.


class CountDifferentLetters
{
    static void Main()
    {
        string text = "Write a program that reads a string from the console and pr" +
                      "along with information how many times each letter is found.";

        Dictionary<char, int> letterCount = CountLettersFromString(text);
        foreach (var element in letterCount)
        {
            Console.WriteLine("Letter: {0} - {1} times",element.Key,element.Value);
        }
    }
    static Dictionary<char, int> CountLettersFromString(string text)
    {
        Dictionary<char, int> letterCount = new Dictionary<char, int>();

        for (int i = 0; i < text.Length; i++)
        {
            if (letterCount.ContainsKey(text[i]))
            {
                letterCount[text[i]]++;
            }
            else
            {
                letterCount.Add(text[i], 1);
            }
        }
        return letterCount;
    }

}

