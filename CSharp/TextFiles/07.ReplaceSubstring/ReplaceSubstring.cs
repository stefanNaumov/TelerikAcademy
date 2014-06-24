using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Text;
using System.Threading.Tasks;

//Write a program that replaces all occurrences of the substring "start" with the substring "finish" in a text file. 
//Ensure it will work with large files (e.g. 100 MB).


class ReplaceSubstring
{
    static void Main()
    {
        Console.Write("Enter the path of the file: ");
        string path = Console.ReadLine();
        Console.Write("Enter the text you want to be replaced: ");
        string text = Console.ReadLine();
        Console.Write("Enter the new text: ");
        string newText = Console.ReadLine();
        ReplaceString(path, text, newText);
    }
    static void ReplaceString(string path, string textToReplace, string newText)
    {
        StreamReader reader = new StreamReader(path);
        string text;
        using (reader)
        {
            text = reader.ReadToEnd();
            text = Regex.Replace(text,textToReplace,newText);
        }
        StreamWriter writer = new StreamWriter(path);
        using (writer)
        {
            writer.Write(text);
        }
    }
}

