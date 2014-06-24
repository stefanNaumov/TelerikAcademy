using System;

namespace _01.Tubes
{
    class Tubes
    {
        static void Main()
        {
            int tubesNum = int.Parse(Console.ReadLine());
            int tubesNeeded = int.Parse(Console.ReadLine());
            int[] tubes = new int[tubesNum];
            
            int left = 0;
            int right = 0;
            int max = -1;
            for (int i = 0; i < tubes.Length; i++)
            {
                tubes[i] = int.Parse(Console.ReadLine());
                if (right < tubes[i])
                {
                    right = tubes[i];
                }
            }
            int middle = (left + right) / 2;

            while (left <= right)
            {
                int possibleTubes = 0;
                for (int i = 0; i < tubesNum; i++)
                {
                    possibleTubes += tubes[i] / middle;
                }
                if (possibleTubes >= tubesNeeded)
                {
                    left = middle + 1;
                    max = middle;
                }
                else
                {
                    right = middle - 1;
                }
                middle = (left + right) / 2;
            }
            Console.WriteLine(max);
        }
    }
}
