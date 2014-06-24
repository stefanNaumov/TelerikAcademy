using System;

//* Write a program that reads a positive integer number N (N < 20) from console and outputs 
//in the console the numbers 1 ... N numbers arranged as a spiral.
//Example for N = 4




namespace _14.Spiral
{
    class Spiral
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());

            int[,] matrix = new int[N, N];
            int count = 1;
            int direction = 1;
            int row = 0;
            int col = 0;
            int maxRow = N - 1;
            int maxCol = N - 1;
            do
            {                                           //go right
                for (int i = col; i <= maxCol; i++)
                {
                    
                    matrix[row, i] = count;
                    count++;
                }

                row++;
                                                        //go down
                for (int i = row; i <= maxRow; i++)
                {
                    matrix[i, maxCol] = count;
                    count++;
                }
                                                        //go left
                maxCol--;

                for (int i = maxCol; i >= col; i--)
                {
                    matrix[maxRow, i] = count;
                    count++;
                }
                maxRow--;
                                                        //go up
                for (int i = maxRow; i >= row; i--)
                {
                    matrix[i, col] = count;
                    count++;
                }
                col++;
            }
            while (count <= N * N);
            

           
            
            
            for (int r = 0; r < N; r++)
            {
                for (int c = 0; c < N; c++)
                {
                    Console.Write(String.Format("{0}",matrix[r,c]).PadLeft(3));
                    Console.Write(' ');
                }
                Console.WriteLine();
            }
        }
    }
}
