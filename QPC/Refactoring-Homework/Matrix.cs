using System;

namespace Matrix
{
    public class Matrix
    {
        private static int[] XDirections = { 1, 1, 1, 0, -1, -1, -1, 0 };
        private static int[] YDirections = { 1, 0, -1, -1, -1, 0, 1, 1 };
        private static int matrixValueCounter = 1;

        private static int GetDimensionsInput(string input) 
        {
            int size;
            bool isNumber = int.TryParse(input,out size);
            if (!isNumber)
            {
                throw new ArgumentException("Input is not a number!");
            }

            if (int.Parse(input) <= 0 || int.Parse(input) > 50)
            {
                throw new ArgumentOutOfRangeException("Input must be between 1 and 50!");
            }
            size = int.Parse(input);

            return size;
        }

        public static int[,] GenerateMatrix(string input) 
        {
            int dimensions = GetDimensionsInput(input);
            int row = 0;
            int col = 0;

            int[,] matrix = new int[dimensions, dimensions];

            FillMatrixValues(matrix, ref row, ref col);
            FindFirstAvaliableCell(matrix, out row, out col);

            matrixValueCounter++;

            return matrix;
        }

        private static void FillMatrixValues(int[,] matrix, ref int row, ref int col)
        {
            int directionX = 1;
            int directionY = 1;

            while (true)
            {
                matrix[row, col] = matrixValueCounter;

                if (!CheckForCollision(matrix,row,col))
                {
                    return;
                }

                while ((row + directionX >= matrix.GetLength(0) 
                    || row + directionX < 0 
                    || col + directionY >= matrix.GetLength(0) 
                    || col + directionY < 0 
                    || matrix[row + directionX, col + directionY] != 0))
                {
                    DirectionChange(ref directionX, ref directionY);

                }
                row += directionX;
                col += directionY;
                matrixValueCounter++;
            }
        }

        static void DirectionChange(ref int directionX, ref int directionY)
        {
            int currentDirection = 0;
            for (int count = 0; count < XDirections.Length; count++)
            {
                if (XDirections[count] == directionX && YDirections[count] == directionY)
                {
                    currentDirection = count;
                    break;
                }
            }

            if (currentDirection == XDirections.Length - 1) 
            { 
                directionX = XDirections[(currentDirection + 1) % XDirections.Length]; 
                directionY = YDirections[(currentDirection + 1) % XDirections.Length]; 
                return; 
            }
            else
            {
                directionX = XDirections[currentDirection + 1];

                directionY = YDirections[currentDirection + 1]; 
            }
        }

        static bool CheckForCollision(int[,] arr, int x, int y)
        {
            int[] dirX = { 1, 1, 1, 0, -1, -1, -1, 0 };
            int[] dirY = { 1, 0, -1, -1, -1, 0, 1, 1 };
            for (int i = 0; i < 8; i++)
            {
                if (x + dirX[i] >= arr.GetLength(0) || x + dirX[i] < 0)
                {
                    dirX[i] = 0;
                }

                if (y + dirY[i] >= arr.GetLength(0) || y + dirY[i] < 0)
                {
                    dirY[i] = 0;
                }
            }
            for (int i = 0; i < 8; i++)
            {
                if (arr[x + dirX[i], y + dirY[i]] == 0)
                {
                    return true;
                }
            }

            return false;
        }

        static void FindFirstAvaliableCell(int[,] arr, out int cellAtxPos, out int cellAtYPos)
        {
            cellAtxPos = 0;
            cellAtYPos = 0;
            for (int row = 0; row < arr.GetLength(0); row++)
            {
                for (int col = 0; col < arr.GetLength(1); col++)
                {
                    if (arr[row, col] == 0) 
                    { 
                        cellAtxPos = row;
                        cellAtYPos = col; 
                        return; 
                    }
                }
            }

        }

        public static int GetDimensionsInput()
        {
            int dimensions = int.Parse(Console.ReadLine());

            return dimensions;
        }

        private static void PrintMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(0); col++)
                {
                    Console.Write("{0}\t", matrix[row, col]);
                    //Console.Write("{0}{1}", matrix[row, col], new string(' ',
                    //    ((size * size).ToString().Length) - matrix[row, col].ToString().Length + 1));
                }

                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            int[,] matrix = GenerateMatrix(Console.ReadLine());

            PrintMatrix(matrix);
        }
    }
}
