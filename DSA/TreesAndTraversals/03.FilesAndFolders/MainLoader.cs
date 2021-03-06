﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Define classes File { string name, int size } 
//and Folder { string name, File[] files, Folder[] childFolders } 
//and using them build a tree keeping all files and folders on the hard drive starting from C:\WINDOWS. 
//Implement a method that calculates the sum of the file sizes in given subtree of the tree and test it accordingly. 
//Use recursive DFS traversal.

namespace FilesAndFoldersTrav
{
    class MainLoader
    {
        static void Main()
        {
            Folder root = new Folder("C:\\Windows");
            FileFolderTree tree = new FileFolderTree(root);

            long sum = tree.CalcFileSizesSum();

            Console.WriteLine("Sum of files sizes is: {0} bytes",sum);
        }
    }
}
