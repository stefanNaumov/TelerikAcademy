using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
   static int width, height, depth;
    static int[, ,] cuboid;
    private static bool[,,] visitedCubes;
    static int maxValue = -1001;
    private static int totalWalkSum = 0;
    static List<int> listOfMaxValues = new List<int>();
    static void Main()
    {
        string[] dimensions = Console.ReadLine().Split();
        width = int.Parse(dimensions[0]);
        height = int.Parse(dimensions[1]);
        depth = int.Parse(dimensions[2]);

        int positionWidth = width / 2;
        int positionHeight = height / 2;
        int positionDepth = depth / 2;

        cuboid = new int[width, height, depth];
        visitedCubes = new bool[width, height, depth];
        FillCuboid(cuboid);
        MaxWalkCounter(positionWidth,positionHeight,positionDepth);
        Console.WriteLine(totalWalkSum);
    }

    static int MaxWalkCounter(int positionWidth, int positionHeight, int positionDepth)
    {
        visitedCubes[positionWidth, positionHeight, positionDepth] = true;
        totalWalkSum += cuboid[positionWidth, positionHeight, positionDepth];
        int tempWidth = positionWidth;
        int tempHeigth = positionHeight;
        int tempDepth = positionDepth;
        
        while (true)
        {
            int tempMaxValue = -1001;
            //Go Left
            int[] tempValueAndCoordinates = GoLeft(positionWidth, positionHeight, positionDepth);
            if (tempValueAndCoordinates[0] > tempMaxValue)
            {
                tempMaxValue = tempValueAndCoordinates[0];
                tempWidth = tempValueAndCoordinates[1];
                tempHeigth = tempValueAndCoordinates[2];
                tempDepth = tempValueAndCoordinates[3];
            }
            //Go Right
            tempValueAndCoordinates = GoRight(positionWidth, positionHeight, positionDepth);
            if (tempValueAndCoordinates[0] > tempMaxValue)
            {
                tempMaxValue = tempValueAndCoordinates[0];
                tempWidth = tempValueAndCoordinates[1];
                tempHeigth = tempValueAndCoordinates[2];
                tempDepth = tempValueAndCoordinates[3];
            }
            //Go Up
            tempValueAndCoordinates = GoUp(positionWidth, positionHeight, positionDepth);
            if (tempValueAndCoordinates[0] > tempMaxValue)
            {
                tempMaxValue = tempValueAndCoordinates[0];
                tempWidth = tempValueAndCoordinates[1];
                tempHeigth = tempValueAndCoordinates[2];
                tempDepth = tempValueAndCoordinates[3];
            }
            // Go Down
            tempValueAndCoordinates = GoDown(positionWidth, positionHeight, positionDepth);
            if (tempValueAndCoordinates[0] > tempMaxValue)
            {
                tempMaxValue = tempValueAndCoordinates[0];
                tempWidth = tempValueAndCoordinates[1];
                tempHeigth = tempValueAndCoordinates[2];
                tempDepth = tempValueAndCoordinates[3];
            }
            // Go Deeper
            tempValueAndCoordinates = GoDeeper(positionWidth, positionHeight, positionDepth);
            if (tempValueAndCoordinates[0] > tempMaxValue)
            {
                tempMaxValue = tempValueAndCoordinates[0];
                tempWidth = tempValueAndCoordinates[1];
                tempHeigth = tempValueAndCoordinates[2];
                tempDepth = tempValueAndCoordinates[3];
            }
            //Go Shallower
            tempValueAndCoordinates = GoShallower(positionWidth, positionHeight, positionDepth);
            if (tempValueAndCoordinates[0] > tempMaxValue)
            {
                tempMaxValue = tempValueAndCoordinates[0];
                tempWidth = tempValueAndCoordinates[1];
                tempHeigth = tempValueAndCoordinates[2];
                tempDepth = tempValueAndCoordinates[3];
            }
            if (visitedCubes[tempWidth,tempHeigth,tempDepth] == true)
            {
                return totalWalkSum;
            }
            else if (listOfMaxValues.Contains(tempMaxValue))
            {
                return totalWalkSum;
            }
            //else if (tempMaxValue == maxValue)
            //{
            //    return totalWalkSum;
            //}
            else
            {
                listOfMaxValues.Add(tempMaxValue);
                totalWalkSum += tempMaxValue;
                maxValue = tempMaxValue;
                positionWidth = tempWidth;
                positionHeight = tempHeigth;
                positionDepth = tempDepth;
                visitedCubes[positionWidth, positionHeight, positionDepth] = true;
            }
        }
    }
    //=======================================================================
    static int[] GoLeft(int width, int height, int depth)
    {
        width -= 1;
        int[] valueAndCoordinates = new int[4];
        int bestValue = -1001;
        int bestWidth = width;
        while (width >= 0)
        {
            int tempValue = cuboid[width, height, depth];
            if(tempValue > bestValue)
            {
                bestValue = tempValue;
                bestWidth = width;
            }
            width--;
        }
        valueAndCoordinates[0] = bestValue;
        valueAndCoordinates[1] = bestWidth;
        valueAndCoordinates[2] = height;
        valueAndCoordinates[3] = depth;
        return valueAndCoordinates;
    }
    static int[] GoRight(int width, int height, int depth)
    {
        width += 1;
        int[] valuesAndCoordinates = new int[4];
        int bestValue = -1001;
        int bestWidth = width;
        while (width < cuboid.GetLength(0))
        {
            int tempValue = cuboid[width, height, depth];
            if (tempValue > bestValue)
            {
                bestValue = tempValue;
                bestWidth = width;
            }
            width++;
        }
        valuesAndCoordinates[0] = bestValue;
        valuesAndCoordinates[1] = bestWidth;
        valuesAndCoordinates[2] = height;
        valuesAndCoordinates[3] = depth;

        return valuesAndCoordinates;

    }
    static int[] GoUp(int width, int height, int depth)
    {
        height -= 1;
        int[] valuesAndCoordinates = new int[4];
        int bestValue = -1001;
        int bestHeight = height;

        while (height >= 0)
        {
            int tempValue = cuboid[width, height, depth];
            if (tempValue > bestValue)
            {
                bestValue = tempValue;
                bestHeight = height;
            }
            height--;
        }
        valuesAndCoordinates[0] = bestValue;
        valuesAndCoordinates[1] = width;
        valuesAndCoordinates[2] = bestHeight;
        valuesAndCoordinates[3] = depth;

        return valuesAndCoordinates;
    }
    static int[] GoDown(int width, int height, int depth)
    {
        height += 1;
        int[] valuesAndCoordinates = new int[4];
        int bestValue = -1001;
        int bestHeight = height;

        while (height < cuboid.GetLength(1))
        {
            int tempValue = cuboid[width, height, depth];
            if (tempValue > bestValue)
            {
                bestValue = tempValue;
                bestHeight = height;
            }
            height++;
        }
        valuesAndCoordinates[0] = bestValue;
        valuesAndCoordinates[1] = width;
        valuesAndCoordinates[2] = bestHeight;
        valuesAndCoordinates[3] = depth;

        return valuesAndCoordinates;
    }
    static int[] GoDeeper(int width, int height, int depth)
    {
        depth += 1;
        int[] valuesAndCoordinates = new int[4];
        int bestValue = -1001;
        int bestDepth = depth;
        
        while (depth < cuboid.GetLength(2))
        {
            int tempValue = cuboid[width, height, depth];
            if (tempValue > bestValue)
            {
                bestValue = tempValue;
                bestDepth = depth;
            }
            depth++;
        }
        valuesAndCoordinates[0] = bestValue;
        valuesAndCoordinates[1] = width;
        valuesAndCoordinates[2] = height;
        valuesAndCoordinates[3] = bestDepth;

        return valuesAndCoordinates;
    }
    static int[] GoShallower(int width, int height, int depth)
    {
        depth -= 1;
        int[] valuesAndCoordinates = new int[4];
        int bestValue = -1001;
        int bestDepth = depth;

        while (depth >= 0)
        {
            int tempValue = cuboid[width, height, depth];
            if (tempValue > bestValue)
            {
                bestValue = tempValue;
                bestDepth = depth;
            }
            depth--;
        }
        valuesAndCoordinates[0] = bestValue;
        valuesAndCoordinates[1] = width;
        valuesAndCoordinates[2] = height;
        valuesAndCoordinates[3] = bestDepth;

        return valuesAndCoordinates;
    }
    
    static int[, ,] FillCuboid(int[, ,] cuboid)
    {
        for (int h = 0; h < height; h++)
        {
            string[] currentRow = Console.ReadLine().Split(new string[] { " | " }, StringSplitOptions.RemoveEmptyEntries);
            for (int d = 0; d < depth; d++)
            {
                string[] integers = currentRow[d].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                for (int w = 0; w < width; w++)
                {
                    cuboid[w,h,d] = int.Parse(integers[w]);
                }
            }
        }
        return cuboid;
    }
}

