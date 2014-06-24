using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.IO;

//Modify the solution of the previous problem to replace only whole words (not substrings).



class ReplaceWords
{
    static void Main()
    {
        Console.Write("Enter the path of the file: ");
        string path = Console.ReadLine();
        Console.Write("Enter the text you want to be replaced: ");
        string textToReplace = Console.ReadLine();
        Console.Write("Enter the new text: ");
        string newText = Console.ReadLine();
        ReplaceWholeWords(path, textToReplace, newText);
    }
    static void ReplaceWholeWords(string path,string textToBeReplaced,string newText)
    {
        StreamReader reader = new StreamReader(path);
        string text;
        using (reader)
        {
            text = reader.ReadToEnd();
               
            text = Regex.Replace(text, @"\b"+textToBeReplaced+@"\s", newText); //using regular expressions
            //for testing visit http://gskinner.com/RegExr/
        }
        StreamWriter writer = new StreamWriter(path);
            
        using(writer)
        {
            writer.Write(text);
        }
    }
}

