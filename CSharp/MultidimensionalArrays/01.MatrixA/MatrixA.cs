using System;
using System.Collections.Generic;

class MatricesWithGivenSize
{
    static void Main()
    {
        Console.WriteLine("Enter the size of the matrix:");
        int size = int.Parse(Console.ReadLine());
        int count = 1;
        int[,] matrix = new int[size, size];

        for (int col = 0; col < size; col++)
        {
            for (int row = 0; row < size; row++)
            {
                matrix[row, col] = count++;
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