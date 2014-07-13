using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that finds in given array of integers a sequence of given sum S (if present). 
//Example:	 {4, 3, 1, 4, 2, 5, 8}, S=11  {4, 2, 5}
namespace _10.SequenceOfGivenSum
{
    class SeqOfGivenSum
    {
        static void Main()
        {
            int[] array = GenerateRandomArray(20, 50);

            //The following hardcoded array is used to check for particular boundary problems
            // in this case for S = 11
            //int[] arr = new int[] { 11,4, 3, 1, 4, 2, 5, 8, 3, 11 };

            Console.Write("Enter sum S: ");
            int sum = int.Parse(Console.ReadLine());
            List<List<int>> sumSequences = FindSequenceOfSum(array, sum);
            if (sumSequences.Count > 0)
            {
                Console.WriteLine("Subsequences with sum equal to input value");
                for (int i = 0; i < sumSequences.Count; i++)
                {
                    List<int> currSeq = sumSequences[i];

                    for (int j = 0; j < currSeq.Count; j++)
                    {
                        Console.Write(currSeq[j] + " ");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("There are no elements with this sum in the array");
            }
            
        }

        static int[] GenerateRandomArray(int minSize, int maxSize)
        {
            Random generator = new Random();

            int arraySize = generator.Next(minSize, maxSize);
            int[] array = new int[arraySize];

            for (int i = 0; i < arraySize; i++)
            {
                array[i] = generator.Next(1, 10);
            }

            return array;
        }

        static List<List<int>> FindSequenceOfSum(int[] array, int sum)
        {
            List<List<int>> allSequences = new List<List<int>>();

            for (int i = 0; i < array.Length; i++)
            {
                List<int> currentSequence = new List<int>();
                int currentSum = array[i];
                currentSequence.Add(array[i]);

                if (currentSum == sum)
                {
                    allSequences.Add(currentSequence);
                }
                else if (currentSum < sum && i < array.Length - 1)
                {
                    for (int j = i + 1; j < array.Length; j++)
                    {
                        currentSum += array[j];
                        currentSequence.Add(array[j]);

                        if (currentSum == sum)
                        {
                            allSequences.Add(currentSequence);
                            break;
                        }
                    }
                }
                
            }

            return allSequences;
        }
    }
}
