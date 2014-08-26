using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program to traverse the directory C:\WINDOWS 
//and all its subdirectories recursively and to display all files matching the mask *.exe. 
//Use the class System.IO.Directory.

namespace TraverseDirectory
{
    class DirectoryTraverser
    {
        static void Main()
        {
            string rootDir = "C:\\WINDOWS";

            System.IO.DirectoryInfo dirInfo = new System.IO.DirectoryInfo(rootDir);
            TraverseDir(dirInfo);
            
        }

        public static void TraverseDir(System.IO.DirectoryInfo dirInfo)
        {
            System.IO.FileInfo[] files;

            files = dirInfo.GetFiles("*.exe*");

            if (files != null)
            {
                foreach (var file in files)
                {
                    Console.Write(file.FullName);
                    Console.WriteLine();
                }
            }
        }
    }
}
