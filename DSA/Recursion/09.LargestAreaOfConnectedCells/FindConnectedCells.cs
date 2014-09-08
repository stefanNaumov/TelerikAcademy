using System;
using System.Collections.Generic;

//Write a recursive program to find the largest connected area of adjacent empty cells in a matrix.

namespace _09.LargestAreaOfConnectedCells
{
    class FindConnectedCells
    {
        private static readonly char[,] labyrinth =
        {
            { ' ', ' ', ' ', '*', '*', ' ', ' ' },
            { '*', '*', ' ', '*', ' ', '*', '*' },
            { ' ', '*', ' ', '*', '*', ' ', ' ' },
            { '*','*', '*', '*', '*', '*', ' ' },
            { ' ', ' ', ' ', ' ', ' ', '*', 'e' },
        };

        static int maxCells = 0;

        static void Main()
        {
            FindLargestEmptyCellsArea(0, 0 , 0);
        }

        static void FindLargestEmptyCellsArea(int row, int col, int cellCounter)
        {
            if (row < 0 || row >= labyrinth.GetLength(0) || col < 0 || col >= labyrinth.GetLength(1))
            {
                return;
            }

            if (labyrinth[row,col] == '*')
            {
                if (cellCounter > maxCells)
                {
                    maxCells = cellCounter;
                }

                return;
            }

            if (row >= labyrinth.GetLength(0) - 1 && col >= labyrinth.GetLength(1) - 1)
            {
                Console.WriteLine("Max number of empty adjacent cells: {0}", maxCells);
                return;
            }

            if (labyrinth[row,col] != 'v')
            {
                cellCounter++;
            }
            else
            {
                if (cellCounter > maxCells)
                {
                    maxCells = cellCounter;
                    Console.WriteLine("Max number of empty adjacent cells: {0}", maxCells);
                }

                return;
            }
            
            labyrinth[row, col] = 'v';

            //go up
            FindLargestEmptyCellsArea(row - 1, col, cellCounter);

            //go down
            FindLargestEmptyCellsArea(row + 1, col, cellCounter);

            //go left
            FindLargestEmptyCellsArea(row, col - 1, cellCounter);

            //go right
            FindLargestEmptyCellsArea(row, col + 1, cellCounter);

        }
    }
}
