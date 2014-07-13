using System;

//Write a program that finds the maximal increasing sequence in an array. Example: {3, 2, 3, 4, 2, 2, 4}  {2, 3, 4}.

namespace _05.MaxInreasingSequence
{
    class MaxIncreasingSeq
    {
        static void Main()
        {
            int[] array = new int[] { 3, 2, 3, 4, 2, 2, 4 };
            
            int maxSeqCounter = 0;
            int seqStartIndex = 0;
            int seqEndIndex = 0;
            for (int i = 0; i < array.Length - 1; i++)
            {
                int currSequenceCounter = 1;
                int currElement = array[i];
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] <= currElement)
                    {
                        break;
                    }

                    currSequenceCounter++;
                }

                if (currSequenceCounter > maxSeqCounter)
                {
                    maxSeqCounter = currSequenceCounter;
                    seqStartIndex = i;
                    seqEndIndex = i + maxSeqCounter - 1;
                }
            }

            Console.Write("The maximal increasing sequence is: ");
            for (int i = seqStartIndex; i <= seqEndIndex; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
