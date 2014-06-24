using System;
using System.Collections.Generic;


//Write a program that generates and prints to the console 10 random values in the range [100, 200].


namespace _02.RandomNumers
{
    class RandomNumbers
    {
        static void Main()
        {
            int[] arr = GenAndPrintRandomNums.RandomNums();
            Console.WriteLine("Ten random numbers in the range from 100 to 200: ");
            GenAndPrintRandomNums.PrintRandomNumbers(arr);
        }
    }
}
