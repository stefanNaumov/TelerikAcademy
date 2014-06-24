using System;
using System.Collections.Generic;
using System.Threading.Tasks;
//* Write a program that finds the largest area of equal neighbor elements in a rectangular matrix and prints its size. 
//Hint: you can use the algorithm "Depth-first search" or "Breadth-first search" (find them in Wikipedia).

class LargestAreaOfEqualNeighbourElements
{
    static int bestCount = 0;
    static int tempCount = 0;
    static string[,] matrix = new string[,] {
                                            {"1","3","2","2","2","4",},
                                            {"3","3","3","2","4","4",},
                                            {"4","3","1","2","3","3",},
                                            {"4","3","1","3","3","1",},
                                            {"4","3","3","3","1","1",},
                                            };

    static void Main()
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                if(matrix[row,col] != "v")
                {
                    tempCount = 0;
                    SearchArea(row, col);
                    if(tempCount > bestCount)
                    {
                        bestCount = tempCount;
                    }
                    
                }
            }
        }
        Console.WriteLine(bestCount); 
    }
    static bool IsInTheMatrix(int row,int col)
    {
        bool isInMatrix = true;
        if((row <0 || col < 0) || (row >= matrix.GetLength(0) || col >= matrix.GetLength(1)))
        {
            isInMatrix = false;
        }
        return isInMatrix;
    }

    static void SearchArea(int row, int col)
    {
        string currentStr = matrix[row, col];
        matrix[row, col] = "v"; //mark the current cell as visited
        tempCount++;
        for (int i = -1; i < 2; i += 2) 
        {
            if ((IsInTheMatrix(row + i, col) && matrix[row + i, col] == currentStr)) //search the neighbour cells for the row
            {
                
                SearchArea(row + i, col);
            }
            if ((IsInTheMatrix(row, col + i) && matrix[row, col + i] == currentStr)) //search the neighbour cells for the col
            {
                
                SearchArea(row, col + i);
            }
        }
    }
    static void PrintMatrix(string[,] matrix)
    {
        for (int r = 0; r < matrix.GetLength(0); r++)
        {
            for (int c = 0; c < matrix.GetLength(1); c++)
            {
                Console.Write(matrix[r,c]);
            }
            Console.WriteLine();
        }
    }
}

