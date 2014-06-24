using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;

//Write a program that extracts from given XML file all the text without the tags. Example:
//<?xml version="1.0"><student><name>Pesho</name>
//<age>21</age><interests count="3"><interest> Games</instrest>
//<interest>C#</instrest><interest> Java</instrest></interests></student>



class TextWithoutTheTags
{
    static void Main()
    {
        Console.Write("Enter file path: ");
        string path = Console.ReadLine();
        ExtractTextWithoutTags(path);
    }
    static void ExtractTextWithoutTags(string path)
    {
        
        StreamReader reader = new StreamReader(path);
        string wordsWithoutTags;
        using (reader)
        {
            string text = reader.ReadToEnd();
            wordsWithoutTags = Regex.Replace(text, @"<(.*?)>", " "); //removes anything between "<" and ">"
        }
        StreamWriter writer = new StreamWriter(path);

        using (writer)
        {
            writer.Write(wordsWithoutTags);
        }
    }
}

