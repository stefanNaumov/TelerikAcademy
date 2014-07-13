using System;

// Write a program that allocates array of 20 integers and initializes each
// element by its index multiplied by 5. Print the obtained array on the console.

namespace _01.IntegerArray
{
    class IntegerArray
    {
        static void Main(string[] args)
        {
            int size = 20;
            int[] array = new int[size];

            for (int i = 0; i < size; i++)
            {
                array[i] = i * 5;
            }

            for (int i = 0; i < size; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
