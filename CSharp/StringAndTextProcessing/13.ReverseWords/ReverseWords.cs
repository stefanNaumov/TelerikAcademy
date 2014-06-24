using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Write a program that reverses the words in given sentence.
//Example: "C# is not C++, not PHP and not Delphi!"  "Delphi not and PHP, not C++ not is C#!".




class ReverseWords
{
    static void Main()
    {
        string sentence = "C# is not C++, not PHP and not Delphi!";
        string reversed = ReverseString(sentence);
        Console.WriteLine(reversed);
        

    }
    static string ReverseString(string text)
    {
        List<char> lettersInAlphabet = new List<char>();
        for (int i = 97; i < 123; i++)
        {
            lettersInAlphabet.Add((char)i);
        }
        for (int i = 65; i < 91; i++)
        {
            lettersInAlphabet.Add((char)i);
        }
        for (int i = 35; i < 44; i++)
        {
            lettersInAlphabet.Add((char)i);
        }
        char[] separators = new char[] { '.', ',', '!',' '};
        string[] words = text.Split(separators,StringSplitOptions.RemoveEmptyEntries);

        StringBuilder builder = new StringBuilder();
        string[] punctuation = text.Split(lettersInAlphabet.ToArray(),StringSplitOptions.RemoveEmptyEntries);
        Array.Reverse(words);

        for (int i = 0; i < punctuation.Length; i++)
        {
            builder.Append(words[i]);
            builder.Append(punctuation[i]);
        }
        return builder.ToString();
    }
}

