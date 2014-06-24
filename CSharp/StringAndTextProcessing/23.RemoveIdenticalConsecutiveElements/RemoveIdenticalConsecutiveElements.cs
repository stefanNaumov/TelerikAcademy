using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that reads a string from the console and replaces 
//all series of consecutive identical letters with a single one. Example: "aaaaabbbbbcdddeeeedssaa"  "abcdedsa".



class RemoveIdenticalConsecutiveElements
{
    static void Main()
    {
        string text = "aaaaabbbbbcdddeeeedssaa";
        string reduced = ReduceIdenticalRowToOneElement(text);
        Console.WriteLine(reduced);
    }
    static string ReduceIdenticalRowToOneElement(string text)
    {
        StringBuilder builder = new StringBuilder();
        int position = 0;

        while (position < text.Length-1)
        {
            char currentLetter = text[position];
            builder.Append(currentLetter);
            position++;

            while(text[position] == currentLetter && position < text.Length - 1)
            {
                position++;
            }
        }
        return builder.ToString();
    }
}

