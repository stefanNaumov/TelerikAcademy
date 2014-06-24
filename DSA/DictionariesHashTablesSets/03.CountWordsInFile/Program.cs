using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;


class Program
{
    static void Main()
    {
        string pathToFile = "../../words.txt";
        Dictionary<string, int> wordsCount = CountWords(pathToFile);
        var words = from word in wordsCount
                    orderby word.Value ascending
                    select word;
        foreach (var word in words)
        {
            Console.WriteLine("{0} -> {1} times",word.Key,word.Value);
        }
    }
    static Dictionary<string, int> CountWords(string path)
    {
        Dictionary<string, int> words = new Dictionary<string, int>();

        StreamReader reader = new StreamReader(path);
        using (reader)
        {
            string line = reader.ReadLine();
            while (line != null)
            {
                string[] lineWords = line.Split(new char[] { ' ', ',', '.', '!', '-','?' }, StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < lineWords.Length; i++)
                {
                    string currentWord = lineWords[i].ToLower();
                    if (char.IsLetter(currentWord[0]))
                    {
                        if (!(words.ContainsKey(currentWord)))
                        {
                            words.Add(currentWord, 1);
                        }
                        else
                        {
                            words[currentWord]++;
                        } 
                    }
                }
                line = reader.ReadLine();
            }
        }
        return words;
        
    }
}

