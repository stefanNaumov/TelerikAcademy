using System;
using System.Collections.Generic;




class GenAndPrintRandomNums
{
    public static int[] RandomNums()
    {
        int[] numbers = new int[10];
        Random generator = new Random();

        for (int i = 0; i < numbers.Length; i++)
        {
            int random = generator.Next(100, 200);
            numbers[i] = random;
        }
        return numbers;
    }
    public static void PrintRandomNumbers(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
    }
}

