using System;
using System.Collections.Generic;


namespace Biatlon
{
    class Biatlon
    {
        static void Main()
        {
            int comp = int.Parse(Console.ReadLine());
            int results = 3;
            int[,] biatlon = new int[comp,results];
            for (int competitors = 0; competitors < comp; competitors++)
            {
                for (int result = 0; result < biatlon.GetLength(1)-1; result++)
                {
                    if (result == 0)
                    {
                        int minute = int.Parse(Console.ReadLine());
                        biatlon[competitors, result] = minute;
                    }
                    if (result == 1)
                    {
                        int seconds = int.Parse(Console.ReadLine());
                        biatlon[competitors, result] = seconds;
                    }
                    if (result == 2)
                    {
                        int targets = int.Parse(Console.ReadLine());
                        biatlon[competitors, result] = targets;
                        if (targets == 4)
                        {
                            targets += 30;
                        }
                        if (targets == 3)
                        {
                            targets += 60;
                        }
                        if (targets == 2)
                        {
                            targets += 90;
                        }
                        if (targets == 1)
                        {
                            targets += 120;
                        }
                    }
                }
            }
            for (int competitor = 0; competitor < comp; competitor++)
            {
                for (int result = 0; result < biatlon.GetLength(1); result++)
                {
                    Console.WriteLine(biatlon[competitor, result]);
                }
                Console.WriteLine();
            }
        }
    }
}
