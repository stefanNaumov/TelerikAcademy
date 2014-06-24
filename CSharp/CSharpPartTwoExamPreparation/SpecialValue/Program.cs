using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecialValue
{
    class Program
    {
        static void Main()
        {
            int numberOfRows = int.Parse(Console.ReadLine());
            int[][] jagged = new int[numberOfRows][];
            bool[][] used = new bool[numberOfRows][];
            ReadJaggedArray(jagged);
            long bestCount = 0;
            for (int i = 0; i < jagged[0].Length; i++)
            {
                long pathCount = PathCounter(jagged, i);
                if(pathCount > bestCount)
                {
                    bestCount = pathCount;
                }
            }
            Console.WriteLine(bestCount);

            //for (int i = 0; i < jagged.GetLength(0); i++)
            //{
            //    for (int j = 0; j < jagged[i].Length; j++)
            //    {
            //        Console.Write(jagged[i][j] + " ");
            //    }
            //    Console.WriteLine();
            //}
        }
        static long PathCounter(int[][] jaggedArr, int position)
        {
            int currentValue = 0;
            int currentRow = 0;
            int currentPosition = position;
            long pathCount = 0;
            if(jaggedArr[currentRow][currentPosition] < 0)
            {
                return Math.Abs(jaggedArr[currentRow][currentPosition]) + 1;
            }
            else
            {
                while (true)
                {
                    if(currentRow == jaggedArr.GetLength(0))
                    {
                        currentRow = 0;
                    }
                    currentValue = jaggedArr[currentRow][currentPosition];
                    if (currentValue < 0)
                    {
                        pathCount += Math.Abs(currentValue)+1;
                        break;
                    }
                    currentPosition = currentValue;

                    pathCount++;
                    currentRow++;
                    
                    //used[currentRow][currentPosition] = true;
                } 
            }
            return pathCount;
        }

        private static int[][] ReadJaggedArray(int[][] rows)
        {
            for (int i = 0; i < rows.GetLength(0); i++)
            {
                string[] currentRow = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                rows[i] = new int[currentRow.Length];

                for (int j = 0; j < currentRow.Length; j++)
                {
                    rows[i][j] = int.Parse(currentRow[j]);
                }
            }
            return rows;
        }
        //static int PathCounter(int[][] jaggedArr)
        //{
        //    int bestValue = 0;
        //    for (int i = 0; i < jaggedArr.GetLength(0); i++)
        //    {
                
        //        for (int j = 0; j < jaggedArr[i].Length; j++)
        //        {
                    
        //        }
        //    }
        //}
    }
}
