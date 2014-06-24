using System;
using System.Collections.Generic;
using System.IO;


//Write a program that enters file name along with its full file path (e.g. C:\WINDOWS\win.ini), 
//reads its contents and prints it on the console. 
//Find in MSDN how to use System.IO.File.ReadAllText(…). 
//Be sure to catch all possible exceptions and print user-friendly error messages.




class ReadFileFromPath
{
    static void Main()
    {
        
        Console.Write("Enter the path of the file you want to print: ");
        string path = Console.ReadLine();
        PrintFromPath(path);
    }
    static void PrintFromPath(string path)
    {
        try
        {
            string file = File.ReadAllText(path);
            Console.WriteLine(file);
        }
        catch (DirectoryNotFoundException)
        {
            throw new DirectoryNotFoundException("\n The directory you entered could not be found!");
        }
        catch (FileNotFoundException)
        {
            throw new FileNotFoundException("\n The file could not be found in the specified directory!");
        }
        catch (ArgumentNullException ane)
        {

            throw new ArgumentNullException(ane.Message);
        }

    }
}

