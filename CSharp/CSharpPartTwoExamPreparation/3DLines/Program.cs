using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    
    
    static int[] directionW = new int[] { 1,0,0,1,1,1,-1,-1,1,0,0,1,1};
    static int[] directionH = new int[] { 0,1,0,1,1,1,1,0,0,1,1,-1,-1};
    static int[] directionD = new int[] { 0,0,1,0,-1,1,0,1,1,1,-1,1,-1};


    static void Main()
    {
        string[] dimensions = Console.ReadLine().Split(new char[]{' '},StringSplitOptions.RemoveEmptyEntries);
        
        int width = int.Parse(dimensions[0]);
        int height = int.Parse(dimensions[1]);
        int depth = int.Parse(dimensions[2]);
        
        string[, ,] cube = new string[width, height, depth];
        
        cube = FillCube(cube,width,height,depth);
        int bestLineLength = 1;
        int bestlineCounter = 0;

        for (int w = 0; w < width; w++)
        {
            for (int h = 0; h < height; h++)
            {
                for (int d = 0; d < depth; d++)
                {
                    string currentColor = cube[w, h, d];
                    
                    for (int i = 0; i < directionW.Length; i++)
                    {
                        int currentLine = 1;
                        int currentWidth = w;
                        int currentHeight = h;
                        int currentDepth = d;

                        while (true)
                        {
                            currentWidth += directionW[i];
                            currentHeight += directionH[i];
                            currentDepth += directionD[i];
                            if (!(IsPassable(cube, currentWidth, currentHeight, currentDepth)))
                            {
                                break;
                            }
                            else if (cube[currentWidth, currentHeight, currentDepth] == currentColor)
                            {
                                currentLine++;
                            }
                            else
                            {
                                break;
                            }
                        }
                        if (currentLine == bestLineLength)
                        {
                            bestlineCounter++;
                        }
                        else if (currentLine > bestLineLength)
                        {
                            bestLineLength = currentLine;
                            bestlineCounter = 1;
                        }
                    }
                }
            }
        }
        if (bestLineLength > 1)
        {
            Console.WriteLine("{0} {1}", bestLineLength, bestlineCounter); 
        }
        else
        {
            Console.WriteLine(-1);
        }
    }
    
    static bool IsPassable(string[, ,] cuboid, int W, int H, int D)
    {
        if (W < 0 || W >= cuboid.GetLength(0) || H < 0 || H >= cuboid.GetLength(1) || D < 0 || D >= cuboid.GetLength(2))
        {
            return false;
        }
        else
        {
            return true;
        }
    }
    static string[,,] FillCube(string[,,] cuboid,int W,int H,int D)
    {
        for (int h = 0; h < H; h++)
        {
            string currentLine = Console.ReadLine();
            string[] sequences = currentLine.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            for (int d = 0; d < D; d++)
            {
                string current = sequences[d];
                for (int w = 0; w < W; w++)
                {
                    cuboid[w, h, d] = current[w].ToString();
                }
            }
        }
        return cuboid;
    }
}

