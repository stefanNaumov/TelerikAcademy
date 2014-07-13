using System;
using System.Collections.Generic;
using System.Linq;

//Write a program that finds the most frequent number in an array. Example:
	//{4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3}  4 (5 times)

namespace _09.MostFreqNumInArray
{
    class MostFreqNum
    {
        static void Main()
        {
            int[] array = new int[] { 4, 1, 1, 3, 2, 3, 4, 4, 1, 2, 3, 9, 3 };

            int mostFreqNum = FindMostFrequentNumber(array);

            Console.WriteLine(mostFreqNum);
        }

        static int FindMostFrequentNumber(int[] array)
        {
            Dictionary<int,int> arrayElements = new Dictionary<int,int>(array.Length);

            for (int i = 0; i < array.Length; i++)
            {
                if (!arrayElements.ContainsKey(array[i]))
                {
                    arrayElements.Add(array[i], 1);
                }
                else
                {
                    arrayElements[array[i]]++;
                }
            }
            KeyValuePair<int, int> mostFreqNum = arrayElements.Aggregate((a, b) => a.Value > b.Value ? a : b);

            return mostFreqNum.Key;
        }
    }
}
