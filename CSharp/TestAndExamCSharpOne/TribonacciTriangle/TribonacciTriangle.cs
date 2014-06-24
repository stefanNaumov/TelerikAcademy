using System;

namespace TribonacciTriangle
{
    class TribonacciTriangle
    {
        static void Main()
        {
            long firstNum = long.Parse(Console.ReadLine());
            long secNum = long.Parse(Console.ReadLine());
            long thirdNum = long.Parse(Console.ReadLine());
            

            int numberOfLines = int.Parse(Console.ReadLine());
            Console.WriteLine(firstNum);
            Console.WriteLine(secNum + " " + thirdNum);

            if (numberOfLines > 2)
            {
                for (int i = 3; i <= numberOfLines; i++)
                {
                    for (int j = 0; j < i; j++)
                    {
                        long tempSum = firstNum + secNum + thirdNum;
                        firstNum = secNum;
                        secNum = thirdNum;
                        thirdNum = tempSum;
                        Console.Write("{0} ",tempSum);
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
