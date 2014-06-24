using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;

//Write a program that deletes from a text file all words that start with the prefix "test". 
//Words contain only the symbols 0...9, a...z, A…Z, _.



class DeleteTextWithPrefix
{
    static void Main()
    {
        Console.Write("Enter file path: ");
        string filePath = Console.ReadLine();
        DeleteText(filePath);
    }
    static void DeleteText(string path)
    {
        StreamReader reader = new StreamReader(path);
        string deletedPrefix;

        using (reader)
        {
            string text = reader.ReadToEnd();
            deletedPrefix = Regex.Replace(text, @"\b(?:test).*?\b", "");
        }
        StreamWriter writer = new StreamWriter(path);

        using (writer)
        {
            writer.Write(deletedPrefix);
        }
    }
}

