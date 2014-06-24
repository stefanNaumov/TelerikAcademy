using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//A dictionary is stored as a sequence of text lines containing words and their explanations. 
//Write a program that enters a word and translates it by using the dictionary. 
//Sample dictionary:
//.NET – platform for applications from Microsoft
//CLR – managed execution environment for .NET
//namespace – hierarchical organization of classes




class WordExplaination
{
    static void Main()
    {
        string word = Console.ReadLine();
        string explanation = Dictionary(word);
        if (explanation == null)
        {
            Console.WriteLine("No such word in dictionary!");
        }
        else
        {
            Console.WriteLine(explanation); 
        }
    }

    static string Dictionary(string word)
    {
        string explanation = null;
        Dictionary<string,string> dictionary = new Dictionary<string,string>();
        dictionary.Add(".NET", "platform for applications from Microsoft");
        dictionary.Add("CLR", "managed execution environment for .NET");
        dictionary.Add("namespace", "hierarchical organization of classes");
        for (int i = 0; i < dictionary.Count; i++)
        {
            if (dictionary.ContainsKey(word))
            {
                explanation = dictionary[word];
            }

        }
        return explanation;
    }
}

