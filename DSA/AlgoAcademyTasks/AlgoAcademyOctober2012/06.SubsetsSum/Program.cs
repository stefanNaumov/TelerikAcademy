using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SubsetsSum
{
    class Program
    {
        static bool[] usedNumbers;
        static List<int> sums = new List<int>();
        static List<int> allSums = new List<int>();
        static void Main()
        {
            int T = int.Parse(Console.ReadLine());

            for (int i = 0; i < T; i++)
            {
                string[] parameters = Console.ReadLine().Split(new char[]{' '}, StringSplitOptions.RemoveEmptyEntries);

                int n = int.Parse(parameters[0]);
                int k = int.Parse(parameters[1]);
                usedNumbers = new bool[n];

                string numbersStr = Console.ReadLine();
                int[] numbers = ParseStringInput(numbersStr);
                
                GetSubsetSum(numbers, 0, k);
                for (int j = 0; j < sums.Count; j++)
                {
                    Console.Write(sums[j] + ' ');
                }
                allSums.Add(sums.Sum());
                sums.Clear();
            }

            Print();
           
        }

        static void GetSubsetSum(int[] numbers, int index, int k)
        {
            if (index >= k)
            {
                int sum = 0;
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (!usedNumbers[i])
                    {
                        sum += numbers[i];
                        
                    }
                }
                sums.Add(sum);
                sum = 0;
                return;
            }

            for (int i = index; i < numbers.Length; i++)
            {
                usedNumbers[i] = true;
                GetSubsetSum(numbers, index + 1, k);
                usedNumbers[i] = false;
            }
        }

        static int[] ParseStringInput(string numsAsString)
        {
            string[] strArr = numsAsString.Split(' ');
            int[] numbers = new int[strArr.Length];

            for (int i = 0; i < strArr.Length; i++)
            {
                numbers[i] = int.Parse(strArr[i]);
            }

            return numbers;
        }

        static void Print()
        {
            for (int i = 0; i < allSums.Count; i++)
            {
                Console.WriteLine(allSums[i]);
            }
        }
    }
}
