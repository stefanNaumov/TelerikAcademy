using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Bomb
{
    public int width;
    public int height;
    public int depth;
    public int power;
}

class BombingCuboids
{
    static int width, heigth, depth;
    static char[,,] cube = new char[width,heigth,depth];
    static List<Bomb> bombs = new List<Bomb>();
    static Dictionary<char, int> removedColors = new Dictionary<char, int>();
    static int totalHits = 0;
    const char empty = ' ';
    static void Main()
    {
        string dimensions = Console.ReadLine();
        char[] separator = new char[]{' '};
        string[] dimensionStrings = dimensions.Split(separator, StringSplitOptions.RemoveEmptyEntries);

        width = int.Parse(dimensionStrings[0]);
        heigth = int.Parse(dimensionStrings[1]);
        depth = int.Parse(dimensionStrings[2]);
        cube = new char[width, heigth, depth];
        FillCube();

        GetBombsCoordinates();

        for (int i = 0; i < bombs.Count; i++)
        {
            BombExplosion(bombs[i]);
            FallDown();
        }
        Console.WriteLine(totalHits);
        var sortAlphabetically = removedColors.OrderBy(key => key.Key);
        foreach (var item in sortAlphabetically)
        {
            Console.WriteLine("{0} {1}",item.Key,item.Value);
        }
    }
    static void BombExplosion(Bomb currentBomb)
    {
        for (int w = 0; w < width; w++)
        {
            for (int h = 0; h < heigth; h++)
            {
                for (int d = 0; d < depth; d++)
                {
                    double distance = Math.Sqrt(((w - currentBomb.width) * (w - currentBomb.width)) + ((h - currentBomb.height) * (h - currentBomb.height)) + 
                        (d - currentBomb.depth) * (d - currentBomb.depth));

                    if (cube[w,h,d] != empty)
                    {
                        if (distance <= currentBomb.power)
                        {
                            char currentColor = cube[w, h, d];

                            if (removedColors.ContainsKey(currentColor))
                            {
                                removedColors[currentColor]++;
                            }
                            else
                            {
                                removedColors.Add(currentColor, 1);
                            }
                            cube[w, h, d] = empty;
                            totalHits++;
                        } 
                    }
                }
            }
        }
    }
    static void FallDown()
    {
        for (int w = 0; w < width; w++)
        {
            for (int d = 0; d < depth; d++)
            FallDownPillar(w,d);
        }
    }

    private static void FallDownPillar(int w,int d)
    {
        int bottom = 0;

        for (int h = 0; h < heigth; h++)
        {
            if (cube[w,h,d] != empty)
            {
                if (h != bottom)
                {
                    cube[w, bottom, d] = cube[w, h, d];
                    cube[w, h, d] = empty;
                }
                bottom++;
            }
        }
    }
        
    static void GetBombsCoordinates()
    {
        int numberOfBombs = int.Parse(Console.ReadLine());

        for (int i = 0; i < numberOfBombs; i++)
        {
            Bomb currentBomb = new Bomb();
            string[] currentBombCoordinates = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            currentBomb.width = int.Parse(currentBombCoordinates[0]);
            currentBomb.height = int.Parse(currentBombCoordinates[1]);
            currentBomb.depth = int.Parse(currentBombCoordinates[2]);
            currentBomb.power = int.Parse(currentBombCoordinates[3]);
            bombs.Add(currentBomb);
        }
    }
    private static void FillCube()
    {
        for (int h = 0; h < heigth; h++)
        {
            string currentLine = Console.ReadLine();
            string[] sequences = currentLine.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            for (int d = 0; d < depth; d++)
            {
                string currentSequence = sequences[d];
                for (int w = 0; w < width; w++)
                {
                    cube[w, h, d] = currentSequence[w];
                }
            }
        }
    }
}

