using System;

//Write a recursive program that simulates the execution of n nested loops from 1 to n.
namespace NestedLoops
{
    class MainLoader
    {
        private static int[] arr;

        static void Main()
        {
            int N = 2;
            arr = new int[N];
            GenerateNestedLoops(0, N);
        }

        public static void GenerateNestedLoops(int index, int loopsCount)
        {
            if (index >= loopsCount)
            {
                Console.WriteLine(String.Join(", ",arr));
                return;
            }

            for (int i = 1; i <= loopsCount; i++)
            {
                arr[index] = i;
                GenerateNestedLoops(index + 1, loopsCount);
            }
        }
    }
}
