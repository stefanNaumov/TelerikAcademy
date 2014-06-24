using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;


//Write a program that compares two text files line by line and prints the number of lines that are the same 
//and the number of lines that are different. Assume the files have equal number of lines.



class Program
{
    static void Main()
    {
        Console.Write("Enter first file path: ");
        string firstFile = Console.ReadLine();
        Console.Write("Enter second file path: ");
        string secondFile = Console.ReadLine();
        Tuple<int,int> compared = CompareFilesForEqualLines(firstFile,secondFile);
        Console.WriteLine("The equal lines in the tow files are {0}",compared.Item1);
        Console.WriteLine("The different lines are {0}",compared.Item2);
    }
    static Tuple<int, int> CompareFilesForEqualLines(string firstFilePath, string secondFilePath)
    {
        StreamReader firstFileReader = new StreamReader(firstFilePath);
        StreamReader secondFileReader = new StreamReader(secondFilePath);
        int equalLines = 0;
        int differentLines = 0;
        using (firstFileReader)
        {
            string currFirstLine = firstFileReader.ReadLine();
            string currSecondLine = secondFileReader.ReadLine();
            
            while (currFirstLine != null && currSecondLine != null) //in this particular task the two files will be with equal length
            {                                                       //but despite that this seems more correct.
                if (currFirstLine == currSecondLine)
                {
                    equalLines++;
                }
                else if (currFirstLine != currSecondLine)
                {
                    differentLines++;
                }
                currFirstLine = firstFileReader.ReadLine();
                currSecondLine = secondFileReader.ReadLine();
            }

        }
        return new Tuple<int, int>(equalLines, differentLines);
    }
}

