using System;
using System.Collections.Generic;

//We are given a matrix of strings of size N x M. 
//Sequences in the matrix we define as sets of several neighbor elements located on the same line, column or diagonal. 
//Write a program that finds the longest sequence of equal strings in the matrix.

class StringMatrix
{
    static void Main()
    {
        string[,] matrix = new string[,]
        {
        {"c","fifi","ho","ha"},
        {"hgh","c","ese","trg"},
        {"h","gh","c","g"},
        {"ha","fifi","po","hi"},
        {"fg","h","ese","c"},
        {"xxx","eder","ha","bmw"}};
        int count = 1;
        int maxSum = 0;
        string currentElement = "";
        int position = 1;
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 1; col++)
            {
                if (matrix[row, col] == matrix[row, col + 1])
                {
                    count++;
                }
                else
                {
                    count = 1;
                }
                if (count > maxSum)
                {
                    maxSum = count;
                    currentElement = matrix[row, col];
                    position = 1;
                }
            }
            count = 1;
        }

        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                if (matrix[row, col] == matrix[row + 1, col])
                {
                    count++;
                }
                else
                {
                    count = 1;
                }
                if (count > maxSum)
                {
                    maxSum = count;
                    currentElement = matrix[row, col];
                    position = 2;
                }
            }
            count = 1;
        }
        for (int row = 0; row < matrix.GetLength(0) - 1; row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 1; col++)
            {
                for (int i = row, i2 = col; i < matrix.GetLength(0) - 1 && i2 < matrix.GetLength(1) - 1; i++, i2++)
                {
                    if (matrix[i, i2] == matrix[i + 1, i2 + 1])
                    {
                        count++;
                    }
                    else
                    {
                        count = 1;
                    }
                    if (count > maxSum)
                    {
                        maxSum = count;
                        currentElement = matrix[i, i2];
                        position = 3;
                    }
                }
            }
            count = 1;
        }
        for (int row = 0; row < matrix.GetLength(0) - 1; row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                for (int i = row, i2 = col; i < matrix.GetLength(0) - 1 && i2 > 0; i++, i2--)
                {
                    if (matrix[i, i2] == matrix[i + 1, i2 - 1])
                    {
                        count++;
                    }
                    else
                    {
                        count = 1;
                    }
                    if (count > maxSum)
                    {
                        maxSum = count;
                        currentElement = matrix[i, i2];
                        position = 4;
                    }
                }
                count = 1;
            }
        }
        switch (position)
        {
            case 1:
                Console.WriteLine("{0} is {1} times ", currentElement, maxSum);
                break;
            case 2:
                Console.WriteLine("{0} is {1} times", currentElement, maxSum);
                break;
            case 3:
                Console.WriteLine("{0} is {1} times", currentElement, maxSum);
                break;
            case 4:
                Console.WriteLine("{0} is {1} times", currentElement, maxSum);
                break;
            default:
                break;
        }
    }
}

