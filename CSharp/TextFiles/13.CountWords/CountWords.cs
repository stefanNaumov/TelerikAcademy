using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

//Write a program that reads a list of words from a file words.txt and finds how many times each of the words 
//is contained in another file test.txt. 
//The result should be written in the file result.txt and the words should be sorted by the number of their occurrences in descending order. 
//Handle all possible exceptions in your methods.



class CountWords
{
    static void Main()
    {
        Console.Write("Enter path of the file: ");
        string pathOfFile = Console.ReadLine();
        Console.Write("Enter the path of the file where the words are listed: ");
        string listOfWordsPath = Console.ReadLine();
        Console.Write("Enter the path of the file where the result will be written: ");
        string result = Console.ReadLine();

        WordCounter(pathOfFile, listOfWordsPath, result);
    }
    static void WordCounter(string path, string listOfWords, string resultFilePath)
    {
        StreamReader reader = new StreamReader(listOfWords);

        //make a class WordCount which has properties Name and Count -> the word and the number of it's appearance
        List<WordCount> wordsList = new List<WordCount>();

        using (reader)
        {
            string[] wordsArr = reader.ReadToEnd().Split(' ');
            for (int i = 0; i < wordsArr.Length; i++)
            {
                WordCount currentPair = new WordCount();
                currentPair.Name = wordsArr[i];
                currentPair.Count = 0;
                wordsList.Add(currentPair);
            }
        }
        reader = new StreamReader(path);

        using (reader)
        {
            string text = reader.ReadToEnd();
            for (int i = 0; i < wordsList.Count; i++)
            {
                int currentWordCounter = Regex.Matches(text, @"\b" + wordsList[i].Name + @"\b").Count;
                wordsList[i].Count += currentWordCounter;
            }
        }
        List<WordCount> orderedList = wordsList.OrderByDescending(w => w.Count).ToList();
        StreamWriter writer = new StreamWriter(resultFilePath);

        using (writer)
        {
            for (int i = 0; i < orderedList.Count; i++)
            {
                writer.Write(orderedList[i].Name + " ");
            }
        }
       
    }
}

