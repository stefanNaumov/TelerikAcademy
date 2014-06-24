using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;


//Write a program that removes from a text file all words listed in given another text file. 
//Handle all possible exceptions in your methods.




class RemoveWordsListedInOtheFile
{
    static void Main()
    {
        Console.Write("Enter file path: ");
        string pathOfFile = Console.ReadLine();
        Console.Write("Enter path of the list of words: ");
        string listOfWords = Console.ReadLine();
        RemoveWords(pathOfFile, listOfWords);

    }
    
    static void RemoveWords(string pathOfFile, string listPath)
    {
        StreamReader reader = new StreamReader(listPath);
        string text;
        using (reader)
        {
            string listOfWords = reader.ReadToEnd();
            string[] words = listOfWords.Split(' ');
            StreamReader textReader = new StreamReader(pathOfFile);
            using (textReader)
            {
                text = textReader.ReadToEnd();

                for (int i = 0; i < words.Length; i++)
                {
                    text = text.Replace(words[i], " ");
                }
            }
        }
        StreamWriter writer = new StreamWriter(pathOfFile);

        using (writer)
        {
            writer.Write(text);
        }
    }
}

