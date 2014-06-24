using System;
using System.Collections.Generic;

class MatrixWithGivenSizeB
{
    static void Main()
    {
        Console.WriteLine("Enter the size of the matrix:");
        int size = int.Parse(Console.ReadLine());
        int[,] matrix = new int[size, size];
        int count = 0;
        for (int col = 0; col < size; col++)
        {
            if (col % 2 == 0)
            {
                for (int row = 0; row < size; row++)
                {
                    matrix[row, col] = count++;
                }
            }
            else
            {
                for (int row = size - 1; row >= 0; row--)
                {
                    matrix[row, col] = count++;
                }
            }
        }
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0,5}", matrix[row, col]);
            }
            Console.WriteLine();
        }
    }
}

