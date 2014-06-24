using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Ball
{
    public int BallWidth { get; set; }

    public int BallHeight { get; set; }

    public int BallDepth { get; set; }

    public Ball(int BallWidth, int BallHeight, int BallDepth)
    {
        this.BallWidth = BallWidth;
        this.BallHeight = BallHeight;
        this.BallDepth = BallDepth;
    }
}

class Program
{
    private static int width, height, depth;
    private static string[, ,] cube;
    private static int ballWidth,ballHeight,ballDepth;

    static void Main()
    {
        string[] whd = Console.ReadLine().Split();
        width = int.Parse(whd[0]);
        height = int.Parse(whd[1]);
        depth = int.Parse(whd[2]);

        cube = new string[width, height, depth];
        FillCube(cube);

        string[] ballPosition = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        ballWidth = int.Parse(ballPosition[0]);
        ballHeight = 0;
        ballDepth = int.Parse(ballPosition[1]);

        ProcessBall(cube);
        
        
    }

    private static void ProcessBall(string[,,] cube)
    {
        while (true)
        {
            string[] currentCell = cube[ballWidth,ballHeight,ballDepth].Split(new char[] {' '},StringSplitOptions.RemoveEmptyEntries);
            int currentWidth = ballWidth;
            int currentHeight = ballHeight;
            int currentDepth = ballDepth;

            if (currentCell[0] == "S")
            {
                ProccessSlide(currentCell[1]);
            }
            if (currentCell[0] == "T")
            {
                ballWidth = int.Parse(currentCell[1]);
                ballDepth = int.Parse(currentCell[2]);
            }
            if(currentCell[0] == "E")
            {
                if (ballHeight == height - 1)
                {
                    Console.WriteLine("Yes");
                    Console.WriteLine("{0} {1} {2}", ballWidth, ballHeight, ballDepth);
                    return;
                }
                else
                {
                    ballHeight++;
                }
            }
            if(currentCell[0] == "B")
            {
                Console.WriteLine("No");
                Console.WriteLine("{0} {1} {2}",ballWidth,ballHeight,ballDepth);
                Environment.Exit(0);
            }
            
            if(IsPassable() == false)
            {
                Console.WriteLine("No");
                Console.WriteLine("{0} {1} {2}", currentWidth, currentHeight, currentDepth);
                Environment.Exit(0);
            }
            if (ballHeight >= height)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("{0} {1} {2}", currentWidth, currentHeight, currentDepth);
                Environment.Exit(0);

            }
        }
    }
    static void ProccessSlide(string command)
    {
        switch (command)
        {
            case "L":
                    ballHeight++;
                    ballWidth--;
                    break;
            case "R":
                    ballHeight++;
                    ballWidth++;
                    break;
            case "F":
                    ballHeight++;
                    ballDepth--;
                    break;
            case "B":
                    ballHeight++;
                    ballDepth++;
                    break;
            case "FL":
                    ballHeight++;
                    ballWidth--;
                    ballDepth--;
                    break;
            case "FR":
                    ballHeight++;
                    ballWidth++;
                    ballDepth--;
                    break;
            case "BL":
                    ballHeight++;
                    ballWidth--;
                    ballDepth++;
                    break;
            case "BR":
                    ballHeight++;
                    ballDepth++;
                    ballWidth++;
                    break;
        }
        
    }
    static bool IsPassable()
    {
        if (ballWidth < 0 || ballWidth > width || ballDepth < 0 || ballDepth > depth)
        {
            return false;
        }
        else
        {
            return true;
        }
    }

    static string[, ,] FillCube(string[, ,] cube)
    {
        for (int h = 0; h < height; h++)
        {
            string[] currentLine = Console.ReadLine().Split(new string[] { " | " }, StringSplitOptions.RemoveEmptyEntries );
            for (int d = 0; d < depth; d++)
            {
                string[] bracketsContent = currentLine[d].Split(new char[] { '(', ')' }, StringSplitOptions.RemoveEmptyEntries);

                for (int w = 0; w < width; w++)
                {
                    cube[w,h,d] = bracketsContent[w];
                }
            }
        }
        return cube;
    }
}

