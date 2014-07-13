using System;
using System.Collections.Generic;

//Write a program that finds the sequence of maximal sum in given array. Example:
	//{2, 3, -6, -1, 2, -1, 6, 4, -8, 8}  {2, -1, 6, 4}
	//Can you do it with only one loop (with single scan through the elements of the array)?

namespace _08.MaxSumSequence
{
    class MaxSumSeq
    {
        static void Main()
        {
            int[] array = new int[] { 2, 3, -6, -1, 2, -1, 6, 4, -8, 8 };

            List<int> maxSumSeq = FindMaxSumSeq(array);

            for (int i = 0; i < maxSumSeq.Count; i++)
            {
                Console.Write(maxSumSeq[i] + " ");
            }
            Console.WriteLine();
        }

        //we use Kadane's algorithm
        static List<int> FindMaxSumSeq(int[] array)
        {
            List<int> maxSumSeq = new List<int>(array.Length);
            int maxSum = array[0];
            int tempSum = array[0];

            int startIndex = 0;
            int startTempIndex = 0;
            int endIndex = 1;

            for (int i = 1; i < array.Length; i++)
            {
                if (tempSum < 0)
                {
                    tempSum = array[i];
                    startTempIndex = i;
                }
                else
                {
                    tempSum += array[i];
                }

                if (tempSum > maxSum)
                {
                    maxSum = tempSum;
                    startIndex = startTempIndex;
                    endIndex = i;
                }
            }

            for (int i = startIndex; i <= endIndex; i++)
            {
                maxSumSeq.Add(array[i]);
            }

            return maxSumSeq;
        }
    }
}
