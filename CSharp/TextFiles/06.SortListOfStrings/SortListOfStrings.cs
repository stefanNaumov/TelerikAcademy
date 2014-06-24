using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;


//Write a program that reads a text file containing a list of strings, 
//sorts them and saves them to another text file. Example:
    //Ivan			George
    //Peter			Ivan
    //Maria			Maria
    //George			Peter


    class SortListOfStrings
    {
        static void Main()
        {
            Console.Write("Enter path of the unsorted file: ");
            string unsortedFile = Console.ReadLine();
            Console.Write("Enter path of the file where the sorted old file will be copied: ");
            string sortedPath = Console.ReadLine();
            List<string> listToSort = ReadAndSortStrings(unsortedFile);
            PrintToFile(listToSort, sortedPath);
            
        }
        static List<string> ReadAndSortStrings(string path)
        {
            StreamReader reader = new StreamReader(path);
            List<string> readFile = new List<string>();
            using (reader)
            {
                string currLine = reader.ReadLine();
                while (currLine != null)
                {
                    readFile.Add(currLine);
                    currLine = reader.ReadLine();
                }
            }
            readFile.Sort();
            return readFile;
        }
        static void PrintToFile(List<string> sortedList, string pathOfFile)
        {
            StreamWriter writer = new StreamWriter(pathOfFile);
            using (writer)
            {
                for (int i = 0; i < sortedList.Count; i++)
                {
                    writer.WriteLine(sortedList[i]);
                }
            }
        }
    }

