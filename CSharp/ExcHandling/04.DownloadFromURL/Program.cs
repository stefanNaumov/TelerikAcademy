using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.IO;
using System.Diagnostics;
using System.Threading;


//Write a program that downloads a file from Internet 
//(e.g. http://www.devbg.org/img/Logo-BASD.jpg) and stores it the current directory. 
//Find in Google how to download files in C#. 
//Be sure to catch all exceptions and to free any used resources in the finally block.



namespace _04.DownloadFromURL
{
    class Program
    {
        static void Main()
        {
            try
            {
                Console.Write("Enter URL: ");
                string url = Console.ReadLine();
                Console.Write("Enter directory: ");
                string path = Console.ReadLine();
                Console.Write("Enter file name: ");
                string fileName = Console.ReadLine();
                Console.WriteLine("Please wait while downloading...");
                string fullPath = path + "\\" + fileName;
                WebClient client = new WebClient();
                client.DownloadFile(url, fullPath);

                Console.WriteLine("Download completed!");
                

            }
            catch (Exception ex)
            {

                Console.WriteLine("Invalid URL or missing directory!");
            }

        }
    }
}



