using System;
using System.Collections.Generic;

namespace QuadronacciRectangle
{
    class QuadronacciRectangle
    {
        static void Main()
        {
            long firstNum = long.Parse(Console.ReadLine());
            long secNum = long.Parse(Console.ReadLine());
            long thirdNum = long.Parse(Console.ReadLine());
            long fourthNum = long.Parse(Console.ReadLine());
            long sum = 0;
            long listRow = long.Parse(Console.ReadLine());
            long listCol = long.Parse(Console.ReadLine());

            for (int r = 0; r < listRow; r++)
            {
                for (int c = 0; c < listCol; c++)
                {
                    Console.Write("{0} ",firstNum);
                    sum = firstNum + secNum + thirdNum + fourthNum;
                    firstNum = secNum;
                    secNum = thirdNum;
                    thirdNum = fourthNum;
                    
                    fourthNum = sum;
                }
                Console.WriteLine();
            }
        }
    }
}
