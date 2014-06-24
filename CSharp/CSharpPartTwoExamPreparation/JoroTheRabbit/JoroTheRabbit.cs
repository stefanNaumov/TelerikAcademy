using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class JoroTheRabbit
{
    static void Main()
    {
        string terrainNumbers = Console.ReadLine();
        
        int[] terrainArray = TerrainNumsToIntArr(terrainNumbers);
        //int[] steps = GetPossibleSteps(terrainArray);
        int bestSteps = int.MinValue;

        for (int p = 0; p < terrainArray.Length; p++)
        {
            for (int i = 1; i < terrainArray.Length; i++)
            {
                int tempSteps = 1;

                tempSteps = CountSteps(terrainArray, i, p);

                if (bestSteps < tempSteps)
                {
                    bestSteps = tempSteps;
                }
            }


        }


        Console.WriteLine(bestSteps);
    }


    static int CountSteps(int[] terrain, int currentStep, int currentPosition)
    {

        int stepCounter = 1;

        while (true)
        {
            int currentNumber = terrain[currentPosition];
            int nextPosition = (currentPosition + currentStep) % terrain.Length;

            int nextNumber = terrain[nextPosition];
            if (nextNumber < currentNumber)
            {
                break;
            }
            stepCounter++;
            currentPosition = nextPosition;

        }
        return stepCounter;
    }

    static int[] TerrainNumsToIntArr(string numbers)
    {

        string[] array = numbers.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int[] arr = new int[array.Length];
        for (int i = 0; i < array.Length; i++)
        {
            arr[i] = int.Parse(array[i]);
        }
        return arr;
    }

    //static int[] GetPossibleSteps(int[] terrainNumbers)
    //{
    //    List<int> steps = new List<int>();
    //    for (int i = 0; i < terrainNumbers.Length; i++)
    //    {
    //        if(terrainNumbers[i] > 0)
    //        {
    //            steps.Add(terrainNumbers[i]);
    //        }
    //    }
    //    int[] resultSteps = steps.ToArray();
    //    return resultSteps;
    //}
}