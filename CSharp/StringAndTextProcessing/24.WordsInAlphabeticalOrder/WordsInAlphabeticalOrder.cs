using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.



class WordsInAlphabeticalOrder
{
    static void Main()
    {
        string text = "Write a program that reads a list of words " + 
        "separated by spaces and prints the list in an alphabetical order.";
        string[] sortedWords = SortAlphabetically(text);
        for (int i = 0; i < sortedWords.Length; i++)
        {
            Console.WriteLine(sortedWords[i]);
        }
        Console.WriteLine();
    }
    static string[] SortAlphabetically(string text)
    {
        string[] splitted = text.Split(' ');
        Array.Sort(splitted);
        return splitted;
    }
}

