using System;
using System.Collections.Generic;
using System.Numerics;

namespace OddNumber
{
    class OddNumber
    {
        static void Main()
        {


            long N = int.Parse(Console.ReadLine());
            if (N == 1)
            {
                int number = int.Parse(Console.ReadLine());
                Console.WriteLine(number);
            }
            else
            {
                long[] numbers = new long[N];
                long result = 0;

                for (int i = 0; i < numbers.Length; i++)
                {
                    numbers[i] = long.Parse(Console.ReadLine());
                }

                for (int i = 0; i < numbers.Length; i++)
                {
                    int tempCounter = 1;
                    for (int j = i + 1; j < numbers.Length; j++)
                    {
                        if (numbers[i] == numbers[j])
                        {
                            tempCounter++;
                        }
                    }
                    if (tempCounter % 2 != 0)
                    {
                        result = numbers[i];
                        break;
                    }
                }
                Console.WriteLine(result);
            }
        }
    }
}
