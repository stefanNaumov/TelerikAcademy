using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class Program
    {
        static void Main()
        {
            Matrix<decimal> matrix = new Matrix<decimal>(3,3);
            Matrix<decimal> secMatrix = new Matrix<decimal>(3, 3);
            decimal counter = 1;
            decimal secCounter = 2;
            for (int i = 0; i < matrix.GetRows; i++)
            {
                for (int j = 0; j < matrix.GetCols; j++)
                {
                    matrix[i, j] = counter;
                    secMatrix[i, j] = secCounter;
                    counter++;
                    secCounter += 2;
                }
            }
            Console.WriteLine("Sum of the two matrices");
            Matrix<decimal> sum = matrix + secMatrix;
            for (int i = 0; i < sum.GetRows; i++)
            {
                for (int j = 0; j < sum.GetCols; j++)
                {
                    Console.Write(sum[i,j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("Subtraction of the two matrices");
            Matrix<decimal> subtraction = matrix - secMatrix;
            for (int i = 0; i < sum.GetRows; i++)
            {
                for (int j = 0; j < sum.GetCols; j++)
                {
                    Console.Write(subtraction[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("Mulitplication of the two matrices:");
            Matrix<decimal> multiplication = matrix * secMatrix;
            for (int i = 0; i < sum.GetRows; i++)
            {
                for (int j = 0; j < sum.GetCols; j++)
                {
                    Console.Write(multiplication[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
