using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static int width;
    static int height;
    static int depth;

    static void Main()
    {
        Dictionary<char, int> stars = new Dictionary<char, int>();
        string[] dimensions = Console.ReadLine().Split();
        width = int.Parse(dimensions[0]);
        height = int.Parse(dimensions[1]);
        depth = int.Parse(dimensions[2]);
        char[, ,] cuboid = FillCuboid(width,height,depth);
        for (int w = 0; w < width; w++)
        {
            for (int h = 0; h < height; h++)
            {
                for (int d = 0; d < depth; d++)
                {
                    char currentColor = cuboid[w, h, d];
                    if (CanAStarBeCalculated(w, h, d, cuboid) == true && CheckIfIsAStar(w, h, d, currentColor, cuboid) == true)
                    {
                        
                        if (stars.ContainsKey(currentColor))
                        {
                            stars[currentColor]++;
                        }
                        else
                        {
                            stars.Add(currentColor, 1);
                        }
                        
                    }
                }
            }
        }
        int sum = stars.Values.Sum();
        var sorted = stars.OrderBy(el => el.Key);
        Console.WriteLine(sum);
        foreach (var item in sorted)
        {
            Console.WriteLine("{0} {1}",item.Key,item.Value);
        }
    }
    static bool CheckIfIsAStar(int w, int h, int d,char currentColor,char[,,] cuboid)
    {
        if (cuboid[w-1,h,d] == currentColor && cuboid[w+1,h,d] == currentColor && cuboid[w,h+1,d] == currentColor
            && cuboid[w,h-1,d] == currentColor && cuboid[w,h,d-1] == currentColor && cuboid[w,h,d+1] == currentColor)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    static bool CanAStarBeCalculated(int W, int H, int D,char[,,] cuboid)
    {
        if (W + 1 < width && W - 1 >= 0 && H + 1 < height && H - 1 >= 0 && D + 1 < depth && D - 1 >= 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    static char[,,] FillCuboid(int W,int H,int D)
    {
        char[, ,] cuboid = new char[W, H, D];
        for (int h = 0; h < height; h++)
        {
            string[] currentLine = Console.ReadLine().Split(new char[]{' '},StringSplitOptions.RemoveEmptyEntries);
            for (int d = 0; d < depth; d++)
            {
                string currentSequence = currentLine[d];
                for (int w = 0; w < width; w++)
                {
                    cuboid[w, h, d] = currentSequence[w];
                }
            }
        }
        return cuboid;
    }
}

