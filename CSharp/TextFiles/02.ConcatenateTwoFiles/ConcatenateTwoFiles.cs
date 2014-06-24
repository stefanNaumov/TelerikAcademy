using System;
using System.Collections.Generic;
using System.IO;
using System.Text;


//Write a program that concatenates two text files into another text file.


class ConcatenateTwoFiles
{
    static void Main()
    {
        Console.Write("Enter first file path: ");
        string first = Console.ReadLine();
        Console.Write("Enter second file path:");
        string second = Console.ReadLine();
        Console.Write("Enter the new file path in which the two files will be concatenated: ");
        string newFile = Console.ReadLine();
        ConcatenateFiles(first, second, newFile);
        
    }
    static void ConcatenateFiles(string firstFilePath,string secondFilePath,string newFilePath)
    {
        StreamReader reader = new StreamReader(firstFilePath);
        
        using (reader)
        {
            string textLine = reader.ReadLine();
            while (textLine != null)
            {
                StreamWriter writer = new StreamWriter(newFilePath,true); //true is used in order to append data to file
                using (writer)                                            //false will overwrite it
                {
                    writer.WriteLine(textLine);
                    textLine = reader.ReadLine();
                }
            }
        }
        reader = new StreamReader(secondFilePath);

        using (reader)
        {
            string textLine = reader.ReadLine();
            while (textLine != null)
            {
                StreamWriter writer = new StreamWriter(newFilePath, true); 
                using (writer)
                {
                    writer.WriteLine(textLine);
                    textLine = reader.ReadLine();
                }
            }
        }



        reader = new StreamReader(newFilePath);
        using (reader)
        {
            string text = reader.ReadToEnd();
            Console.WriteLine(text);
        }

        
    }
}

