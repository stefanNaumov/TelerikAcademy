using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Divisors
{
    class Program
    {
        static List<int> permutations = new List<int>();
        static int numberOfElements;

        static void Main()
        {
            numberOfElements = int.Parse(Console.ReadLine());

            int[] numbers = new int[numberOfElements];

            for (int i = 0; i < numberOfElements; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            GetPermutations(numbers, 0);

            //for (int i = 0; i < permutations.Count; i++)
            //{
            //    Console.Write(permutations[i] + " ");
            //}
            //Console.WriteLine();

            int result = GetNumWithMinDivisors(permutations);

            Console.WriteLine(result);
        }

        static void GetPermutations(int[] numbersArr, int index)
        {
            int size = numbersArr.Length;
            //TODO: fix, too stupid done this way
            if (index == size)
            {
                string numToStr = "";
                for (int i = 0; i < numbersArr.Length; i++)
                {
                    numToStr += numbersArr[i];
                }
                int resultNum = int.Parse(numToStr);

                permutations.Add(resultNum);

                return;
            }
            else
            {
                for (int i = index; i < size; i++)
                {
                    int temp = numbersArr[i];
                    numbersArr[i] = numbersArr[index];
                    numbersArr[index] = temp;

                    GetPermutations(numbersArr, index + 1);

                    temp = numbersArr[i];
                    numbersArr[i] = numbersArr[index];
                    numbersArr[index] = temp;
                }
            }

        }

        static long CountDivisors(int number)
        {
            long counter = 0;

            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    counter++;
                }    
            }

            return counter;
        }

        static int GetNumWithMinDivisors(List<int> numbers)
        {
            long minDivisorsCount = int.MaxValue;
            int result = -1;

            for (int i = 0; i < numbers.Count; i++)
            {
                long currDivisors = CountDivisors(numbers[i]);

                if (currDivisors == minDivisorsCount)
                {
                    result = Math.Min(result, numbers[i]);
                }
                if (currDivisors < minDivisorsCount)
                {
                    minDivisorsCount = currDivisors;
                    result = numbers[i];
                }
            }

            return result;
        }
    }
}
