using System;

//Write a program that reads two integer numbers N and K and an array of N elements from the console. 
//Find in the array those K elements that have maximal sum.

namespace _06.FindMaxSum
{
    class MaxSum
    {
        static void Main()
        {
            Console.Write("Enter number N for array size: ");
            int N = int.Parse(Console.ReadLine());
            Console.Write("Enter number K for subsequence: ");
            int K = int.Parse(Console.ReadLine());
            int[] array = new int[N];

            for (int i = 0; i < N; i++)
            {
                Console.Write("Enter array number {0}: ",i + 1);
                array[i] = int.Parse(Console.ReadLine());
            }
            int maxSum = 0;
            int sequenceStartIndex = 0;
            for (int i = 0; i < (N - K) + 1; i++)
            {
                int currentSum = array[i];
                for (int j = i + 1; j < i + K; j++)
                {
                    currentSum += array[j];
                }

                if (currentSum > maxSum)
                {
                    maxSum = currentSum;
                    sequenceStartIndex = i;
                }
                currentSum = 0;
            }

            Console.Write("The SubSequence with maximal sum is: ");
            for (int i = sequenceStartIndex; i < K; i++)
            {
                Console.Write(array[i]);
            }
            Console.WriteLine();
        }
    }
}
