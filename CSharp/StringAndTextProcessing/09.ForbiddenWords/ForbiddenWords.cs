using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


//We are given a string containing a list of forbidden words and a text containing some of these words. 
//Write a program that replaces the forbidden words with asterisks. Example:

//Microsoft announced its next generation PHP compiler today. 
//It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.

//Words: "PHP, CLR, Microsoft"
//The expected result:

//********* announced its next generation *** compiler today. 
//It is based on .NET Framework 4.0 and is implemented as a dynamic language in ***.




class ForbiddenWords
{
    static void Main()
    {
        string text = "Microsoft announced its next generation PHP compiler today.\n" +
                      "It is based on .NET Framework 4.0 \nand is implemented as a dynamic language in CLR.";
        string forbiddenWords = "PHP, CLR, Microsoft";
       
        string withoutForbidden = ForbiddenWordsToAsteriks(text, forbiddenWords);
        Console.WriteLine(withoutForbidden);
    }
    static string ForbiddenWordsToAsteriks(string text, string words)
    {
        words = words.Trim();
        string[] forbiddenWords = words.Split(',');
        
        StringBuilder builder = new StringBuilder(text);

        for (int i = 0; i < forbiddenWords.Length; i++)
        {
            builder = builder.Replace(forbiddenWords[i], new string('*', forbiddenWords[i].Length));
        }
        return builder.ToString();
    }

}

