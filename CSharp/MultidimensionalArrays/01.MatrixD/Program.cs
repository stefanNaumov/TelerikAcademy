using System;
using System.Collections.Generic;

class MatrixWithGivenSizeD
{
    static void Main()
    {

        Console.WriteLine("Enter the size of the matrix and press Enter:");
        int size = int.Parse(Console.ReadLine());
        int count = 1;
        int start = 0;
        int end = size;
        int[,] matrix = new int[size, size];
        do
        {
            for (int A = start; A < end; A++)
            {
                matrix[A, start] = count++;
            }
            for (int B = start + 1; B < end; B++)
            {
                matrix[end - 1, B] = count++;
            }
            for (int C = end - 2; C >= start; C--)
            {
                matrix[C, end - 1] = count++;
            }
            for (int D = end - 2; D > start; D--)
            {
                matrix[start, D] = count++;
            }
            end -= 1;
            start += 1;
        }
        while (end - start > 0);
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0,5}", matrix[row, col]);
            }
            Console.WriteLine();
            Console.WriteLine();
        }

    }
}

