using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SubsetsSum
{
    class Program
    {
        static bool[] usedNumbers;
        static List<long> sums = new List<long>();

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
                
                long sum = GetSubsetSum(numbers, n - 1, k);

                sums.Add(sum);
            }

            Print();
        }

        static long GetSubsetSum(int[] numbers, int n, int k)
        {
            long binomCoeff = CalcBinom(k, n);
            long sum = CalcSum(numbers);

            return binomCoeff * sum;
        }
        static long CalcBinom(int k, int n)
        {
            long nominator = 1;
            long denominator = 1;
            for (int i = n; i >= (n - k + 1); i--)
            {
                nominator *= i;
            }

            for (int i = k; i > 0; i--)
            {
                denominator *= i;
            }

            return (nominator / denominator);
        }

        static long CalcSum(int[] numbers)
        {
            long sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }

            return sum;
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
            for (int i = 0; i < sums.Count; i++)
            {
                Console.WriteLine(sums[i]);
            }
        }
    }
}
