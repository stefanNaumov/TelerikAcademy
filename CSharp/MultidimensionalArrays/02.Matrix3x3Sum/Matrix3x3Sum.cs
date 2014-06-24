using System;
using System.Collections.Generic;

//Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 that has maximal sum of its elements.



class Matrix3x3Sum
{
    static void Main()
    {
        //Console.WriteLine("Write value N for rows:");
        //int n = int.Parse(Console.ReadLine());
        //Console.WriteLine("Write value M for columns:");
        //int m = int.Parse(Console.ReadLine());
        int[,] matrix = new int[,]
        {
        { 9, 8, 4, 7, 9, 0 },

        { 7, 66, -3, 3, 8, 0 },

        { 8, 7, 9, 8, 9, 0 },

        { 12, 2, 7, 9, 1, 0 },

        { 0, 2, 4, 0, 9, 5 },

        { 7, 1, 3, 3, 2, 1 },

        { 1, 3, 9, 8, 5, 6 },

        { 4, 6, 7, 9, 1, 0 }};

        int tempSum;
        int bestSum = int.MinValue;
        int bestRow = 0;
        int bestCol = 0;

        for (int rows = 0; rows < matrix.GetLength(0) - 2; rows++)
        {
            for (int columns = 0; columns < matrix.GetLength(1) - 2; columns++)
            {
                tempSum = matrix[rows, columns] + matrix[rows, columns + 1] + matrix[rows, columns + 2] + matrix[rows + 1, columns] +
                    matrix[rows + 1, columns + 1] + matrix[rows + 1, columns + 2] + matrix[rows + 2, columns] +
                    matrix[rows + 2, columns + 1] + matrix[rows + 2, columns + 2];
                if (tempSum > bestSum)
                {
                    bestSum = tempSum;
                    bestRow = rows;
                    bestCol = columns;
                }
                tempSum = 0;
            }
        }
        for (int row = bestRow; row <= bestRow + 2; row++)
        {
            for (int col = bestCol; col <= bestCol + 2; col++)
            {
                Console.Write("{0,5}", matrix[row, col]);
            }
            Console.WriteLine();
        }
        Console.WriteLine("And the biggest sum is: {0} ", bestSum);

    }
}

