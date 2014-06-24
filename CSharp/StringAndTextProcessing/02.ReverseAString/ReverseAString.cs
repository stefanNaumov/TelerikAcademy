using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Write a program that reads a string, reverses it and prints the result at the console.
//Example: "sample"  "elpmas".




class ReverseAString
{
    static void Main()
    {
        Console.Write("Enter a word to be reversed: ");
        string word = Console.ReadLine();
        string reversed = ReverseString(word);
        Console.WriteLine(reversed);
    }
    static string ReverseString(string word)
    {
        StringBuilder builder = new StringBuilder();

        for (int i = word.Length-1; i >= 0; i--)
        {
            builder.Append(word[i]);
        }
        return builder.ToString();
    }
}

