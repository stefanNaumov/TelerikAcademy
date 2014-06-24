using System;

//Write a program that reads from the console a positive integer number N (N < 20) and outputs a matrix like the following:



namespace _12.Matrix
{
    class Matrix
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());

            int[,] matrix = new int[N, N];
            int counter = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)         //matrix.GetLength(0) gets the length of the
            {
                                                                 //first dimension of the matrix - the rows
                for (int col = 0; col < matrix.GetLength(1); col++) //matrix.GetLength(1) - the length of the second dimension-
                {                                                   // the columns of the matrix,if we have a cube[,,]
                    counter++;                                               // there will be 3 dimensions, for example.
                    matrix[row, col] = counter; 
                }
                counter = (counter - (N/2)) - 1;
                Console.WriteLine();
            }
            
            //Printing the matrix using the same logic

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row,col]);
                    Console.Write(' ');
                }
                Console.WriteLine();
            }

        }
    }
}
