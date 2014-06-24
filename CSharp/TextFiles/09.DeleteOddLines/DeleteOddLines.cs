using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

//Write a program that deletes from given text file all odd lines. The result should be in the same file.


class DeleteOddLines
{
    static void Main()
    {
        Console.Write("Enter file path: ");
        string path = Console.ReadLine();
        OddLinesDeleter(path);
    }
    static void OddLinesDeleter(string path)
    {
        List<string> evenLines = new List<string>();
        int lineCounter = 1;
        StreamReader reader = new StreamReader(path);
        
        using (reader)
        {
            string currentLine = reader.ReadLine();
            while (currentLine != null)
            {
                if (lineCounter % 2 == 0)
                {
                    evenLines.Add(currentLine);
                }
                currentLine = reader.ReadLine();
                lineCounter++;
            }
        }
        StreamWriter writer = new StreamWriter(path);

        using (writer)
        {
            for (int i = 0; i < evenLines.Count; i++)
            {
                writer.Write(evenLines[i]);
            }
        }
    }
}

