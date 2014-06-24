using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Write a program that reads a string from the console and lists all different words 
//in the string along with information how many times each word is found.



class CountDifferentWords
{
    static void Main()
    {
        string text = "Write a program that reads a string from the console and lists all different words" + 
        "in the string along with information how many times each word is found.";

        var words = WordCounter(text);
        foreach (var element in words)
        {
            Console.WriteLine("The word: \"{0}\" appears {1} times",element.Key,element.Value);
        }
    }
    static Dictionary<string,int> WordCounter(string text)
    {
        Dictionary<string, int> list = new Dictionary<string, int>();

        string[] textToArray = text.Split(' ');
        for (int i = 0; i < textToArray.Length; i++)
        {
            if (list.ContainsKey(textToArray[i]))
            {
                list[textToArray[i]]++;
            }
            else
            {
                list.Add(textToArray[i], 1);
            }
        }
        return list;
    }
}

