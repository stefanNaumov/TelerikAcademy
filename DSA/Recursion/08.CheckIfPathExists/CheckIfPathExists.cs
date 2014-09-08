using System;
using System.Collections.Generic;
using System.Linq;

//Modify the above program to check whether a path exists between two cells without finding all possible paths. 
//Test it over an empty 100 x 100 matrix.

namespace _08.CheckIfPathExists
{
     
    class CheckIfPathExists
    {
        private static readonly char[,] labyrinth =
        {
            {' ', ' ', ' ', ' ', ' ', ' ',' ', ' ', ' ', ' ', ' ', ' ',' ', ' ', ' ', ' ', ' ', ' ', ' ' },
            {' ', ' ', ' ', ' ', ' ', ' ',' ', ' ', ' ', ' ', ' ', ' ',' ', ' ', ' ', ' ', ' ', ' ', ' ' },
            {' ', ' ', ' ', ' ', ' ', ' ',' ', ' ', ' ', ' ', ' ', ' ',' ', ' ', ' ', ' ', ' ', ' ', ' ' },
            {' ', ' ', ' ', ' ', ' ', ' ',' ', ' ', ' ', ' ', ' ', ' ',' ', ' ', ' ', ' ', ' ', ' ', ' ' },
            {' ', ' ', ' ', ' ', ' ', ' ',' ', ' ', ' ', ' ', ' ', ' ',' ', ' ', ' ', ' ', ' ', ' ', ' ' },
            {' ', ' ', ' ', ' ', ' ', ' ',' ', ' ', ' ', ' ', ' ', ' ',' ', ' ', ' ', ' ', ' ', ' ', ' ' },
            {' ', ' ', ' ', ' ', ' ', ' ',' ', ' ', ' ', ' ', ' ', ' ',' ', ' ', ' ', ' ', ' ', ' ', ' ' },
            {' ', ' ', ' ', ' ', ' ', ' ',' ', ' ', ' ', ' ', ' ', ' ',' ', ' ', ' ', ' ', ' ', ' ', ' ' },
            {' ', ' ', ' ', ' ', ' ', ' ',' ', ' ', ' ', ' ', ' ', ' ',' ', ' ', ' ', ' ', ' ', ' ', ' ' },
            {' ', ' ', ' ', ' ', ' ', ' ',' ', ' ', ' ', ' ', ' ', ' ',' ', ' ', ' ', ' ', ' ', ' ', ' ' },
            {' ', ' ', ' ', ' ', ' ', ' ',' ', ' ', ' ', ' ', ' ', ' ',' ', ' ', ' ', ' ', ' ', ' ', ' ' },
            {' ', ' ', ' ', ' ', ' ', ' ',' ', ' ', ' ', ' ', ' ', ' ',' ', ' ', ' ', ' ', ' ', ' ', ' ' },
            {' ', ' ', ' ', ' ', ' ', ' ',' ', ' ', ' ', ' ', ' ', ' ',' ', ' ', ' ', ' ', ' ', ' ', 'e' },
        };

        private static bool IsPathExisting = false;

        static void Main()
        {
            FindPath(labyrinth, 0, 0);
        }

        private static void FindPath(char[,] labyrinth, int row, int col)
        {
            if (row < 0 || row >= labyrinth.GetLength(0) || col < 0 || col >= labyrinth.GetLength(1))
            {
                return;
            }

            if (labyrinth[row,col] == '|')
            {
                return;
            }

            if (row >= labyrinth.GetLength(0) - 1 && col >= labyrinth.GetLength(1) - 1 && labyrinth[row,col] != 'e')
            {
                Console.WriteLine("No path exists");
                return;
            }

            if (labyrinth[row,col] == 'e')
            {
                Console.WriteLine("Exit found");
                return;
            }
            labyrinth[row, col] = '|';
            
            //go up
            FindPath(labyrinth, row - 1, col);

            //go down
            FindPath(labyrinth, row + 1, col);

            //go left
            FindPath(labyrinth, row, col - 1);

            //go right
            FindPath(labyrinth, row, col + 1);

            //labyrinth[row, col] = ' ';
        }
    }
}
