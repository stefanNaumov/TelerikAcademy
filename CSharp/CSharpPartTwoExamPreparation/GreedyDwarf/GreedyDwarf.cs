using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class GreedyDwarf
{
    static void Main()
    {
        string[] valley = Console.ReadLine().Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
        ushort numberOfPatterns = ushort.Parse(Console.ReadLine());
        int result = 0;
        int bestResult = 0;
        for (int i = 0; i < numberOfPatterns; i++)
        {
            string[] currentPattern = Console.ReadLine().Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            result = CoinCounter(valley, currentPattern);
            if (result > bestResult)
            {
                bestResult = result;
            }
        }
        Console.WriteLine(bestResult);

    }
    static int CoinCounter(string[] valley, string[] pattern)
    {
        bool[] visitedSteps = new bool[valley.Length];
        //int[] valleyToIntArr = new int[valley.Length];
        //int[] patternToIntArr = new int[pattern.Length];
        //for (int i = 0; i < valley.Length; i++)
        //{
        //    valleyToIntArr[i] = int.Parse(valley[i]);
        //}
        //for (int i = 0; i < pattern.Length; i++)
        //{
        //    patternToIntArr[i] = int.Parse(pattern[i]);
        //}

        int coins = int.Parse(valley[0]);
        visitedSteps[0] = true;
        int pattPos = 0;
        int valleyPos = 0;
        while (true)
        {
            if (pattPos >= pattern.Length)
            {
                pattPos = 0;
            }
            valleyPos += int.Parse(pattern[pattPos]);

            if (valleyPos >= valley.Length || valleyPos < 0 || visitedSteps[valleyPos] == true)
            {
                break;
            }


            coins += int.Parse(valley[valleyPos]);
            visitedSteps[valleyPos] = true;
            pattPos++;
        }
        return coins;
    }
}