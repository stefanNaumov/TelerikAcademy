using System;
using System.Collections.Generic;
using System.Linq;
//We are given a matrix of passable and non-passable cells. Write a recursive program for finding all paths between two cells in the matrix.


namespace _07.FindPathsInMatrix
{
    class FindPaths
    {
        private static readonly char[,] labyrinth =
        {
            { ' ', ' ', ' ', '*', ' ', ' ', ' ' },
            { '*', '*', ' ', '*', ' ', '*', ' ' },
            { ' ', ' ', ' ', ' ', ' ', ' ', ' ' },
            { ' ', '*', '*', '*', '*', '*', ' ' },
            { ' ', ' ', ' ', ' ', ' ', ' ', 'e' },
        };

        static void Main()
        {
            int row = 0;
            int col = 0;
            List<char> directions = new List<char>();
            List<char> directionsList = new List<char>();
            FindPath(labyrinth, row, col,' ', directionsList);
        }

        static void FindPath(char[,] labyrinth, int row, int col, char direction, List<char> directions)
        {
            if (row < 0 || row >= labyrinth.GetLength(0) || col < 0 || col >= labyrinth.GetLength(1))
            {
                return;
            }
            
            if (labyrinth[row,col] == 'e')
            {
                Console.WriteLine("Exit found!");
                Console.WriteLine(String.Join(" ",directions));
                //Print(labyrinth, row, col);
                return;
            }

            if (labyrinth[row,col] == '*')
            {
                return;
            }

            if (labyrinth[row,col] == '|')
            {
                return;
            }
            labyrinth[row, col] = '|';
            directions.Add(direction);
            //go up
            FindPath(labyrinth, row - 1, col, 'U', directions);

            //go down
            FindPath(labyrinth, row + 1, col, 'D', directions);

            //go left
            FindPath(labyrinth, row, col - 1, 'L', directions);

            //go right
            FindPath(labyrinth, row, col + 1, 'R', directions);

            labyrinth[row, col] = ' ';
        }
    }
}
