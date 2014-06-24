using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

//Write a program that reads a text file containing a square matrix of numbers 
//and finds in the matrix an area of size 2 x 2 with a maximal sum of its elements. 
//The first line in the input file contains the size of matrix N. 
//Each of the next N lines contain N numbers separated by space. 
//The output should be a single number in a separate text file. Example:
//4
//2 3 3 4
//0 2 3 4			17
//3 7 1 2
//4 3 3 2


class Matrix2X2
{
    static void Main()
    {
        Console.Write("Enter path to the file: ");
        string path = Console.ReadLine();
        int biggestSum = Searchmatrix(path);
        Console.WriteLine("The biggest sum is {0}",biggestSum);
    }
    static int Searchmatrix(string path)
    {
        StreamReader reader = new StreamReader(path);
        int bestSum = 0;
        int matrixSize = int.Parse(reader.ReadLine());
        int[,] matrix = new int[matrixSize, matrixSize];

        //parse the numbers from the text file into a int[,];
        //we have taken the first line of the text file with "int matrixsize", so we start directly 
        //from the second line and parse each line by using it as array of strings;
        using (reader)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] currentLine = reader.ReadLine().Split(' ');
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = int.Parse(currentLine[col]);
                }
            }
        }
        
        //search the matrix for the best sum;

        for (int row = 0; row < matrix.GetLength(0)-1; row++)
        {
            for (int col = 0; col < matrix.GetLength(1)-1; col++)
            {
                int tempSum = matrix[row, col] + matrix[row + 1, col] + matrix[row, col + 1] + matrix[row + 1, col + 1];
                if (tempSum > bestSum)
                {
                    bestSum = tempSum;
                }
            }
        }
        return bestSum;
    }
}

