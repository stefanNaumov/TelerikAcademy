using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Write a program that extracts from a given text all sentences containing given word.
//Example: The word is "in". The text is:

//We are living in a yellow submarine. We don't have anything else. 
//Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.

//The expected result is:

//We are living in a yellow submarine.
//We will move out of it in 5 days.



class ExtractSentences
{
    static void Main()
    {
        string text = "We are living in a yellow submarine. We don't have anything else." +
                      "Inside the submarine is very tight. So we are drinking all the day." +
                      "We will move out of it in 5 days.";
        List<string> sentences = SentencesWithGivenWord(text,"in");
        for (int i = 0; i < sentences.Count; i++)
        {
            Console.Write(sentences[i] + ".");
        }
        Console.WriteLine();
    }
    static List<string> SentencesWithGivenWord(string text,string word)
    {
        List<string> extraxtedSentences = new List<string>();
        string[] splitText = text.Split('.');

        for (int i = 0; i < splitText.Length; i++)
        {
            if (splitText[i].Contains(" " + word + " "))
            {
                extraxtedSentences.Add(splitText[i]);
            }
        }
        return extraxtedSentences;
    }
}

