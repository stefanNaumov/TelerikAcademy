using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

//Write a program that reads a text file and inserts line numbers in front of each of its lines. 
//The result should be written to another text file.



class InsertLineNumbers
{
    static void Main()
    {
        Console.Write("Enter file path: ");
        string pathFile = Console.ReadLine();
        Console.Write("Enter file path for the new file: ");
        string newFilePath = Console.ReadLine();
        LineNumbersInsert(pathFile, newFilePath);
        PrintFileFromPath(newFilePath);
    }
    static void LineNumbersInsert(string notNumbered,string fileToUse)
    {
        StreamReader reader = new StreamReader(notNumbered);
        int lineCounter = 1;
        using (reader)
        {
            string currentLine = reader.ReadLine();

            StreamWriter writer = new StreamWriter(fileToUse);

            using (writer)
            {
                while (currentLine != null)
                {
                    writer.Write(lineCounter);
                    writer.WriteLine(currentLine);
                    currentLine = reader.ReadLine();
                    lineCounter++; 
                }
            }
        }
    }
    static void PrintFileFromPath(string path)
    {
        StreamReader reader = new StreamReader(path);
        using (reader)
        {
            string text = reader.ReadToEnd();
            Console.WriteLine(text);
        }
    }
}

