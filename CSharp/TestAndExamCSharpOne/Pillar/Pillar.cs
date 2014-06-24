using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pillar
{
    class Pillar
    {
        static void Main()
        {
            int[,] matrix = new int[8, 8];
            
            //fill the matrix

            for (int row = 0; row < 8; row++)
            {
                int number = int.Parse(Console.ReadLine());
                for (int col = 0; col < 8; col++)
                {
                    matrix[row, col] = (number >> 7 - col) & 1;
                }
            }
            //for (int r = 0; r < 8; r++)
            //{
            //    for (int c = 0; c < 8; c++)
            //    {
            //        Console.Write(matrix[r,c]);
            //    }
            //    Console.WriteLine();
            //}
            //count bits
            int allBits = 0;
            for (int r = 0; r < 8; r++)
            {
                for (int c = 0; c < 8; c++)
                {
                    if (matrix[r, c] == 1)
                    {
                        allBits++;
                    }
                }
            }
            if (allBits == 1 || allBits == 0)
            {
                Console.WriteLine("No");
            }
            else
            {

                for (int middle = 0; middle < 8; middle++)
                {
                    int leftCounter = 0;
                    int rightCounter = 0;
                    for (int col = 0; col < 8; col++)
                    {
                        for (int row = 0; row < 8; row++)
                        {
                            if (col < middle)
                            {
                                leftCounter += matrix[row, col];
                            }
                            if (col > middle)
                            {
                                rightCounter += matrix[row, col];

                            }
                        }
                    }
                    if (leftCounter == rightCounter)
                    {
                        Console.WriteLine(7 - middle);
                        Console.WriteLine(leftCounter);
                        return;
                    }
                    else if (middle == 7 && leftCounter != rightCounter)
                    {
                        Console.WriteLine("No");
                    }
                }
            }
            

            //for (int r = 0; r < 8; r++)
            //{
            //    for (int c = 7; c >= 0; c--)
            //    {
            //        Console.Write(matrix[r,c]);
            //    }
            //    Console.WriteLine();
            //}

        }
    }
}
