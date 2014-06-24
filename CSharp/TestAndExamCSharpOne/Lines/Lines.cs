using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lines
{
    class Lines
    {
        static void Main()
        {
            int[,] matrix = new int[8, 8];

            for (int row = 0; row < 8; row++)
            {
                int number = int.Parse(Console.ReadLine());
                for (int col = 0; col < 8; col++)
                {
                    matrix[row, col] = (number >> 7 - col) & 1;
                }
            }

            int longestLine = 0;
            int longestLineCounter = 0;
            for (int row = 0; row < 8; row++)
            {
                int currCounter = 0;
                for (int col = 0; col < 8; col++)
                {
                    if (matrix[row, col] == 1)
                    {
                        currCounter++;
                    }
                    if (matrix[row, col] == 0)
                    {
                        currCounter = 0;
                    }
                    if (currCounter > longestLine)
                    {
                        longestLine = currCounter;
                        longestLineCounter = 1;
                    }
                    else if (currCounter == longestLine)
                    {
                        longestLineCounter++;
                    }
                }
            }
            for (int col = 0; col < 8; col++)
            {
                int currCounter = 0;
                for (int row = 0; row < 8; row++)
                {
                    if (matrix[row, col] == 1)
                    {
                        currCounter++;
                    }
                    if (matrix[row, col] == 0)
                    {
                        currCounter = 0;
                    }
                    if (currCounter > longestLine)
                    {
                        longestLine = currCounter;
                        longestLineCounter = 1;
                    }
                    else if (currCounter == longestLine)
                    {
                        longestLineCounter++;
                    }
                }
            }
            if (longestLine == 1)
            {
                longestLineCounter = longestLineCounter / 2;
            }
            Console.WriteLine(longestLine);
            Console.WriteLine(longestLineCounter);




            //for (int row = 0; row < 8; row++)
            //{

            //    for (int col = 0; col < 8; col++)
            //    {
            //        Console.Write(matrix[row, col]);
            //    }
            //    Console.WriteLine();
            //}

        }
    }
}