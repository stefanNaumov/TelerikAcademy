using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace SubsetSums
{
    class SubsetSums
    {
        static void Main()
        {

            long sum = 0;//long.Parse(Console.ReadLine());
            int numberOfLines = 5;//int.Parse(Console.ReadLine());
            long[] nums = new long[]{-1,-2,1,2,3};
            //for (int i = 0; i < numberOfLines; i++)
            //{
            //    nums[i] = long.Parse(Console.ReadLine());
            //}

            int maxI = (int)Math.Pow(2, numberOfLines) - 1;
            int counter = 0;

            for (int i = 1; i <= maxI; i++)
            {
                long currentSum = 0;
                for (int j = 0; j < numberOfLines; j++)
                {
                    int mask = 1 << j;
                    int nandMask = i & mask;
                    int bit = nandMask >> j;

                    if (bit == 1)
                    {
                        currentSum += nums[j];
                    }

                }
                if (currentSum == sum)
                {
                    counter++;
                }
            }




            //BigInteger S = int.Parse(Console.ReadLine());
            //int numberOfLines = int.Parse(Console.ReadLine());
            //int[] numbers = new int[numberOfLines];

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    numbers[i] = int.Parse(Console.ReadLine());
            //}

            //if (numberOfLines == 1)
            //{
            //    Console.WriteLine(1);
            //}
            //else
            //{
            //    int counter = 0;
            //    int sum = 0;

            //    foreach (int num in numbers)
            //    {
            //        sum += num;
            //        if (sum == S)
            //        {
            //            counter++;
            //        }
            //    }
            //    Console.WriteLine(counter);
            //}
        }
    }
}
