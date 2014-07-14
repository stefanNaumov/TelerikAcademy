using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that finds all prime numbers in the range [1...10 000 000]. 
//Use the sieve of Eratosthenes algorithm (find it in Wikipedia).

namespace _15.SieveOfErathosthenes
{
    class SieveOfErathosthenes
    {
        static void Main()
        {
            Console.Write("Enter range for finding the prime numbers in it: ");
            int size = int.Parse(Console.ReadLine());

            bool[] arr = GenerateBoolArray(size);
            GenerateSieveOfErathosthenes(arr);

            Console.WriteLine("Prime numbers from 1 to {0}:", size);
            for (int i = 0; i < arr.Length; i++)
            {
                if (!arr[i])
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
        }

        static bool[] GenerateBoolArray(int size)
        {
            bool[] array = new bool[size];

            return array;
        }

        static void GenerateSieveOfErathosthenes(bool[] array)
        {
            array[0] = true;
            array[1] = true;
            for (int i = 2; i < Math.Sqrt(array.Length); i++)
            {
                if (!array[i])
                {
                    for (int j = i * i; j < array.Length; j += i)
                    {
                        array[j] = true;
                    }
                }
            }
        }
    }
}
