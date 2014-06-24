using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

//Write a program that reads a text file and prints on the console its odd lines.



class OddLines
{
    static void Main()
    {
        Console.Write("Enter path to file: ");
        string path = Console.ReadLine();
        PrintOddLines(path);
    }
    static void PrintOddLines(string path)
    {
        StreamReader reader = new StreamReader(path);

        using (reader)
        {
            string line = reader.ReadLine();
            int lineCounter = 1;

            while(line != null)
            {
                if (lineCounter % 2 != 0)
                {
                    Console.WriteLine("line {0}: {1}",lineCounter,line);
                }
                line = reader.ReadLine();
                lineCounter++;
            }
        }
    }
}

