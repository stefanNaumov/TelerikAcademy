using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeInOne
{
    class Program
    {
        static void Main()
        {
            string points = Console.ReadLine();

            string[] pointsToArr = points.Split(',');
            if (pointsToArr.Length < 3)
            {
                int a = int.Parse(pointsToArr[0]);
                int b = int.Parse(pointsToArr[1]);
                int result = Math.Max(a, b);
                int secondResult = Math.Min(a, b);
                if (result < 22)
                {
                    Console.WriteLine(result);
                }
                else if (secondResult < 22)
                {
                    Console.WriteLine(secondResult);
                }
                else if (result > 21 && secondResult > 21)
                {
                    Console.WriteLine(-1);
                }
            }

            int[] pointsArr = new int[pointsToArr.Length];

            for (int i = 0; i < pointsToArr.Length; i++)
            {
                pointsArr[i] = Convert.ToInt32((pointsToArr[i]));
            }
            int maxResult = 0;
            int winingpos = 0;

            for (int i = 0; i < pointsArr.Length; i++)
            {
                if (pointsArr[i] < 22 && pointsArr[i] > maxResult)
                {
                    maxResult = pointsArr[i];
                    winingpos = i;
                }
            }
            bool IsAWinner = true;
            int[] checkForMultipleWinners = new int[pointsArr.Length];
            for (int i = 0; i < checkForMultipleWinners.Length; i++)
            {
                checkForMultipleWinners[i] = pointsArr[i];
            }
            Array.Sort(checkForMultipleWinners);
            if (checkForMultipleWinners[checkForMultipleWinners.Length - 1] == checkForMultipleWinners[checkForMultipleWinners.Length - 2])
            {
                IsAWinner = false;
            }
            if (IsAWinner == true)
            {
                Console.WriteLine(winingpos);
            }
            else if (IsAWinner == false)
            {
                Console.WriteLine(-1);
            }


            string sizes = Console.ReadLine();
            int F = int.Parse(Console.ReadLine());
            string[] sizesArr = sizes.Split(',');
            Array.Sort(sizesArr);

            int myCakes = int.Parse(sizesArr[sizesArr.Length - 1]);
            Array.Reverse(sizesArr);

            for (int i = F + 1; i < sizesArr.Length; i += F + 1)
            {
                myCakes += int.Parse(sizesArr[i]);
            }

            Console.WriteLine(myCakes);
            
        }
    }
}
